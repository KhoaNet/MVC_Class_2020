using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dao.Model
{
    //06/01/2020 
    // Table Shoe
    [Table("Shoes")]
     public class ShoeModel
    {
        [Key]
        public int Id { get; set; }
        public string ShoeName { get; set; }
        public int SizeShoe { get; set; }
        public string ShoeImg { get; set; }
        public int ShoeCateId { get; set; }
        public string ShoeDesc { get; set; }

        public int Status { get; set; }
        public int CreateId { get; set; }
        public DateTime CreateDate { get; set; }
        public int Updateid { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
