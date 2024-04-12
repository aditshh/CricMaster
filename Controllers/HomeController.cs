using CricMaster.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CricMaster.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var client = new RestClient("https://cricbuzz-cricket.p.rapidapi.com/matches/v1/recent");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", "ed1a0fed5dmshf5cc369b41a68afp1331e6jsn48acd0bf3a10");
            request.AddHeader("X-RapidAPI-Host", "cricbuzz-cricket.p.rapidapi.com");
            RestResponse response = client.Execute(request);
            var statReceived =
                JsonConvert.DeserializeObject<ScoreData>(response.Content);

            return View(statReceived);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}