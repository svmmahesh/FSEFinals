using System;
using System.Linq;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProjectManagerWebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/projectManager")]
    public class HelloController : BaseAPIController
    {
        [Route("sayHi")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return tryCatchWebMethod(() =>
            {
                var msg = new StringBuilder();
                msg.Append("Web API saying hi");
                
                var model = new
                {
                    msg = msg.ToString()
                };
                
                return Json(model);
            });
        }
    }
}
