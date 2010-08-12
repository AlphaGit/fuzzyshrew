using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace FuzzyShrew.Model
{
    [XmlInclude(typeof(HTTPHeader))]
    [XmlInclude(typeof(Parameter))]
    [XmlInclude(typeof(ResultExpression))]
    [XmlInclude(typeof(Variable))]
    [XmlInclude(typeof(FuzzyShrew.Model.VariableSources.CounterVariableSource.CounterVariableSource))]
    public class Session
    {
        public List<HTTPHeader> Headers { get; set; }
        public List<Parameter> GetParameters { get; set; }
        public List<Parameter> PostParameters { get; set; }
        public List<ResultExpression> ResultExpressions { get; set; }
        public List<Variable> Variables { get; set; }
        public string Url { get; set; }
        public string Method { get; set; }

        public Session()
        {
            Headers = new List<HTTPHeader>();
            GetParameters = new List<Parameter>();
            PostParameters = new List<Parameter>();
            ResultExpressions = new List<ResultExpression>();
            Variables = new List<Variable>();
        }
        public Session(List<HTTPHeader> headers, List<Parameter> getParameters, List<Parameter> postParameters, List<Variable> variables, List<ResultExpression> resultExpressions, string url, string method)
        {
            Headers = headers;
            GetParameters = getParameters;
            PostParameters = postParameters;
            Variables = variables;
            ResultExpressions = resultExpressions;
            Url = url;
            Method = method;
        }

        public void Save(string fileName)
        {
            var writer = XmlWriter.Create(fileName, 
                new XmlWriterSettings() {
                    CloseOutput = true,
                    Encoding = Encoding.UTF8,
                    Indent = true,
                    IndentChars = "\t",
                    OmitXmlDeclaration = true
                });

            XmlSerializer x = new XmlSerializer(this.GetType());
            x.Serialize(writer, this);
        }

        public static Session Load(string fileName)
        {
            var reader = XmlReader.Create(fileName,
                new XmlReaderSettings()
                {
                    CloseInput = true
                });

            XmlSerializer x = new XmlSerializer(typeof(Session));
            return (Session) x.Deserialize(reader);
        }

        public string ApplyVariables(string originalString)
        {
            string newString = originalString;

            Variables.ForEach(v =>
                newString = newString.Replace(v.VariableID, v.Source.GetValue())
            );

            return newString;
        }
    }
}
