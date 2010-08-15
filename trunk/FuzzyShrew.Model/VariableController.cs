using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuzzyShrew.Model.Plugin.Variables;

namespace FuzzyShrew.Model
{
    public class VariableController
    {
        public List<VariableBase> Variables { private set;  get; }
        private int _currentCombination;

        public VariableController(List<VariableBase> variables)
    	{
            Variables = variables;
            _currentCombination = 0;
            Variables.ForEach(v => v.ResetCurrentValue());
    	}

        public void AdvanceOneCombination()
        {
            if (HasReachedEnd()) return;

            AdvanceVariable(0);
        }

        private void AdvanceVariable(int variableIndex)
        {
            if (Variables.Count <= variableIndex) return;

            if (Variables[variableIndex].HasReachedFinalValue())
            {
                Variables[variableIndex].ResetCurrentValue();
                AdvanceVariable(variableIndex + 1);
            }
            else
            {
                Variables[variableIndex].AdvanceValue();
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
            Variables.ForEach(v => total *= v.GetTotalValues());
            return total;
        }

        public int GetCurrentCombination()
        {
            return _currentCombination;
        }
    }
}
