using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassionProjetn106.Models
{
    
    public class Category
    {
        [Key]
       
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}