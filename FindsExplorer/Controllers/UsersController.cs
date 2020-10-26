using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindsExplorer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using FindsExplorer.Models;
using System.Threading;

namespace FindsExplorer.Controllers
{
    public class UsersController : Controller
    {
        private const int _usersToListQuantity = 40;
        private readonly IUsersService _usersService;
        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _usersService = new UsersService(userManager);
        }
        /////////////////////////////////////////////////////

        public IActionResult AllUsers()
        {
            return View();
        }
        
        // AJAX
        public IActionResult GetAllUsers(int offset = 0, int take = _usersToListQuantity)
        {
            if (take < _usersToListQuantity)
            {
                ViewBag.ErrorMessage = "Недопустимое значение переменной 'take'.";
                return PartialView("_AjaxError");
            }
            if (offset < 0)
            {
                ViewBag.ErrorMessage = "Недопустимое значение переменной 'offset'.";
                return PartialView("_AjaxError");
            }
            IEnumerable<string> allUserNames = _usersService.GetAllUserNames(offset, take, out bool isNextVisible);
            ViewBag.AllNamesQuantity = _usersToListQuantity;
            ViewBag.Offset = offset;
            ViewBag.IsNextVisible = isNextVisible;
            return PartialView("_AllUsers", allUserNames);
        }

        // AJAX
        public IActionResult FindByName(string name, int offset = 0, int take = _usersToListQuantity)
        {
            if (take < _usersToListQuantity)
            {
                ViewBag.ErrorMessage = "Недопустимое значение переменной 'take'.";
                return PartialView("_AjaxError");
            }
            if (offset < 0)
            {
                ViewBag.ErrorMessage = "Недопустимое значение переменной 'offset'.";
                return PartialView("_AjaxError");
            }
            if (string.IsNullOrEmpty(name))
            {
                return RedirectToAction("GetAllUsers");
            }
            IEnumerable<string> findedNames = _usersService.FindByName(name, offset, take, out bool isNextVisible);
            ViewBag.AllNamesQuantity = _usersToListQuantity;
            ViewBag.LastSearching = name;
            ViewBag.Offset = offset;
            ViewBag.IsNextVisible = isNextVisible;
            return PartialView("_FindByName", findedNames);
        }

        public IActionResult User(string name)
        {
            ApplicationUser user = _usersService.GetUserByName(name);
            return View("User", user);
        }
    }
}
