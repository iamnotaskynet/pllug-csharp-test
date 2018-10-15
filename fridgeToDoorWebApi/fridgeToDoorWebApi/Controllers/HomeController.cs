
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fridgeToDoorWebApi.Controllers
{
    //[Produces("text/html")]
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
    
        [HttpGet]
        [ActionName("Index")]
        public ContentResult Index()
        {
            var content = System.IO.File.ReadAllText("Pages/index.html");

            return new ContentResult
            {
                ContentType = "text/html",
                StatusCode = (int)System.Net.HttpStatusCode.OK,
                Content = content
            };
        }

    }
}
