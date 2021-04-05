using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Combis.Models
{
    public class Contact
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string firstname { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string lastname { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string email { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string mobilephone { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string address { get; set; }
    }
}
