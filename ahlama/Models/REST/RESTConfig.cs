using System.Net;

namespace ahlama.Models.REST
{
    public class RESTConfig
    {
        public string username = null;
        public string password = null;
        public int HTTPTimeOut = 3000;
        public int POSTReadTimeOut = 3000;
        public int POSTWriteTimeOut = 3000;
        public Nullable<SecurityProtocolType> TLSVersion = null;
        public bool IgnoreCertErrors = false;
    }
}
