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
        private IDataAccessService dataAccess;

        public UsersController(IDataAccessService da)
        {
            dataAccess = da;
        }

        [HttpGet]
        [Route("{id}/{guid}")]
        public IHttpActionResult GetUser(string id, string guid)
        {
            try
            {
                var user = dataAccess.GetUser(id, guid);
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
            return dataAccess.GetUsers();
        }

        [HttpPost]
        [Route]
        public IHttpActionResult ValidateUser(LoginInfo loginInfo)
        {
            if (loginInfo == null)
            {
                return BadRequest();
            }

            var authUser = dataAccess.GetUserGuid(loginInfo);

            if (authUser.Guid != null)
                return Ok(authUser);
            else
                return NotFound();
        }
    }
}
