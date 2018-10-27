/*Compiling the below code currently produces the error: "The name 'output' does not exist in the current context". This error is the result of improper variable scoping.
The output variable is declared twice: once within the if statement's curly braces and again within the else statement's curly braces. Remember, variables in C# can only be used within the curly braces that they are declared within. The last line of code in this program, Console.WriteLine(output);, is attempting to use a variable named output, which doesn't exist outside of the if/else statement's curly braces.

To fix this error:

Declare the output variable just before the if statement and assign it to an empty string (i.e. "").
Remove the string data types from the output variables within the if/else statement's curly braces */

using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {            
            string input = Console.ReadLine();
            string output = "";
            if (input == "quit")
            {
                output = "Goodbye.";
            }
            else
            {
                output = "You entered " + input + ".";
            }
            
            Console.WriteLine(output);
        }
    }
}