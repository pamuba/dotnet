// using System;
// using System.Reflection.Metadata;

// namespace ConsoleApp2 // Note: actual namespace depends on the project name.
// {
//     class Mn{
//         //variable list args OR array containing variable args
//         public int MinVal(params int[] nums){
//             int m;
//             if(nums.Length == 0){
//                 Console.WriteLine("Error: No Arguments");
//             }
//             m = nums[0];
//             for (int i = 0; i < nums.Length; i++)
//             {
//                 if(nums[i] < m) m = nums[i];
//             }
//             return m;
//         }
//     }
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//            Mn ob = new Mn();
//            int min;
//            int a = 20, b = 30;

//            min = ob.MinVal(a,b);
//            Console.WriteLine(min);

//            min = ob.MinVal(a,b, -1);
//            Console.WriteLine(min);

//            min = ob.MinVal(a,b,12,3,4,5,6);
//            Console.WriteLine(min);

//            int[] vals = {11,22,33,44,55};
//            min = ob.MinVal(vals);
//            Console.WriteLine(min);

//            int[] vals1 = {44,55};
//            min = ob.MinVal(vals1);
//            Console.WriteLine(min);

           
//         }
//     }
// }
