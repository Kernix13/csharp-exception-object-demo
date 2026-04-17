# Learn CSharp Exception Handling and the Exception Object

A C# console application demonstrating exception handling, try/catch, user input parsing using Int.Parse(), and exploring the Exception object.

## Overview

This is a deliverable for module 2, week 2 for Code:You's Software Development pathway. The requirements are:

- Accept user input and store it in a string variable
- Use the `Parse()` method to parse the user input in to a specific data type and catch the exceptions thrown when that value cannot be parsed into that data type
- Implement try/catch to perform error handling using the Parse method in the try block and use the catch block for handling exceptions.

This console app delves into the properties in the Exception object and writes all relevant information to the console for the common exception types.

> _The main purpose of this console app is primarily to learn the exception object, and secondarily to learn exception handling._

## Prerequisites

- [.NET SDK 10.0](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio Code](https://code.visualstudio.com/) with [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)

<br>

## Installation & Usage

1. Clone this repository and switch into project folder

   ```sh
   git clone https://github.com/Kernix13/csharp-exception-object-demo
   cd csharp-exception-object-demo
   ```

2. Create a solution file

   ```sh
   dotnet new sln
   ```

3. Link the project to the solution

   ```sh
   dotnet sln add csharp-exception-object-demo.csproj
   ```

4. Run the application

   ```bash
   dotnet run
   ```

5. Build the application

   ```bash
   dotnet build
   ```

### Quick Start

```sh
git clone https://github.com/Kernix13/csharp-exception-object-demo
cd csharp-exception-object-demo
dotnet new sln
dotnet sln add csharp-exception-object-demo.csproj
dotnet run
```

<br>

## Tasks

1. add Console.WriteLine statements to prompt the user to enter any character other than a number to generate a FormatException
2. add a ReadLine statement inside a try block to Parse the input provided above
3. add a Console.WriteLine statement in the catch block that outputs as much information about the Exception that is useful. Use `$@"{e.Message}"` and other properties to display the info
4. Copy that format for other type of exceptions, maybe with prompts on which type of Exception the user wants to display

```
ex.Message        // Human-readable message
ex.Source         // Assembly/app name
ex.StackTrace     // Full stack trace string
ex.InnerException // Nested exception (nothing there?)
ex.TargetSite     // Method where error occurred (not sure how to split that string)

EXAMPLE:

Message [string] = "Attempted to divide by zero."
Source [string] = "Exceptions101"

StackTrace [string] = at Program.<Main>$(String[] args) in c:\Users\path_to_project\Exceptions101\Program.cs:line 42
```

Common exceptions to include

- IndexOutOfRangeException
- NullReferenceException
- DivideByZeroException
- FormatException (bad parsing input)
- Maybe: ArgumentNullException, ArgumentOutOfRangeException

Until we cover dictionaries or Classes/objects, just reference links in an array

```cs
string[] urls =
{
    "https://learn.microsoft.com/en-us/dotnet/api/system.dividebyzeroexception",
    "https://learn.microsoft.com/en-us/dotnet/api/system.formatexception",
    "https://learn.microsoft.com/en-us/dotnet/api/system.indexoutofrangeexception",
    "https://learn.microsoft.com/en-us/dotnet/api/system.nullreferenceexception"
};
```

Warnings I am getting in the console:

```
C:\Users\pc\Documents\WebDev\CSharp\csharp-exception-object-demo\Program.cs(60,33): warning CS8604: Possible null reference argument for parameter 's' in 'int int.Parse(string s)'.

C:\Users\pc\Documents\WebDev\CSharp\csharp-exception-object-demo\Program.cs(43,22): warning CS8602: Dereference of a possibly null reference.
```
