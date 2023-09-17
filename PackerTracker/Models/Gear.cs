using System.Collections.Generic;


namespace PackerTracker.Models
{
  public class Gear
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Gear> _instances = new List<Gear> { };


    public Gear(string description)
    {
        Description = description;
         _instances.Add(this);
         Id = _instances.Count;
    }

    public static List<Gear> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Gear Find(int SearchId)
    {
      return _instances[SearchId-1];
    }
  }
}