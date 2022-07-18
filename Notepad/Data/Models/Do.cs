namespace Notepad.Data.Models
{
    public class Do
    {
        public string name { get; set; }
        public bool status { get; set; }
        public DateTime date { get; set; }
        public Do(string name, bool status, DateTime date)
        {
            this.name = name;
            this.status = status;
            this.date = date;
        }   
    }
}
