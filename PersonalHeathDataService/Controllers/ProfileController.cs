using PersonalHeathDataService.Helpers;
using System.Web.Http;

namespace PersonalHeathDataService.Controllers
{
    [RoutePrefix("api/v1/profile")]
    public class ProfileController : ApiController
    {
        [HttpGet]
        [Route]
        public IHttpActionResult GetProfile()
        {
            return Ok();
        }

        [HttpPost]
        [Route("{id}")]
        public IHttpActionResult SetProfile(string id)
        {
            //if (string.IsNullOrEmpty(id))
            //{
            //    return new HttpActionResult(System.Net.HttpStatusCode.BadRequest, "Id not created");
            //}
            return Ok();
        }
    }
}
