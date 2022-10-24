using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIBKMNET_WebApp.Context;
using SIBKMNET_WebApp.Models;
using SIBKMNET_WebApp.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKMNET_WebApp.Controllers
{
    public class ProvinceController : Controller
    {
        ProvinceRepository ProvinceRepository;
        public ProvinceController(ProvinceRepository ProvinceRepository)
        {
            this.ProvinceRepository = ProvinceRepository;
        }
        public IActionResult Index()
        {
            var role = HttpContext.Session.GetString("Role");
            if (role.Equals("Admin"))
            {
                var data = ProvinceRepository.Get();
                return View(data);
            }
            return RedirectToAction("Unauthorized", "ErrorPage");
        }

        //GET BY ID
        //GET
        [HttpGet]
        public IActionResult Details(int id)
        {
            var data = ProvinceRepository.Get(id);
            return View(data);
        }
        //CREATE
        //GET
        //[HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Province province)
        {
            if (ModelState.IsValid)
            {
                var result = ProvinceRepository.Post(province);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }

        //UPDATE
        //GET
        [HttpGet]
        public IActionResult Update(int id)
        {
            var data = ProvinceRepository.Get(id);
            return View(data);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Province province)
        {
            if (ModelState.IsValid)
            {
                var result = ProvinceRepository.Put(id, province);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }

        //DELETE
        //GET
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = ProvinceRepository.Get(id);
            return View(data);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(Province province)
        {
            var result = ProvinceRepository.Delete(province);
            if (result > 0)
                return RedirectToAction("Index");
            return View();
        }
    }
}
