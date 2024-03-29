# .NET Features

### Contains various features that exist within the .NET ecosystem with examples:

* Deconstruct method

* In/Out Keywords excluding Covariance and Contravariance
	* Includes performance pitfalls of in keyword when used incorrectly. https://devblogs.microsoft.com/premier-developer/avoiding-struct-and-readonly-reference-performance-pitfalls-with-errorprone-net/.
	* https://github.com/SergeyTeplyakov/ErrorProne.NET can help to mitigate the subtle pitfalls of using in keyword incorrectly.

* Smart enums
	* How to add additional functionality to enums using SmartEnums nuget package. https://github.com/ardalis/SmartEnum.
	
* Params
	* Performance impact of using params incorrectly. Including memory consumptions.
	
* Visual Studio snippets
	* How to create and import your own snippets into Visual Studio. https://docs.microsoft.com/en-us/visualstudio/ide/code-snippets?view=vs-2022
	* Snippets helps avoid users writting common code such as for loops, if statements etc. by generating this code automatically.
	* Snippets schema reference: https://docs.microsoft.com/en-us/visualstudio/ide/code-snippets-schema-reference?view=vs-2022
	
* Smart using statements
	* How to take advantage of the using statement in c# to create cleaner code.
	* Dependencies:
		* Microsoft.Extensions.Hosting
		* Microsoft.Extensions.Http
	* Dummy Api: https://jsonplaceholder.typicode.com/posts
	* Compiler: https://sharplab.io/
	* IHttpClientFactory: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-6.0
	* Host builder: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-6.0
	
* Closures
	* Closures are classes (eg. DisplayClass2_0) with a method that are automatically generated when using Linq, Expression, Func, Predicate, Action etc. Basically anywhere where Lambda functions (x => x > 400) are used.
	
* Boxing and unboxing
	* Boxing is the process of converting a value type to the type "object" or to any interface type implemented by this value type. When the common language runtime (CLR) boxes a value type, it wraps the value inside a System.Object instance and stores it on the managed heap. Unboxing extracts the value type from the object.

	
* C# Records
	* Records is a class or struct that makes creating immutable objects simple. Using records automatically generates properties, equality checking, cloning and deconstruction among other methods.