using WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1, date = DateTime.Now, description = "Testy" },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M, date = DateTime.Now, description = "Wjuh Wjuh" },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M, date = DateTime.Now, description = "For man with a lot of money" }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
