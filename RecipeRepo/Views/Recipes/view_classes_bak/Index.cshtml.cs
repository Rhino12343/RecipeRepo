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
    public class IndexModel : PageModel
    {
        private readonly RecipeRepo.Models.RecipeContext _context;

        public IndexModel(RecipeRepo.Models.RecipeContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipes { get; set; }

        public async Task OnGetAsync()
        {
            Recipes = await _context.Recipes.ToListAsync();
        }
    }
}
