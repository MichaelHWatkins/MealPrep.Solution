using Microsoft.AspNetCore.Mvc;
using MealPrep.Models;


namespace MealPrep.Controllers
{
  public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/addMeals/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [Route("/addMeals")]
        public ActionResult Create(string ingredient)
        {
            
            var allPlans= MealPlanData.GetMealPlanDatas(EnvironmentVariables.apiKey, ingredient);
            return View("Index", allPlans);
        }
    }
}