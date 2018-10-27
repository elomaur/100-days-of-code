
/*

The following table describes my room temperature preferences. Print the message from the table when a user enters a number in the corresponding range. For example, if temperature is 21 the code should print "Just right." to the screen.

Temperature (°C)	Message
Less than 21°	Too cold!
21° to 22°	Just right.
Greater than 22°	Too hot!

 */

using System;

namespace Treehouse.PracticeSession
{
    class TemperatureChallenge
    {
        static void Main()
		{
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
}