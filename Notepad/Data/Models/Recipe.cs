namespace Notepad.Data.Models
{
    public class Recipe
    {
        public string name { get; set; }
        public string description { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public Recipe(string name, string description, List<Ingredient> ingredients)
        {
            this.name= name;
            this.description = description;
            this.ingredients = ingredients;
        }
    }
}
