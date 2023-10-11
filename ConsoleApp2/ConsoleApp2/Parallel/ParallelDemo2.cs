using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo
{
    class ParallelDemo2
    {
        //static void Main()
        //{
        //    DateTime StartDateTime = DateTime.Now;
        //    Stopwatch stopWatch = new Stopwatch();

        //    Console.WriteLine("For Loop Execution start");
        //    stopWatch.Start();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        long total = DoSomeIndependentTask();
        //        Console.WriteLine("{0} - {1}", i, total);
        //    }
        //    DateTime EndDateTime = DateTime.Now;
        //    Console.WriteLine("For Loop Execution end ");
        //    stopWatch.Stop();
        //    Console.WriteLine($"Time Taken to Execute the For Loop in miliseconds {stopWatch.ElapsedMilliseconds}");

        //    Console.ReadLine();
        //}

        //static long DoSomeIndependentTask()
        //{
        //    //Do Some Time Consuming Task here
        //    //Most Probably some calculation or DB related activity
        //    long total = 0;
        //    for (int i = 1; i < 100000000; i++)
        //    {
        //        total += i;
        //    }
        //    return total;
        //}


        //static void Main()
        //{
        //    DateTime StartDateTime = DateTime.Now;
        //    Stopwatch stopWatch = new Stopwatch();
        //    Console.WriteLine("Parallel For Loop Execution start");
        //    stopWatch.Start();

        //    Parallel.For(0, 10, i =>
        //    {
        //        long total = DoSomeIndependentTask();
        //        Console.WriteLine("{0} - {1}", i, total);
        //    });
        //    DateTime EndDateTime = DateTime.Now;
        //    Console.WriteLine("Parallel For Loop Execution end ");
        //    stopWatch.Stop();
        //    Console.WriteLine($"Time Taken to Execute Parallel For Loop in miliseconds {stopWatch.ElapsedMilliseconds}");

        //    Console.ReadLine();
        //}
        //static long DoSomeIndependentTask()
        //{
        //    //Do Some Time Consuming Task here
        //    //Most Probably some calculation or DB related activity
        //    long total = 0;
        //    for (int i = 1; i < 100000000; i++)
        //    {
        //        total += i;
        //    }
        //    return total;
        //}





        //static void Main(string[] args)
        //{
        //    //Limiting the maximum degree of parallelism to 2
        //    var options = new ParallelOptions()
        //    {
        //        MaxDegreeOfParallelism = 3,
        //    };
        //    int n = 10;
        //    Parallel.For(0, n, options,  i =>
        //    {
        //        Console.WriteLine(@"value of i = {0}, thread = {1}  Degree:{2}",
        //        i, Thread.CurrentThread.ManagedThreadId, options.MaxDegreeOfParallelism);
        //        Thread.Sleep(10);
        //    });

        //    Console.WriteLine("Press any key to exist");
        //    Console.ReadLine();
        //}



        //static void Main()
        //{
        //    var BreakSource = Enumerable.Range(0, 1000).ToList();
        //    int BreakData = 0;
        //    Console.WriteLine("Using loopstate Break Method");
        //    Parallel.For(0, BreakSource.Count, (i, BreakLoopState) =>
        //    {
        //        BreakData += i;
        //        if (BreakData > 100)
        //        {
        //            BreakLoopState.Break();
        //            Console.WriteLine("Break called iteration {0}. data = {1} ", i, BreakData);
        //        }
        //    });
        //    Console.WriteLine("Break called data = {0} ", BreakData);
        //    //////////////////////////////////////////////////////////////////////////
        //    var StopSource = Enumerable.Range(0, 1000).ToList();
        //    int StopData = 0;
        //    Console.WriteLine("Using loopstate Stop Method");
        //    Parallel.For(0, StopSource.Count, (i, StopLoopState) =>
        //    {
        //        StopData += i;
        //        if (StopData > 100)
        //        {
        //            StopLoopState.Stop();
        //            Console.WriteLine("Stop called iteration {0}. data = {1} ", i, StopData);
        //        }
        //    });

        //    Console.WriteLine("Stop called data = {0} ", StopData);
        //    Console.ReadKey();
        //}

        //static void Main() { 
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();

        //    List<int> integerList = Enumerable.Range(0, 10).ToList();
        //    var options = new ParallelOptions() { MaxDegreeOfParallelism = 2};
        //    Parallel.ForEach(integerList, i => { 

        //        long total = DoSomeIndependentTask();
        //        Console.WriteLine(i+" "+ total);
        //    });
        //    stopwatch.Stop();
        //    Console.WriteLine($"{stopwatch.ElapsedMilliseconds}");
        //}
        //static long DoSomeIndependentTask()
        //{
        //    //Do Some Time Consuming Task here
        //    //Most Probably some calculation or DB related activity
        //    long total = 0;
        //    for (int i = 1; i < 100000000; i++)
        //    {
        //        total += i;
        //    }
        //    return total;
        //}


        //static void Main()
        //{
        //    Stopwatch stopWatch = new Stopwatch();

        //    stopWatch.Start();
        //    //Calling Three methods sequentially
        //    Method1();
        //    Method2();
        //    Method3();
        //    stopWatch.Stop();

        //    Console.WriteLine($"Sequential Execution Took {stopWatch.ElapsedMilliseconds} Milliseconds");
        //    Console.ReadKey();
        //}
        //static void Method1()
        //{
        //    Thread.Sleep(200);
        //    Console.WriteLine($"Method 1 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
        //}
        //static void Method2()
        //{
        //    Thread.Sleep(200);
        //    Console.WriteLine($"Method 2 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
        //}
        //static void Method3()
        //{
        //    Thread.Sleep(200);
        //    Console.WriteLine($"Method 3 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
        //}


        //static void Main()
        //{
        //    Stopwatch stopWatch = new Stopwatch();
        //    stopWatch.Start();
        //    //Calling Three methods Parallely
        //    Parallel.Invoke(
        //         Method1, Method2, Method3
        //    );
        //    stopWatch.Stop();
        //    Console.WriteLine($"Parallel Execution Took {stopWatch.ElapsedMilliseconds} Milliseconds");
        //    Console.ReadKey();
        //}
        //static void Method1()
        //{
        //    Thread.Sleep(200);
        //    Console.WriteLine($"Method 1 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
        //}
        //static void Method2()
        //{
        //    Thread.Sleep(200);
        //    Console.WriteLine($"Method 2 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
        //}
        //static void Method3()
        //{
        //    Thread.Sleep(200);
        //    Console.WriteLine($"Method 3 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
        //}


        //static void Main()
        //{
        //    Parallel.Invoke(
        //         NormalAction, // Invoking Normal Method
        //         delegate ()   // Invoking an inline delegate 
        //         {
        //             Console.WriteLine($"Method 2, Thread={Thread.CurrentThread.ManagedThreadId}");
        //         },
        //        () =>   // Invoking a lambda expression
        //        {
        //            Console.WriteLine($"Method 3, Thread={Thread.CurrentThread.ManagedThreadId}");
        //        }
        //    );
        //    Console.WriteLine("Press any key to exist.");
        //    Console.ReadKey();
        //}
        static void NormalAction()
        {
            Console.WriteLine($"Method 1, Thread={Thread.CurrentThread.ManagedThreadId}");
        }

        //static void Main() {
        //    Parallel.For(1, 11, (number) =>
        //    {
        //        Console.WriteLine(number);
        //    });
        //    Console.ReadLine();
        //}

        //static void Main() {
        //    Stopwatch watch = new Stopwatch();
        //    var cts = new CancellationTokenSource();
        //    cts.CancelAfter(TimeSpan.FromSeconds(3));

        //    int i1=0, i2=0, i3=0, i4=0, i5=0, i6=0;
        //    ParallelOptions options = new ParallelOptions() { 
        //        MaxDegreeOfParallelism = 1,
        //        CancellationToken = cts.Token
        //    };
        //    try
        //    {

        //        watch.Start();
        //        Parallel.Invoke(
        //            options,
        //            () => i1 = DoSomeTask(1),
        //            () => i2 = DoSomeTask(2),
        //            () => i3 = DoSomeTask(3),
        //            () => i4 = DoSomeTask(4),
        //            () => i5 = DoSomeTask(5),
        //            () => i6 = DoSomeTask(6)
        //        );
        //        watch.Stop();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally {
        //        cts.Dispose();
        //        cts = null;
        //        Console.WriteLine($"Time Elapsed:{watch.ElapsedMilliseconds} milliseconds");
        //        Console.WriteLine(i1 + " " + i2 + " " + i3);
        //    }


        //}
        //static int DoSomeTask(int number) {
        //    Console.WriteLine($"DoSomeTask {number} srated by thred {Thread.CurrentThread.ManagedThreadId}");
        //    Thread.Sleep(1000);
        //    Console.WriteLine($"DoSomeTask {number} completed by thred {Thread.CurrentThread.ManagedThreadId}");
        //    return 100;
        //}

        //static void Main()
        //{
        //    Stopwatch watch = new Stopwatch();
        //    var cts = new CancellationTokenSource();
        //    cts.CancelAfter(TimeSpan.FromSeconds(2));

        //    ParallelOptions options = new ParallelOptions()
        //    {
        //        MaxDegreeOfParallelism = 1,
        //        CancellationToken = cts.Token
        //    };

        //    try
        //    {
        //        watch.Start();
        //        List<int> ints = Enumerable.Range(0, 20).ToList();
        //        Parallel.ForEach(ints, options, x =>
        //        {
        //            Thread.Sleep(1000);
        //            Console.WriteLine($"Value of i: {x}, thread: {Thread.CurrentThread.ManagedThreadId}");
        //        });

        //    }
        //    catch (Exception ex) { watch.Stop(); }
        //    finally
        //    {
        //        cts.Dispose();
        //        cts = null;
        //        Console.WriteLine($"Time Elapsed:{watch.ElapsedMilliseconds} milliseconds");
        //    }

        //}
        static object ob = new object();
        static void Main() {

            //var val = 0;
            //Parallel.For(0, 100000, _ =>
            //{
            //    //Interlocked.Increment(ref val);
            //    lock (ob) { 
            //    val++; }
            //});
            //Console.WriteLine(100000);
            //Console.WriteLine(val);

            Stopwatch w = new Stopwatch();
         
            var numbers = Enumerable.Range(1,2000);

            var evens = numbers.AsParallel().Where(x => x % 2 == 0).WithDegreeOfParallelism(3).ToList();
            w.Start();
            foreach (var n in evens) { 
            Console.WriteLine(n); }
            w.Stop();
            Console.WriteLine("Time :"+w.ElapsedMilliseconds);

        }

            
        }
}