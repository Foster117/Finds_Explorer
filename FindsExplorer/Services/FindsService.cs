using FindsExplorer.Data;
using FindsExplorer.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using LazZiya.ImageResize;
using System.Drawing;

namespace FindsExplorer.Services
{
    public class FindsService : IFindsService
    {
        private readonly ApplicationDbContext _context;
        public FindsService(ApplicationDbContext context)
        {
            _context = context;
        }


        public void AddFind(FindUploadingModel find, string userId, IWebHostEnvironment environment)
        {
            string path = environment.WebRootPath + "\\FindsPhotos\\";
            string fileNameBase = Guid.NewGuid().ToString();
            string previewName = fileNameBase + "_pr.jpg";
            string photo1Name = fileNameBase + "_1.jpg";
            string photo2Name = null;
            string photo3Name = null;
            MakeAndSavePreview(find.Photo1, path, previewName);
            ResizeAndSavePhoto(find.Photo1, path, photo1Name);
            if (find.Photo2 != null)
            {
                photo2Name = fileNameBase + "_2.jpg";
                ResizeAndSavePhoto(find.Photo2, path, photo2Name);
            }
            if (find.Photo3 != null)
            {
                photo3Name = fileNameBase + "_3.jpg";
                ResizeAndSavePhoto(find.Photo3, path, photo3Name);
            }

            Find newFind = new Find()
            {
                FindName = find.Name,
                Description = find.Description,
                MaterialId = GetMaterialIdByName(find.Material),
                PeriodId = GetPeriodIdByName(find.Period),
                OwnerId = userId,
                UploadDate = DateTime.Now,
                Preview = previewName,
                Photo1 = photo1Name,
                Photo2 = photo2Name,
                Photo3 = photo3Name
            };
            _context.Finds.Add(newFind);
            _context.SaveChanges();
        }


        private void MakeAndSavePreview(IFormFile image, string path, string filename)
        {
            using Image img = Image.FromStream(image.OpenReadStream());
            img.ScaleAndCrop(60, 60).SaveAs(path + filename);
            img.Dispose();
        }
        private void ResizeAndSavePhoto(IFormFile image, string path, string filename)
        {
            var watermark = Image.FromFile(@"wwwroot\images\watermark_fe.png");
            using Image img = Image.FromStream(image.OpenReadStream());
            img.Scale(800, 800).AddImageWatermark(watermark, 
                new ImageWatermarkOptions() { Location = TargetSpot.BottomRight, Opacity = 50 })
                .SaveAs(path + filename);
            img.Dispose();
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
        private int GetMaterialIdByName(string materialName)
        {
            return _context.Materials.Where(_ => _.MaterialName == materialName).FirstOrDefault().Id;
        }
        private int GetPeriodIdByName(string periodName)
        {
            return _context.Periods.Where(_ => _.PeriodName == periodName).FirstOrDefault().Id;
        }

  
    }
}
