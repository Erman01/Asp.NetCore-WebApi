using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.API.Fake;
using UserManagement.API.Models;

namespace UserManagement.API.Controllers
{
    [Route("api/[Controller]")]
    public class UsersController:ControllerBase
    {
        private List<User> _users = FakeData.GetUsers(200);

        public List<User> Get()
        {
            return _users;
        }
    }
}
