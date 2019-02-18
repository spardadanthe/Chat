using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        public static List<Message> messages = new List<Message>();

        // GET: api/Chat
        [HttpGet]
        public List<Message> Get()
        {
            return messages;
        }

        // POST: api/Chat
        [HttpPost]
        public void Post([FromBody] Message message)
        {
            messages.Add(message);
        }


    }
}
