using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoalKe_1_WEB.Models;

namespace SoalKe_1_WEB.Controllers
{
    public class HitungController : Controller
    {
        // GET: Hitung
        [HttpGet]
        public ActionResult Index()
        {
            HitungModel op = new HitungModel();
            return View();
        }

        // GET: Hitung/Details/5
        [HttpPost]
        public ActionResult Index(HitungModel )
        {
            
        }

        // GET: Hitung/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hitung/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Hitung(HitungModel p, double a, double b)
        {
            if (ModelState.IsValid)
            {
                HitungServiceModel svc = new HitungServiceModel();
                svc.Penjumlahan(a, b);
                return RedirectToAction("Hitung");
            }
            return View(p);
        }

    }
}