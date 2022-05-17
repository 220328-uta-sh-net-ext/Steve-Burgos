using Microsoft.AspNetCore.Mvc;
using Models;
using DL;
using BL;
namespace WebApplication1.Controllers
{
   
    [Route("[api/controller]")]
    public class UsersController : Controller
    {
        

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public int Get()
        {

            return 0;
        }
    }
}