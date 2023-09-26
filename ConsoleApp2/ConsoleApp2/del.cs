// // // public delegate void MyDelegate(string msg);

// // // class Program
// // // {
// // //     static void Main(string[] args)
// // //     {
// // //         MyDelegate del = ClassA.MethodA;
// // //         del("Hello World");

// // //         del = ClassB.MethodB;
// // //         del("Hello World");

// // //         del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
// // //         del("Hello World");


// // //         MyDelegate d1 = ClassA.MethodA;
// // //         MyDelegate d2 = ClassB.MethodB;
// // //         MyDelegate multicastDelegate = (MyDelegate)Delegate.Combine(d1, d2);
// // //         multicastDelegate.Invoke("How ru");
// // //     }
// // // }

// // // class ClassA
// // // {
// // //     public static void MethodA(string message)
// // //     {
// // //         Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
// // //     }
// // // }

// // // class ClassB
// // // {
// // //     public static void MethodB(string message)
// // //     {
// // //         Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
// // //     }
// // // }

// // ////////////////////////////////////////////////////////////////////////////
// // ///
// // // Declare a delegate
// // // delegate void MultiplyCallback(int i, double j);

// // // class MathClass
// // // {
// // //     static void Main()
// // //     {
// // //         MathClass m = new MathClass();

// // //         // Delegate instantiation using "MultiplyNumbers"
// // //         MultiplyCallback d = m.MultiplyNumbers;

// // //         // Invoke the delegate object.
// // //         Console.WriteLine("Invoking the delegate using 'MultiplyNumbers':");
// // //         for (int i = 1; i <= 5; i++)
// // //         {
// // //             d(i, 2);
// // //         }

// // //         // Keep the console window open in debug mode.
// // //         Console.WriteLine("Press any key to exit.");
// // //     }

// // //     // Declare the associated method.
// // //     void MultiplyNumbers(int m, double n)
// // //     {
// // //         Console.Write(m * n + " ");
// // //     }
// // // }
// // // /* Output:
// // //     Invoking the delegate using 'MultiplyNumbers':
// // //     2 4 6 8 10
// // // */

// // // Declare a delegate
// // delegate void Callback();

// // class SampleClass
// // {
// //     public void InstanceMethod()
// //     {
// //         Console.WriteLine("A message from the instance method.");
// //     }

// //     static public void StaticMethod()
// //     {
// //         Console.WriteLine("A message from the static method.");
// //     }
// // }

// // class TestSampleClass
// // {
// //     static void Main()
// //     {
// //         var sc = new SampleClass();

// //         // Map the delegate to the instance method:
// //         Callback d = sc.InstanceMethod;
// //         d();

// //         // Map to the static method:
// //         d = SampleClass.StaticMethod;
// //         d();
// //     }
// // }
// // /* Output:
// //     A message from the instance method.
// //     A message from the static method.
// // */


// using System;

// // Define a custom delegate that has a string parameter and returns void.
// delegate void CustomCallback(string s);

// class TestClass
// {
//     // Define two methods that have the same signature as CustomCallback.
//     static void Hello(string s)
//     {
//         Console.WriteLine($"  Hello, {s}!");
//     }

//     static void Goodbye(string s)
//     {
//         Console.WriteLine($"  Goodbye, {s}!");
//     }

//     static void Main()
//     {
//         // Declare instances of the custom delegate.
//         CustomCallback hiDel, byeDel, multiDel, multiMinusHiDel;

//         // In this example, you can omit the custom delegate if you
//         // want to and use Action<string> instead.
//         //Action<string> hiDel, byeDel, multiDel, multiMinusHiDel;

//         // Initialize the delegate object hiDel that references the
//         // method Hello.
//         hiDel = Hello;

//         // Initialize the delegate object byeDel that references the
//         // method Goodbye.
//         byeDel = Goodbye;

//         // The two delegates, hiDel and byeDel, are combined to
//         // form multiDel.
//         multiDel = hiDel + byeDel;

//         // Remove hiDel from the multicast delegate, leaving byeDel,
//         // which calls only the method Goodbye.
//         multiMinusHiDel = multiDel - hiDel;

//         Console.WriteLine("Invoking delegate hiDel:");
//         hiDel("A");
//         Console.WriteLine("Invoking delegate byeDel:");
//         byeDel("B");
//         Console.WriteLine("Invoking delegate multiDel:");
//         multiDel("C");
//         Console.WriteLine("Invoking delegate multiMinusHiDel:");
//         multiMinusHiDel("D");
//     }
// }
// /* Output:
// Invoking delegate hiDel:
//   Hello, A!
// Invoking delegate byeDel:
//   Goodbye, B!
// Invoking delegate multiDel:
//   Hello, C!
//   Goodbye, C!
// Invoking delegate multiMinusHiDel:
//   Goodbye, D!
// */
