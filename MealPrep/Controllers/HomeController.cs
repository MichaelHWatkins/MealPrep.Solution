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

        [Route("/meals/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [Route("/items")]
        public ActionResult Create(string ingredient)
        {
            
            var allPlans= MealPlanData.GetMealPlanDatas(EnvironmentVariables.apiKey, ingredient);
            return View("Index", allPlans);
        }
    }
}