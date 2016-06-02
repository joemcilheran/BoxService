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

        [Display(Name = "How much do you like Beer?")]
        public Answer Question1 { get; set; }

        [Display(Name = "How much do you like Wine?")]
        public Answer Question2 { get; set; }

        [Display(Name = "How much do you like terrible things?")]
        public Answer Question3 { get; set; }
        
        [Display(Name = "How much do you like wonderful things?")]
        public Answer Question4 { get; set; }
        [ForeignKey("asp.netusers")]
        [Column(Order = 12)]
        public string UserID { get; set; }

    }
    public enum Answer
    {
        Love,
        Like,
        Apathetic,
        Dislike,
        Hate  
    }
}