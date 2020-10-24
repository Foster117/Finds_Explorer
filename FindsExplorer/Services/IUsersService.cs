using FindsExplorer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindsExplorer.Services
{
    interface IUsersService
    {
        IEnumerable<string> GetAllUserNames(int offset, int take, out bool isNextVisible);
        IEnumerable<string> FindByName(string name, int offset, int take, out bool isNextVisible);
        ApplicationUser GetUserByName(string name);
    }
}
