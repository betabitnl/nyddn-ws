using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Lab.Pages.Models
{
    public class TodoItem
    {
       
        [Required]
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
    }
}
