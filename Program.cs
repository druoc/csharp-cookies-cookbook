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

            }
        }
    }
}