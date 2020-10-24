using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FindsExplorer.Models
{
    public class ApplicationUser : IdentityUser
    {
        [DataType(DataType.MultilineText)]
        public string Location { get; set; }
        public string AboutUser { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
