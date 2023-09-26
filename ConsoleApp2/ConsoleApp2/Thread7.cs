// using System;
// using System.Threading;
// class SumArray {
//  int sum;
//  object lockOn = new object(); // a private object to lock on
//  public int SumIt(int[] nums) {
//  lock(lockOn) { // lock the entire method
//  sum = 0; // reset sum
//  for(int i=0; i < nums.Length; i++) {
//  sum += nums[i];
//  Console.WriteLine("Running total for " +  Thread.CurrentThread.Name +  " is " + sum);
//  Thread.Sleep(10); // allow task-switch
//  }
//  return sum;
//  }
//  }
// }
// class MyThread {
//  public Thread Thrd;
//  int[] a;
//  int answer;
//  // Create one SumArray object for all instances of MyThread.
//  static SumArray sa = new SumArray();
//  // Construct a new thread.
//  public MyThread(string name, int[] nums) {
//  a = nums;
//  Thrd = new Thread(this.Run);
//  Thrd.Name = name;
//  Thrd.Start(); // start the thread
//  Console.WriteLine(Thread.CurrentThread.ThreadState);
//  }
//  // Begin execution of new thread.
//  void Run() {
//  Console.WriteLine(Thrd.Name + " starting.");
//  answer = sa.SumIt(a);
//  Console.WriteLine("Sum for " + Thrd.Name +
//  " is " + answer);
//  Console.WriteLine(Thrd.Name + " terminating.");
//  }
// }
// class Sync {
//  static void Main() {
//  int[] a = {1, 2, 3, 4, 5};
//  MyThread mt1 = new MyThread("Child #1", a);
//  MyThread mt2 = new MyThread("Child #2", a);
//  mt1.Thrd.Join();
//  mt2.Thrd.Join();
//  }
// }