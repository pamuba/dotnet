// using System;
// using System.Threading;

// class MyThread{
//     public int Count;
//     string thrdName;

//     public Thread thrd;
//     public MyThread(string name, int num){
//         Count = 0;
//         thrd = new Thread(this.Run);
//         thrd.Name = name;
//         thrd.Start(num);
//     }

//     //Entry point for the thread
//     //containsthe code to be launched as a separate thread
//     void Run(object num){
//         Console.WriteLine(thrd.Name+" starting");
//         do{
//             Thread.Sleep(500);
//             Console.WriteLine("In "+thrd.Name+", Count is "+Count+" Passed: "+num);
//             Count++;
//         }
//         while(Count<10);
//     }
// }

// class MultiThread{
//     static void Main(){
//         Console.WriteLine("Main thread starting");
//         MyThread mt = new MyThread("Child 1", 5);
//         MyThread mt1 = new MyThread("Child 2", 4);
//         MyThread mt2 = new MyThread("Child 3", 3);


//         mt.thrd.Priority = ThreadPriority.Lowest;
//         mt1.thrd.Priority = ThreadPriority.Lowest;
//         mt2.thrd.Priority = ThreadPriority.Highest;


//         Console.WriteLine(mt.thrd.Priority);
//         Console.WriteLine(mt1.thrd.Priority);
//         Console.WriteLine(mt2.thrd.Priority);

//         mt.thrd.Join();
//         mt1.thrd.Join();
//         mt2.thrd.Join();


//         Console.WriteLine($"Child 1: {mt.thrd.IsAlive.ToString()}");
//         Console.WriteLine($"Child 2: {mt1.thrd.IsAlive.ToString()}");
//         Console.WriteLine($"Child 3: {mt2.thrd.IsAlive.ToString()}");

//         Console.WriteLine(Thread.CurrentThread.Priority);
//         Console.WriteLine("Main thread Ending");
//     }
// }