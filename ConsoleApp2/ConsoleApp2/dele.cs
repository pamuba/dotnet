// using System;

// namespace AppDemo
// {

//     delegate void StrMod(ref string srt);
//     class DelegateTest{
//         public static void ReplaceSpaces(ref String s){
//             Console.WriteLine("Replacing spaces :");
//             s = s.Replace(" ", "-");
//         }
//         public static void RemoveSpaces(ref string s){
//             Console.WriteLine("Removing spaces :");
//             // return s.Remove(' ');
//             s = s.Replace(" ", "");
//         }
//         public static void ReverseString(ref string s){
//             Console.WriteLine("Reversing string :");
//             // return s.Remove(' ');
//             char[] arr = s.ToCharArray();
//             Array.Reverse(arr);
//             s = new string(arr);
//         }
//         public void demo(ref string str){
//             //apples are good  => Apples are good
//              str = str.Replace('a','A');
//         }
//     }

//     class AppDemos{
//         static void Main(){
//             DelegateTest obj = new DelegateTest();
//             string data = "apples are good";
//             obj.demo(ref data);
//             Console.WriteLine(data);
//              //Construct a delegete 
//             //  StrMod strOp = new StrMod(DelegateTest.ReplaceSpaces);
//             //  Console.WriteLine(strOp("Hi how ru"));
//             //  strOp = new StrMod(DelegateTest.RemoveSpaces);
//             //  Console.WriteLine(strOp("Hi how ru"));
//             //  strOp = new StrMod(DelegateTest.ReverseString);
//             //  Console.WriteLine(strOp("Hi how ru"));

//             // StrMod strOp;
//             // string data = "Hello how ru";

//             // strOp = DelegateTest.ReplaceSpaces;
//             // strOp += DelegateTest.RemoveSpaces;
//             // StrMod strOp1 = DelegateTest.ReverseString;
//             // StrMod srtOp3 = strOp + strOp1;
            
//             // // Console.WriteLine(srtOp3.GetInvocationList().Length);
//             // foreach (var del in srtOp3.GetInvocationList())
//             // {
//             //     var f = (StrMod)del;
//             //     f(ref data);
//             // }
//             // Console.WriteLine(data);

//         }
//     }
// }

