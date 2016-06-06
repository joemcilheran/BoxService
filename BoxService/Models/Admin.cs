﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoxService.Models
{
    public class Admin
    {
        [Key]
        public int? ID { get; set; }
        [Display(Name = "Number of Accounts")]
        public int? NumberOfAccounts { get; set; }
        [Display(Name = "Total Paid Monthly")]
        public double? MonthlyTotal { get; set; }
        [Display(Name = "Customers with Box of Terrible Beers")]
        public double? PercentTerribleBeers { get; set; }
        [Display(Name = "Customers with Box of Wonderful Beers")]
        public double? PercentWonderfulBeers { get; set; }
        [Display(Name = "Customers with Box of Terrible Wines")]
        public double? PercentTerribleWines { get; set; }
        [Display(Name = "Customers with Box of Wonderful Wines")]
        public double? PercentWonderfulWines { get; set; }
    }
}