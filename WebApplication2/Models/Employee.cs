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
        public string name { get; set; }
        public DateTime StartDate { get; set; }
        public string grade { get; set; }
        public string Salary { get; set; }
        public string color { get; set; }
        public string weight { get; set; }
        public string ChildrenTotal { get; set; }
        public string Address { get; set; }
        //Relationship
        public int LeaderId { get; set; }
        [ForeignKey("LeaderId")]
        public Leader Leader { get; set; }
    }
}
