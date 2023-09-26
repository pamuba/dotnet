// using System;
// using System.Reflection.Metadata;

// namespace ConsoleApp2 // Note: actual namespace depends on the project name.
// {
    
//     internal class Program
//     {
//         public record Employee{
//             public string FirstName {get; set;}
//             public string SecondName {get; set;}
//             public int EmpID {get; set;}
//         }
//         //exit code
//         static void Main(string[] args)
//         {
//             // var person = new Person("Ivan", "Petrov", 30 );
//             // //person.age = 33;
//             // Console.WriteLine(person);

//             // var person2 = person with{
//             //     FirstName = "John",
//             //     age = 66
//             // };
//             // Console.WriteLine(person2);

//             // var person1 = new Person("Ivan", "Petrov", 30 );
//             // Console.WriteLine(person==person1);

//             var emp = new Employee{
//                 FirstName = "Sam",
//                 SecondName = "Smith",
//                 EmpID = 1001
//             };

//             emp.FirstName  = "New Name";
//             Console.WriteLine(emp.ToString());
//         } 
//     }
// }
