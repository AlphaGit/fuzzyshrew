using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using FuzzyShrew.Model;
using FuzzyShrew.Model.Plugin.Variables;

namespace FuzzyShrew.BLL
{
    //TODO Unhardcode literals
    public class SessionManager
    {
        public static void Save(Session session, string fileName)
        {
            XmlDocument doc = new XmlDocument();
            var declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(declaration);

            var xmlSession = doc.CreateElement("Session");
            doc.AppendChild(xmlSession);

            var method = doc.CreateAttribute("Method");
            method.Value = session.Method;
            xmlSession.Attributes.Append(method);

            var url = doc.CreateAttribute("URL");
            url.Value = session.Url;
            xmlSession.Attributes.Append(url);

            var headers = doc.CreateElement("Headers");
            xmlSession.AppendChild(headers);
            foreach (var header in session.Headers)
            {
                var xmlHeader = doc.CreateElement("Header");
                headers.AppendChild(xmlHeader);

                var name = doc.CreateAttribute("Name");
                name.Value = header.Name;
                xmlHeader.Attributes.Append(name);

                var value = doc.CreateAttribute("Value");
                value.Value = header.Value;
                xmlHeader.Attributes.Append(value);
            }

            var parametersSection = doc.CreateElement("Parameters");
            xmlSession.AppendChild(parametersSection);
            foreach (var parameter in session.GetParameters)
            {
                var xmlHeader = doc.CreateElement("GET");
                parametersSection.AppendChild(xmlHeader);

                var name = doc.CreateAttribute("Name");
                name.Value = parameter.Name;
                xmlHeader.Attributes.Append(name);

                var value = doc.CreateAttribute("Value");
                value.Value = parameter.Value;
                xmlHeader.Attributes.Append(value);
            }

            foreach (var parameter in session.PostParameters)
            {
                var xmlHeader = doc.CreateElement("POST");
                parametersSection.AppendChild(xmlHeader);

                var name = doc.CreateAttribute("Name");
                name.Value = parameter.Name;
                xmlHeader.Attributes.Append(name);

                var value = doc.CreateAttribute("Value");
                value.Value = parameter.Value;
                xmlHeader.Attributes.Append(value);
            }

            var resultsSection = doc.CreateElement("Results");
            xmlSession.AppendChild(resultsSection);
            foreach (var expression in session.ResultExpressions)
            {
                var xmlHeader = doc.CreateElement("Result");
                resultsSection.AppendChild(xmlHeader);

                var name = doc.CreateAttribute("Name");
                name.Value = expression.Name;
                xmlHeader.Attributes.Append(name);

                var regex = doc.CreateAttribute("Regex");
                regex.Value = expression.Regex;
                xmlHeader.Attributes.Append(regex);
            }

            var variablesSection = doc.CreateElement("Variables");
            xmlSession.AppendChild(variablesSection);
            foreach (var variable in session.Variables)
            {
                var xmlHeader = doc.CreateElement("Variable");
                variablesSection.AppendChild(xmlHeader);

                var name = doc.CreateAttribute("VariableID");
                name.Value = variable.VariableID;
                xmlHeader.Attributes.Append(name);

                var type = doc.CreateAttribute("Type");
                type.Value = variable.GetType().FullName;
                xmlHeader.Attributes.Append(type);

                var data = doc.CreateElement("Data");
                data.InnerText = variable.SerializeVariableConfiguration();
                xmlHeader.AppendChild(data);
            }

            doc.Save(fileName);
        }

        public static Session Load(string fileName)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);

            Session session = new Session();
            var xmlSession = xmlDoc.GetElementsByTagName("Session")[0];
            session.Method = xmlSession.Attributes["Method"].Value;
            session.Url = xmlSession.Attributes["URL"].Value;

            var xmlHeaders = xmlDoc.GetElementsByTagName("Header");
            for (int i = 0; i < xmlHeaders.Count; i++)
            {
                var xmlHeader = xmlHeaders[i];
                var header = new HTTPHeader();
                header.Name = xmlHeader.Attributes["Name"].Value;
                header.Value = xmlHeader.Attributes["Value"].Value;

                session.Headers.Add(header);
            }

            var xmlGetParameters = xmlDoc.GetElementsByTagName("GET");
            for (int i = 0; i < xmlGetParameters.Count; i++)
            {
                var xmlGetParameter = xmlGetParameters[i];
                var getParameter = new Parameter();
                getParameter.Name = xmlGetParameter.Attributes["Name"].Value;
                getParameter.Value = xmlGetParameter.Attributes["Value"].Value;

                session.GetParameters.Add(getParameter);
            }

            var xmlPostParameters = xmlDoc.GetElementsByTagName("POST");
            for (int i = 0; i < xmlPostParameters.Count; i++)
            {
                var xmlPostParameter = xmlPostParameters[i];
                var postParameter = new Parameter();
                postParameter.Name = xmlPostParameter.Attributes["Name"].Value;
                postParameter.Value = xmlPostParameter.Attributes["Value"].Value;

                session.PostParameters.Add(postParameter);
            }

            var xmlResults = xmlDoc.GetElementsByTagName("Result");
            for (int i = 0; i < xmlResults.Count; i++)
            {
                var xmlResult = xmlResults[i];
                var result = new ResultExpression();
                result.Name = xmlResult.Attributes["Name"].Value;
                result.Regex = xmlResult.Attributes["Regex"].Value;

                session.ResultExpressions.Add(result);
            }

            var xmlVariables = xmlDoc.GetElementsByTagName("Variable");
            for (int i = 0; i < xmlVariables.Count; i++)
            {
                var xmlVariable = xmlVariables[i];

                var variableType = xmlVariable.Attributes["Type"].Value;

                var variable = (VariableBase)PluginManager.SearchAndLoadPlugin(variableType);

                variable.VariableID = xmlVariable.Attributes["VariableID"].Value;
                var data = xmlVariable.ChildNodes[0].InnerText;
                variable.DeserializeVariableConfiguration(data);

                session.Variables.Add(variable);
            }

            return session;
        }
    }
}
