using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sports_system.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Father_Name { get; set; }
        public string Reg_NO { get; set; }
        public string age { get; set; }
        public string department { get; set; }
        public string Program { get; set; }
        public int Contact { get; set; }
        public string Address { get; set; }
    }
}