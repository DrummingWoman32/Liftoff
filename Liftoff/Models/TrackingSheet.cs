﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liftoff.Models
{
    public class TrackingSheet
    {
        public string date { get; set; }

        //a tracking sheet is basically a list of businesses and their info...
        List<Business> businesses { get; set; }
        public int ID { get; set; }

        //at some point I might wanna look into IList...it was used in CheeseMVCPersistent

        


    }
}
