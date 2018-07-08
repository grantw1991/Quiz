using Microsoft.AspNetCore.Mvc;

namespace Quiz.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        [HttpGet("status")]
        public ActionResult<string> Test()
        {
            return "bacon";
        }
    }
}
