using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FuzzyShrew.Model.Plugin.Variables
{
    public class VariableConfigurationFormBase: Form
    {
        public VariableBase VariableToConfigure { get; set; }
        public VariableConfigurationFormBase()
        {

        }
        public VariableConfigurationFormBase(VariableBase variable): base()
        {
            VariableToConfigure = variable;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ConfigurationFormBase
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "ConfigurationFormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }
    }
}
