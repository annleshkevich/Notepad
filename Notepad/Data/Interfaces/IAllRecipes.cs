using Notepad.Data.Models;

namespace Notepad.Data.Interfaces
{
    public interface IAllRecipes
    {
        IEnumerable<Recipe> Recipes { get; }
        Recipe GetRecipe(string name);
    }
}
