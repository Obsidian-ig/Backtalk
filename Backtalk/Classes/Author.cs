namespace Backtalk.Classes
{
    public class Author
    {
        public int index { get; set; }
        public Guid key { get; set; } = Guid.NewGuid();
        public string name { get; set; } = "";
        public string? pfp_b64 { get; set; }
        public string? role { get; set; }
        public string? discord_url { get; set; }
        public string? github_url { get; set; }
        public string? youtube_url { get; set; }
        public string? description { get; set; }
        public string? other_contact_info { get; set; }
    }
}
