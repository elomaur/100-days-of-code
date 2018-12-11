using System;

namespace TreehouseDefense
{
  class Tower
  {
    private const int _range = 1; //Declaring a constant 
    private const int _power =1;
    private const double _accuracy = .75;
    
    private static readonly Random _random = new Random();
    
    private readonly MapLocation _location;
    
    public Tower(MapLocation location)
    {
       _location = location;
    }
    
    public bool IsSuccessfulShot()
    {
      return _random.NextDouble() < _accuracy;
    }
    
    public void FireOnInvaders(Invader[] invaders)
      
    {
      foreach(Invader invader in invaders) //1
      {
        if(invader.IsActive && _location.InRangeOf(invader.Location, _range)) //2
          
        {
          if(IsSuccessfulShot())
          {
            invader.DecreaseHealth(_power); //3
            Console.WriteLine("Shot at and hit an invader!");
            
            if(invader.IsNeutralized)
            {
               Console.WriteLine("Neutralized an invader!");
            }
          }
          else 
          {
            Console.WriteLine("Shot at and missed an invader.");
          }
          break;
        }
      }
      
    }
  }
}

/* 

1. With the for each loop we get rid of the loop counter variable entirely. This loop will always run if there's at least one item in the array.

2. We use this for each loop to look at each invader in the array and determine if it's in range of the tower.
 - In the tower class we can write if our location is in range of the invaders location using a range of one.
 - the one here is the width of one grid square.

 3. If the invader's in range, we'll decrease its health. This shows that the tower was able to cause some damage to the invader.
 - And we'll have the invaders health decreased by one.
 
 the is active property we previously added to the invader class allows the towers to only shoot at invaders that are both active  and in range
and not on the ones that have already been neutralized or made it to the end of the path

The break statement handicaps the tower a bit by letting them shoot at one tower at a time by forcing the 
foreach loop to exit after it's found and shot one enemy. 
*/