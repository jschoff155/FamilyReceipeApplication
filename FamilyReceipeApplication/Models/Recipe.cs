namespace FamilyReceipeApplication.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public string RecipeIngredients { get; set; }
        public string RecipeInstructions { get; set; }
        public string RecipeMealType { get; set; }
        public string RecipeCusineType { get; set; }

        public Recipe()
        {
            
        }
    }
}
