using FindsExplorer.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindsExplorer.Services
{
    public interface IFindsService
    {
        void AddFind(FindUploadingModel find, string userId, IWebHostEnvironment environment);
        string[] GetAllMaterials();
        string[] GetAllPeriods();
        bool CheckMaterial(string material);
        bool CheckPeriod(string period);
    }
}
