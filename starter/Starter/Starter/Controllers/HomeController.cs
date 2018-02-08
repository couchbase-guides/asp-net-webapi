using System.Web.Http;
using Starter.Models;

namespace Starter.Controllers
{
    public class HomeController : ApiController
    {
        private readonly ProfileRepository _repo;

        public HomeController()
        {
            _repo = new ProfileRepository();
        }

        [Route("api/Save")]
        [HttpPost]
        public IHttpActionResult Save(Profile profile)
        {
            _repo.Save(profile);
            return Ok(profile);
        }

        [Route("api/GetAll")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(_repo.GetAll());
        }

        [Route("api/Delete/{id}")]
        [HttpDelete]
        public IHttpActionResult Delete(string id)
        {
            _repo.Delete(id);
            return Ok("Deleted: " + id);
        }
    }
}