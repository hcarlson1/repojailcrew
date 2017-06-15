using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Test
    {
        
        [Key]
        public int TestId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}