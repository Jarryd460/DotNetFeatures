// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartUsingStatements;

// Creates a host which sets up a number of things such as DI, logging, loading of appsettings etc. Hover over the CreateDefaultBuilder
// class to see everything that is setup or go to https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-6.0
var host = Host.CreateDefaultBuilder()
    .ConfigureServices(services =>
    {
        services.AddHttpClient();
        services.AddTransient<DummyApiService>();
    })
    .Build();

var dummyApiService = host.Services.GetRequiredService<DummyApiService>();

var postsWithoutSmartUsing = await dummyApiService.GetPostsWithoutSmartUsingAsync();

Console.WriteLine();
Console.WriteLine($"Number of posts: {postsWithoutSmartUsing.Count}");
Console.WriteLine("====================================");
Console.WriteLine();

foreach (var post in postsWithoutSmartUsing)
{
    Console.WriteLine($"UserId: {post.UserId}");
    Console.WriteLine($"Id: {post.Id}");
    Console.WriteLine($"Title: {post.Title}");
    Console.WriteLine($"Body: {post.Body}");
    Console.WriteLine();
}

var postsWithSmartUsing = await dummyApiService.GetPostsWithSmartUsingAsync();

Console.WriteLine();
Console.WriteLine($"Number of posts: {postsWithSmartUsing.Count}");
Console.WriteLine("====================================");
Console.WriteLine();

foreach (var post in postsWithSmartUsing)
{
    Console.WriteLine($"UserId: {post.UserId}");
    Console.WriteLine($"Id: {post.Id}");
    Console.WriteLine($"Title: {post.Title}");
    Console.WriteLine($"Body: {post.Body}");
    Console.WriteLine();
}