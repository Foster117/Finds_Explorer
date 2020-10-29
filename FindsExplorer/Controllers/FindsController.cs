using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindsExplorer.Data;
using FindsExplorer.Models;
using FindsExplorer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FindsExplorer.Controllers
{
    public class FindsController : Controller
    {
        private readonly IFindsService _service;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _environment;
        private const int _findsToListQuantity = 20;
        public FindsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IWebHostEnvironment environment)
        {
            _service = new FindsService(context);
            _userManager = userManager;
            _environment = environment;
        }

        public IActionResult AllFinds()
        {
            return View();
        }

        //AJAX
        public IActionResult GetAllFinds(int offset = 0, int take = _findsToListQuantity)
        {
            if (take < _findsToListQuantity)
            {
                ViewBag.ErrorMessage = "Недопустимое значение переменной 'take'.";
                return PartialView("_AjaxError");
            }
            if (offset < 0)
            {
                ViewBag.ErrorMessage = "Недопустимое значение переменной 'offset'.";
                return PartialView("_AjaxError");
            }
            List<AllFindsModel> finds = _service.GetAllFinds(offset, take, out bool isNextVisible);
            ViewBag.AllFindsQuantity = _findsToListQuantity;
            ViewBag.Offset = offset;
            ViewBag.IsNextVisible = isNextVisible;
            return PartialView("_AllFinds", finds);
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
                _service.AddFind(find, _userManager.GetUserId(User), _environment);
                return RedirectToAction("MyFinds");
            }
            else
            {
                string[] materials = _service.GetAllMaterials();
                string[] periods = _service.GetAllPeriods();
                ViewBag.MaterialsSelectList = new SelectList(materials, find.Material);
                ViewBag.PeriodsSelectList = new SelectList(periods, find.Period);
                return View();
            }

        }

        [Authorize]
        public IActionResult MyFinds()
        {
            return View();
        }
    }
}
