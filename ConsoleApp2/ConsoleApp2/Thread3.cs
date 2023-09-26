// // Create a thread of execution.
// using System;
// using System.Threading;
// class MyThread {
//  public int Count;
//  string thrdName;

//  public MyThread(string name) {
//  Count = 0;
//  thrdName = name;
//  }

//  // Entry point of thread.
//  public void Run() {
//  Console.WriteLine(thrdName + " starting.");
//  do {
//  Thread.Sleep(500);
//  Console.WriteLine("In " + thrdName + ", Count is " + Count);
//  Count++;
//  } while(Count < 10);
//  Console.WriteLine(thrdName + " terminating.");
//  }
// }
// class MultiThread {
//  static void Main() {
//  Console.WriteLine("Main thread starting.");
//  // First, construct a MyThread object.
//  MyThread mt = new MyThread("Child #1");
//  // Next, construct a thread from that object.
//  Thread newThrd = new Thread(mt.Run);
//  // Finally, start execution of the thread.
//  newThrd.Start();
//  do {
//  Console.Write(".");
//  Thread.Sleep(100);
//  } while (mt.Count != 10);
//  Console.WriteLine("Main thread ending.");
//  }
// }
