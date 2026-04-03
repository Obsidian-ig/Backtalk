namespace Backtalk.Classes
{
    public class Author
    {
        public required string name { get; set; }
        public string? pfp_b64 { get; set; }
        public string? role { get; set; }
        public string? discord_username { get; set; }
        public string? github_username { get; set; }
        public string? youtube_username { get; set; }
        public string? description { get; set; }
        public string? other_contact_info { get; set; }
    }
}
