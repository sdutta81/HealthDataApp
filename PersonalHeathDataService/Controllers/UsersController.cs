using PersonalHeathDataService.DataAccess;
using PersonalHeathDataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PersonalHeathDataService.Controllers
{
    [RoutePrefix("api/v1/users")]
    public class UsersController : ApiController
    {
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetUser(string id)
        {
            try
            {
                var dataAccess = new DataAccessService();
                var user = dataAccess.GetUser(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route]
        public IEnumerable<UserInfo> GetUsers()
        {
            var dataAccess = new DataAccessService();
            return dataAccess.GetUsers();
        }
    }
}
