using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Async2
    {
        //UI
        static void Main() {
            Console.WriteLine("Main method Started....");
            SomeMethod();
            //SomeMethod();
            Console.WriteLine("Main method End");
            Console.ReadLine();
        }

        public async static void SomeMethod() {
            Console.WriteLine("Some method startred");
            await Wait();
            //Console.WriteLine();
            Console.WriteLine("Some Method ended");
        }
        //async code synchronously
        private static async Task Wait()
        {
            await Task.Delay(5000); //fetching data
            //returning the data 

            await Task.Delay(5000); //fetching data
            //returning the data 

            Console.WriteLine("5 seconds wait Completed");
        }

    }
}

//Task  Task<T>
