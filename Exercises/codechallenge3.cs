
/*

Add more input validation to the program by printing "You must enter a positive number." if the user enters a negative number.

- Add an if/else conditional statement just after parsing the user's provided input to an integer
- Write a conditional expression to ensure that the remainder of the code in the try block is only executed if the user provides a non-negative number
- If the user enters a negative number, output to the console the message "You must enter a positive number."

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
                if(count < 0)
                    {
                        Console.WriteLine ("You must enter a positive number.");
                    }
				else
                {
                int i = 0;
                
                while(i < count)
                    {
                        i += 1;   
                        Console.WriteLine("Yay!");
                    }
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("You must enter a whole number.");
            }
        }
    }
}
