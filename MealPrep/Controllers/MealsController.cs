using Microsoft.AspNetCore.Mvc;
using MealPrep.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data;

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

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Meal meal)
    {
      _db.Meals.Add(meal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Meal thisMeal = _db.Meals.FirstOrDefault(meal => meal.MealId == id);
      return View(thisMeal);
    }


    public ActionResult Delete(int id)
    {
      var thisMeal = _db.Meals.FirstOrDefault(meal => meal.MealId == id);
      return View(thisMeal);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisMeal = _db.Meals.FirstOrDefault(meal => meal.MealId == id);
      _db.Meals.Remove(thisMeal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}