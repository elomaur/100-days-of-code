namespace TreehouseDefense
{
  class MapLocation : Point
    
  {
    public MapLocation(int x, int y, Map map) : base(x, y)
    {
      if (!map.OnMap(this)) //1
        
      {
        throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of the map.");
      }
    }
      public bool InRangeOf(MapLocation location, int range) //2
        
      {
        return DistanceTo(location) <= range;
      }
    }
}

/* 1. "this" refers to the object that is being constructed. 
Be careful when using this in a constructor since an object is not fully constructed until the constructor has returned. 
There might still be some fields that haven't been fully initialized and using the word this too soon could have unexpected results.


2. We already know where the invader and the towers are located because they both have map location member variables.
We created a method that uses the distance to method to see how far they are from each other and then 
check if the distance is less than the shooting range of the tower. We call our method InRangeOf.
It takes another map location as a parameter and an integer range.
Then we call the distance to method we already wrote to get the distance between the map location object this method w
as called on and the one that's passed in.
Then we check if that distance is less than or equal to the range passed in and return the result of the comparison.

*/