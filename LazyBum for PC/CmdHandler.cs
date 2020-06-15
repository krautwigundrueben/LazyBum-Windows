using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LazyBum_for_PC
{
    class CmdHandler
    {
        public string connect(string btn)
        {
            string response = ""; 

            try {
                string url = "http://192.168.2.108/?";                
                string uri = url + btn;                 
                using (WebClient client = new WebClient()) {
                    response = client.DownloadString(uri);
                }
            }
            catch (Exception e) {
            }
            return response;
        }

        public string connect() {
            string response = "";
            try {
                string url = "http://192.168.2.108/?";
                using (WebClient client = new WebClient()) {
                    response = client.DownloadString(url);
                }
            }
            catch (Exception e) {
            }
            return response;
        }
    }
}
