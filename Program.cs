string[] urls =
{
    "https://learn.microsoft.com/en-us/dotnet/api/system.dividebyzeroexception",
    "https://learn.microsoft.com/en-us/dotnet/api/system.formatexception",
    "https://learn.microsoft.com/en-us/dotnet/api/system.indexoutofrangeexception",
    "https://learn.microsoft.com/en-us/dotnet/api/system.nullreferenceexception"
};

Console.WriteLine("Learn exception handling and the Exception object.\n");
Console.WriteLine(@"Enter the type of exception you want to see:

1. DivideByZeroException (Enter 1)
2. FormatException (Enter 2)
3. IndexOutOfRangeException (Enter 3)
4. NullReferenceException (Enter 4)");

string? type = Console.ReadLine();

// Use a switch statement to determine which exception to demonstrate based on user input
switch (type)
{
    case "1":
        ShowDivideByZeroException();
        break;
    case "2":
        ShowFormatException();
        break;
    case "3":
        // Create function to demonstrate IndexOutOfRangeException
        // ShowIndexOutOfRangeException();
        break;
    case "4":
        // Create function to demonstrate NullReferenceException
        // ShowNullReferenceException();
        break;
    default:
        Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 4.");
        return;
}

// Helper function to display exception information
void ShowExceptionInfo(Exception ex, string[] urls, int index)
{

    Console.WriteLine($"\nError Type: {ex.GetType().Name}");
    Console.WriteLine($"Type Description: {ex.Message}");
    Console.WriteLine($"Source Directory: {ex.Source}");

    if (ex.StackTrace != null)
    {
        string[] filePath = ex.StackTrace.Split('\\');
        string fileAndLine = filePath[^1].Trim();
        Console.WriteLine($"Location of Exception: {fileAndLine}");
    }

    Console.WriteLine($"{ex.GetType().Name} Docs Link: {urls[index]}");
}

// Option 1: Divide By Zero Exception ✅
void ShowDivideByZeroException()
{
    try
    {
        Console.Write("Enter the number 0 to see a Divide By Zero Exception: ");
        int divisor = int.Parse(Console.ReadLine()!);

        int result = 10 / divisor;
    }
    catch (DivideByZeroException ex)
    {
        ShowExceptionInfo(ex, urls, 0);
    }
}


// Option 2: Format Exception ✅
void ShowFormatException()
{
    try
    {
        Console.Write("Enter a non-numeral character to see a Format Exception: ");

        int number = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException ex)
    {
        ShowExceptionInfo(ex, urls, 1);
    }
}


// Option 3: Index Out Of Range Exception 📌


// Option 4: Null Reference Exception 📌

