using Microsoft.AspNetCore.Mvc;
using MealPrep.Models;


namespace MealPrep.Controllers
{
  public class HomeController : Controller
    {
        private readonly MealPrepContext _db;
        public HomeController(MealPrepContext db)
        {
          _db = db;
        }
        public IActionResult Index()
        {
            var allPlans= MealPlanData.GetMealPlanDatas(EnvironmentVariables.apiKey);
            return View(allPlans);
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
    }
}