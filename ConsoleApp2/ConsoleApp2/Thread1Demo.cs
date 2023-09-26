using System;
using System.Threading;

class MyThread{
    public int Count;
    string thrdName;

    public MyThread(string name){
        Count = 0;
        thrdName = name;
    }

    //Entry point for the thread
    //containsthe code to be launched as a separate thread
    public void Run(){
        Console.WriteLine(thrdName+" starting");
        do{
            Thread.Sleep(500);
            Console.WriteLine("In "+thrdName+", Count is "+Count);
            Count++;
        }
        while(Count<10);
    }
}

class MultiThread{
    static void Main(){
        Console.WriteLine("Main thread starting");
        
        MyThread mt = new MyThread("Child 1");
        Thread newthrd = new Thread(mt.Run);
        newthrd.Start(); //Main thrd started the child thread

        Console.WriteLine("Main thread Ending");
    }
}