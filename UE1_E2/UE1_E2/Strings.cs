using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Strings
    {
        public void testString()
        {
            // Declare without initializing.
            string message1;

            // Initialize to null.
            string message2 = null;

            // Initialize as an empty string.
            // Use the Empty constant instead of the literal "".
            string message3 = System.String.Empty;

            //Initialize with a regular string literal.
            string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

            // Initialize with a verbatim string literal.
            string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

            // Use System.String if you prefer.
            System.String greeting = "Hello World!";

            // In local variables (i.e. within a method body)
            // you can use implicit typing.
            var temp = "I'm still a strongly-typed System.String!";

            // Use a const string to prevent 'message4' from
            // being used to store another string value.
            const string message4 = "You can't get rid of me!";

            // Use the String constructor only when creating
            // a string from a char*, char[], or sbyte*. See
            // System.String documentation for details.
            char[] letters = { 'A', 'B', 'C' };
            string alphabet = new string(letters);
        }

        public void testImutable()
        {
            string s1 = "A string is more ";
            string s2 = "than the sum of its chars.";

            // Concatenate s1 and s2. This actually creates a new
            // string object and stores it in s1, releasing the
            // reference to the original object.
            s1 += s2;

            System.Console.WriteLine(s1);
            // Output: A string is more than the sum of its chars.
        }

        public void testSequence()
        {
            string text = @"My pensive SARA ! thy soft cheek reclined
                            Thus on mine arm, most soothing sweet it is
                            To sit beside our Cot,...";
            Console.WriteLine(text);
        }

        public void testFormatString()
        {
            // Get user input.
            System.Console.WriteLine("Enter a number");
            string input = System.Console.ReadLine();

            // Convert the input string to an int.
            int j;
            System.Int32.TryParse(input, out j);

            // Write a different string each iteration.
            string s;
            for (int i = 0; i < 10; i++)
            {
                // A simple format string with no alignment formatting.
                s = System.String.Format("{0} times {1} = {2}", i, j, (i * j));
                System.Console.WriteLine(s);
            }

            //Keep the console window open in debug mode.
            System.Console.ReadKey();
        }

        public void testCaracOperations()
        {
            string s3 = "Visual C# Express";
            System.Console.WriteLine(s3.Substring(7, 2));
            // Output: "C#"

            System.Console.WriteLine(s3.Replace("C#", "Basic"));
            // Output: "Visual Basic Express"

            // Index values are zero-based
            int index = s3.IndexOf("C");
            // index = 7
        }
          
    }
}
