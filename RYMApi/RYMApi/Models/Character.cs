﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYMApi.Models
{
    

    public class Origin
    {
        public string name { get; set; }
        public DateTime url { get; set; }

    }
    public class Location
    {
        public string name { get; set; }
        public DateTime url { get; set; }

    }
    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string species { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public Origin origin { get; set; }
        public Location location { get; set; }
        public string image { get; set; }
        public IList<string> episode { get; set; }
        public DateTime url { get; set; }
        public DateTime created { get; set; }

    }
}
