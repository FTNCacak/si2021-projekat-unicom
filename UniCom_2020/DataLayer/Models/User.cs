﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string username { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Year_of_Birth { get; set; }
    }
}
