// Prompt the user for the lower and upper bounds
// Console.Write("Enter the lower bound: ");
// int lowerBound = int.Parse(Console.ReadLine());

// Console.Write("Enter the upper bound: ");
// int upperBound = int.Parse(Console.ReadLine());


// decimal averageValue = 0;
// bool exit = false;

// do
// {
//     try
//     {

//     if (lowerBound >= upperBound)
//     {
//         throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
//     }
//     // Calculate the sum of the even numbers between the bounds
//     averageValue = AverageOfEvenNumbers(lowerBound, upperBound);
//     // Display the value returned by AverageOfEvenNumbers in the console
//     Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

//     exit=true;
// }
// catch (ArgumentOutOfRangeException ex)
// {
//     Console.WriteLine("An error has occurred.");
//     Console.WriteLine(ex.Message);
//         Console.WriteLine($"Upper bound must be greater than {lowerBound}");
//         Console.WriteLine($"Enter a new upper bound  (or enter Exit to quit):  ");
//         string? userResponse = Console.ReadLine();
//         if (userResponse.ToLower().Contains("exit"))
//         {
//             exit = true;
//         }
//         else
//         {
//             upperBound = int.Parse(userResponse);
//         }
//     }


// } while (exit == false);


// // Wait for user input
// Console.ReadLine();

// static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
// {
//     int sum = 0;
//     int count = 0;
//     decimal average = 0;

//     // try
//     // {
//         for (int i = lowerBound; i <= upperBound; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 sum += i;
//                 count++;
//             }
//         }

//         average = (decimal)sum / count;
//     // }
//     // catch (DivideByZeroException)
//     // {
//     //     ArgumentOutOfRangeException invalidInput = new ArgumentOutOfRangeException("ArgumentOutOfRangeException: Upper bound should be greater than lower bound.");

//     //     throw invalidInput;
//     // }
//     return average;
// }





// string[][] userEnteredValues = new string[][]
// {
//             new string[] { "1", "2", "3"},
//             new string[] { "1", "two", "3"},
//             new string[] { "0", "1", "2"}
// };

// Workflow1(userEnteredValues);


// static void Workflow1(string[][] userEnteredValues)
// {

//     foreach (string[] userEntries in userEnteredValues)
//     {
//         Process1(userEntries);
//     }
// }

// static void Process1(String[] userEntries)
// {
//     string processStatus = "clean";
//     string returnMessage = "";
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         bool integerFormat = int.TryParse(userValue, out valueEntered);

//         if (integerFormat == true)
//         {
//             if (valueEntered != 0)
//             {
//                 checked
//                 {
//                     int calculatedValue = 4 / valueEntered;
//                 }
//             }
//             else
//             {
//                 returnMessage = "Invalid data. User input values must be non-zero values.";
//                 processStatus = "error";
//             }
//         }
//         else
//         {
//             returnMessage = "Invalid data. User input values must be valid integers.";
//             processStatus = "error";
//         }
//     }

//     if (processStatus == "clean")
//     {
//         returnMessage = "process complete";
//     }

//     string operationStatusMessage = "good";
//     string processStatusMessage = "";

//     processStatusMessage = returnMessage;

//     if (processStatusMessage == "process complete")
//     {
//         Console.WriteLine("'Process1' completed successfully.");
//         Console.WriteLine();
//     }
//     else
//     {
//         Console.WriteLine("'Process1' encountered an issue, process aborted.");
//         Console.WriteLine(processStatusMessage);
//         Console.WriteLine();
//         operationStatusMessage = processStatusMessage;
//     }

//     if (operationStatusMessage == "good")
//     {
//         operationStatusMessage = "operating procedure complete";
//     }

//     string overallStatusMessage = operationStatusMessage;
//     if (overallStatusMessage == "operating procedure complete")
//     {
//         Console.WriteLine("'Workflow1' completed successfully.");
//     }
//     else
//     {
//         Console.WriteLine("An error occurred during 'Workflow1'.");
//         Console.WriteLine(overallStatusMessage);
//     }

// }









string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};


try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");
    Console.WriteLine();

}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'");
    Console.WriteLine(ex.Message);
}



static void Workflow1(string[][] userEnteredValues)
{

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }

}

static void Process1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {

        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }

}

