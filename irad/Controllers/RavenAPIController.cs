using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using irad.Models;
using Raven.Client.Documents.Session;

namespace irad.Controllers
{
    [RequireHttps]
    public class RavenApiController : ApiController
    {
        public IDocumentSession RavenSession { get; set; }

        public RavenApiController()
        {

        }

        //public Measurements GetAsset(string id)
        //{
        //    return RavenSession.Query<Measurements>().SingleOrDefault(x => x.Id == id);
        //}

        //public IEnumerable<Measurements> GetAssets()
        //{
        //    return RavenSession.Query<Measurements>();
        //}

        protected override void Initialize(System.Web.Http.Controllers.HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            if (RavenSession == null)
                RavenSession = WebApiApplication.Store.OpenSession();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            using (RavenSession)
            {
                RavenSession?.SaveChanges();
            }
        }
    }
}