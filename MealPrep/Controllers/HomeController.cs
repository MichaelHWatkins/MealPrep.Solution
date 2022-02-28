using Microsoft.AspNetCore.Mvc;
using MealPrep.Models;


namespace MealPrep.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allPlans= MealPlanData.GetMealPlanDatas(EnvironmentVariables.apiKey);
            return View(allPlans);
        }
        
    }
}