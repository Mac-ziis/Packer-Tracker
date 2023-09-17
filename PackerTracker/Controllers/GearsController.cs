using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class GearsController : Controller
  {
    [HttpGet("/gears")]
    public ActionResult Index()
    {
      List<Gear> allGears = Gear.GetAll();
      return View(allGears);
    }

    [HttpGet("/gears/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/gears")]
    public ActionResult Create(string description)
    {
      Gear myGear = new Gear(description);
      return RedirectToAction("Index");
    }

  }
}