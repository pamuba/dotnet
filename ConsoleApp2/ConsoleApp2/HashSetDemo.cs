using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class HashSetDemo
    {
        //unordered
        //unique

        static void Main() {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Sunday");
            hs.Add("Monday");
            hs.Add("Tuesday"); 
            hs.Add("Monday");


            HashSet<string> hs1 = new HashSet<string>();
            hs1.Add("Sunday");
            hs1.Add("Friday");
            hs1.Add("Saturday");
            hs.Add("Wednesday");

            /*hs.Intersect<string>(hs1)*/;


            foreach (var item in hs.Intersect<string>(hs1))
            {
                Console.WriteLine(item);
            }

        }
       
    }
}
