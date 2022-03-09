using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        //shahad test
    }
}
