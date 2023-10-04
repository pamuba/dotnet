using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class webapidemo
    {
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

                HttpResponseMessage response = await client.GetAsync($"api/greetings2/{Name}");
                response.EnsureSuccessStatusCode();
                //message = await response.Content.ReadAsStringAsync();
                Console.WriteLine(message);
            }
            return message;
        }
    }
}
