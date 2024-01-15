namespace CookiesCookbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cookiesRecipeApp = new CookiesRecipeApp();
            cookiesRecipeApp.Run();
        }

        class CookiesRecipeApp
        {
            private readonly RecipeRepository _recipeRepository;
            private readonly RecipeUserInteraction _recipeUserInteraction;

            public CookiesRecipeApp(RecipeRepository recipeRepository, RecipeUserInteraction recipeUserInteraction)
            {
                _recipeRepository = recipeRepository;
                _recipeUserInteraction = recipeUserInteraction;
            }

            public void Run()
            {
                var allRecipes = _recipeRepository.Read(filePath);
                _recipeUserInteraction.PrintExistingRecipes(allRecipes);

                _recipeUserInteraction.PromptToCreateRecipe();

                var ingredients = _recipeUserInteraction.ReadIngredientsFromUser();

                if(ingredients.Count > 0)
                {
                    var recipes = new CookiesRecipeApp(ingredients);
                    allRecipes.Add(recipes);
                    _recipeRepository.Write(filePath, allRecipes);

                    _recipeUserInteraction.ShowMessage("Recipe added.");
                    _recipeUserInteraction.ShowMessage(recipe.ToString());
                }
                else
                {
                    _recipeUserInteraction.ShowMessage(
                        "No ingredients selected." + "Recipe will not be saved");
                }
                _recipeUserInteraction.Exit();
            }
        }
    }
}