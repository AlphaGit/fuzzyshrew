using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyShrew.Model
{
    public class VariableController
    {
        public List<Variable> Variables { private set;  get; }
        private int _currentCombination;

        public VariableController (List<Variable> variables)
    	{
            Variables = variables;
            _currentCombination = 0;
            Variables.ForEach(v => v.Source.ResetCurrentValue());
    	}

        public void AdvanceOneCombination()
        {
            if (HasReachedEnd()) return;

            AdvanceVariable(0);
        }

        private void AdvanceVariable(int variableIndex)
        {
            if (Variables.Count <= variableIndex) return;

            if (Variables[variableIndex].Source.HasReachedFinalValue())
            {
                Variables[variableIndex].Source.ResetCurrentValue();
                AdvanceVariable(variableIndex + 1);
            }
            else
            {
                Variables[variableIndex].Source.AdvanceValue();
                _currentCombination++;
            }
        }

        public bool HasReachedEnd()
        {
            return (_currentCombination == GetTotalCombinations());
        }

        public int GetTotalCombinations()
        {
            int total = 1;
            Variables.ForEach(v => total *= v.Source.GetTotalValues());
            return total;
        }

        public int GetCurrentCombination()
        {
            return _currentCombination;
        }
    }
}
