using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeRepo.Models
{
    public class Recipe
    { 
        public int RecipeId { get; set; }
        [Required]
        [Display(Name="Recipe Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Ingredients")]
        public string Ingredients { get; set; }
        [Required]
        [Display(Name = "Instructions")]
        public string Instructions { get; set; }
    }
}
