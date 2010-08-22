namespace FuzzyShrew.Model.Plugin.Formats.Csv
{
    public partial class FrmCsvConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tvPropertiesTree = new System.Windows.Forms.TreeView();
            this.chkShowTitles = new System.Windows.Forms.CheckBox();
            this.chkUseQuotationMarksForAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(274, 187);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(51, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(331, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(51, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tvPropertiesTree
            // 
            this.tvPropertiesTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tvPropertiesTree.CheckBoxes = true;
            this.tvPropertiesTree.Location = new System.Drawing.Point(12, 72);
            this.tvPropertiesTree.Name = "tvPropertiesTree";
            this.tvPropertiesTree.Size = new System.Drawing.Size(370, 109);
            this.tvPropertiesTree.TabIndex = 3;
            this.tvPropertiesTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvPropertiesTree_AfterCheck);
            this.tvPropertiesTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvPropertiesTree_NodeMouseDoubleClick);
            // 
            // chkShowTitles
            // 
            this.chkShowTitles.AutoSize = true;
            this.chkShowTitles.Location = new System.Drawing.Point(12, 12);
            this.chkShowTitles.Name = "chkShowTitles";
            this.chkShowTitles.Size = new System.Drawing.Size(214, 17);
            this.chkShowTitles.TabIndex = 4;
            this.chkShowTitles.Text = "&First line should contain column headers";
            this.chkShowTitles.UseVisualStyleBackColor = true;
            this.chkShowTitles.CheckedChanged += new System.EventHandler(this.chkShowTitles_CheckedChanged);
            // 
            // chkUseQuotationMarksForAll
            // 
            this.chkUseQuotationMarksForAll.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkUseQuotationMarksForAll.Location = new System.Drawing.Point(12, 35);
            this.chkUseQuotationMarksForAll.Name = "chkUseQuotationMarksForAll";
            this.chkUseQuotationMarksForAll.Size = new System.Drawing.Size(370, 31);
            this.chkUseQuotationMarksForAll.TabIndex = 4;
            this.chkUseQuotationMarksForAll.Text = "Use &double quotation marks to enclose all fields (not only those that contain a " +
                "coma)";
            this.chkUseQuotationMarksForAll.UseVisualStyleBackColor = true;
            this.chkUseQuotationMarksForAll.CheckedChanged += new System.EventHandler(this.chkUseQuotationMarksForAll_CheckedChanged);
            // 
            // FrmCsvConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 219);
            this.Controls.Add(this.chkUseQuotationMarksForAll);
            this.Controls.Add(this.chkShowTitles);
            this.Controls.Add(this.tvPropertiesTree);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCsvConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV Format Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TreeView tvPropertiesTree;
        private System.Windows.Forms.CheckBox chkShowTitles;
        private System.Windows.Forms.CheckBox chkUseQuotationMarksForAll;
    }
}