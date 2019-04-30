using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SerchingOfGitHubRepositories.Models;
using System.Web;

namespace SerchingOfGitHubRepositories.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookmarksController : ControllerBase
    {
        [HttpGet]
        public bool AddRepository( [FromQuery]string url, [FromQuery] string id )
        {
            if (string.IsNullOrEmpty(url)|| string.IsNullOrEmpty(id))
                return false;
            HttpContext.Session.SetString(id, url);
            return true;
        }
    }
}