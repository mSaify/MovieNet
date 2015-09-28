using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Client;

namespace MovieNet.Domain
{  
    public class ServiceBase
    {
        //Ask for key
        private static string APIKey = "xxxxx-xxxxxxx-xxxxxx-xxxx";
        protected static TMDbClient client;
   
        public ServiceBase()
        {
            client = new TMDbClient(APIKey);
        }
    }
}
