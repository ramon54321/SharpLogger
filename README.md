# SharpLogger
A custom logging system for .NET, written in C#, which allows levels and filtering, with an independent output implementation.

## Getting Started
View the [examples](https://github.com/ramon54321/SharpLogger/tree/master/examples) page for information on a various logger setups.

[Latest NuGet Package](https://www.nuget.org/packages/SharpLogger)

## Overview
SharpLogger attempts to push you away from being stingy with what you log. I believe that it is valuable to log many things in your code, however, this often turns into a mess, when you have a cluttered log file with information regarding objects you are no longer interested in, or are not currently concerned with.

The solution is not to remove those logs, but rather filter them, to only show the information you are interested in. SharpLogger allows you to specify a log level for your logs, as well as a filter, which can be dot separated into groups and subgroups. This allows you to simply specify a filter you are interested in, and viewing the logs regarding that specific filter. Filters can be changed on the fly, while the application is running.

### Printer
The logger calls the printer class' Print() method, allowing you to override the class with your own handler for the log itself, meaning you are not restricted to Console.WriteLine(), or Debug.Log() for Unity, but can take the processed string from the logger and do with it what you like, including writing to a file.

This also means you can use SharpLogger on slightly different environments, since you are able to control them individually, such as Unity Client and Server applications.

## Contributing
If you'd like to contribute, feel free to fork the repository. Pull requests are welcome!

## Diagrams
#### Component Diagram
![Component Diagram](http://repo.ramonbrand.ml/images/SharpLogger/ComponentDiagram.jpg)

#### Class Diagram
![Class Diagram](http://repo.ramonbrand.ml/images/SharpLogger/ClassDiagram.jpg)

## Dev Log
### 12 Jan 2018
There seems to be an issue with msbuild using the Net35 assemblies, so in order to package the NuGet package with dotnet, there is an override added to the csproj file.

The [latest release 1.0.4 on NuGet](https://www.nuget.org/packages/SharpLogger/1.0.4) or the [latest release 1.0.4 on GitHub](https://github.com/ramon54321/SharpLogger/releases/tag/v1.0.4) includes dlls for NetStandard 1.0, Net35 and Net4. If you are using Unity, use the Net35 dlls.

### 9 Jan 2018
Changed target runtime to NetStandard 1.0, since there is no need to restrict the library to NetCore. I am working on including a library built for Net3.5 also, since Unity does not seem to work with NetStandard libraries, and Unity is certainly required to be compatible.

Opened a question [here on Unity.com/questions](https://answers.unity.com/questions/1452392/why-are-netstandard-10-libraries-not-working.html), to see if I can get some answers regarding the issue with Unity and NetStandard libraries.

For now the release and the NuGet package will include both NetStandard and Net3.5 dlls.

Thinking also of changing the filtering system somewhat, to ensure consistent wording is used. I have noticed an issue sometimes arrises where I sometimes set the filter to be "NetworkManager.Objects" and sometimes "NetworkManager.Object" as an example, without noticing the plural on one of them, and this then causing issues later in the filter. Possibly a sort of enum, or some form of filter tracking is needed.
