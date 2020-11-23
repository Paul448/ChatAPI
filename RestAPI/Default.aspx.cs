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
            if(this.Verwalter is null)
            {
                this.Verwalter = new Controller();
            }
            else
            {

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            this.Verwalter.SendMSG(txtURL.Text, txtNachricht.Text, ref LogList);
        }
    }
}