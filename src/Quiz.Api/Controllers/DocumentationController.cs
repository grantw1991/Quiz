using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class DocumentationController : Controller
    {
        [HttpGet("status")]
        public ActionResult<string> Status()
        {
            return "1.0.0";
        }
    }
}
