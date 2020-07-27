using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Todo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<int>> Get () 
        {
            return new int[] { 1, 2, 5 };
        }
    }
}