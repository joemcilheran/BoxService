﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoxService.Models
{
    public class Box
    {
        [Key]
        public int BoxID { get; set; }

        public string Name { get; set; }
        public string  Description { get; set; }
        public double Price { get; set; }
    }
}