using Notepad.Data.Interfaces;
using Notepad.Data.Models;

namespace Notepad.Data.Mocks
{
    public class MockAction : IAllToDoLists
    {
        public IEnumerable<Do> Actions
        {
            get
            {
                return new List<Do>
                {
                    new Do ("Pet the cat", true,  new DateTime(2022, 07, 08)),
                    new Do ("Pet the dog", true,  new DateTime(2022, 07, 09)),
                    new Do ("Buy an aquarium", false,  new DateTime(2022, 07, 09)),
                };
            }
        }

        public Do GetAction(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Do GetAction(bool status)
        {
            throw new NotImplementedException();
        }
    }
}
