using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatViaHttp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ChatViaHttp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        List<Message> messages = new List<Message>();

        // GET: api/Chat
        [HttpGet]
        public Message Get()
        {
            return messages.Last();
        }

        // POST: api/Chat
        [HttpPost]
        public void Post([FromBody] Message message)
        {
            messages.Add(message);
        }

        // PUT: api/Chat/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
