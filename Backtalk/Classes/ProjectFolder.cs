namespace Backtalk.Classes
{
    public class ProjectFolder
    {
        public required string name { get; set; }
        public List<int> endpoints { get; set; } = new List<int>();
    }
}
