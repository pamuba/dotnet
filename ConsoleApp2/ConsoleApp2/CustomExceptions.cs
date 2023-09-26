// using System;
// namespace ExceptionHandlingDemo
// {
//     //Creating our own Exception Class by inheriting Exception class
//     public class OddNumberException : Exception
//     {
//         //Overriding the Message property
//         public override string Message
//         {
//             get
//             {
//                 return "Divisor Cannot be Odd Number";
//             }
//         }

//         //Overriding the HelpLink Property
//         public override string HelpLink
//         {
//             get
//             {
//                 return "Get More Information from here: https://dotnettutorials.net/lesson/create-custom-exception-csharp/";
//             }
//         }
//     }
// }

// namespace ExceptionHandlingDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int Number1, Number2, Result;
//             try
//             {
//                 Console.WriteLine("Enter First Number:");
//                 // Number1 = int.Parse(Console.ReadLine());
//                 Number1 = 44;

//                 Console.WriteLine("Enter Second Number:");
//                 // Number2 = int.Parse(Console.ReadLine());
//                 Number2 = 13;

//                 if (Number2 % 2 > 0)
//                 {
//                     //OddNumberException ONE = new OddNumberException();
//                     //throw ONE;
//                     throw new OddNumberException();
//                 }
//                 Result = Number1 / Number2;
//                 Console.WriteLine(Result);
//             }
//             catch (OddNumberException one)
//             {
//                 Console.WriteLine($"Message: {one.Message}");
//                 Console.WriteLine($"HelpLink: {one.HelpLink}");
//                 Console.WriteLine($"Source: {one.Source}");
//                 Console.WriteLine($"StackTrace: {one.StackTrace}");
//             }

//             Console.WriteLine("End of the Program");
//             // Console.ReadKey();
//         }
//     }
// }

// // using System.Runtime.CompilerServices;

// // class Person{
// //     public Person(string n, bool p)
// //     {
// //         FirstName = n;
// //         NoticePeriod = p;
// //     }

// //     public string FirstName{get; set;}
// //     public bool NoticePeriod{get;set;}

    

// // }

// // class NPException: Exception{
// //     public NPException(string mesg):base(mesg){}
// // }

// // class Demo{
// //     static void Main(){
// //         Person[] people = new Person[3]
// //         {
// //             new Person("John Smith", false),
// //             new Person("Jim Johnson", true),
// //             new Person("Sue Rabon", false),
// //         };

// //         foreach(Person p in people){
// //             if(p.NoticePeriod == true){
// //                 try{
// //                     throw new NPException("Employee in NP cant take conssecutive leaves");
// //                 }
// //                 catch(Exception e){
// //                     Console.WriteLine(e.Message);
// //                 }
            

// //             }
// //         }
// //     }
// // }