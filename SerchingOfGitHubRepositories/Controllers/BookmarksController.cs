using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SerchingOfGitHubRepositories.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookmarksController : ControllerBase
    {
        public static List<string> Bookmarks=new List<string> ();


        [HttpGet]
        public bool AddRepository( [FromQuery]string url)
        {
            if (url == null || url.Length == 0)
                return false;
            if (!Bookmarks.Contains(url))
            {
                Bookmarks.Add(url);
            }

            return true;
        }
    }
}