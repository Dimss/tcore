using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TCore.Models;
using Newtonsoft.Json;

namespace TCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {

        // GET api/items/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            Item i = new Item();
            i.Id = id;
            i.ItemName = "ItemX";
            i.ItemType = "SecretItem";
            
            return JsonConvert.SerializeObject(i);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
