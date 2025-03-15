using Microsoft.AspNetCore.Mvc;
using ProductInventoryApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductInventoryApp.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Description = "Gaming Laptop", Price = 1500 },
            new Product { Id = 2, Name = "Smartphone", Description = "Android Phone", Price = 500 },
            new Product { Id = 3, Name = "Headphones", Description = "Noise Cancelling", Price = 200 }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            return View(product);
        }

        public IActionResult Add()
        {
            var newProduct = new Product { Id = products.Count + 1, Name = "New Product", Description = "Sample", Price = 100 };
            products.Add(newProduct);
            return RedirectToAction("Index");
        }
    }
}
