using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoxService.Models
{
    public class Survey
    {
        [Key]
        public int SurveyID{ get; set; }

        [Display(Name = "Do you like Beer or Wine?")]
        public DrinkAnswer Question1 { get; set; }

        [Display(Name = "Do you like Terrible or Wonderful?")]
        public LoveOrHateAnswer Question2 { get; set; }



        

    }
    public enum DrinkAnswer
    {
        Beer,
        Wine 
    }
    public enum LoveOrHateAnswer
    {
        Terrible,
        Wonderful
    }
}