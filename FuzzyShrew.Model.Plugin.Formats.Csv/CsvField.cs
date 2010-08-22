using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace FuzzyShrew.Model.Plugin.Formats.Csv
{
    public class CsvField
    {
        public Type ClassType { get; set; }
        public List<CsvField> ChildFields { get; set; }
        public string FieldName { get; set; }
        public bool ShowField { get; set; }
        private bool WasChildrenPopulated { get; set; }

        public static List<CsvField> GetAllChildFields(Type type)
        {
            return type
                .GetProperties()
                .Where(p => p.CanRead)
                .ToList()
                .Select<PropertyInfo, CsvField>(p => new CsvField()
                    {
                        ClassType = p.PropertyType,
                        FieldName = p.Name,
                        ShowField = false
                    })
                .ToList();
        }

        public CsvField Clone()
        {
            return new CsvField()
            {
                ClassType = this.ClassType,
                FieldName = this.FieldName,
                ShowField = this.ShowField,
                ChildFields = this.ChildFields.Select(c => c.Clone()).ToList()
            };
        }
    }
}
