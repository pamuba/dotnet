// using System;

// namespace App{
//     class AppDemo{
//         static void Main(){
//             // Declare without initializing.
//             string message1;

//             // Initialize to null.
//             string message2 = null;

//             // Initialize as an empty string.
//             // Use the Empty constant instead of the literal "".
//             string message3 = System.String.Empty;

//             // Initialize with a regular string literal.
//             string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

//             // Initialize with a verbatim string literal.
//             string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

//             // Use System.String if you prefer.
//             System.String greeting = "Hello World!";

//             // In local variables (i.e. within a method body)
//             // you can use implicit typing.
//             var temp = "I'm still a strongly-typed System.String!";

//             // Use a const string to prevent 'message4' from
//             // being used to store another string value.
//             const string message4 = "You can't get rid of me!";

//             // Use the String constructor only when creating
//             // a string from a char*, char[], or sbyte*. See
//             // System.String documentation for details.
//             char[] letters = { 'A', 'B', 'C' };
//             string alphabet = new string(letters);


//             string singleLine = """Friends say "hello" as they pass by.""";
// string multiLine = """
//     "Hello World!" is typically the first program someone writes.
//     """;
// string embeddedXML = """
//        <element attr = "content">
//            <body style="normal">
//                Here is the main text
//            </body>
//            <footer>
//                Excerpts from "An amazing story"
//            </footer>
//        </element >
//        """;
// // The line "<element attr = "content">" starts in the first column.
// // All whitespace left of that column is removed from the string.

// string rawStringLiteralDelimiter = """"
//     Raw string literals are delimited 
//     by a string of at least three double quotes,
//     like this: """
//     """";
//         }
//     }
// }