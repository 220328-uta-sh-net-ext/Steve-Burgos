using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using DL;
namespace WebApplication1.Controllers
{
    public class UserController : ApiController
    {
        public IEnumerable<UserModel> returnAllUsers()
        {
            IEnumerable<UserModel> users = DLUser.SearchUsers();
            
            return users;
        }
    }
}
