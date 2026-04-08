using CloudNimble.BlazorEssentials.IndexedDb;
using Microsoft.JSInterop;

namespace Backtalk.Classes.Data
{
    public class AppDb : IndexedDbDatabase
    {
        // REMEMBER TO CHANGE THE VERSION OF THE DATABASE (+1)
        // IF YOU ADD ANOTHER OBJECTSTORE FOR STORING SOMETHING ELSE OTHER THAN USER PROJECTS 

        [ObjectStore(Name = "projects", AutoIncrementKeys = false)]
        public IndexedDbObjectStore Projects { get; set; }

        [ObjectStore(Name = "inbox", AutoIncrementKeys = false)]
        public IndexedDbObjectStore Inbox { get; set; }

        public AppDb(IJSRuntime jsRuntime) : base(jsRuntime)
        {
            Name = "BacktalkDb";
            Version = 2;
        }
    }
}
