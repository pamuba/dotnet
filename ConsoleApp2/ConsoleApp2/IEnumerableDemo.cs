// using System;
// using System.Collections;
// public class Person
// {
//     public Person(string fName, string lName)
//     {
//         this.firstName = fName;
//         this.lastName = lName;
//     }

//     public string firstName;
//     public string lastName;
// }
// public class People : IEnumerable
// {
//     private Person[] _people;
//     public People(Person[] pArray)
//     {
//         _people = new Person[pArray.Length];

//         for (int i = 0; i < pArray.Length; i++)
//         {
//             _people[i] = pArray[i];
//         }
//     }

//     // public IEnumerator GetEnumerator()
//     // {
//     //      return (IEnumerator) new PeopleEnum(_people);
//     // }

//     IEnumerator IEnumerable.GetEnumerator()
//     {
//        return (IEnumerator) GetEnumerator();
//     }

//     public PeopleEnum GetEnumerator()
//     {
//         return new PeopleEnum(_people);
//     }

// }

// public class PeopleEnum : IEnumerator
// {
//     public Person[] _people;
//     int position = -1;

//     public PeopleEnum(Person[] list)
//     {
//         _people = list;
//     }

//     public bool MoveNext()
//     {
//         position++;
//         return (position < _people.Length);
//     }

//     public void Reset()
//     {
//         position = -1;
//     }

//     public object Current
//     {
//         get
//         {
//             try
//             {
//                 return _people[position];
//             }
//             catch (IndexOutOfRangeException)
//             {
//                 throw new InvalidOperationException();
//             }
            
//         }
//     }

// }

// class App
// {
//     static void Main()
//     {
//         Person[] peopleArray = new Person[3]
//         {
//             new Person("John", "Smith"),
//             new Person("Jim", "Johnson"),
//             new Person("Sue", "Rabon"),
//         };

//         People peopleList = new People(peopleArray);
//         // foreach (Person p in peopleList)
//         //     Console.WriteLine(p.firstName + " " + p.lastName);

//         //  IEnumerable e = (IEnumerable)peopleList;
//          IEnumerator en = peopleList.GetEnumerator();
//          en.MoveNext();
//          Console.WriteLine(((Person)(en.Current)).firstName + " "+ ((Person)(en.Current)).lastName);
//          en.MoveNext();
//          Console.WriteLine(((Person)(en.Current)).firstName + " "+ ((Person)(en.Current)).lastName);
//          en.MoveNext();
//          Console.WriteLine(((Person)(en.Current)).firstName + " "+ ((Person)(en.Current)).lastName);
//          en.Reset();
//          en.MoveNext();
//          Console.WriteLine(((Person)(en.Current)).firstName + " "+ ((Person)(en.Current)).lastName);
//     }
// }

//Custom Exceptions
//AppDomain in Exceptions
//jagged array
//predefined generic delegates
//Linq
//Async

