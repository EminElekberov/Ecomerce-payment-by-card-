using CardsShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardsShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext _dbcontext;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;
        public AccountController(DataContext portoDbContext,
           UserManager<User> userManager,
           RoleManager<IdentityRole> roleManager,
           SignInManager<User> signInManager
           )
        {
            _dbcontext = portoDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        [Authorize]
        public ActionResult Index()
        {
            var username = User.Identity.Name;
            var orders = _dbcontext.Orders
                .Where(i => i.Username == username)
                .Select(i => new UserOrderModel()
                {
                    Id = i.Id,
                    OrderNumber = i.OrderNumber,
                    OrderDate = i.OrderDate,
                    OrderState = i.OrderState,
                    Total = i.Total
                }).OrderByDescending(i => i.OrderDate).ToList();

            return View(orders);
        }
        [Authorize]
        public IActionResult Details(int id)
        {
            var entity = _dbcontext.Orders.Where(i => i.Id == id)
                .Select(i => new OrderDetailsModel()
                {
                    OrderId = i.Id,
                    OrderNumber = i.OrderNumber,
                    Total = i.Total,
                    OrderDate = i.OrderDate,
                    OrderState = i.OrderState,
                    AdresBasligi = i.AdresBasligi,
                    Adres = i.Adres,
                    Sehir = i.Sehir,
                    Semt = i.Semt,
                    Mahalle = i.Mahalle,
                    PostaKodu = i.PostaKodu,
                    Orderlines = i.Orderlines.Select(a => new OrderLineModel()
                    {
                        ProductId = a.ProductId,
                        ProductName = a.Product.Name.Length > 50 ? a.Product.Name.Substring(0, 47) + "..." : a.Product.Name,
                        Image = a.Product.Image,
                        Quantity = a.Quantity,
                        Price = a.Price
                    }).ToList()
                }).FirstOrDefault();

            return View(entity);
        }
        public async Task SeedRoles()
        {
            if (!await _roleManager.RoleExistsAsync(roleName: "Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName: "Admin"));
            }
            if (!await _roleManager.RoleExistsAsync(roleName: "User"))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName: "User"));
            }
        }
        [HttpGet]
        public IActionResult Login()

        {
            SignInVm user = new SignInVm();
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(SignInVm signIn)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            var userName = await _userManager.FindByEmailAsync(signIn.Email);
            var result = await _signInManager.PasswordSignInAsync(userName, signIn.Passsword, false, false);
            if (result.Succeeded)
            {
                return Redirect("/Home/Index/");
            }
            return View(signIn);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(SignInVm signInVm)
        {
           
            if (_userManager.FindByEmailAsync(signInVm.Email).Result == null)
            {
                User user = new User
                {
                    UserName = signInVm.Username,
                    Email = signInVm.Email,
                    Password = signInVm.Passsword
                };
                if (_userManager.FindByNameAsync(signInVm.Username).Result != null)
                {
                    return NotFound();
                }
                var result = await _userManager.CreateAsync(user, signInVm.Passsword);
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "User").Wait();
                    await _signInManager.SignInAsync(user, true);
                    return Redirect("/Account/Login");
                }
                if (!result.Succeeded)
                {
                    return NotFound();
                }
            }
            return View(signInVm);
        }
        public async Task SeedAdmin()
        {
            if (_userManager.FindByEmailAsync("eminelekberov09@gmail.com").Result == null)
            {
                User user = new User
                {
                    UserName = "emin",
                    Email = "eminelekberov09@gmail.com"
                };
                var result = await _userManager.CreateAsync(user, "emin123!A");
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                    await _dbcontext.SaveChangesAsync();
                    await _signInManager.SignInAsync(user, true);
                }
            }
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
