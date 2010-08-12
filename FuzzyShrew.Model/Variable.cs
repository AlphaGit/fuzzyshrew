using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuzzyShrew.Model.VariableSources;

namespace FuzzyShrew.Model
{
    public class Variable
    {
        public string VariableID { get; set; }
        public VariableSources.VariableSourceBase Source { get; set; }

        public void SetNewSource(string sourceName)
        {
            VariableSourceType type;
            if (!Enum.TryParse<VariableSourceType>(sourceName, out type)) return;

            Source = VariableSourceBase.GetInstance(type);
        }

        public VariableSnapshot GetSnapshot()
        {
            return new VariableSnapshot(this.VariableID, this.Source.GetValue());
        }
    }
}
