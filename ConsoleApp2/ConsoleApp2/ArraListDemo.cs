using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ArraListDemo
    {
        static void Main() {
            //ArrayList myAL = new ArrayList();
            //myAL.Add("Hello");

            //Console.WriteLine(myAL[0]);

            //ArrayList myALCopy = new ArrayList();
            //myALCopy[0] = "New Value";

            //Console.WriteLine(myAL[0]);

            //Console.WriteLine(myALCopy[0]);

            Employee[] employees = new Employee[] {
               new Employee(66, "zirst"),
                new Employee(2, "kecond"),
                new Employee(11, "third")
            };

            Console.WriteLine("Before Sorting:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID={emp.Id}, Employee Name:{emp.EmpName}");
            }

            Array.Sort(employees);

            Console.WriteLine("After Sorting:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID={emp.Id}, Employee Name:{emp.EmpName}");
            }
        }
    }

    class Employee:IComparable { 
        public int Id { get; set; }
        public string EmpName { get; set; }

        public Employee(int id, string empName)
        {
            Id = id;
            EmpName = empName;
        }

        public int CompareTo(object? obj)
        {
            Employee? employee = obj as Employee;
            //return this.EmpName.CompareTo(employee.EmpName);

            return employee.EmpName.CompareTo(this.EmpName);
        }
    }
}
