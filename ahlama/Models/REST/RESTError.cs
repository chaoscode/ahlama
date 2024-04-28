namespace ahlama.Models.REST
{
   public class RESTResponse
    {
        public RESTError restError = new RESTError();
    }

    public class RESTError
    {
        public bool success;
        public List<string> messages = new List<string>();
        public string error;
    }
}
