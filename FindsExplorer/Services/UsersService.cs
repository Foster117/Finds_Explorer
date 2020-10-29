using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using FindsExplorer.Models;

namespace FindsExplorer.Services
{
    public class UsersService : IUsersService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UsersService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IEnumerable<string> FindByName(string name, int offset, int take, out bool isNextVisible)
        {
            List<string> findedNamesX2 = _userManager.Users.Where(x => x.UserName.Contains(name))
                .Select(_ => _.UserName).Skip(offset).Take(take * 2).ToList();
            List<string> findedNames = findedNamesX2.Take(take).ToList();
            List<string> check = findedNamesX2.Skip(take).ToList();
            if (check.Count == 0)
            {
                isNextVisible = false;
            }
            else
            {
                isNextVisible = true;
            }
            return findedNames;
        }

        public IEnumerable<string> GetAllUserNames(int offset, int take, out bool isNextVisible)
        {
            List<string> userNamesX2 = _userManager.Users.Select(_ => _.UserName).Skip(offset).Take(take * 2).ToList();
            List<string> userNames = userNamesX2.Take(take).ToList();
            List<string> check = userNamesX2.Skip(take).ToList();
            if (check.Count == 0)
            {
                isNextVisible = false;
            }
            else
            {
                isNextVisible = true;
            }
            return userNames;
        }

        public ApplicationUser GetUserByName(string name)
        {
            ApplicationUser user = _userManager.FindByNameAsync(name).Result;
            return user;
        }
    }
}
