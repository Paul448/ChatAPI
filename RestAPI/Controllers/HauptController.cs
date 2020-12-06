using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestAPI;

namespace RestAPI
{
    public class HauptController : ApiController
    {
        private Controller _Verwalter;
        public Controller Verwalter { get => _Verwalter; set => _Verwalter = value; }

        // GET: api/Haupt
        public string Get(string valueTXT="")
        {
            try
            {
                Nachricht NR = new Nachricht(valueTXT, DateTime.Now);
                Global.Verwalter.MSGLIST.Add(NR);
                return "OK";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        /*public string Get(string valueTXT1 = "", string DTime="")
        {
            try
            {
                DateTime DT = Convert.ToDateTime(DTime);
                Nachricht NR = new Nachricht(valueTXT1, DT);
                Global.Verwalter.MSGLIST.Add(NR);
                return "OK";
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        } */

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
