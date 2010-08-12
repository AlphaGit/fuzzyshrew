using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyShrew.Model
{
    public class ResultExpressionSnapshot
    {
        public string Name { get; set; }
        public bool IsPresent { get; set; }

        public ResultExpressionSnapshot(string name, bool isPresent)
        {
            Name = name;
            IsPresent = isPresent;
        }
    }
}
