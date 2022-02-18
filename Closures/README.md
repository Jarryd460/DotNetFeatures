# Closures

### Description

* Closures are classes (eg. DisplayClass2_0) with a method that are automatically generated when using Linq, Expression, Func, Predicate, Action etc. Basically anywhere where Lambda functions (x => x > 400) are used.

### Dependencies

* ClrHeapAllocationAnalyzer

### Closures

* Closures take up memory as they generate classes which are added to the heap when Lambda expression is heaped.
* Run the console application and put a breakpoint on "GetNumbersOverNumberUsingLinq" method (line 31) and capture a snapshot (Diagnostics Tools Window). Click on Objects (Diff) or Heap Size (Diff) and search for "display". You should see the generated class DisplayClass....
	* Do the above for GetNumbersOverNumberMethodScoped and the "display" class should be generated and added to the heap as well when the Lambda expression is called.
	* Do the above for GetNumbersOverNumberConstantNumber and GetNumbersOverNumberLambdaScoped, you will see that the display class is not generated but a class "c" is still (search using "Closures.Application").
	* Do the above for GetNumbersOverNumberUsingLoop and no class will be generated ("display" and "c").
* Using clrHeapAllocationAnalyzer nuget package helps one see where closures will be generated and make changes if needed.

### References

* Nick Chapsas: https://www.youtube.com/watch?v=h3MsnBRqzcY&t=190s

### Additional Resources

* View lowered code: https://sharplab.io/