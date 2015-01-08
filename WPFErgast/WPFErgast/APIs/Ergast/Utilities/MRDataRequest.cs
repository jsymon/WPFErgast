using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;

namespace WPFErgast.APIs.Ergast.Utilities
{
    public class MRDataRequest
    {
        /// <summary>
        /// The request URL minus any query string or JSON-specific parameters.
        /// </summary>
        public string URL { get; set; }

        public int Limit { get; set; }

        public int Offset { get; set; }

        public bool IsJSON { get; set; }

        private string BuildURL()
        {
            return URL + string.Format("?limit={0}&offset={1}", Limit, Offset);
        }

        internal virtual Stream GetResponseStream()
        {
            var webRequest = WebRequest.Create(BuildURL());
            var webResponse = webRequest.GetResponse();
            return webResponse.GetResponseStream();
        }

        internal virtual string GetResponseString()
        {
            var stream = GetResponseStream();
            var sr = new StreamReader(stream);
            return sr.ReadToEnd();
        }

        internal virtual T GetResponseType<T>()
        {
            if (IsJSON)
                throw new NotImplementedException();
            else
            {
                using (var stream = GetResponseStream())
                {
                    var deserialiser = new XmlSerializer(typeof(T));
                    return (T)deserialiser.Deserialize(stream);
                }
            }
        }

        public override int GetHashCode()
        {
            return new { URL, Limit, Offset, IsJSON }.GetHashCode();
        }
    }
}