using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecipeRepo.Models;

namespace RecipeRepo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly RecipeContext _context;

        public RecipesController(RecipeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Recipe> Get()
        {
            return _context.Recipes.ToArray();
        }

        [HttpGet("{id:int}")]
        public Recipe Get(int id)
        {
            return _context.Recipes.FirstOrDefault(m => m.RecipeId == id);
        }
    }
}
