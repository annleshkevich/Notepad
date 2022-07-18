using Microsoft.AspNetCore.Mvc;
using Notepad.Data.Interfaces;
using Notepad.ViewModels;

namespace Notepad.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly IAllToDoLists _allToDoLists;
        public ToDoListController(IAllToDoLists iAllToDoLists)
        {
            _allToDoLists = iAllToDoLists; ;
        }
        public ViewResult ListRecipes()
        {
            ViewBag.Title = "To Do Lists ";
            ToDoListViewModel objTD = new ToDoListViewModel();
            objTD.allToDoList = _allToDoLists.Actions;
            return View(objTD);
        }
    }
}
