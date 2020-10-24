using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FindsExplorer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FindsExplorer.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }
        public string AboutUser { get; set; }
        public string Location { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Display(Name = "Имя пользователя")]
            public string UserName { get; set; }
            [Phone]
            [Display(Name = "Номер телефона")]
            public string PhoneNumber { get; set; }

            [DataType(DataType.MultilineText)]
            [Display(Name = "О пользователе")]
            public string AboutUser { get; set; }
            [Display(Name = "Откуда")]
            public string Location { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var aboutUser = (await _userManager.FindByNameAsync(userName)).AboutUser;
            var location = (await _userManager.FindByNameAsync(userName)).Location;

            Username = userName;
            AboutUser = aboutUser;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                AboutUser = aboutUser,
                Location = location            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Ошибка при попытке установить номер телефона.";
                    return RedirectToPage();
                }
            }

            var aboutUser = (await _userManager.FindByIdAsync(user.Id)).AboutUser;
            if (Input.AboutUser != aboutUser)
            {
                user.AboutUser = Input.AboutUser;
                var updateResult = await _userManager.UpdateAsync(user);
                if (!updateResult.Succeeded)
                {
                    StatusMessage = "Ошибка при попытке изменить поле \"О пользователе\".";
                    return RedirectToPage();
                }
            }

            var location = (await _userManager.FindByIdAsync(user.Id)).Location;
            if (Input.Location != location)
            {
                user.Location = Input.Location;
                var updateResult = await _userManager.UpdateAsync(user);
                if (!updateResult.Succeeded)
                {
                    StatusMessage = "Ошибка при попытке изменить поле \"О пользователе\".";
                    return RedirectToPage();
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Ваш профиль изменён";
            return RedirectToPage();
        }
    }
}
