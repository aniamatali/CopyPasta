using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using ChangeThisNameSpace.Models;

namespace Find.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/ChangeThis/results")]
    public ActionResult Results()
    {
      ClassNameHere ObjectName = new ClassNameHere (Request.Form["______"], Request.Form["_____"]);
      return View (ObjectName);
    }
  }
}
