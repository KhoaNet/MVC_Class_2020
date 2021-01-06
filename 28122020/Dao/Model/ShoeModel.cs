using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dao.Model
{
    [Table("Shoes")]
    public class ShoeModel
    {
        [Key]
        public int ShoeId { get; set; }
        public string ShoeName { get; set; }
        public string ShoeImg { get; set; }
    }
}
