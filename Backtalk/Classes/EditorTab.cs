namespace Backtalk.Classes
{
    public class EditorTab
    {
        public string key { get; set; } = Guid.NewGuid().ToString();
        public ApiEndpoint? endpoint { get; set; }
        public string tabName { get; set; } = "";
        public bool active { get; set; } = false;
    }
}
