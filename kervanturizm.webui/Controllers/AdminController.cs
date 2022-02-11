using kervanturizm.business.Abstract;
using kervanturizm.webui.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kervanturizm.webui.Controllers
{
    public class AdminController : Controller
    {
        private IBiletService _biletService;
        public AdminController(IBiletService biletService)
        {
            this._biletService = biletService;
        }

        public IActionResult AdminList()
        {
            return View(new BiletGuzergah()
            {
                Bilets = _biletService.GetAll()
            });
        }
        public IActionResult IptalBilet(int BiletID)
        {
            var bilet = _biletService.GetById(BiletID);
            if (bilet!=null)
            {
                _biletService.Delete(bilet);
            }
            return RedirectToAction("AdminList");
        }
    }
}
