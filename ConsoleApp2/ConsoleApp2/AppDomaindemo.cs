// using System;
// using static System.Console;
// using System;

// namespace ConsoleCalculator
// {
//     public class Calculator
//     {
//         public int Calculate(int number1, int number2, string operation)
//         {
//             //throw new ArgumentNullException(nameof(number1));

//             string nonNullOperation = 
//                 operation ?? throw new ArgumentNullException(nameof(operation));

//             //if (operation is null)
//             //{
//             //    throw new ArgumentNullException(nameof(operation));
//             //}

//             if (nonNullOperation == "/")
//             {
//                 try
//                 {
//                     return Divide(number1, number2);
//                 }
//                 catch (DivideByZeroException ex)
//                 {
//                     // Log.Error(ex);
//                     //throw;

//                     throw new ArithmeticException("An error occurred during calculation.",
//                         ex);
//                 }

//             }
//             else
//             {
//                 throw new ArgumentOutOfRangeException(nameof(operation),
//                     "The mathematical operator is not supported.");

//                 //Console.WriteLine("Unknown operation.");
//                 //return 0;
//             }
//         }
        
//         private int Divide(int number, int divisor)
//         {
//             return number / divisor;
//         }
//     }
// }


// namespace ConsoleCalculator
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             AppDomain currentAppDomain = AppDomain.CurrentDomain;
//             currentAppDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);

//             WriteLine("Enter first number");
//             // int number1 = int.Parse(ReadLine());
//             int number1 = 10; 

//             WriteLine("Enter second number");
//             // int number2 = int.Parse(ReadLine());
//             int number2 = 0;

//             WriteLine("Enter operation");
//             // string operation = ReadLine().ToUpperInvariant();
//             string operation = "/";


//             var calculator = new Calculator();

//             // try
//             // {
//                 int result = calculator.Calculate(number1, number2, operation);
//             //     DisplayResult(result);
//             // // }
//             // catch (ArgumentNullException ex) when (ex.ParamName == "operation")
//             // {
//             //     // Log.Error(ex);
//             //     WriteLine($"Operation was not provided. {ex}");
//             // }
//             // catch (ArgumentNullException ex)
//             // {
//             //     // Log.Error(ex);
//             //     WriteLine($"An argument was null. {ex}");
//             // }
//             // catch (ArgumentOutOfRangeException ex)
//             // {
//             //     // Log.Error(ex);
//             //     WriteLine($"Operation is not supported. {ex}");
//             // }
//             // catch (Exception ex)
//             // {
//             //     WriteLine($"Sorry, something went wrong. {ex}");
//             //     throw ex;
//             // }
//             // finally
//             // {
//             //     WriteLine("...finally...");
//             // }
            


            
//              Console.WriteLine("Program Ended");
            
//         }

//         private static void HandleException(object sender, UnhandledExceptionEventArgs e)
//         {
//             WriteLine($"Sorry there was a problem and we need to close. Details: {e.ExceptionObject}");
//         }

//         private static void DisplayResult(int result)
//         {
//             WriteLine($"Result is: {result}");
//         }
//     }
// }
