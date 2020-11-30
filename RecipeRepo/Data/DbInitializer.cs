using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeRepo.Models;

namespace RecipeRepo.Data
{
    public class DbInitializer
    {
        public static void Initialize (RecipeContext context)
        {
            if (context.Recipes.Any())
            {
                return;
            }

            var recipes = new Recipe[]
            {
                new Recipe{ Name="spaghetti", Ingredients="water, spaghetti", Instructions="just read the packet" },
                new Recipe{ Name="meatballs", Ingredients="microwave meal meatballs", Instructions="read the packet and just shove it in the microwave" },
                new Recipe{ Name="brownies", Ingredients="shoes, socks, clothes, local shop", Instructions="use google to find a local shop and go for a walk to buy some..." },
                new Recipe{ Name="Chips", Ingredients="frozen chips", Instructions="put a portion on a baking tray in a preheated oven till browned and crispy" },
                new Recipe{ Name="Pizza", Ingredients="a smart phone, tablet, or computer", Instructions="place an order with just eat and enjoy a nice chilled night in" },
            };

            foreach (Recipe recipe in recipes)
            {
                context.Recipes.Add(recipe);
            }

            context.SaveChanges();
        }
    }
}
