using System.ComponentModel.DataAnnotations;

namespace Backtalk.Classes
{
    public class ProjectData
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string name { get; set; }
        public string? short_description { get; set; }
        public string? description { get; set; }
        public required List<Author> authors { get; set; }
        public List<ContactOption>? contacts { get; set; }
        public DateTime last_updated_utc { get; set; } = DateTime.UtcNow;
        public required string api_version { get; set; } = "1.0.0";
        public required ProjectConfig config { get; set; }
        public int endpoints_count { get; set; } = 0;
        public int get_count { get; set; } = 0;
        public int post_count { get; set; } = 0;
        public int put_count { get; set; } = 0;
        public int patch_count { get; set; } = 0;
        public int delete_count { get; set; } = 0;
        public List<ProjectFolder> folders { get; set; } = new List<ProjectFolder>();
        public string status_endpoint { get; set; } = "";
        public List<ApiEndpoint> api_endpoints { get; set; } = new List<ApiEndpoint>()
        {
            new ApiEndpoint()
            {
                key = 0
            }
        };
    }
}
