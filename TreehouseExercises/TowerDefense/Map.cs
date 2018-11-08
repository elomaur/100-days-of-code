namespace TreehouseDefense
{
  class Map
  {
      public readonly int Width; //Instance variables. They exist as long as the object exists and ca be used by other methods and classes. 
      public readonly int Height;
    
    public Map(int width, int height)
    {
      Width = width; // Method level variables - they only exist inside this method. That is the variable scope 
      Height = height;
    }
    
    public bool OnMap(Point point)
    {
      return point.X >= 0 && point.X < Width &&
             point.Y >= 0 && point.Y < Height;
    }
  }
}