# UTParse
C# Library for parsing UNTONE Project Info files (project.info).
# Usage
First compile the DLL and add it to your project's references, then import it:
```
using UTParse;
```
Provided a project.info string, you can easily retrieve individual properties, like this:
```
var readProjectInfo = File.ReadAllText("project.info");
var parsedProjectInfo = Parser.ParseUTInfo(readProjectInfo);
Console.WriteLine(parsedProjectInfo.Name);
```
This example reads a project.info file to a string, then parses it and writes its Name property to the screen.
