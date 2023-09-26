//1. Basic Query Expression
// string[] names = {"John", "Jill", "Mark"};

// IEnumerable<string> query =  from n in names
// where n.Contains("a")
// select n;

// foreach (string item in query)
// {
//     Console.WriteLine(item);
// }

//2. chaining query operators
// string[] names = {"Ayanz", "Jallyddfd", "Mark"};

// IEnumerable<string> query =  names
//                                   .Where(n => n.Contains("a"))
//                                   .OrderBy(n => -n.Length)
//                                   .Select(n => n.ToUpper());

// IEnumerable<string> filtered  = names.Where(n => n.Contains("a"));
// IEnumerable<string> sorted  = filtered.OrderBy(n => -n.Length);
// IEnumerable<string> result  = sorted.Select(n => n.ToUpper());

// foreach (string item in result)
// {
//     Console.WriteLine(item);
// }

//3.automatic type inference
// string[] names = {"Ayanz", "Jallyddfd", "Mark", "Harry", "Batman", "Iron Man"};

// IEnumerable<Int32> r = names.Select(n=>n.Length);

// //no of chars-int
// //string

// IEnumerable<string> sortedByLength, sortedAlpha;

// sortedByLength = names.OrderByDescending(n => n.Length);
// sortedAlpha = names.OrderByDescending(n => n);


// foreach (string item in sortedByLength)
// {
//     Console.WriteLine(item);
// }

//4. other functions 

// int[] numbers = {10,9,7,6,8};
// // IEnumerable<Int32> r = numbers.Take(3);
// // IEnumerable<Int32> r = numbers.Skip(3);
// IEnumerable<Int32> r = numbers.Take(3).Reverse();


// //System.Linq  IEnumerable as extension methods

// // Console.WriteLine(string.Join(" ", r));
// // Console.WriteLine(numbers.First());
// // Console.WriteLine(numbers.Last());
// // Console.WriteLine(numbers.Skip(1).ElementAt(1));
// // Console.WriteLine(numbers.Count());
// Console.WriteLine(numbers.Min());
// Console.WriteLine(numbers.Max());
// Console.WriteLine(numbers.Contains(9));
// Console.WriteLine(numbers.Any());

// // foreach (int item in r)
// // {
// //     Console.WriteLine(item);
// // }

//5. Deferred + Reevaluation
// class Prog{
//     static void Main(){
//         IList<string> names = new List<string>{"John", "Bill","June","April"};
//         var filtered =  (from name in names 
//                         where name.StartsWith("J") 
//                         select name).ToArray();
        
//         names.Add("Jic");
//         Console.WriteLine(string.Join(" ",filtered));
//         // foreach(var n in filtered){
//         //     Console.WriteLine(n);
//         // }
//     }
// }


// class Prog{
//     static void Main(){
//         IList<string> names = new List<string>{"John", "Bill","June","April"};
//         var filtered =  (from name in names 
//                         where name.StartsWith("J") 
//                         select name).ToArray();
//         Console.Write("Before: ");
//         Console.WriteLine(string.Join(" ",filtered));

//         names.Clear();

//         Console.Write("After: ");
//         Console.WriteLine(string.Join(" ",filtered));

//         // foreach(var n in filtered){
//         //     Console.WriteLine(n);
//         // }
//     }
// }

//6. capturing

// int[] numbers = {1,2};
// int factor = 10;
// IEnumerable<int> r = numbers.Select(n=>n*factor);
// factor = 20;
// Console.WriteLine(string.Join(" ",r));

//Linq + async 
//9.30 - 12.30





