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