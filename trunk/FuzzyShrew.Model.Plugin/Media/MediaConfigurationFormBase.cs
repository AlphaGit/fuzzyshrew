using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FuzzyShrew.Model.Plugin.Media
{
    public class MediaConfigurationFormBase: Form
    {
        public ExportMediaBase MediaToConfigure { get; set; }
        public MediaConfigurationFormBase(ExportMediaBase media): base()
        {
            MediaToConfigure = media;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ConfigurationFormBase
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "MediaConfigurationFormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }
    }
}
