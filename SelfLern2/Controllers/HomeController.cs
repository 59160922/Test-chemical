using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelfLern2.Models;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Routing;

namespace SelfLern2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("{id?}")]
        public IActionResult Index(string id)
        {
            var client = new RestClient();
            if (id != null && id !="")
            {               

                client = new RestClient("https://api-football-v1.p.rapidapi.com/v2/teams/league/"+id);
            
            }
            else {
                client = new RestClient("https://api-football-v1.p.rapidapi.com/v2/teams/league/2");
            }
            
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "api-football-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "fa42a411c8mshc2bae561be7e0d8p1dc7dejsn22bc8e5d9229");
            IRestResponse response = client.Execute(request);
            dynamic customerDto = JsonConvert.DeserializeObject(response.Content);
            var json = customerDto.api.teams;
            ViewBag.teams = json;
            return View();
        }

      
        public IActionResult Privacy()
        {
            return View();
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
