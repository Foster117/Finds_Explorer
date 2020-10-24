using FindsExplorer.Data;
using FindsExplorer.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageResizer;

namespace FindsExplorer.Services
{
    public class FindsService : IFindsService
    {
        private readonly ApplicationDbContext _context;
        public FindsService(ApplicationDbContext context)
        {
            _context = context;
        }


        public void AddFind(FindUploadingModel find)
        {
            
        }


        public string[] GetAllMaterials()
        {
            return _context.Materials.Select(_ => _.MaterialName).ToArray();
        }
        public string[] GetAllPeriods()
        {
            return _context.Periods.Select(_ => _.PeriodName).ToArray();
        }
        public bool CheckMaterial(string material)
        {
            Material check = _context.Materials.Where(_ => _.MaterialName == material).FirstOrDefault();
            return check != null;
        }
        public bool CheckPeriod(string period)
        {
            Period check = _context.Periods.Where(_ => _.PeriodName == period).FirstOrDefault();
            return check != null;
        }
    }
}
