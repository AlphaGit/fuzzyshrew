using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FuzzyShrew.Model.Plugin.Formats
{
    public class FormatConfigurationFormBase: Form
    {
        public ExportFormatBase FormatToConfigure { get; set; }
        public FormatConfigurationFormBase()
        {

        }
        public FormatConfigurationFormBase(ExportFormatBase format): base()
        {
            FormatToConfigure = format;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ConfigurationFormBase
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "FormatConfigurationFormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }
    }
}
