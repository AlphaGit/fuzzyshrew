using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuzzyShrew.Model.Plugin.Variables;
using System.Xml;

namespace FuzzyShrew.Model.Variables.Counter
{
    public class CounterVariable: VariableBase
    {
        public string Format { get; set; }
        private int _startNumber;
        public int StartNumber
        {
            get
            {
                return _startNumber;
            }
            set
            {
                _startNumber = value;
                CurrentNumber = value;
            }
        }
        private int CurrentNumber { get; set; }
        public int EndNumber { get; set; }

        public override string Author { get { return "Alpha"; } }
        public override string Description { get { return "Numeric counter variable."; } }
        public override string Name { get { return "Numeric Counter"; } }
        public override bool IsPluginConfigurationValid()
        {
            return StartNumber < EndNumber;
        }

        public override string GetValue()
        {
            return CurrentNumber.ToString(Format);
        }

        public override void AdvanceValue()
        {
            if (!HasReachedFinalValue()) CurrentNumber++;
        }

        public override bool HasReachedFinalValue()
        {
            return CurrentNumber == EndNumber;
        }

        public override VariableBase Clone()
        {
            return new CounterVariable(Format, StartNumber, EndNumber, CurrentNumber);
        }

        public CounterVariable()
        {
            Format = "00";
            StartNumber = 0;
            EndNumber = 10;
        }
        private CounterVariable(string format, int startNumber, int endNumber, int currentNumber): this()
        {
            Format = format;
            StartNumber = startNumber;
            EndNumber = endNumber;
            CurrentNumber = currentNumber;
        }

        public override void ShowConfigurationForm(System.Windows.Forms.IWin32Window owner)
        {
            using (var configurationForm = new FrmCounterConfigurationForm(this.Clone()))
            {
                if (configurationForm.ShowDialog(owner) == System.Windows.Forms.DialogResult.OK)
                    this.GetValuesFrom((CounterVariable)configurationForm.VariableToConfigure);
            }
        }

        private void GetValuesFrom(CounterVariable source)
        {
            this.Format = source.Format;
            this.StartNumber = source.StartNumber;
            this.EndNumber = source.EndNumber;
            this.CurrentNumber = source.CurrentNumber;
        }

        public override void ResetCurrentValue()
        {
            CurrentNumber = _startNumber;
        }

        public override int GetTotalValues()
        {
            return EndNumber - StartNumber + 1;
        }

        public override string SerializeVariableConfiguration()
        {
            XmlDocument doc = new XmlDocument();
            var declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(declaration);

            var counterVariable = doc.CreateElement("CounterVariable");
            doc.AppendChild(counterVariable);

            //VariableID="XXX"
            var nameAttribute = doc.CreateAttribute("VariableID");
            nameAttribute.Value = VariableID;
            counterVariable.Attributes.Append(nameAttribute);

            //StartNumber=X
            var startNumberAttribute = doc.CreateAttribute("StartNumber");
            startNumberAttribute.Value = StartNumber.ToString();
            counterVariable.Attributes.Append(startNumberAttribute);

            //EndNumber=X
            var endNumberAttribute = doc.CreateAttribute("EndNumber");
            endNumberAttribute.Value = EndNumber.ToString();
            counterVariable.Attributes.Append(endNumberAttribute);

            //Format="00\0"
            var formatAttribute = doc.CreateAttribute("Format");
            formatAttribute.Value = Format;
            counterVariable.Attributes.Append(formatAttribute);

            return doc.OuterXml;
        }

        public override void DeserializeVariableConfiguration(string configuration)
        {
            var doc = new XmlDocument();
            doc.LoadXml(configuration);

            var counterVariable = doc.GetElementsByTagName("CounterVariable")[0];

            VariableID = counterVariable.Attributes["VariableID"].Value;
            StartNumber = Convert.ToInt32(counterVariable.Attributes["StartNumber"].Value);
            EndNumber = Convert.ToInt32(counterVariable.Attributes["EndNumber"].Value);
            Format = counterVariable.Attributes["Format"].Value;

            ResetCurrentValue();
        }
    }
}
