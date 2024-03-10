using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using odev1.Models;
using System.Diagnostics;
using System.Text.Json;

namespace odev1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "iris.json");
            string json = System.IO.File.ReadAllText(jsonFilePath);

            JArray jsonArray = JArray.Parse(json);
            List<object> irisDataList = new List<object>();
            foreach (var item in jsonArray)
            {
                irisDataList.Add(item);
            }

            return View(irisDataList);
        }
    }
}