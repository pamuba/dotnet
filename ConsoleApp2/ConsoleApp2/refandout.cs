// using System;

// namespace ConsoleApp2 // Note: actual namespace depends on the project name.
// {
//     //123.456
//     class RefDemo{
//         public void Sqr(ref int i){
//             i = i * i;
//             Console.WriteLine("Calculated:"+i);
//         }
//     }
//     class Decompose{
//         public int GetIntPart(double n, out double frac){
//             int whole;
//             whole = (int)n;
//             frac = n - whole;
//             return whole;
//         }
//     }
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             // RefDemo demo = new RefDemo();
//             // int i = 10;
//             // Console.WriteLine("i before the call:"+i);
//             // demo.Sqr(ref i);
//             // Console.WriteLine("i after the call:"+i);

//             Decompose dcom = new Decompose();
//             int i;
//             double f;
//             i = dcom.GetIntPart(987.654,out f);
//             Console.WriteLine("Integer Part:"+i);
//             Console.WriteLine("Fractional Part:"+f);
           
//         }
//     }
// }
// //WAP to swap 2 ints using ref