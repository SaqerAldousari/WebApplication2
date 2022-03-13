using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Survey
    {
        [Key]        
        public int SurveyId { get; set; }
        [Display(Name ="Title")]
        public string title { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Start Date")]
        public DateTime startdate { get; set; }
        [Display(Name = "Answered Date")]
        public DateTime AnswerDate { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        //Realationship
        public string LeaderId { get; set; }
        [ForeignKey("LeaderId")]
        public ApplicationUser Leader { get; set; }
        public string AdminId { get; set; }
        [ForeignKey("AdminId")]
        public ApplicationUser Admin { get; set; }
    }
}
