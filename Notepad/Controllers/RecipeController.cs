using Microsoft.AspNetCore.Mvc;
using Notepad.Data.Interfaces;
using Notepad.ViewModels;

namespace Notepad.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IAllRecipes _allRecipes;
        private readonly IAllToDoLists _allToDoLists;
        private readonly IAllProductsLists _allProducts;
        public RecipeController(IAllRecipes iAllRecipes)
        {
            _allRecipes = iAllRecipes;;
        }
        public ViewResult ListRecipes()
        {
            ViewBag.Title = "recipe page";
            RecipeListViewModel objR = new RecipeListViewModel();
            objR.allRecipes = _allRecipes.Recipes;
            return View(objR);
        }
    }
}
