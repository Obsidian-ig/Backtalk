namespace Backtalk.Classes
{
    public class ApiEndpoint
    {
        public string key { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; } = "";
        public string endpoint { get; set; } = "https://example.com/api/example";
        public string method { get; set; } = "GET";
        public List<string> tags { get; set; } = new();
        public List<QueryParameter>? query_parameters { get; set; }
        public List<Header>? headers { get; set; } = new List<Header>()
        {
            new Header()
            {
                name = "Content-Type",
                value = "application/json"
            }
        };
        public string? body { get; set; }
        public List<ApiResponse> responses { get; set; } = new List<ApiResponse>();
        public DateTime created_at_utc { get; set; } = DateTime.UtcNow;
        public DateTime last_updated_utc { get; set; } = DateTime.UtcNow;
    }
}