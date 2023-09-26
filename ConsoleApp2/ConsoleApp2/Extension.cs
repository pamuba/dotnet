// namespace DefineIMyInterface
// {
//     public interface IMyInterface
//     {
//         void MethodB();
//     }
// }

// // Define extension methods for IMyInterface.
// namespace Extensions
// {
//     using System;
//     using DefineIMyInterface;

// //     // The following extension methods can be accessed by instances of any
// //     // class that implements IMyInterface.
//     public static class Extension
//     {
//         public static void MethodA(this IMyInterface myInterface, int i)
//         {
//             Console.WriteLine
//                 ("Extension.MethodA(this IMyInterface myInterface, int i)");
//         }

//         public static void MethodA(this IMyInterface myInterface, string s)
//         {
//             Console.WriteLine
//                 ("Extension.MethodA(this IMyInterface myInterface, string s)");
//         }
//         public static void MethodB(this IMyInterface myInterface)
//         {
//             Console.WriteLine
//                 ("Extension.MethodB(this IMyInterface myInterface)");
//         }
//     }
// }

// namespace ExtensionMethodsDemo1
// {
//     using System;
//     using Extensions;
//     using DefineIMyInterface;

//     class A : IMyInterface
//     {
//         public void MethodB() { Console.WriteLine("A.MethodB()"); }
//     }

//     class B : IMyInterface
//     {
//         public void MethodB() { Console.WriteLine("B.MethodB()"); }
//         public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
//     }

//     class C : IMyInterface
//     {
//         public void MethodB() { Console.WriteLine("C.MethodB()"); }
//         public void MethodA(object obj)
//         {
//             Console.WriteLine("C.MethodA(object obj)");
//         }
//     }


//     class ExtMethodDemo
//     {
//         static void Main(string[] args)
//         {
//             // Declare an instance of class A, class B, and class C.
//             A a = new A();
//             B b = new B();
//             C c = new C();

//             // For a, b, and c, call the following methods:
//             //      -- MethodA with an int argument
//             //      -- MethodA with a string argument
//             //      -- MethodB with no argument.

//             // A contains no MethodA, so each call to MethodA resolves to
//             // the extension method that has a matching signature.
//             a.MethodA(1);           // Extension.MethodA(IMyInterface, int)
//             a.MethodA("hello");     // Extension.MethodA(IMyInterface, string)

//             // A has a method that matches the signature of the following call
//             // to MethodB.
//             a.MethodB();            // A.MethodB()

//             // B has methods that match the signatures of the following
//             // method calls.
//             b.MethodA(1);           // B.MethodA(int)
//             b.MethodB();            // B.MethodB()

//             // B has no matching method for the following call, but
//             // class Extension does.
//             b.MethodA("hello");     // Extension.MethodA(IMyInterface, string)

//             // C contains an instance method that matches each of the following
//             // method calls.
//             c.MethodA(1);           // C.MethodA(object)
//             c.MethodA("hello");     // C.MethodA(object)
//             c.MethodB();            // C.MethodB()
//         }
//     }
// }
/* Output:
    Extension.MethodA(this IMyInterface myInterface, int i)
    Extension.MethodA(this IMyInterface myInterface, string s)
    A.MethodB()
    B.MethodA(int i)
    B.MethodB()
    Extension.MethodA(this IMyInterface myInterface, string s)
    C.MethodA(object obj)
    C.MethodA(object obj)
    C.MethodB()
 */


// A simple generic class.
// using System;
// // In the following Gen class, T is a type parameter
// // that will be replaced by a real type when an object
// // of type Gen is created.
// class Gen<T> {
//  T ob; // declare a variable of type T
//  // Notice that this constructor has a parameter of type T.
//  public Gen(T o) {
//  ob = o;
//  }
//  // Return ob, which is of type T.
//  public T GetOb() {
//  return ob;
//  }
//  // Show type of T.
//  public void ShowType() {
//  Console.WriteLine("Type of T is " + typeof(T));
//  }
// }
// // Demonstrate the generic class.
// class GenericsDemo {
//  static void Main() {
//  // Create a Gen reference for int.
//  Gen<int> iOb;
//  // Create a Gen<int> object and assign its reference to iOb.
//  iOb = new Gen<int>(102);
//  // Show the type of data used by iOb.
//  iOb.ShowType();
//  // Get the value in iOb.
//  int v = iOb.GetOb();
//  Console.WriteLine("value: " + v);
//  Console.WriteLine();
//  // Create a Gen object for strings.
//  Gen<string> strOb = new Gen<string>("Generics add power.");
//  // Show the type of data stored in strOb.
//  strOb.ShowType();
//  // Get the value in strOb.
//  string str = strOb.GetOb();
//  Console.WriteLine("value: " + str);
//  }
// }