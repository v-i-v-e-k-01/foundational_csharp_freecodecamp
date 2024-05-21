// /* 
// This code uses a names array and corresponding methods to display
// greeting messages
// */

// string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

// string messageText = "";

// foreach (string name in names)
// {
//     if (name == "Sophia")
//         messageText = SophiaMessage();
//     else if (name == "Andrew")
//         messageText = AndrewMessage();
//     else if (name == "AllGreetings")
//     {
//         messageText = SophiaMessage();
//         messageText = messageText + "\n\r" + AndrewMessage();
//     }

//     Console.WriteLine(messageText + "\n\r");
// }

// bool pauseCode = true;
// while (pauseCode == true);

// static string SophiaMessage()
// {
//     return "Hello, my name is Sophia.";
// }

// static string AndrewMessage()
// {
//     return "Hi, my name is Andrew. Good to meet you.";
// }



// int productCount = 2000;
// string[,] products = new string[productCount, 2];

// LoadProducts(products, productCount);

// for (int i = 0; i < productCount; i++)
// {
//     string result;
//     result = Process1(products, i);

//     if (result != "obsolete")
//     {
//         result = Process2(products, i);
//     }
// }

// bool pauseCode = true;
// while (pauseCode == true) ;

// static void LoadProducts(string[,] products, int productCount)
// {
//     Random rand = new Random();

//     for (int i = 0; i < productCount; i++)
//     {
//         int num1 = rand.Next(1, 10000) + 10000;
//         int num2 = rand.Next(1, 101);

//         string prodID = num1.ToString();

//         if (num2 < 91)
//         {
//             products[i, 1] = "existing";
//         }
//         else if (num2 == 91)
//         {
//             products[i, 1] = "new";
//             prodID = prodID + "-n";
//         }
//         else
//         {
//             products[i, 1] = "obsolete";
//             prodID = prodID + "-0";
//         }

//         products[i, 0] = prodID;
//     }
// }

// static string Process1(string[,] products, int item)
// {
//     Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

//     return products[item, 1];
// }

// static string Process2(string[,] products, int item)
// {
//     Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
//     if (products[item, 1] == "new")
//         Process3(products, item);

//     return "continue";
// }

// static void Process3(string[,] products, int item)
// {
//     Console.WriteLine($"Process3 message - processing product information for 'new' product");
// }



// string? readResult;
// int startIndex = 0;
// bool goodEntry = false;

// int[] numbers = { 1, 2, 3, 4, 5 };

// // Display the array to the console.
// Console.Clear();
// Console.Write("\n\rThe 'numbers' array contains: { ");
// foreach (int number in numbers)
// {
//     Console.Write($"{number} ");
// }

// // To calculate a sum of array elements, 
// //  prompt the user for the starting element number.
// Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
// while (goodEntry == false)
// {
//     readResult = Console.ReadLine();
//     goodEntry = int.TryParse(readResult, out startIndex);

//     if (startIndex > 5)
//     {
//         goodEntry = false;
//         Console.WriteLine("\n\rEnter an integer value between 1 and 5");
//     }
// }

// // Display the sum and then pause.
// Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");

// Console.WriteLine("press Enter to exit");
// readResult = Console.ReadLine();

// // This method returns the sum of elements n through 5
// static int SumValues(int[] numbers, int n)
// {
//     int sum = 0;
//     for (int i = n-1; i < numbers.Length; i++)
//     {
//         sum += numbers[i];
//     }
//     return sum;
// }



// bool exit = false;
// var rand = new Random();
// int num1 = 5;
// int num2 = 5;

// do
// {
//     num1 = rand.Next(1, 11);
//     num2 = num1 + rand.Next(1, 51);

// } while (exit == false);



// /*  
// This code instantiates a value and then calls the ChangeValue method
// to update the value. The code then prints the updated value to the console.
// */
// int x = 5;

// x= ChangeValue(x);

// Console.WriteLine(x);

// int ChangeValue(int value) 
// {
//     value=10;
//     return value;
// }


// string[] names = { "Dog", "Cat", "Fish" };
// Object[] objs = (Object[])names;

// Object obj = (Object)13;
// objs[2] = obj; // ArrayTypeMismatchException occurs


// int valueEntered;
// string userValue = "two";
// valueEntered = int.Parse(userValue); // FormatException occurs


// int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
// int[] values2 = new int[6];

// values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs


// object obj = "This is a string";
// int num = (int)obj; //InvalidCastException


// int[] values = null;
// for (int i = 0; i <= 9; i++)
//     values[i] = i * 2;  //NullReferenceException


// string? lowCaseString = null;
// Console.WriteLine(lowCaseString.ToUpper());  //NullReferenceException


// decimal x = 400;
// byte i;

// i = (byte)x; // OverflowException occurs
// Console.WriteLine(i);


