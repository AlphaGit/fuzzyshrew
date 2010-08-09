using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebIntruder.Model.VariableSources.CounterVariableSource
{
    public class CounterVariableSource: VariableSourceBase
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

        public override VariableSourceBase Clone()
        {
            return new CounterVariableSource(Format, StartNumber, EndNumber, CurrentNumber);
        }

        public CounterVariableSource()
        {
            Format = "00";
            StartNumber = 0;
            EndNumber = 10;
        }
        private CounterVariableSource(string format, int startNumber, int endNumber, int currentNumber): this()
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
                    this.GetValuesFrom((CounterVariableSource)configurationForm.VariableToConfigure);
            }
        }

        private void GetValuesFrom(CounterVariableSource source)
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
    }
}
