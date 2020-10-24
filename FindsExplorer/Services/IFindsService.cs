using FindsExplorer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindsExplorer.Services
{
    public interface IFindsService
    {
        void AddFind(FindUploadingModel find);
        string[] GetAllMaterials();
        string[] GetAllPeriods();
        bool CheckMaterial(string material);
        bool CheckPeriod(string period);
    }
}
