using System.Collections.Generic;


namespace PackerTracker.Models
{
  public class Gear
  {
    public string Description { get; set; }
    private static List<Gear> _instances = new List<Gear> { };

    public Gear(string description)
    {
        Description = description;
         _instances.Add(this);
    }
    public static List<Gear> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}