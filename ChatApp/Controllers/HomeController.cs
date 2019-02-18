using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChatApp.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace ChatApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Message> sad = GetData().Result;
            AllMessagesModel model = new AllMessagesModel();
            model.messages = sad;
            return View(model);
        }

        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Message message)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44301/api/Chat");

                //HTTP POST
                var postTask = client.PostAsJsonAsync("Chat", message);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }


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


        private async Task<List<Message>> GetData()
        {
            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync("https://localhost:44301/api/Chat");
                return JsonConvert.DeserializeObject<List<Message>>(content);
            }
        }
    }
}
