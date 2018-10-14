using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using irad.Models;

namespace irad.Controllers
{
    public class MeasurementsController : RavenAPIController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public object Post(Measurements measurement)
        {
            RavenSession.Store(measurement);
            return measurement;
        }

        // PUT api/measurements
        public void Put(Measurements measurement)
        {

        }
    }
}
