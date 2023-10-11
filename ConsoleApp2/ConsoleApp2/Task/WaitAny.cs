//using System;
//using System.Threading;
//using System.Threading.Tasks;

//public class WaitAnyDemo
//{
//    public static void Main()
//    {
//        // Wait on a single task with a timeout specified.
//        Task taskA = Task.Run(() => Thread.Sleep(2000));
//        try
//        {
//            taskA.Wait(1000);       // Wait for 1 second.
//            bool completed = taskA.IsCompleted;
//            Console.WriteLine("Task A completed: {0}, Status: {1}",
//                             completed, taskA.Status);
//            if (!completed)
//                Console.WriteLine("Timed out before task A completed.");
//        }
//        catch (AggregateException)
//        {
//            Console.WriteLine("Exception in taskA.");
//        }
//    }
//}
//// The example displays output like the following:
////     Task A completed: False, Status: Running
////     Timed out before task A completed.
///



using System;
using System.Threading;
using System.Threading.Tasks;

public class WaitAnyDemo
{
    public static void Main()
    {
        var tasks = new Task[3];
        var rnd = new Random();
        for (int ctr = 0; ctr <= 2; ctr++)
            tasks[ctr] = Task.Run(() => Thread.Sleep(rnd.Next(500, 3000)));

        try
        {
            int index = Task.WaitAny(tasks);
            Console.WriteLine("Task #{0} completed first.\n", tasks[index].Id);
            Console.WriteLine("Status of all tasks:");
            foreach (var t in tasks)
                Console.WriteLine("   Task #{0}: {1}", t.Id, t.Status);
        }
        catch (AggregateException)
        {
            Console.WriteLine("An exception occurred.");
        }
    }
}
// The example displays output like the following:
//     Task #1 completed first.
//     
//     Status of all tasks:
//        Task #3: Running
//        Task #1: RanToCompletion
//        Task #4: Running