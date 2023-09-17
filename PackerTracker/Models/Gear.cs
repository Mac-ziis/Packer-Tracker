using System.Collections.Generic;


namespace PackerTracker.Models
{
  public class Gear
  {
    public string Description { get; set; }

    public Gear(string description)
    {
        Description = description;
    }
  }
}