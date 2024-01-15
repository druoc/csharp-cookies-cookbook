namespace CookiesCookbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cookiesRecipeApp = new CookiesRecipeApp(new RecipeRepository(), new RecipeUserInteraction());

            cookiesRecipeApp.Run();
        }

        public class CookiesRecipeApp
        {
            private readonly IRecipeRepository _recipeRepository;
            private readonly IRecipeUserInteraction _recipeUserInteraction;

            public CookiesRecipeApp(IRecipeRepository recipeRepository, IRecipeUserInteraction recipeUserInteraction)
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

    public interface IRecipeUserInteraction
    {
        void ShowMessage(string message);
        void Exit();
    }

    public interface IRecipeRepository
    {

    }

    public class RecipeUserInteraction : IRecipeUserInteraction
    {
        public void Exit()
        {
            Console.WriteLine("press any key to close");
            Console.ReadKey();
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class RecipeRepository : IRecipeRepository
    {
    }
}