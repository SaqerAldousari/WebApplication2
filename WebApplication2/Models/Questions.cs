using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Questions
    {
        [Key]
        public int QuestionId { get; set; }
        public int number { get; set; }
        public string type { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        //Relationship
        public int SurveyId { get; set; }
        [ForeignKey("SurveyId")]
        public Survey Survey { get; set; }
    }
}
