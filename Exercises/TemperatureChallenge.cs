
using System;

namespace Treehouse.PracticeSession
{
    class TemparatureChallenge
    {
        public static void Main()
string input = Console.ReadLine();
int temperature = int.Parse(input);
	if (temperature < 21)
		{
    		Console.WriteLine("Too cold!");
		}
    else if (temperature >= 21 && temperature <= 22)
    	{
        	Console.WriteLine("Just right.");
    	}
	else if (temperature >= 23)
		{
   		 	Console.WriteLine("Too hot!");
		}
	}
}