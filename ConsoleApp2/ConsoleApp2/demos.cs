// using System;

// namespace AppDemo
// {

//     class Baseclass{
//         public int j;
//         public Baseclass(int value){
//             j = value;
//         }
//     }
//     class A:Baseclass{
//          public A(int l):base(l){
//             Console.WriteLine("Ctr in A");
//         }
//         virtual public void dis(){
//             Console.WriteLine("In class A");
//         }
//     }
//     class B:A{
//         public B(int k):base(k){
//             Console.WriteLine("Ctr in B");
//         }
//         override public void dis(){
//             Console.WriteLine("In class B: "+this.j);
//             base.dis();
//         }
//     }
//     class AppDemos{
//         static void Main(){
//             B obj = new B(99);//
//             obj.dis();
//         }
//     }
// }