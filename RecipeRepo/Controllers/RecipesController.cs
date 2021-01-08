using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using RecipeRepo.Models;
using Microsoft.EntityFrameworkCore;
using RecipeRepo.Views.Recipes;

namespace RecipeRepo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : Controller
    {
        private readonly RecipeContext _context;

        public RecipesController(RecipeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Title = "testing";
            IList<Recipe> model = _context.Recipes.ToList();

            return View(model);
        }

        [HttpGet("Edit/{id:int}")]
        public ActionResult Edit(int? id)
        {
            Recipe model = _context.Recipes.Find(id);
            return View(model);
        }

        [HttpPost("Edit/{id:int}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Recipe recipe)
        {
            System.Diagnostics.Debugger.Break();
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("Details/{id:int}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet("Delete/{id:int}")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpGet("all")]
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
