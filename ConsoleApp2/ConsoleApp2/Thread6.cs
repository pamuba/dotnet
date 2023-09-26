// // Demonstrate thread priorities.
// using System;
// using System.Threading;
// class MyThread {
//  public int Count;
//  public Thread Thrd;
//  static bool stop = false;
//  static string currentName;
//  /* Construct a new thread. Notice that this
//  constructor does not actually start the
//  threads running. */
//  public MyThread(string name) {
//  Count = 0;
//  Thrd = new Thread(this.Run);
//  Thrd.Name = name;
//  currentName = name;
//  }
//  // Begin execution of new thread.
//  void Run() {
//  Console.WriteLine(Thrd.Name + " starting.");
//  do {
//  Count++;
//  if(currentName != Thrd.Name) {
//  currentName = Thrd.Name;
//  Console.WriteLine("In " + currentName);
//  }
//  } while(stop == false && Count < 1000000000);
//  stop = true;
//  Console.WriteLine(Thrd.Name + " terminating.");
//  }
// }
// class PriorityDemo {
//  static void Main() {
//  MyThread mt1 = new MyThread("High Priority");
//  MyThread mt2 = new MyThread("Low Priority");
//  // Set the priorities.
//  mt1.Thrd.Priority = ThreadPriority.AboveNormal;
//  mt2.Thrd.Priority = ThreadPriority.BelowNormal;
//  // Start the threads.
//  mt1.Thrd.Start();
//  mt2.Thrd.Start();
//  mt1.Thrd.Join();
//  mt2.Thrd.Join();
//  Console.WriteLine();
//  Console.WriteLine(mt1.Thrd.Name + " thread counted to " +
//  mt1.Count);
//  Console.WriteLine(mt2.Thrd.Name + " thread counted to " +
//  mt2.Count);
//  }
// }