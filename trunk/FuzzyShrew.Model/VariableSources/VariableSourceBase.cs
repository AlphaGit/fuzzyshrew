using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyShrew.Model.VariableSources
{
    public abstract class VariableSourceBase
    {
        public abstract void ShowConfigurationForm(System.Windows.Forms.IWin32Window owner);

        public static VariableSourceBase GetInstance(VariableSourceType type)
        {
            VariableSourceBase variable;

            switch (type)
            {
                case VariableSourceType.Counter:
                    variable = new CounterVariableSource.CounterVariableSource();
                    break;
                default:
                    throw new ArgumentException();
            }

            return variable;
        }

        public abstract string GetValue();

        public abstract void ResetCurrentValue();

        public abstract void AdvanceValue();

        public abstract bool HasReachedFinalValue();

        public abstract VariableSourceBase Clone();

        public abstract int GetTotalValues();
    }
}
