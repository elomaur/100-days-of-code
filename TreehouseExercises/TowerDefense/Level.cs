namespace TreehouseDefense
{
  class Level
  {
    private readonly Invader [] _invaders; // Only needs the array of invaders. Each invader already has an instance of the path object so we don't need to set the path as a field in the level class. 
    
    public Tower[] Towers { get; set; } // not required but eventually, the tower does need to know about them. 
    
    public Level(Invader[] invaders)
    {
      _invaders = invaders;
    }
    //Returns: true if the player wins, false otherwise.
    public bool Play()
    {
      //Run until all invaders are neutralized or an invader reaches the end of the path. 
      int remainingInvaders = _invaders.Length;
      
      while(remainingInvaders > 0)
      {
        // Each tower has an opportunity to fire on invaders
        foreach(Tower tower in Towers)
        {
          tower.FireOnInvaders(_invaders);
        }
        
        // count and move the invaders that are still active.
        remainingInvaders = 0;
        foreach(Invader invader in _invaders)
        {
            if(invader.IsActive)
            {
              invader.Move();
              
              if(invader.HasScored)
                {
                  return false;
                }
              
              remainingInvaders++;
            }
        }
      }
      
      return true;
    }
  }
}