﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp5ByNishan.Controllers
{
    public class HiddenFieldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HiddenFieldPage(IFormCollection collection)
        {
            var hiddenData = collection["myHiddenData"];
            ViewBag.hiddenData = hiddenData;
            return View();
        }
    }
}