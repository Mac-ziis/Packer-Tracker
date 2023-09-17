using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class GearsController : Controller
  {
    [HttpPost("/gears")]
    public ActionResult Create(string description)
    {
      Gear myGear = new Gear(description);
      return RedirectToAction("Index");
    }

  }
}