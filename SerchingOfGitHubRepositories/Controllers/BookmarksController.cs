using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SerchingOfGitHubRepositories.Models;

namespace SerchingOfGitHubRepositories.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookmarksController : ControllerBase
    {
        [HttpGet]
        public bool AddRepository( [FromQuery]string url)
        {
            if (url == null || url.Length == 0)
                return false;
            if (!Bookmark.Bookmarks.Contains(url))
            {
                Bookmark.Bookmarks.Add(url);
            }

            return true;
        }
    }
}