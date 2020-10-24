using System;
using System.Collections.Generic;
using System.Text;
using FindsExplorer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FindsExplorer.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Period> Periods { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Find> Finds { get; set; }
    }

    public class Find
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public int PeriodId { get; set; }
        public int MaterialId { get; set; }
        public string  FindName { get; set; }
        public DateTime UploadDate { get; set; }
        public string Description { get; set; }
        public string Preview { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
        public ApplicationUser Owner { get; set; }
        public Period Period { get; set; }
        public Material Material { get; set; }
    }

    public class Material
    {
        public int Id { get; set; }
        public string MaterialName { get; set; }
    }
    public class Period
    {
        public int Id { get; set; }
        public string PeriodName { get; set; }
    }
}
