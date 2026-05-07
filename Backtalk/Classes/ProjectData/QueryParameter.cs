namespace Backtalk.Classes.ProjectData
{
    public class QueryParameter
    {
        public required string name { get; set; }
        public required string type { get; set; }
        public string? example { get; set; }
        public bool required { get; set; }
    }
}
