namespace Backtalk.Classes
{
    public class ApiEndpoint
    {
        public required int key { get; set; }
        public string endpoint { get; set; } = "https://example.com/api/example";
        public string method { get; set; } = "GET";
        public string tag { get; set; } = "DEV";
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

    }
}