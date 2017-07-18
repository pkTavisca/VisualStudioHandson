using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace WebServicesTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.google.com/";
            string codejamURL = "http://codejam.tavisca.com/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(codejamURL);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var stream = response.GetResponseStream();
            string contentOfThePage = "";
            StreamReader sr = new StreamReader(stream);
            contentOfThePage = sr.ReadToEnd();
            Console.Write(contentOfThePage);
            sr.Close();
            Console.ReadKey();
        }
    }
}
