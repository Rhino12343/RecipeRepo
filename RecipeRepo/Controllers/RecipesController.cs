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
        [HttpGet]
        public IEnumerable<Recipe> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Recipe
            {
                Name = "Recipe no: " + index.ToString(), Ingredients = "ingredients of recipe no: " + index.ToString(), Instructions = "instructions of recipe no: " + index.ToString()
            })
            .ToArray();
        }
    }
}
