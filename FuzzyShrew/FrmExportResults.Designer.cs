namespace FuzzyShrew
{
    partial class FrmExportResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.grpExportFormat = new System.Windows.Forms.GroupBox();
            this.lblExportFormatDescription = new System.Windows.Forms.Label();
            this.lblExportFormatAuthor = new System.Windows.Forms.Label();
            this.lblExportFormatPluginDescriptionTitle = new System.Windows.Forms.Label();
            this.lblExportFormatAuthorTitle = new System.Windows.Forms.Label();
            this.btnConfigureExportFormatPlugin = new System.Windows.Forms.Button();
            this.lnkReloadFormatPluginList = new System.Windows.Forms.LinkLabel();
            this.lblExportFormatTitle = new System.Windows.Forms.Label();
            this.cmbExportFormat = new System.Windows.Forms.ComboBox();
            this.grpExportMedia = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfigureExporMedia = new System.Windows.Forms.Button();
            this.lnkReloadMediaPlugins = new System.Windows.Forms.LinkLabel();
            this.lblExportMediaTitle = new System.Windows.Forms.Label();
            this.cmbExportMedia = new System.Windows.Forms.ComboBox();
            this.grpExportFormat.SuspendLayout();
            this.grpExportMedia.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(409, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(327, 283);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(76, 31);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // grpExportFormat
            // 
            this.grpExportFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExportFormat.Controls.Add(this.lblExportFormatDescription);
            this.grpExportFormat.Controls.Add(this.lblExportFormatAuthor);
            this.grpExportFormat.Controls.Add(this.lblExportFormatPluginDescriptionTitle);
            this.grpExportFormat.Controls.Add(this.lblExportFormatAuthorTitle);
            this.grpExportFormat.Controls.Add(this.btnConfigureExportFormatPlugin);
            this.grpExportFormat.Controls.Add(this.lnkReloadFormatPluginList);
            this.grpExportFormat.Controls.Add(this.lblExportFormatTitle);
            this.grpExportFormat.Controls.Add(this.cmbExportFormat);
            this.grpExportFormat.Location = new System.Drawing.Point(12, 12);
            this.grpExportFormat.Name = "grpExportFormat";
            this.grpExportFormat.Size = new System.Drawing.Size(473, 129);
            this.grpExportFormat.TabIndex = 5;
            this.grpExportFormat.TabStop = false;
            this.grpExportFormat.Text = "Export format";
            // 
            // lblExportFormatDescription
            // 
            this.lblExportFormatDescription.Location = new System.Drawing.Point(102, 69);
            this.lblExportFormatDescription.Name = "lblExportFormatDescription";
            this.lblExportFormatDescription.Size = new System.Drawing.Size(364, 47);
            this.lblExportFormatDescription.TabIndex = 9;
            // 
            // lblExportFormatAuthor
            // 
            this.lblExportFormatAuthor.Location = new System.Drawing.Point(102, 56);
            this.lblExportFormatAuthor.Name = "lblExportFormatAuthor";
            this.lblExportFormatAuthor.Size = new System.Drawing.Size(364, 13);
            this.lblExportFormatAuthor.TabIndex = 9;
            // 
            // lblExportFormatPluginDescriptionTitle
            // 
            this.lblExportFormatPluginDescriptionTitle.AutoSize = true;
            this.lblExportFormatPluginDescriptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportFormatPluginDescriptionTitle.Location = new System.Drawing.Point(21, 69);
            this.lblExportFormatPluginDescriptionTitle.Name = "lblExportFormatPluginDescriptionTitle";
            this.lblExportFormatPluginDescriptionTitle.Size = new System.Drawing.Size(75, 13);
            this.lblExportFormatPluginDescriptionTitle.TabIndex = 8;
            this.lblExportFormatPluginDescriptionTitle.Text = "Description:";
            // 
            // lblExportFormatAuthorTitle
            // 
            this.lblExportFormatAuthorTitle.AutoSize = true;
            this.lblExportFormatAuthorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportFormatAuthorTitle.Location = new System.Drawing.Point(48, 56);
            this.lblExportFormatAuthorTitle.Name = "lblExportFormatAuthorTitle";
            this.lblExportFormatAuthorTitle.Size = new System.Drawing.Size(48, 13);
            this.lblExportFormatAuthorTitle.TabIndex = 8;
            this.lblExportFormatAuthorTitle.Text = "Author:";
            // 
            // btnConfigureExportFormatPlugin
            // 
            this.btnConfigureExportFormatPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigureExportFormatPlugin.Location = new System.Drawing.Point(392, 30);
            this.btnConfigureExportFormatPlugin.Name = "btnConfigureExportFormatPlugin";
            this.btnConfigureExportFormatPlugin.Size = new System.Drawing.Size(75, 23);
            this.btnConfigureExportFormatPlugin.TabIndex = 7;
            this.btnConfigureExportFormatPlugin.Text = "Configure...";
            this.btnConfigureExportFormatPlugin.UseVisualStyleBackColor = true;
            // 
            // lnkReloadFormatPluginList
            // 
            this.lnkReloadFormatPluginList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkReloadFormatPluginList.AutoSize = true;
            this.lnkReloadFormatPluginList.Location = new System.Drawing.Point(271, 16);
            this.lnkReloadFormatPluginList.Name = "lnkReloadFormatPluginList";
            this.lnkReloadFormatPluginList.Size = new System.Drawing.Size(115, 13);
            this.lnkReloadFormatPluginList.TabIndex = 6;
            this.lnkReloadFormatPluginList.TabStop = true;
            this.lnkReloadFormatPluginList.Text = "(Reload format plugins)";
            // 
            // lblExportFormatTitle
            // 
            this.lblExportFormatTitle.AutoSize = true;
            this.lblExportFormatTitle.Location = new System.Drawing.Point(2, 16);
            this.lblExportFormatTitle.Name = "lblExportFormatTitle";
            this.lblExportFormatTitle.Size = new System.Drawing.Size(104, 13);
            this.lblExportFormatTitle.TabIndex = 5;
            this.lblExportFormatTitle.Text = "Select export format:";
            // 
            // cmbExportFormat
            // 
            this.cmbExportFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExportFormat.FormattingEnabled = true;
            this.cmbExportFormat.Location = new System.Drawing.Point(6, 32);
            this.cmbExportFormat.Name = "cmbExportFormat";
            this.cmbExportFormat.Size = new System.Drawing.Size(380, 21);
            this.cmbExportFormat.TabIndex = 4;
            this.cmbExportFormat.SelectedIndexChanged += new System.EventHandler(this.cmbExportFormat_SelectedIndexChanged);
            // 
            // grpExportMedia
            // 
            this.grpExportMedia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExportMedia.Controls.Add(this.label1);
            this.grpExportMedia.Controls.Add(this.label2);
            this.grpExportMedia.Controls.Add(this.label3);
            this.grpExportMedia.Controls.Add(this.label4);
            this.grpExportMedia.Controls.Add(this.btnConfigureExporMedia);
            this.grpExportMedia.Controls.Add(this.lnkReloadMediaPlugins);
            this.grpExportMedia.Controls.Add(this.lblExportMediaTitle);
            this.grpExportMedia.Controls.Add(this.cmbExportMedia);
            this.grpExportMedia.Location = new System.Drawing.Point(11, 147);
            this.grpExportMedia.Name = "grpExportMedia";
            this.grpExportMedia.Size = new System.Drawing.Size(474, 129);
            this.grpExportMedia.TabIndex = 5;
            this.grpExportMedia.TabStop = false;
            this.grpExportMedia.Text = "Export media";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(103, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 47);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(103, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 13);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Author:";
            // 
            // btnConfigureExporMedia
            // 
            this.btnConfigureExporMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigureExporMedia.Location = new System.Drawing.Point(392, 30);
            this.btnConfigureExporMedia.Name = "btnConfigureExporMedia";
            this.btnConfigureExporMedia.Size = new System.Drawing.Size(75, 23);
            this.btnConfigureExporMedia.TabIndex = 7;
            this.btnConfigureExporMedia.Text = "Configure...";
            this.btnConfigureExporMedia.UseVisualStyleBackColor = true;
            // 
            // lnkReloadMediaPlugins
            // 
            this.lnkReloadMediaPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkReloadMediaPlugins.AutoSize = true;
            this.lnkReloadMediaPlugins.Location = new System.Drawing.Point(272, 16);
            this.lnkReloadMediaPlugins.Name = "lnkReloadMediaPlugins";
            this.lnkReloadMediaPlugins.Size = new System.Drawing.Size(114, 13);
            this.lnkReloadMediaPlugins.TabIndex = 6;
            this.lnkReloadMediaPlugins.TabStop = true;
            this.lnkReloadMediaPlugins.Text = "(Reload media plugins)";
            // 
            // lblExportMediaTitle
            // 
            this.lblExportMediaTitle.AutoSize = true;
            this.lblExportMediaTitle.Location = new System.Drawing.Point(3, 16);
            this.lblExportMediaTitle.Name = "lblExportMediaTitle";
            this.lblExportMediaTitle.Size = new System.Drawing.Size(103, 13);
            this.lblExportMediaTitle.TabIndex = 5;
            this.lblExportMediaTitle.Text = "Select export media:";
            // 
            // cmbExportMedia
            // 
            this.cmbExportMedia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExportMedia.FormattingEnabled = true;
            this.cmbExportMedia.Location = new System.Drawing.Point(6, 32);
            this.cmbExportMedia.Name = "cmbExportMedia";
            this.cmbExportMedia.Size = new System.Drawing.Size(380, 21);
            this.cmbExportMedia.TabIndex = 4;
            // 
            // FrmExportResults
            // 
            this.AcceptButton = this.btnExport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(498, 326);
            this.ControlBox = false;
            this.Controls.Add(this.grpExportMedia);
            this.Controls.Add(this.grpExportFormat);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmExportResults";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export results...";
            this.Load += new System.EventHandler(this.FrmExportResults_Load);
            this.grpExportFormat.ResumeLayout(false);
            this.grpExportFormat.PerformLayout();
            this.grpExportMedia.ResumeLayout(false);
            this.grpExportMedia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox grpExportFormat;
        private System.Windows.Forms.Button btnConfigureExportFormatPlugin;
        private System.Windows.Forms.LinkLabel lnkReloadFormatPluginList;
        private System.Windows.Forms.Label lblExportFormatTitle;
        private System.Windows.Forms.ComboBox cmbExportFormat;
        private System.Windows.Forms.GroupBox grpExportMedia;
        private System.Windows.Forms.Button btnConfigureExporMedia;
        private System.Windows.Forms.LinkLabel lnkReloadMediaPlugins;
        private System.Windows.Forms.Label lblExportMediaTitle;
        private System.Windows.Forms.ComboBox cmbExportMedia;
        private System.Windows.Forms.Label lblExportFormatAuthorTitle;
        private System.Windows.Forms.Label lblExportFormatPluginDescriptionTitle;
        private System.Windows.Forms.Label lblExportFormatDescription;
        private System.Windows.Forms.Label lblExportFormatAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}