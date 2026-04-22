# Learn CSharp Exception Handling and the Exception Object

A C# console application demonstrating exception handling, try/catch, user input parsing using Int.Parse(), and exploring the Exception object.

<br>

## Overview

This is a deliverable for module 2, week 2 for Code:You's Software Development pathway. The requirements are:

- Accept user input and store it in a string variable.
- Use the `Parse()` method to parse the user input to a specific data type and catch the exceptions thrown when that value cannot be parsed into that data type.
- Implement try/catch to perform error handling using the `Parse` method in the `try` block and use the `catch` block for handling exceptions.

This console app delves into the properties in the Exception object and writes all relevant information to the console for the common exception types.

> _The main purpose of this console app is primarily to learn the exception object, and secondarily to learn exception handling._

<!-- Are those last 2 sentences repetitive? Should they be combined? -->

<br>

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

2. Run the application

   ```bash
   dotnet run
   ```

3. Build the application

   ```bash
   dotnet build
   ```

4. Follow the propts in the console to see the specific exceptions details.

### <span aria-hidden="true">⚡</span> Quick Start

<!-- I t hink h3 elements should have an emoji/icon at the beginning -->

```sh
git clone https://github.com/Kernix13/csharp-exception-object-demo
cd csharp-exception-object-demo
dotnet run
```

<br>

## Exception object and example output

Console messages tell the user what to enter so that an exception will be thrown. Here is example output for `DivideByZeroException`:

```sh
Learn exception handling and the Exception object.

Enter the type of exception you want to see:

1. DivideByZeroException (Enter 1)
2. FormatException (Enter 2)
3. IndexOutOfRangeException (Enter 3)
4. NullReferenceException (Enter 4)
1
Enter the number 0 to see a Divide By Zero Exception: 0

Error Type: DivideByZeroException
Type Description: Attempted to divide by zero.
Source Directory: csharp-exception-object-demo
Location of Exception: Program.cs:line 65
DivideByZeroException Docs Link: https://learn.microsoft.com/en-us/dotnet/api/system.dividebyzeroexception

```

I could maybe output some aspect of the code like `int result = 10 / divisor;` so the user knows what is going on.

### <span aria-hidden="true">📚</span> Exception object fields

There are not as many fields as I hoped to drill down into to get information, but here are the most useful IMO:

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

ex.TargetSite: Void <<Main>$>g__ShowDivideByZeroException|0_1(<>c__DisplayClass0_0 ByRef)
ex.TargetSite.GetTYpe(): System.Reflection.RuntimeMethodInfo
```

### <span aria-hidden="true">📌</span> Common exceptions to include

I am using 4 exceptions in `Program.cs`:

- `IndexOutOfRangeException`
- `NullReferenceException`
- `DivideByZeroException`
- `FormatException`

Others to consider:

- `OverflowException`
- `ArgumentNullException`
- `ArgumentOutOfRangeException`
- `IOException`
- `TypeInitializationException`

How many exceptions are common enough to include?

### <span aria-hidden="true">🎯</span> Exception.Source values

> _See the comments in `Program.cs` involving `System.Private.CoreLib`._

`ex.Source` = `System.Private.CoreLib` --> The assembly (compiled code) where the exception was thrown.

- `DivideByZeroException` happens inside your code, so Source = your project
- Same for `NullReferenceException` - exception is thrown in your code
- `IndexOutOfRangeException` & `FormatException` -> Exception is thrown inside .NET's parsing code which is in `System.Private.CoreLib` (actually thrown by the runtime).

Your code throwing the exception vs .NET throwing it! `Source` = where the exception is thrown, not where it's caught.

### <span aria-hidden="true">🔗</span> Link to docs array

Until dictionaries or Classes/objects are added to the project, just reference doc links in an array:

```cs
string[] urls =
{
    "https://learn.microsoft.com/en-us/dotnet/api/system.dividebyzeroexception",
    "https://learn.microsoft.com/en-us/dotnet/api/system.formatexception",
    "https://learn.microsoft.com/en-us/dotnet/api/system.indexoutofrangeexception",
    "https://learn.microsoft.com/en-us/dotnet/api/system.nullreferenceexception"
};
```
