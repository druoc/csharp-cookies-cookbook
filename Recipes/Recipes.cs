﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients { get; }

        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }
    }

    public abstract class Ingredient
    {
        public abstract int Id { get; }
        public abstract string Name { get; }
        public virtual string PreparationInstructions => "Add to other ingredients";
    }

    public abstract class Flour : Ingredient
    {
        public override string PreparationInstructions => $"Sieve. Add to other ingredients";
    }


    public class WheatFlour : Flour
    {
        public override int Id => 1;
        public override string Name => "Wheat flour";
    }

    public class SpeltFlour : Flour
    {
        public override int Id => 2;
        public override string Name => "Spelt flour";
    }

    public class Butter : Ingredient
    {
        public override int Id => 3;
        public override string Name => "Butter";
        public override string PreparationInstructions => $"Melt on low heat. Add to other ingredients";
    }

    public class Chocolate : Ingredient
    {
        public override int Id => 4;
        public override string Name => "Chocolate";
        public override string PreparationInstructions => $"Melt in a water beth. Add to other ingredients";
    }

    public class Sugar : Ingredient
    {
        public override int Id => 5;
        public override string Name => "Sugar";
    }

    public class Cardamom : Ingredient
    {
        public override int Id => 6;
        public override string Name => "Cardamom";
        public override string PreparationInstructions => $"Add half a teaspoon to other ingredients";
    }

    public class Cinnamon : Ingredient
    {
        public override int Id => 7;
        public override string Name => "Cinnamon";
        public override string PreparationInstructions => $"Add half a teaspoon to other ingredients";
    }

    public class CocoaPowder : Ingredient
    {
        public override int Id => 8;
        public override string Name => "Cocoa powder";
    }
}