// double float1 = 3000.0;
// double float2 = 0.0;
// int number1 = 3000;
// int number2 = 0;

// try{
// Console.WriteLine(float1 / float2);
// Console.WriteLine(number1 / number2);
// Console.WriteLine("Exit program");
// }
// catch
// {
//     Console.WriteLine("An exception has been caught");
// }




// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     WriteMessage();
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }



// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     try{
//     WriteMessage();
//     }
//     catch{
//         Console.WriteLine("Exception caught in Process1");
//     }
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);

// }


// Here are the properties of the Exception class:

//     Data: The Data property holds arbitrary data in key-value pairs.

//     HelpLink: The HelpLink property can be used to hold a URL (or URN) to a help file that provides extensive information about the cause of an exception.

//     HResult: The HResult property can be used to access to a coded numerical value that's assigned to a specific exception.

//     InnerException: The InnerException property can be used to create and preserve a series of exceptions during exception handling.

//     Message: The Message property provides details about the cause of an exception.

//     Source: The Source property can be used to access the name of the application or the object that causes the error.

//     StackTrace: The StackTrace property contains a stack trace that can be used to determine where an error occurred.

//     TargetSite: The TargetSite property can be used to get the method that throws the current exception.




// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     //  catch(Exception ex)
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//     }
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;
//     byte smallNumber;

//     try
//     {
//         Console.WriteLine(float1 / float2);
//         Console.WriteLine(number1 / number2);
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//     }
//     checked
//     {
//         try
//         {
//             smallNumber = (byte)number1;

//         }
//         catch (OverflowException ex)
//         {
//             Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//         }
//     }
// }



// // inputValues is used to store numeric values entered by a user
// string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

// foreach (string inputValue in inputValues)
// {
//     int numValue = 0;
//     try
//     {
//         numValue = int.Parse(inputValue);
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Invalid readResult. Please enter a valid number.");
//     }
//     catch (OverflowException)
//     {
//         Console.WriteLine("The number you entered is too large or too small.");
//     }
//     catch(Exception ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
// }



// checked
// {
//     try
//     {
//         int num1 = int.MaxValue;
//         int num2 = int.MaxValue;
//         int result = num1 + num2;
//         Console.WriteLine("Result: " + result);
//     }
//     catch (OverflowException ex)
//     {
//         Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
//     }
// }

// try
// {
//     string str = null;
//     int length = str.Length;
//     Console.WriteLine("String Length: " + length);
// }
// catch (NullReferenceException ex)
// {
//     Console.WriteLine("Error: The reference is null." + ex.Message);
// }

// try
// {
//     int[] numbers = new int[5];
//     numbers[5] = 10;
//     Console.WriteLine("Number at index 5: " + numbers[5]);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine("Error: Index out of range." + ex.Message);
// }

// try
// {
//     int num3 = 10;
//     int num4 = 0;
//     int result2 = num3 / num4;
//     Console.WriteLine("Result: " + result2);
// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
// }

// Console.WriteLine("Exiting program.");




// ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");

// throw invalidArgumentException;

// throw new FormatException("FormatException: Calculations in process XYZ have been cancelled due to invalid data format.");




// string[][] userEnteredValues = new string[][]
// {
//         new string[] { "1", "two", "3"},
//         new string[] { "0", "1", "2"}
// };

// foreach (string[] userEntries in userEnteredValues)
// {
//     try
//     {
//         BusinessProcess1(userEntries);
//     }
//     catch (Exception ex)
//     {
//         if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
//         {
//             Console.WriteLine(ex.Message);
            
//         }

//         throw new ApplicationException("An error occured",ex);
//     }
// }

// static void BusinessProcess1(string[] userEntries)
// {
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         try
//         {
//             valueEntered = int.Parse(userValue);

//             // completes required calculations based on userValue
//             // ...
//         }
//         catch (FormatException)
//         {
//             FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
//             throw invalidFormatException;
//         }
//     }
// }





try
{
    OperatingProcedure1();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Exiting application.");
}

static void OperatingProcedure1()
{
    string[][] userEnteredValues = new string[][]
    {
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
    };

    foreach(string[] userEntries in userEnteredValues)
    {
        try
        {
            BusinessProcess1(userEntries);
        }
        catch (Exception ex)
        {
            if (ex.StackTrace.Contains("BusinessProcess1"))
            {
                if (ex is FormatException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Corrective action taken in OperatingProcedure1");
                }
                else if (ex is DivideByZeroException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                    // re-throw the original exception
                    throw;
                }
                else
                {
                    // create a new exception object that wraps the original exception
                    throw new ApplicationException("An error occurred - ", ex);
                }
            }
        }

    }
}

static void BusinessProcess1(string[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;
        }
        catch (DivideByZeroException)
        {
            DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
            throw unexpectedDivideByZeroException;

        }
    }
}