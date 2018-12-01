namespace TreehouseDefense
{
  class Path
  {
    private readonly MapLocation[] _path; 
// using underscore is a common convention in C#. It is helpful for distinguishing between instance variables and method variables. If we didn't have the underscore, noth path variables will have to be named differently or we would use this.path = path instead of _path = path
    
    public int Length => _path.Length;
      
    public Path(MapLocation[] path)
    {
      _path = path;
    }
    
    public MapLocation GetLocationAt(int pathStep)
    {
      return (pathStep < _path.Length) ? _path[pathStep] : null; 
    }
  }
}