using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace webAdmin.Models
{
    public class ViewShoeModelAdd
    {
        [Required]
        [Display(Name ="ShoeName")]
        public string ShoeName { get; set; }

        public IFormFile ShoeImg { get; set; }
    }
}
