using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPI
{
    public class Nachricht
    {
        private string _Text;
        private string _Sender;
        private DateTime _Time;

        public string Text { get => _Text; set => _Text = value; }
        public string Sender { get => _Sender; set => _Sender = value; }
        public DateTime Time { get => _Time; set => _Time = value; }

        public Nachricht()
        {

        }

        public Nachricht(string Txt)
        {
            this.Text = Txt;

        }

        public Nachricht(string Txt, DateTime Time)
        {
            this.Text = Txt;
            this.Time = Time;
        }
    }
}