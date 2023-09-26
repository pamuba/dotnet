// using System;
// namespace Demo{
//     class BaseClass{
//         internal string name;
//         protected string dept;
//         public void getName(){
//             Console.WriteLine("Basse Class Function");
//         }
//         public BaseClass(){
//             name = "name in Base Class";
//         }
//     }
//     class ChildClass:BaseClass{
//         new public void getName(){
//            Console.WriteLine("Child Class Function");
//            base.getName();
//         }
//         public void dis(){
//             // ChildClass ob = new ChildClass();
//             // Console.WriteLine(ob.getName());
//             // Console.WriteLine(ob.name);
//         }
//     }
//     class ObjInitDemo {
    
//         static void Main() {
//           ChildClass ob = new ChildClass();
//           ob.getName();
//         } 
//     }
// }
