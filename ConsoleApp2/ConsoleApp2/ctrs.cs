// using System;
// using System.Reflection.Metadata;

// namespace ConsoleApp2 // Note: actual namespace depends on the project name.
// {
    
//     internal class Program
//     {
//         int  num = 10;
//         static void Main(string[] args)
//         {
//            Program st1 = new Program();
//            Program st2 = new Program();
//            bool b = st1.Equals(st2);//true
//            Console.WriteLine(b);
//         }
//     }
//     class A{
//         public int a;
//         public A(int i){
//             a = i;
//         }
//     }
//     class B:A{
//         public int b;
//         public B(int i,int j):base(i){
//             b = j;
//         }
//     }
//     class C:B{
//         public int c;
//         public C(int i, int j,int k):base(i,j){
//             c = k;
//         }
//         public void dis(){
//             Console.WriteLine(this.a+" "+this.b+" "+this.c);
//         }
//     }
// }
