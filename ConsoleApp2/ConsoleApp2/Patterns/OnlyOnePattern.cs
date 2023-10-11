using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Patterns
{
    internal class OnlyOnePattern
    {

        static void Main() {
            SomeMethod();
            Console.ReadKey();
        }
        //public static async void OnlyOne(){
        //    //Creating the Cancellation Token
        //    var CT = new CancellationTokenSource();

        //    List<string> names = new List<string>() { "John", "Billy", "Sammy", "James"};

        //    await Console.Out.WriteLineAsync("All Names");
        //    foreach (var item in names) {
        //        await Console.Out.WriteLineAsync($"{item}");
        //    }

        //    var tasks = names.Select(x => ProcessingName(x, CT.Token));
        //    var task = await Task.WhenAny(tasks);
        //    //Get the remaining ones after WhenAny
        //    var content = await task;


        //    var task1 = await Task.WhenAny(tasks);

        //    var content1 = await task1;

        //    //Cancel all other tasks
        //    CT.Cancel();

        //    await Console.Out.WriteLineAsync($"\n{content}  {content1}");

        //}

        public static async void SomeMethod() {
            //Calling 2 diff fns using Generic One Pattern

            var content = await GenericOnyOnePattern(
                (ct) => HelloMethod("Jimmy", ct),
                (ct) => GoodbyeMethod("Sammy", ct)
                );
            await Console.Out.WriteLineAsync($"\n{content}");
        }
        public static async Task<T> GenericOnyOnePattern<T>(params Func<CancellationToken, Task<T>>[] functions) {
            var CT = new CancellationTokenSource();
            var tassks = functions.Select(function => function(CT.Token));

            var task = await Task.WhenAny(tassks);
            CT.Cancel();
            return await task;
        }

        public static async Task<string> GoodbyeMethod(string name, CancellationToken token) {
            //return the message after crewating some delay
            //await Task.Delay(TimeSpan.FromSeconds(new Random().NextDouble() * 10 + 10));
            await Task.Delay(1000);
            return $"Goodbye {name}";
        }  
        public static async Task<string> HelloMethod(string name, CancellationToken token) {
            //return the message after crewating some delay
            //await Task.Delay(TimeSpan.FromSeconds(new Random().NextDouble() * 10 + 10));
            await Task.Delay(1000);
            return $"Hello {name}";
        }
    }
}
