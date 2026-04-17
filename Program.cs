string[] urls =
{
    "https://learn.microsoft.com/en-us/dotnet/api/system.dividebyzeroexception",
    "https://learn.microsoft.com/en-us/dotnet/api/system.formatexception",
    "https://learn.microsoft.com/en-us/dotnet/api/system.indexoutofrangeexception",
    "https://learn.microsoft.com/en-us/dotnet/api/system.nullreferenceexception"
};



Console.WriteLine("Learn exception handling and the Exception object.\n");
Console.WriteLine(@"Enter the type of exception you want to see:

1. DivideByZeroException (enter 1)
2. FormatException (enter 2)
3. IndexOutOfRangeException (enter 3)
4. NullReferenceException (enter 4)");

string? type = Console.ReadLine();

// Use a switch statement to determine which exception to demonstrate based on user input
switch (type)
{
    case "1":
        ShowDivideByZeroException();
        break;
    case "2":
        // Create function to demonstrate FormatException
        break;
    case "3":
        // Create function to demonstrate IndexOutOfRangeException
        break;
    case "4":
        // Create function to demonstrate NullReferenceException
        break;
    default:
        Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 4.");
        return;
}

void ShowExceptionInfo(Exception ex, string[] urls, int index)
{
    string[] filePath = ex.StackTrace.Split('\\');
    string fileAndLine = filePath[^1].Trim();

    Console.WriteLine($"\nError Type: {ex.GetType().Name}");
    Console.WriteLine($"Type Description: {ex.Message}");
    Console.WriteLine($"Source Directory: {ex.Source}");
    // Console.WriteLine($"Method where error occurred: {ex.TargetSite}");
    Console.WriteLine($"Location of Exception: {fileAndLine}");
    // Console.WriteLine($"Stack Trace: {ex.StackTrace}");
    Console.WriteLine($"{ex.GetType().Name} Docs Link: {urls[index]}");
}

// Option 1: DivideByZeroException ✅
void ShowDivideByZeroException()
{
    try
    {
        Console.Write("Enter a number (0 will trigger error): ");
        int divisor = int.Parse(Console.ReadLine());

        int result = 10 / divisor;
    }
    catch (DivideByZeroException ex)
    {
        ShowExceptionInfo(ex, urls, 0);
    }
}


// Option 2: FormatException 📌


// Option 3: IndexOutOfRangeException 📌


// Option 4: NullReferenceException 📌

