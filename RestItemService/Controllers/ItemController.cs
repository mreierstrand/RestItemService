using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLib.model;

namespace RestItemService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        // GET: api/Item
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return items;
        }

        // GET: api/Item/5
        [HttpGet("{id}", Name = "Get")]
        public Item Get(int id)
        {
            return items.Find(i => i.Id == id);
        }

        // POST: api/Item
        [HttpPost]
        public void Post([FromBody] Item value)
        {
            items.Add(value);
        }

        // PUT: api/Item/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Item value)
        {
            Item item = Get(id);
            if (item != null)
            {
                item.Id = value.Id;
                item.Name = value.Name;
                item.Quality = value.Quality;
                item.Quantity = value.Quantity;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Item item = Get(id);
            items.Remove(item);
        }

        private static readonly List<Item> items = new List<Item>()
        {
            new Item(1, "Flaske", "High", 2),
            new Item(2, "IPhone", "High", 1),
            new Item(3, "Computer", "Middle", 3),
            new Item(4,"Gibbernakker","High",100),
            new Item(5,"Vodkashots","Low",5)
        };
    }
}
