using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Text.Json;

namespace SmartUsingStatements
{
    internal class DummyApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<DummyApiService> _logger;
        private const string _url = "https://jsonplaceholder.typicode.com/posts";

        public DummyApiService(IHttpClientFactory httpClientFactory, ILogger<DummyApiService> logger)
        {
            // Instead of creating an httpClient explicity, we take advantage of the httpClientFactory and ask for an instance of
            // httpClient. There is a number of benefits of using the httpClientFactory of httpClient: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-6.0
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<List<Post>> GetPostsWithoutSmartUsingAsync()
        {
            // We call the start and stop explicity in this method to time the http request
            var sw = Stopwatch.StartNew();

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, _url);

            try
            {
                var httpClient = _httpClientFactory.CreateClient();
                var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

                httpResponseMessage.EnsureSuccessStatusCode();

                using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

                return await JsonSerializer.DeserializeAsync<List<Post>>(contentStream);
            }
            finally
            {
                sw.Stop();
                _logger.LogInformation($"All posts retrieval completed in {sw.ElapsedMilliseconds}ms");
            }
        }

        public async Task<List<Post>> GetPostsWithSmartUsingAsync()
        {
            // Make use of the "using" keyword we call an extension method called TimedOperation which takes advantage of c# syntax
            // by implementing the IDisposable which when called with the using keyword with implicity call the dispose method which 
            // is where we stop the stopwatch. The start is called immediately in the constructor of the object being created in the TimeOperation method
            using var _ = _logger.TimedOperation("All posts retrieval");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, _url);

            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            httpResponseMessage.EnsureSuccessStatusCode();

            using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<List<Post>>(contentStream);
        }
    }
}
