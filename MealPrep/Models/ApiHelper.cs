using System.Threading.Tasks;
using RestSharp;

namespace MealPrep.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://api.spoonacular.com/recipes");
      RestRequest request = new RestRequest($"complexSearch?query={ingredient}&addRecipeInformation=true&apiKey={apiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}