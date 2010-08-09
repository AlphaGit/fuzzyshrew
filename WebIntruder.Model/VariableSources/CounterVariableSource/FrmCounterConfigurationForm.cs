using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebIntruder.Model.VariableSources.CounterVariableSource
{
    public partial class FrmCounterConfigurationForm : ConfigurationFormBase
    {
        private CounterVariableSource _counter;

        public FrmCounterConfigurationForm(VariableSourceBase variable): base(variable)
        {
            InitializeComponent();
            _counter = (CounterVariableSource)variable;
            txtFormat.Text = _counter.Format;
            udEndValue.Value = _counter.EndNumber;
            udStartValue.Value = _counter.StartNumber;
        }

        private void udStartValue_ValueChanged(object sender, EventArgs e)
        {
            _counter.StartNumber = (int)udStartValue.Value;
        }

        private void udEndValue_ValueChanged(object sender, EventArgs e)
        {
            _counter.EndNumber = (int)udEndValue.Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtFormat_TextChanged(object sender, EventArgs e)
        {
            _counter.Format = txtFormat.Text;
        }
    }
}
