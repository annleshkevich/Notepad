using Notepad.Data.Models;
namespace Notepad.Data.Interfaces
{
    public interface IAllToDoLists
    {
        IEnumerable<Do> Actions { get; }
        Do GetAction(DateTime date);
        Do GetAction(bool status);
    }
}
