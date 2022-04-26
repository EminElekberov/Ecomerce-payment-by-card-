using CardsShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CardsShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;
        public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {

            var urunler = _dataContext.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    CategoryId = i.CategoryId
                }).ToList();

            return View(urunler);
        }
        public IActionResult Details(int id)
        {
            return View(_dataContext.Products.Where(i => i.Id == id).FirstOrDefault());
        }
        public IActionResult List(int? id)
        {
            var urunler = _dataContext.Products
               .Where(i => i.IsApproved)
               .Select(i => new ProductModel()
               {
                   Id = i.Id,
                   Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                   Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                   Price = i.Price,
                   Stock = i.Stock,
                   Image = i.Image ?? "1.jpg",
                   CategoryId = i.CategoryId
               }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }

            return View(urunler.ToList());
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
        public PartialViewResult GetCategories()
        {
            return PartialView(_dataContext.Categories.ToList());
        }
    }
}
