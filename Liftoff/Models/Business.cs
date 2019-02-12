using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liftoff.Models
{
    public class Business
    {
        public string name { get; set; }
        public int address_number { get; set; }
        public string street { get; set; }
        public string spoke_with { get; set; }
        public string DM_name { get; set; }
        public bool not_qualified = false;  //default value
        //there are two other columns labeled DMS and DMP, but I never understood really what they 
        //were about...another column is the $$ column, I don't know what that one was about either
        public string Fab5_notes { get; set; }
    }
}
