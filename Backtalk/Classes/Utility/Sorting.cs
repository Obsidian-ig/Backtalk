using Backtalk.Classes.ProjectData;

namespace Backtalk.Classes.Utility
{
    public static class Sorting
    {
        /*SORTING ENDPOINTS AND FOLDERS*/
        public static List<ApiEndpoint> SortEndpointsByName(List<ApiEndpoint> endpoints, bool reversed = false)
        {
            var sortedList = endpoints;
            if (!reversed)
            {
                sortedList.Sort((x, y) => x.name.CompareTo(y.name));
            }
            else
            {
                sortedList = sortedList.OrderByDescending(x => x.name).ToList();
            }
            return sortedList;
        }
        public static List<ApiEndpoint> SortEndpointsByType(List<ApiEndpoint> endpoints, bool reversed = false)
        {
            var sortedList = endpoints;
            if (!reversed)
            {
                sortedList.Sort((x, y) => x.method.CompareTo(y.method));
            }
            else
            {
                sortedList = sortedList.OrderByDescending(x => x.method).ToList();
            }
            return sortedList;
        }
        public static List<ApiEndpoint> SortEndpointsByCreationDate(List<ApiEndpoint> endpoints, bool reversed = false)
        {
            var sortedList = endpoints;
            if (!reversed)
            {
                sortedList = sortedList.OrderBy(x => x.created_at_utc).ToList();
            }
            else
            {
                sortedList = sortedList.OrderByDescending(x => x.created_at_utc).ToList();
            }
            return sortedList;
        }
        public static List<ApiEndpoint> SortEndpointsByLastModifiedDate(List<ApiEndpoint> endpoints, bool reversed = false)
        {
            var sortedList = endpoints;
            if (!reversed)
            {
                sortedList = sortedList.OrderBy(x => x.last_updated_utc).ToList();
            }
            else
            {
                sortedList = sortedList.OrderByDescending(x => x.last_updated_utc).ToList();
            }
            return sortedList;
        }
        public static List<ProjectFolder> SortFoldersByName(List<ProjectFolder> Folders, bool reversed = false)
        {
            var sortedList = Folders;
            if (!reversed)
            {
                sortedList.Sort((x, y) => x.name.CompareTo(y.name));
            }
            else
            {
                sortedList = sortedList.OrderByDescending(x => x.name).ToList();
            }
            return sortedList;
        }
        public static List<ProjectFolder> SortFoldersByCreationDate(List<ProjectFolder> Folders, bool reversed = false)
        {
            var sortedList = Folders;
            if (!reversed)
            {
                sortedList = sortedList.OrderBy(x => x.created_at_utc).ToList();
            }
            else
            {
                sortedList = sortedList.OrderByDescending(x => x.created_at_utc).ToList();
            }
            return sortedList;
        }
        public static List<ProjectFolder> SortFoldersByLastModifiedDate(List<ProjectFolder> Folders, bool reversed = false)
        {
            var sortedList = Folders;
            if (!reversed)
            {
                sortedList = sortedList.OrderBy(x => x.last_updated_utc).ToList();
            }
            else
            {
                sortedList = sortedList.OrderByDescending(x => x.last_updated_utc).ToList();
            }
            return sortedList;
        }
        public static List<ProjectFolder> SortFoldersByEndpointCount(List<ProjectFolder> Folders, bool reversed = false)
        {
            var sortedList = Folders;
            if (!reversed)
            {
                sortedList = sortedList.OrderBy(x => x.endpoints.Count).ToList();
            }
            else
            {
                sortedList = sortedList.OrderByDescending(x => x.endpoints.Count).ToList();
            }
            return sortedList;
        }
        /*END OF ENDPOINTS AND FOLDERS SORTING*/
    }
}
