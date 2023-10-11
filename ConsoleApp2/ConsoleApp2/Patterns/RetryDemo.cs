using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Patterns
{
    internal class RetryDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");
            RetryMethod();

            Console.WriteLine("Main Method Completed");
            Console.ReadKey();
        }
        public static async void RetryMethod()
        {
            //It tells the number of times we will retry the operation if it is failing
            //Of course, if it is not falling then we will not retry
            var RetryTimes = 3;
            //The idea is that we don't want to immediately retry, but 
            //we may want to retry after a certain amount of time.
            //In our case, it is five hundred milliseconds or half a second.
            var WaitTime = 500;
            for (int i = 0; i < RetryTimes; i++)
            {
                try
                {
                    //Do the Operation
                    //If the Operation Successful break the loop
                    await RetryOperation();
                    Console.WriteLine("Operation Successful");
                    break;
                }
                catch (Exception Ex)
                {
                    //If the operations throws an error
                    //Log the Exception if you want
                    Console.WriteLine($"Retry {i + 1}: Getting Exception : {Ex.Message}");
                    //Wait for 500 milliseconds
                    await Task.Delay(WaitTime);
                }
            }
        }

        public static async Task RetryOperation()
        {
            //Doing Some Processing
            await Task.Delay(500);
            //Throwing Exception so that retry will work
            throw new Exception("Exception Occurred in while Processing...");
        }
    }
}
