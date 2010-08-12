using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FuzzyShrew.Model.VariableSources
{
    public class ConfigurationFormBase: Form
    {
        public VariableSourceBase VariableToConfigure { get; set; }
        public ConfigurationFormBase()
        {

        }
        public ConfigurationFormBase(VariableSourceBase variable): base()
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }
    }
}
