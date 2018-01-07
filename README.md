# SharpLogger
A custom logging system for .NET Core 2.0, written in C#, which allows levels and filtering, with an independent output implementation.

## Overview
SharpLogger attempts to push you away from being stingy with what you log. I believe that it is valuable to log many things in your code, however, this often turns into a mess, when you have a cluttered log file with information regarding objects you are no longer interested in, or are not currently concerned with.

The solution is not to remove those logs, but rather filter them, to only show the information you are interested in. SharpLogger allows you to specify a log level for your logs, as well as a filter, which can be dot separated into groups and subgroups. This allows you to simply specify a filter you are interested in, and viewing the logs regarding that specific filter. Filters can be changed on the fly, while the application is running.

### Printer
The logger calls the printer class' Print() method, allowing you to override the class with your own handler for the log itself, meaning you are not restricted to Console.WriteLine(), or Debug.Log() for Unity, but can take the processed string from the logger and do with it what you like, including writing to a file.

This also means you can use SharpLogger on slightly different environments, since you are able to control them individually, such as Unity Client and Server applications.

## Diagrams
#### Component Diagram
![Component Diagram](http://repo.ramonbrand.ml/images/SharpLogger/ComponentDiagram.jpg)

#### Class Diagram
![Class Diagram](http://repo.ramonbrand.ml/images/SharpLogger/ClassDiagram.jpg)
