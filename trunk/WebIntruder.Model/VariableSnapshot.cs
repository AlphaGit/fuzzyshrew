using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebIntruder.Model
{
    public class VariableSnapshot
    {
        public string VariableID { get; set; }
        public string Value { get; set; }

        public VariableSnapshot(string variableID, string value)
        {
            VariableID = variableID;
            Value = value;
        }
    }
}
