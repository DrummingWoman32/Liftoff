using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Liftoff.Models
{
    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        public int areaCode { get; set; }
        public int ID { get; set; }
        public int sourceCode { get; set; }
        //public List<TrackingSheet> trackingSheets {get; set;}
        public IEnumerable<TrackingSheet> trackingSheets { get; set; }
    }
}
