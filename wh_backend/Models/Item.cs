using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace wh_backend.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string name { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string description { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int category { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string section { get; set; }
    }
}
