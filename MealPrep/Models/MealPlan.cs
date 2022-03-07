using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MealPrep.Models
{

    public class MealPlanData
    {
        public static JObject GetMealPlanDatas(string apiKey, string ingredient)
        {
            var apiCallTask = ApiHelper.ApiCall(apiKey, ingredient);
            string result = apiCallTask.Result;
            dynamic stuff = JObject.Parse(result);
            return stuff;
        }
    
        public class Meal
        {
            public int id { get; set; }
            public string imageType { get; set; }
            public string title { get; set; }
            public int readyInMinutes { get; set; }
            public int servings { get; set; }
            public string sourceUrl { get; set; }
        }

        public class Nutrients
        {
            public double calories { get; set; }
            public double protein { get; set; }
            public double fat { get; set; }
            public double carbohydrates { get; set; }
        }

        public class Monday
        {
            public List<Meal> meals { get; set; }
            public Nutrients nutrients { get; set; }
        }

        public class Tuesday
        {
            public List<Meal> meals { get; set; }
            public Nutrients nutrients { get; set; }
        }

        public class Wednesday
        {
            public List<Meal> meals { get; set; }
            public Nutrients nutrients { get; set; }
        }

        public class Thursday
        {
            public List<Meal> meals { get; set; }
            public Nutrients nutrients { get; set; }
        }

        public class Friday
        {
            public List<Meal> meals { get; set; }
            public Nutrients nutrients { get; set; }
        }

        public class Saturday
        {
            public List<Meal> meals { get; set; }
            public Nutrients nutrients { get; set; }
        }

        public class Sunday
        {
            public List<Meal> meals { get; set; }
            public Nutrients nutrients { get; set; }
        }

        public class Week
        {
            public Monday monday { get; set; }
            public Tuesday tuesday { get; set; }
            public Wednesday wednesday { get; set; }
            public Thursday thursday { get; set; }
            public Friday friday { get; set; }
            public Saturday saturday { get; set; }
            public Sunday sunday { get; set; }
        }

        public class Root
        {
            public Week week { get; set; }
        }
    }
        
}