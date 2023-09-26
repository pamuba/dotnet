// using System;
// using System.Diagnostics.Contracts;
// namespace demo{

//     delegate void MyEventHandler();//delegate
//     class MyEvent{
//         public event MyEventHandler SomeEvent;

//         //to be called when the event is raised
//         public void OnSomeEvent(){
//             if(SomeEvent != null)//Delegate List created ?
//                 SomeEvent(); 
//             else
//                Console.WriteLine("Delegate List is not created");
//         }
//     }

//     class X {
//         public void XHandler(){
//             Console.WriteLine("Event Received by X");
//         }
//     }
//     class Y {
//         public void YHandler(){
//             Console.WriteLine("Event Received by Y");
//         }
//     }

//     class EventDemo{
//         //event handler
//         static void Handler(){
//             Console.WriteLine("Event Occured");
//         }

//         static void Main(){
//             // MyEvent evt = new MyEvent();

//             // //Add the Handler to the event list
//             // //delegate behind the scenes
//             // evt.SomeEvent += Handler;
//             // evt.SomeEvent += new X().XHandler;
//             // evt.SomeEvent += new Y().YHandler;

//             // //Raise the event 
//             // evt.OnSomeEvent();

//             Print print = delegate(int i){
//                 return $"Inside Anonymous Fucntion: {i}";
//             };

//             Console.WriteLine(print(100));
//         }
//     }
//     public delegate string Print(int v);
    
// }