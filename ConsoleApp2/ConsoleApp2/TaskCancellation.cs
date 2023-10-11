using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TaskCancellation
    {
        static void Main(string[] args) {
            SomeMethod();
            Console.ReadLine();
        }

        private static async void SomeMethod() {
            int count = 10;
            Console.WriteLine("SomeMethod Started");
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(5));
            try
            {

                await LongRunningTask(count, cancellationTokenSource.Token);
            }
            catch (TaskCanceledException ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);

            }
        }
        public static async Task LongRunningTask(int count, CancellationToken token) {
            for (int i = 0; i < count; i++)
            {
                await Task.Delay(1000);
                await Console.Out.WriteLineAsync("LongRunningTask Processing.....");
                if (token.IsCancellationRequested) { 
                   throw new TaskCanceledException();
                }
            }
        }
    }
}
