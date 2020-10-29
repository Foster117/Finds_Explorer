using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindsExplorer.Models
{
    public class AllFindsModel
    {
        public string Id { get; set; }
        public string FindName { get; set; }
        public string OwnerName { get; set; }
        public string PeriodName { get; set; }
        public string MaterialName { get; set; }
        public string Preview { get; set; }
    }
}
