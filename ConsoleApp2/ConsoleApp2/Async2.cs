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
        //static void Main() {
        //    Console.WriteLine("Main method Started....");
        //    SomeMethod();
        //    //SomeMethod();
        //    Console.WriteLine("Main method End");
        //    Console.ReadLine();
        //}

        //public async static void SomeMethod() {
        //    Console.WriteLine("Some method startred");
        //    await Wait();
        //    //Console.WriteLine();
        //    Console.WriteLine("Some Method ended");
        //}
        ////async code synchronously
        //private static async Task Wait()
        //{
        //    await Task.Delay(5000); //fetching data
        //    //returning the data 

        //    await Task.Delay(5000); //fetching data
        //    //returning the data 

        //    Console.WriteLine("5 seconds wait Completed");
        //}


        public static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");
            Console.WriteLine("Enter the Name: ");
            string Name = Console.ReadLine();
            SomeMethod(Name);
            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }
        public async static void SomeMethod(string Name)
        {
            Console.WriteLine("Some Method Started......");
            var GreetingSMessage = await Greetings(Name);
            Console.WriteLine($"\n{GreetingSMessage}");
            Console.WriteLine("Some Method End");
        }

        public static async Task<string> Greetings(string Name)
        {
            string message = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7029/WeatherForecast/");

                HttpResponseMessage response = await client.GetAsync($"api/greetings/{Name}");
                //response.EnsureSuccessStatusCode();
                message = await response.Content.ReadAsStringAsync();
                Console.WriteLine(message);
            }
            return message;
        }

    }
}

//Task  Task<T>
