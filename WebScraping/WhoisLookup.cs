using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraping
{

    internal class WhoisLookup
    {
        public WhoisLookup()
        {
            var whois = new WhoisLookup();
            var response = whois.Lookup("ilgili link");
        }

        private object Lookup(string v)
        {
            throw new System.NotImplementedException();
        }
    }
}
