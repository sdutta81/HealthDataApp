using PersonalHeathDataService.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PersonalHeathDataService.Controllers
{
    [RoutePrefix("api/v1/users/{id}")]
    public class UsersController : ApiController
    {
        [HttpGet]
        [Route]
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
                //return Ok(ex);
                return InternalServerError(ex);
            }
        }
    }
}
