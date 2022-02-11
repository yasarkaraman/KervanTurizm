using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using kervanturizm.entity;
using kervanturizm.data;
using kervanturizm.business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using kervanturizm.data.Concrete;
using System.Security.Claims;

namespace kervanturizm.webui.Controllers
{
    public class LoginController:Controller
    {
        BiletContext c = new BiletContext();
        public IActionResult Index()
        {

            return View();

        }
public IActionResult GirisYap()
        {
            return View();

        }
        public async Task<IActionResult> AdminList(Admin p)
        {
             var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == p.Kullanici && x.Sifre == p.Sifre);
             if (bilgiler != null)
             {
                 var claims = new List<Claim>
                 {
                 new Claim(ClaimTypes.Name,p.Kullanici)
                 };
                 var useridentity = new ClaimsIdentity(claims, "Login");
                 ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                 await HttpContext.SignInAsync(principal);
                 return RedirectToAction("Index", "Home");
             }
             return View();

         }
        }





    }