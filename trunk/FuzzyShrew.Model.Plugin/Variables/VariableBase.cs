using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyShrew.Model.Plugin.Variables
{
    public abstract class VariableBase: PluginBase
    {
        public string VariableID { get; set; }

        public VariableSnapshot GetSnapshot()
        {
            return new VariableSnapshot(VariableID, GetValue());
        }

        public abstract string GetValue();

        public abstract void ResetCurrentValue();

        public abstract void AdvanceValue();

        public abstract bool HasReachedFinalValue();

        public abstract VariableBase Clone();

        public abstract int GetTotalValues();

        public abstract string SerializeVariableConfiguration();
        public abstract void DeserializeVariableConfiguration(string configuration);
    }
}
