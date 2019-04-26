using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerchingOfGitHubRepositories.Models
{
    public class Bookmark
    {
        public static List<string> Bookmarks = new List<string>();

        public string  Url { get; set; }
    }
}
