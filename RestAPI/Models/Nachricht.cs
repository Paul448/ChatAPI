using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPI
{
    public class Nachricht
    {
        private string _Text;
        private string _Send;

        public string Text { get => _Text; set => _Text = value; }
        public string Send { get => _Send; set => _Send = value; }

        public Nachricht()
        {

        }

        public Nachricht(string Txt)
        {
            this.Text = Txt;

        }
    }
}