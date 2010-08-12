using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using FuzzyShrew.Model;

namespace FuzzyShrew.BLL
{
    public class WebRequestHelper
    {
        public WebRequestHelper(Session config, string url)
        {
            Configuration = config;
            Request = WebRequest.Create(url);
            Request.Method = config.Method;
        }
        public WebRequest Request { get; set; }
        public Session Configuration { get; set; }

        public void SendBody()
        {
            if (Request.Method != "POST") return;

            //parameterName=parameterValue
            var postParameters = Configuration.PostParameters.Select(p => Configuration.ApplyVariables(p.Name) + "=" + Configuration.ApplyVariables(p.Value));
            var bodyContent = string.Join("&", postParameters);

            var data = Encoding.UTF8.GetBytes(bodyContent);

            Request.ContentType = "application/x-www-form-urlencoded"; //TODO: make configurable, along with encoding
            Request.ContentLength = data.Length;
            Request.GetRequestStream().Write(data, 0, data.Length);
        }

        public void SetHeaders()
        {
            Configuration.Headers.ForEach(h => Request.Headers.Add(Configuration.ApplyVariables(h.Name), Configuration.ApplyVariables(h.Value)));
        }

        public WebResponse GetResponse()
        {
            return Request.GetResponse();
        }
    }
}
