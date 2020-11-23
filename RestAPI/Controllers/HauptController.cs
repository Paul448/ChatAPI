using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestAPI;

namespace RestAPI.Controllers
{
    public class HauptController : ApiController
    {
        // GET: api/Haupt
        public string Get(string value="")
        {
            Nachricht NR = new Nachricht(value);
            return "OK";
        }

        // GET: api/Haupt/5
        public string Get(int id)
        {
            return "value" + id;
        }


        // POST: api/Haupt
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Haupt/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Haupt/5
        public void Delete(int id)
        {
        }
    }
}
