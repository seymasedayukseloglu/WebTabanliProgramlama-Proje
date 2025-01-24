using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Florals.Models;
using System.Linq;

namespace Florals.Controllers
{
    public class ProductController : Controller
    {
        private readonly myAppContext _context;
        public ProductController(myAppContext context)
        {
            _context = context;
        }

        public ActionResult Index(string category, string sortBy)
        {
            var products = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                products = products.Where(p => p.Category == category);
            }

            switch (sortBy)
            {
                case "price_asc":
                    products = products.OrderBy(p => p.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(p => p.Price);
                    break;
                default:
                    products = products.OrderBy(p => p.ProductName);
                    break;
            }

            return View(products.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

    }


}