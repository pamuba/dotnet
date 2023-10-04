// class ArraySun{
//     int sum;
//     public int Sum(int[] nums){
//         for (int i = 0; i < nums.Length; i++)
//         {
//             sum += nums[i];
//             Console.WriteLine($"Totla from {Thread.CurrentThread.Name} is {sum}");
//             Thread.Sleep(10);
//         }
//         return sum;
//     }
// }

// class MyThread{
//     public int[] a;
//     public Thread thrd;
//     int result;

//     object ob = new object();

//     public static ArraySun sumArray = new ArraySun();

//     public MyThread(string name, int[] nums){
//         thrd = new Thread(this.Run);
//         thrd.Name = name;
//         a = nums;
//         thrd.Start();
//     }
//     public void Run(){
//         Console.WriteLine(thrd.Name+" starting");
//         lock(sumArray) result = sumArray.Sum(a);
//         Console.WriteLine(thrd.Name+  " terminating");
//     }
// }

// class Sync{
//     static void Main(){
//         int[] a = {1,2,3,4,5};

//         MyThread mt1 = new MyThread("Child 1", a);
//         MyThread mt2 = new MyThread("Child 2", a);

//         mt1.thrd.Join();
//         mt2.thrd.Join();

//     }
// }



using System;
using System.Threading;
using System.Security.AccessControl;

internal class Example
{
    internal static void Main()
    {
        const string mutexName = "MutexExample4";

        Mutex m = null;
        bool doesNotExist = false;
        bool unauthorized = false;

        // The value of this variable is set by the mutex
        // constructor. It is true if the named system mutex was
        // created, and false if the named mutex already existed.
        //
        bool mutexWasCreated = false;

        // Attempt to open the named mutex.
        try
        {
            // Open the mutex with (MutexRights.Synchronize |
            // MutexRights.Modify), to enter and release the
            // named mutex.
            //
            m = Mutex.OpenExisting(mutexName);
        }
        catch(WaitHandleCannotBeOpenedException)
        {
            Console.WriteLine("Mutex does not exist.");
            doesNotExist = true;
        }
        catch(UnauthorizedAccessException ex)
        {
            Console.WriteLine("Unauthorized access: {0}", ex.Message);
            unauthorized = true;
        }

        // There are three cases: (1) The mutex does not exist.
        // (2) The mutex exists, but the current user doesn't 
        // have access. (3) The mutex exists and the user has
        // access.
        //
        if (doesNotExist)
        {
            // The mutex does not exist, so create it.

            // Create an access control list (ACL) that denies the
            // current user the right to enter or release the 
            // mutex, but allows the right to read and change
            // security information for the mutex.
            //
            string user = Environment.UserDomainName + "\\"
                + Environment.UserName;
            var mSec = new MutexSecurity();

            MutexAccessRule rule = new MutexAccessRule(user, 
                MutexRights.Synchronize | MutexRights.Modify, 
                AccessControlType.Deny);
            mSec.AddAccessRule(rule);

            rule = new MutexAccessRule(user, 
                MutexRights.ReadPermissions | MutexRights.ChangePermissions,
                AccessControlType.Allow);
            mSec.AddAccessRule(rule);

            // Create a Mutex object that represents the system
            // mutex named by the constant 'mutexName', with
            // initial ownership for this thread, and with the
            // specified security access. The Boolean value that 
            // indicates creation of the underlying system object
            // is placed in mutexWasCreated.
            //
            m = new Mutex(true, mutexName, out mutexWasCreated, mSec);

            // If the named system mutex was created, it can be
            // used by the current instance of this program, even 
            // though the current user is denied access. The current
            // program owns the mutex. Otherwise, exit the program.
            // 
            if (mutexWasCreated)
            {
                Console.WriteLine("Created the mutex.");
            }
            else
            {
                Console.WriteLine("Unable to create the mutex.");
                return;
            }
        }
        else if (unauthorized)
        {
            // Open the mutex to read and change the access control
            // security. The access control security defined above
            // allows the current user to do this.
            //
            try
            {
                m = Mutex.OpenExisting(mutexName, 
                    MutexRights.ReadPermissions | MutexRights.ChangePermissions);

                // Get the current ACL. This requires 
                // MutexRights.ReadPermissions.
                MutexSecurity mSec = m.GetAccessControl();
                
                string user = Environment.UserDomainName + "\\"
                    + Environment.UserName;

                // First, the rule that denied the current user 
                // the right to enter and release the mutex must
                // be removed.
                MutexAccessRule rule = new MutexAccessRule(user, 
                     MutexRights.Synchronize | MutexRights.Modify,
                     AccessControlType.Deny);
                mSec.RemoveAccessRule(rule);

                // Now grant the user the correct rights.
                // 
                rule = new MutexAccessRule(user, 
                    MutexRights.Synchronize | MutexRights.Modify,
                    AccessControlType.Allow);
                mSec.AddAccessRule(rule);

                // Update the ACL. This requires
                // MutexRights.ChangePermissions.
                m.SetAccessControl(mSec);

                Console.WriteLine("Updated mutex security.");

                // Open the mutex with (MutexRights.Synchronize 
                // | MutexRights.Modify), the rights required to
                // enter and release the mutex.
                //
                m = Mutex.OpenExisting(mutexName);
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine("Unable to change permissions: {0}",
                    ex.Message);
                return;
            }
        }

        // If this program created the mutex, it already owns
        // the mutex.
        //
        if (!mutexWasCreated)
        {
            // Enter the mutex, and hold it until the program
            // exits.
            //
            try
            {
                Console.WriteLine("Wait for the mutex.");
                m.WaitOne();
                Console.WriteLine("Entered the mutex.");
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine("Unauthorized access: {0}", ex.Message);
            }
        }

        Console.WriteLine("Press the Enter key to exit.");
        Console.ReadLine();
        m.ReleaseMutex();
        m.Dispose();
    }
}