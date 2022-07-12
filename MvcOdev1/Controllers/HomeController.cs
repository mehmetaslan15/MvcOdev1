using MvcOdev1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOdev1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult UyeOl()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UyeOl(Uye uye)
        {
            if (ModelState.IsValid)
            {
                TempData["UyeBilgisi"] = $"Adı: {uye.Ad} <br> Soyadı: {uye.Soyad}<br> Kullanıcı Adı: {uye.KullaniciAdi}<br> Email: {uye.Email}<br> Telefon: {uye.Telefon}";
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string kullaniciAdi, string sifre)
        {
            Uye kullanici = new Uye()
            {
                Ad="Ali",
                Soyad="Kuş",
                KullaniciAdi="admin",
                Sifre="12345"
            };
            if (kullaniciAdi == "admin" && sifre == "12345")
            {
                Session["kullanici"] = kullanici.Ad + " " + kullanici.Soyad;
            }
            return View();
        }
        public ActionResult SessionSil()
        {
            Session.Remove("kullanici");
            return View();
        }
    }
}