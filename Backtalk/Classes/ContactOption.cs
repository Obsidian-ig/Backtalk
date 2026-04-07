namespace Backtalk.Classes
{
    public class ContactOption
    {
        public int index { get; set; }
        public Guid key { get; set; } = Guid.NewGuid();
        public string contact_name { get; set; } = "";
        public string contact { get; set; } = "";
        public string method { get; set; } = "";
    }
}
