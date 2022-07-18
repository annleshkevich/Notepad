using Microsoft.AspNetCore.Mvc;
using Notepad.Data.Models;

namespace Notepad.ViewModels
{
    public class ToDoListViewModel : Controller
    {
         public IEnumerable<Do> allToDoList { get; set; }
    }
}
