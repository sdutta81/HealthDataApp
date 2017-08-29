using PersonalHeathDataService.DataAccess;
using PersonalHeathDataService.Models;
using System;
using System.Collections.Generic;
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

        [HttpPost]
        [Route("{uid}/{pwd}")]
        public IHttpActionResult PostUser(string uid, string pwd)
        {
            var dataAccess = new DataAccessService();
            var authUser = dataAccess.GetUserGuid(uid, pwd);

            if (authUser.Guid != null)
                return Ok(authUser);
            else
                return NotFound();
        }
    }
}
