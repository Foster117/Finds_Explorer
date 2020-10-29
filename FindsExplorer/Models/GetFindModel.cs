using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindsExplorer.Models;

namespace FindsExplorer.Models
{
    public class GetFindModel
    {
        public string Id { get; set; }
        public string FindName { get; set; }
        public DateTime UploadDate { get; set; }
        public string Description { get; set; }
        public string OwnerName { get; set; }
        public string Material { get; set; }
        public string  Period { get; set; }
        public string Preview { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
    }
}

