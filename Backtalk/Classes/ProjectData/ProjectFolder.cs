namespace Backtalk.Classes.ProjectData
{
    public class ProjectFolder
    {
        public string name { get; set; } = "Folder Name";
        public List<string> endpoints { get; set; } = new(); //list of all the included endpoints guids
        public DateTime created_at_utc { get; set; } = DateTime.UtcNow;
        public DateTime last_updated_utc { get; set; } = DateTime.UtcNow;
        public ExplorerDisplayOption? endpoints_display_option { get; set; } = null;
        public bool changingName { get; set; } = false;
    }
}
