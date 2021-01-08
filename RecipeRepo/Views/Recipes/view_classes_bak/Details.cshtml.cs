using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipeRepo.Models;

namespace RecipeRepo.Views.Recipes
{
    public class DetailsModel : PageModel
    {
        private readonly RecipeRepo.Models.RecipeContext _context;

        public DetailsModel(RecipeRepo.Models.RecipeContext context)
        {
            _context = context;
        }

        public Recipe Recipe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipes.FirstOrDefaultAsync(m => m.RecipeId == id);

            if (Recipe == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
