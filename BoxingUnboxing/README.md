# Boxing and Unboxing

### Description

* Boxing is the process of converting a value type to the type "object" or to any interface type implemented by this value type. When the common language runtime (CLR) boxes a value type, it wraps the value inside a System.Object instance and stores it on the managed heap. Unboxing extracts the value type from the object.

### Dependencies

* BenchmarkDotNet

### Boxning

* Running the application and capturing a snapshot (Diagnostics Tools Window) just before "someNumber" is assigned to "someObject" and then again after, you will see that the value "420" is assigned to an object on the heap.
	* Click on Objects (Diff) or Heap Size (Diff) and Compare the two snapshots and search for "Int32".  You should see that 420 was added to an object in "Int32".
	* To view the MSIL (Microsoft Intermediate Language) code, go to https://dotnetfiddle.net/# and paste the code and click on "Tidy up" and select "View IL". You will see that there is a "box" step. You could also get ILSpy which is an extension for Visual Studio to accomplish the same thing.
	* Boxing is 20 times slower than a normal assignment.

### Unboxning
* Running the application again and capturing 3 snapshots, the first 2 exactly the same as mentioned above and the 3 just after the assigning of "unboxing", you will notice that even after unboxing, the boxed value still exist's on the heap.
	* To view the MSIL (Microsoft Intermediate Language) code, go to https://dotnetfiddle.net/# and paste the code and click on "Tidy up" and select "View IL". You will see that there is a "unbox.any" step.
	* Unboxing is 4 times slower than a normal assignment.

### References

* Nick Chapsas: https://www.youtube.com/watch?v=GVJ5EUhWQBc&t=1s
* Dotnet Fiddle: https://dotnetfiddle.net/#
* ILSpy: https://marketplace.visualstudio.com/items?itemName=SharpDevelopTeam.ILSpy#:~:text=ILSpy%20is%20a%20Visual%20Studio%20extension%20for%20the%20ILSpy%20open%20source%20decompiler.

### Additional Resources

* View lowered code (how your code looks before compiling it to MSIL code): https://sharplab.io/