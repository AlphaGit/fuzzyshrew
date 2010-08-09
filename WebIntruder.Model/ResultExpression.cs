using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebIntruder.Model
{
    public class ResultExpression
    {
        public string Name { get; set; }
        public string Regex { get; set; }

        public bool IsConditionMet(string responseString)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(responseString, Regex);
        }
    }
}
