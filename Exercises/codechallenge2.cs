/*
Add input validation to the below program by printing "You must enter a whole number." if the user enters a decimal or something that isn’t a number.

- Wrap all of the code contained in the Main method in a try/catch block
- The catch block should catch FormatException exceptions
- Inside of the catch block, output to the console the message "You must enter a whole number."
 */


using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter the number of times to print \"Yay!\": ");
                string input = Console.ReadLine();

                int count = int.Parse(input);

                int i = 0;
                while(i < count)
                {
                    i += 1;   
                    Console.WriteLine("Yay!");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("You must enter a whole number.");
            }
        }
    }
}
