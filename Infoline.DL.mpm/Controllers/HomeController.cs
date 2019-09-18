using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Infoline.DL.mpm.Data;
using Microsoft.AspNetCore.Mvc;
using Infoline.DL.mpm.Models;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace Infoline.DL.mpm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ListResult()
        {

            var context = new mpmContext();
            var resList = context.Set<Data.Entities.mpm>().ToList();

            var model = new HomeListViewModel()
            {
                Mpms = resList
            };
            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
