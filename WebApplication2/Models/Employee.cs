using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Display(Name = "EmployeeId")]

        public string name { get; set; }
        [Display(Name = "name")]

        public DateTime StartDate { get; set; }
        [Display(Name = "StartDate")]

        public string grade { get; set; }
        [Display(Name = "grade")]

        public string Salary { get; set; }
        [Display(Name = "Salary")]

        public string color { get; set; }
        [Display(Name = "color")]

        public string weight { get; set; }
        [Display(Name = "weight")]

        public string ChildrenTotal { get; set; }
        [Display(Name = "ChildrenTotal")]

        public string Address { get; set; }
        [Display(Name = "Address")]

        //Relationship
        public string LeaderId { get; set; }
        [ForeignKey("LeaderId")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
