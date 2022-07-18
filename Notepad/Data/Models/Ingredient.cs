namespace Notepad.Data.Models
{
    public class Ingredient
    {
        public string name { get; set; }
        public string quantities { get; set; }
        public Ingredient(string name, string qualitities)
        {
            this.name = name;   
            this.quantities = qualitities;
            Print();
        }
        public string Print()
        {
            return $"{name} - {quantities}";
        }
    }
}
