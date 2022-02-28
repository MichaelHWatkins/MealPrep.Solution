using Microsoft.AspNetCore.Mvc;
using MealPrep.Models;
using System.Collections.Generic;
using System.Linq;

namespace MealPrep.Controllers
{
  public class MealsController : Controller
  {
    private readonly MealPrepContext _db;

    public MealsController(MealPrepContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Meal> model = _db.Meals.ToList();
      return View(model);
    }
  }
}