// public class A
// {
//     private int _value = 10;

//     public class B : A
//     {
//         public int GetValue()
//         {
//             return _value;
//         }
//     }
// }

// public class C : A
// {
//     //    public int GetValue()
//     //    {
//     //        return _value;
//     //    }
// }
// public enum Season
// {
//     Spring,
//     Summer,
//     Autumn,
//     Winter
// }
// public enum Seasons
// {
//     Spring ,
//     Summer,
//     Autumn,
//     Winter
// }

// public struct Coords
// {
//     private int counter;
//     public int Counter
//     {
//         readonly get => counter;
//         set => counter = value;
//     }
// }


// public class AccessExample
// {
//     public static void Main(string[] args)
//     {
//         Coords ob = new Coords();
//         ob.Counter = 44;
//         Console.WriteLine(ob.Counter.ToString());
//         // ob.X = 44;
//         // Console.WriteLine(ob.X);
//         // var b = new A.B();
//         // Console.WriteLine(b.GetValue());
//         // // Console.WriteLine(Seasons.Spring);
//         // Seasons s = new Seasons();
//         // Console.WriteLine(s);
//     }
// }
// // The example displays the following output:
// //       10