class ArraySun{
    int sum;
    public int Sum(int[] nums){
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            Console.WriteLine($"Totla from {Thread.CurrentThread.Name} is {sum}");
            Thread.Sleep(10);
        }
        return sum;
    }
}

class MyThread{
    public int[] a;
    public Thread thrd;
    int result;

    object ob = new object();

    public static ArraySun sumArray = new ArraySun();

    public MyThread(string name, int[] nums){
        thrd = new Thread(this.Run);
        thrd.Name = name;
        a = nums;
        thrd.Start();
    }
    public void Run(){
        bool acquiredLock = false;
        Console.WriteLine(thrd.Name+" starting");

        Monitor.Enter(sumArray, ref acquiredLock);
        result = sumArray.Sum(a);
        if(acquiredLock)
            Monitor.Exit(sumArray);


        Console.WriteLine(thrd.Name+  " terminating");
    }
}

class Sync{
    static void Main(){
        int[] a = {1,2,3,4,5};

        MyThread mt1 = new MyThread("Child 1", a);
        MyThread mt2 = new MyThread("Child 2", a);

        mt1.thrd.Join();
        mt2.thrd.Join();

    }
}

//Pulse, wait
//mutex
//semaphore
//deadlock
//threadpool
//autoresetevents + mutualresetevents
//thread life cycle
//inter thread communication

//Collections
//async
//file handling
//parallel programming
//autoMapper