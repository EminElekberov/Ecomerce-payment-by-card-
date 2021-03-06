using CardsShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Linq;
using Microsoft.AspNetCore.Session;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace CardsShop.Controllers
{
    public class CartController : Controller
    {
        private readonly DataContext db;
        //public System.Web.HttpSessionStateBase Session { get; }

        public CartController(DataContext dataContext)
        {
            db = dataContext;
        }
        public IActionResult Index()
        {
            return View(GetCart());
        }

        public IActionResult AddToCart(int Id)
        {
            List<Product> products;
            var product = db.Products.FirstOrDefault(i => i.Id == Id);
            if (product != null)
            {
                GetCart().AddProduct(product, 1);
            }
            string basketstr;
            basketstr = HttpContext.Request.Cookies["Cart"];
            if (basketstr==null)
            {
                products = new List<Product>();
                products.Add(product);
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<Product>>(basketstr);
                products.Add(product);
            }
            string basket = JsonConvert.SerializeObject(products);
            HttpContext.Response.Cookies.Append("Cart", basket);
            //HttpContext.Session.SetString("Cart", product.Name);
           // HttpContext.Response.Cookies.Append("Cart", product.Name);
            return RedirectToAction("Index");
        }
        public IActionResult Showbasket()
        {
            string basketstr = HttpContext.Request.Cookies["Cart"];
            List<Product> basketpr = JsonConvert.DeserializeObject<List<Product>>(basketstr);

            return Json(basketpr);
        }
        public IActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }

            return RedirectToAction("Index");
        }

        public Cart GetCart()
        {
            
            //HttpSessionStateBase  bu klasdan gelmelidi Session
            //HttpContext.Session.SetString("Cart",)
            //var cart = (Cart)Session["Cart"];
            //var cart = JsonConvert.DeserializeObject<Cart>(HttpContext.Session.GetString("Cart"));

            //if (cart == null)
            //{
            //    cart = new Cart();
            //    //Session["Cart"] = cart;
            //}

            return new Cart();
        }

        public PartialViewResult Summary()
        {
            return PartialView(GetCart());
        }
        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }
        [HttpPost]
        public ActionResult Checkout(ShippingDetails entity)
        {
            var cart = GetCart();

            if (cart.CartLines.Count == 0)
            {
                ModelState.AddModelError("UrunYokError", "Sepetinizde ürün bulunmamaktadır.");
            }

            if (ModelState.IsValid)
            {
                SaveOrder(cart, entity);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(entity);
            }
        }
        private void SaveOrder(Cart cart, ShippingDetails entity)
        {
            var order = new Order();

            order.OrderNumber = "A" + (new Random()).Next(11111, 99999).ToString();
            order.Total = cart.Total();
            order.OrderDate = DateTime.Now;
            order.OrderState = EnumOrderState.Waiting;
            order.Username = User.Identity.Name;

            order.AdresBasligi = entity.AdresBasligi;
            order.Adres = entity.Adres;
            order.Sehir = entity.Sehir;
            order.Semt = entity.Semt;
            order.Mahalle = entity.Mahalle;
            order.PostaKodu = entity.PostaKodu;

            order.Orderlines = new List<OrderLine>();

            foreach (var pr in cart.CartLines)
            {
                var orderline = new OrderLine();
                orderline.Quantity = pr.Quantity;
                orderline.Price = pr.Quantity * pr.Product.Price;
                orderline.ProductId = pr.Product.Id;

                order.Orderlines.Add(orderline);
            }
            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
}
