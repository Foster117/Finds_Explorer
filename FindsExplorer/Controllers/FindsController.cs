using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindsExplorer.Data;
using FindsExplorer.Models;
using FindsExplorer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FindsExplorer.Controllers
{
    public class FindsController : Controller
    {
        private readonly IFindsService _service;
        public FindsController(ApplicationDbContext context)
        {
            _service = new FindsService(context);
        }

        [Authorize]
        public IActionResult UploadFind()
        {
            string[] materials = _service.GetAllMaterials();
            string[] periods = _service.GetAllPeriods();
            ViewBag.MaterialsSelectList = new SelectList(materials, materials[0]);
            ViewBag.PeriodsSelectList = new SelectList(periods, periods[0]);
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult UploadFind(FindUploadingModel find)
        {
            if (!_service.CheckMaterial(find.Material))
            {
                ModelState.AddModelError(nameof(find.Material), "Некорректное значение поля");
            }
            if (!_service.CheckPeriod(find.Period))
            {
                ModelState.AddModelError(nameof(find.Period), "Некорректное значение поля");
            }

            if (ModelState.IsValid)
            {
                _service.AddFind(find);
                return View("Home/Index");
            }
            else
            {
                string[] materials = _service.GetAllMaterials();
                string[] periods = _service.GetAllPeriods();
                ViewBag.MaterialsSelectList = new SelectList(materials, materials[0]);
                ViewBag.PeriodsSelectList = new SelectList(periods, periods[0]);
                return View();
            }

        }
    }
}
