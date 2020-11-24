using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;

namespace RestAPI
{
    public partial class _Default : Page
    {
        private Controller _Verwalter;

        public Controller Verwalter { get => _Verwalter; set => _Verwalter = value; }

        protected void Page_Init(object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
           if(this.Session.Count <= 0)
            {
                this.Session["Verwalter"] = this.Verwalter = Global.Verwalter;
            }
           else
            {
                Global.Verwalter = this.Verwalter = (Controller)this.Session["Verwalter"];
            }

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            this.Verwalter.SendMSG(txtURL.Text, txtNachricht.Text, ref LogList);
        }
    }
}