using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace WebScraping
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                 

                string data = null;
                WebClient webl = new WebClient();
                data = webl.DownloadString("ilgili link");

                Match m = Regex.Match(data, "ilgili div");

                Console.WriteLine("Sleep for 1 seconds."); //sirkülayon devam etsin diye var.
                Thread.Sleep(1000);
                Console.WriteLine(m.Groups[5].Value);
            }
        }
    }
}
