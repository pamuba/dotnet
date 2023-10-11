using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TaskContinueWith
    {

        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() =>
            {
                return 10;
            });

            task.ContinueWith((i) =>
            {
                Console.WriteLine("TasK Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            task.ContinueWith((i) =>
            {
                Console.WriteLine("Task Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);


            var completedTask = task.ContinueWith((i) =>
            {
                Console.WriteLine($"Task Completed {i.Result}");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();

            Console.ReadKey();


            //Task<string> task1 = Task.Run(() =>
            //{
            //    return 12;
            //}).ContinueWith((val) =>
            //{
            //    return $"{val.Result*val.Result}";
            //});

            //Console.WriteLine(task1.Result);
            //await Console.Out.WriteLineAsync();
        }
    }
}

