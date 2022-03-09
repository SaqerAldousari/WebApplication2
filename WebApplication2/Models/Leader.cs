using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Leader
    {
        [Key]
        public int LeaderId { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}
