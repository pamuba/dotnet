// // Passing an argument to the thread method.
// using System;
// using System.Threading;
// class MyThread {
//  public int Count;
//  public Thread Thrd;
//  // Notice that MyThread is also passed an int value.
//  public MyThread(string name, int num) {
//  Count = 0;
//  // Explicitly invoke ParameterizedThreadStart constructor
//  // for the sake of illustration.
//  Thrd = new Thread(this.Run);
//  Thrd.Name = name;
//  // Here, Start() is passed num as an argument.
//  Thrd.Start(num);
//  }
//  // Notice that this version of Run() has
//  // a parameter of type object.
//  void Run(object num) {
//  Console.WriteLine(Thrd.Name + " starting with count of " + num);
//  do {
//  Thread.Sleep(500);
//  Console.WriteLine("In " + Thrd.Name + ", Count is " + Count);
//  Count++;
//  } while(Count < (int) num);
//  Console.WriteLine(Thrd.Name + " terminating.");
//  }
// }
// class PassArgDemo {
//  static void Main() {
//  // Notice that the iteration count is passed
//  // to these two MyThread objects.
//  MyThread mt = new MyThread("Child #1", 5);
//  MyThread mt2 = new MyThread("Child #2", 3);
//  do {
//  Thread.Sleep(100);
//  } while (mt.Thrd.IsAlive | mt2.Thrd.IsAlive);
//  Console.WriteLine("Main thread ending.");
//  }
// }