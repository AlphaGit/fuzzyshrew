using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using FuzzyShrew.Model.Plugin.Variables;
using FuzzyShrew.Model.Plugin;

namespace FuzzyShrew.Model
{
    [XmlInclude(typeof(HTTPHeader))]
    [XmlInclude(typeof(Parameter))]
    [XmlInclude(typeof(ResultExpression))]
    [XmlInclude(typeof(VariableBase))]
    public class Session
    {
        public List<HTTPHeader> Headers { get; set; }
        public List<Parameter> GetParameters { get; set; }
        public List<Parameter> PostParameters { get; set; }
        public List<ResultExpression> ResultExpressions { get; set; }
        public List<VariableBase> Variables { get; set; }
        public string Url { get; set; }
        public string Method { get; set; }

        public Session()
        {
            Headers = new List<HTTPHeader>();
            GetParameters = new List<Parameter>();
            PostParameters = new List<Parameter>();
            ResultExpressions = new List<ResultExpression>();
            Variables = new List<VariableBase>();
        }
        public Session(List<HTTPHeader> headers, List<Parameter> getParameters, List<Parameter> postParameters, List<VariableBase> variables, List<ResultExpression> resultExpressions, string url, string method)
        {
            Headers = headers;
            GetParameters = getParameters;
            PostParameters = postParameters;
            Variables = variables;
            ResultExpressions = resultExpressions;
            Url = url;
            Method = method;
        }

        public string ApplyVariables(string originalString)
        {
            string newString = originalString;

            Variables.ForEach(v =>
                newString = newString.Replace(v.VariableID, v.GetValue())
            );

            return newString;
        }
    }
}
