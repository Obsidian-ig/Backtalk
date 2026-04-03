namespace Backtalk.Classes
{
    public class ApiResponse
    {
        public required int status_code { get; set; }
        public string? condition { get; set; }
        public string? message { get; set; }
        public string? response { get; set; }
    }
}
