using System.Web.Http;
using irad.Models;

namespace irad.Controllers
{
    public class MeasurementsController : RavenApiController
    {
        // POST api/values
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult Post(Measurements measurement)
        {
            RavenSession.Store(measurement);
            return Ok();
            //return measurement;
        }
    }
}
