using Microsoft.AspNetCore.Mvc;
using SIBKMNET_WebApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKMNET_WebApp.Controllers
{
    public class RegionController : Controller
    {
        MyContext myContext;
        public RegionController(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public IActionResult Index()
        {
            var data = myContext.Regions.ToList();
            return View(data);
        }
    }
}
