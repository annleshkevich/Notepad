using Notepad.Data.Interfaces;
using Notepad.Data.Models;

namespace Notepad.Data.Mocks
{
    public class MockRecipe : IAllRecipes
    {
        public List<Ingredient> ingredients1 = new() { 
            new Ingredient ("Milk", "350 ml"),
            new Ingredient ("Eggs","2 pcs"),
            new Ingredient ("Flour", "130 g"),
            new Ingredient ("Sugar", "40 g"),
            new Ingredient ("Salt", "0.33 tsp"),
            new Ingredient ("Sunflower oil", "2 tbsp") };
        public List<Ingredient> ingredients2 = new()
        {
            new Ingredient ("Cheese", "300 g"),
            new Ingredient ("Egg","1 pcs"),
            new Ingredient ("Sunflower oil", "70 ml"),
            new Ingredient ("Flour", "30 g")
        };

        public IEnumerable<Recipe> Recipes
        {
            get
            {
                return new List<Recipe>
                {
                    new Recipe ("Pancakes", "All the ingredients are mixed together and then fried in a heated frying pan.", ingredients1),
                    new Recipe ( "Сheese sticks", "Grate cheese on a fine grater, add flour, egg. Stir to mix. " +
                        "Form cheese sticks. Fry in vegetable oil.", ingredients2)
                };
            }
        }

        public Recipe GetRecipe(string name)
        {
            throw new NotImplementedException("");
        }
    }
}
