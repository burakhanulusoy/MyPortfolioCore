using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Entities;
using Portfolio.Web.Models;
using Proje1Denemesi.Context;
using System.Security.Claims;

namespace Portfolio.Web.Controllers
{
    [AllowAnonymous]
    public class AuthController(PortfolioContext context) : Controller
    {

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            //FAST FAİL İLK HATA YAKALA
            if (!ModelState.IsValid)
            {

                      return View(model);

            }

            var user=context.Users.FirstOrDefault(x=>x.UserName==model.UserName && x.Password==model.Password );

            if (user is  null)
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
                return View(model);

            }


            //kişi sisteme girdiği an bilgi tutcaz
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim("fullName",string.Join(" ",user.FirstName,user.LastName))
            };


            var claimIdenty=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);

            var authproporties = new AuthenticationProperties
            {
                ExpiresUtc = DateTime.UtcNow.AddMinutes(30),//oturumda kalma suresi
                IsPersistent = false // *** *** sürekli sistemde kalsın mı?
                //datetime now farkı bak saat heryede aynı
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimIdenty),
                authproporties);



            HttpContext.Session.SetString("UserName", user.UserName);

            return RedirectToAction("Index", "Statistics");


        }




        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Remove("UserName");
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Default");


        }





    }
}
