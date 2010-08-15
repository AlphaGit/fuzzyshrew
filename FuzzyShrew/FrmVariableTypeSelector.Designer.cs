namespace FuzzyShrew
{
    partial class FrmVariableTypeSelector
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpVariableTypes = new System.Windows.Forms.GroupBox();
            this.lblVariableTypeDescription = new System.Windows.Forms.Label();
            this.lblVariableTypeAuthor = new System.Windows.Forms.Label();
            this.lblVariableTypeDescriptionTitle = new System.Windows.Forms.Label();
            this.lblVariableTypeAuthorTitle = new System.Windows.Forms.Label();
            this.btnConfigureVariableTypePlugin = new System.Windows.Forms.Button();
            this.lnkReloadVariablePluginList = new System.Windows.Forms.LinkLabel();
            this.lblVariableTypeTitle = new System.Windows.Forms.Label();
            this.cmbVariableTypes = new System.Windows.Forms.ComboBox();
            this.grpVariableTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(409, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(327, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grpVariableTypes
            // 
            this.grpVariableTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVariableTypes.Controls.Add(this.lblVariableTypeDescription);
            this.grpVariableTypes.Controls.Add(this.lblVariableTypeAuthor);
            this.grpVariableTypes.Controls.Add(this.lblVariableTypeDescriptionTitle);
            this.grpVariableTypes.Controls.Add(this.lblVariableTypeAuthorTitle);
            this.grpVariableTypes.Controls.Add(this.btnConfigureVariableTypePlugin);
            this.grpVariableTypes.Controls.Add(this.lnkReloadVariablePluginList);
            this.grpVariableTypes.Controls.Add(this.lblVariableTypeTitle);
            this.grpVariableTypes.Controls.Add(this.cmbVariableTypes);
            this.grpVariableTypes.Location = new System.Drawing.Point(12, 12);
            this.grpVariableTypes.Name = "grpVariableTypes";
            this.grpVariableTypes.Size = new System.Drawing.Size(473, 129);
            this.grpVariableTypes.TabIndex = 5;
            this.grpVariableTypes.TabStop = false;
            this.grpVariableTypes.Text = "Variable type";
            // 
            // lblVariableTypeDescription
            // 
            this.lblVariableTypeDescription.Location = new System.Drawing.Point(102, 69);
            this.lblVariableTypeDescription.Name = "lblVariableTypeDescription";
            this.lblVariableTypeDescription.Size = new System.Drawing.Size(364, 47);
            this.lblVariableTypeDescription.TabIndex = 9;
            // 
            // lblVariableTypeAuthor
            // 
            this.lblVariableTypeAuthor.Location = new System.Drawing.Point(102, 56);
            this.lblVariableTypeAuthor.Name = "lblVariableTypeAuthor";
            this.lblVariableTypeAuthor.Size = new System.Drawing.Size(364, 13);
            this.lblVariableTypeAuthor.TabIndex = 9;
            // 
            // lblVariableTypeDescriptionTitle
            // 
            this.lblVariableTypeDescriptionTitle.AutoSize = true;
            this.lblVariableTypeDescriptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariableTypeDescriptionTitle.Location = new System.Drawing.Point(21, 69);
            this.lblVariableTypeDescriptionTitle.Name = "lblVariableTypeDescriptionTitle";
            this.lblVariableTypeDescriptionTitle.Size = new System.Drawing.Size(75, 13);
            this.lblVariableTypeDescriptionTitle.TabIndex = 8;
            this.lblVariableTypeDescriptionTitle.Text = "Description:";
            // 
            // lblVariableTypeAuthorTitle
            // 
            this.lblVariableTypeAuthorTitle.AutoSize = true;
            this.lblVariableTypeAuthorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariableTypeAuthorTitle.Location = new System.Drawing.Point(48, 56);
            this.lblVariableTypeAuthorTitle.Name = "lblVariableTypeAuthorTitle";
            this.lblVariableTypeAuthorTitle.Size = new System.Drawing.Size(48, 13);
            this.lblVariableTypeAuthorTitle.TabIndex = 8;
            this.lblVariableTypeAuthorTitle.Text = "Author:";
            // 
            // btnConfigureVariableTypePlugin
            // 
            this.btnConfigureVariableTypePlugin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigureVariableTypePlugin.Location = new System.Drawing.Point(392, 30);
            this.btnConfigureVariableTypePlugin.Name = "btnConfigureVariableTypePlugin";
            this.btnConfigureVariableTypePlugin.Size = new System.Drawing.Size(75, 23);
            this.btnConfigureVariableTypePlugin.TabIndex = 7;
            this.btnConfigureVariableTypePlugin.Text = "Configure...";
            this.btnConfigureVariableTypePlugin.UseVisualStyleBackColor = true;
            this.btnConfigureVariableTypePlugin.Click += new System.EventHandler(this.btnConfigureVariableTypePlugin_Click);
            // 
            // lnkReloadVariablePluginList
            // 
            this.lnkReloadVariablePluginList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkReloadVariablePluginList.AutoSize = true;
            this.lnkReloadVariablePluginList.Location = new System.Drawing.Point(271, 16);
            this.lnkReloadVariablePluginList.Name = "lnkReloadVariablePluginList";
            this.lnkReloadVariablePluginList.Size = new System.Drawing.Size(123, 13);
            this.lnkReloadVariablePluginList.TabIndex = 6;
            this.lnkReloadVariablePluginList.TabStop = true;
            this.lnkReloadVariablePluginList.Text = "(Reload variable plugins)";
            // 
            // lblVariableTypeTitle
            // 
            this.lblVariableTypeTitle.AutoSize = true;
            this.lblVariableTypeTitle.Location = new System.Drawing.Point(2, 16);
            this.lblVariableTypeTitle.Name = "lblVariableTypeTitle";
            this.lblVariableTypeTitle.Size = new System.Drawing.Size(103, 13);
            this.lblVariableTypeTitle.TabIndex = 5;
            this.lblVariableTypeTitle.Text = "Select variable type:";
            // 
            // cmbVariableTypes
            // 
            this.cmbVariableTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVariableTypes.FormattingEnabled = true;
            this.cmbVariableTypes.Location = new System.Drawing.Point(6, 32);
            this.cmbVariableTypes.Name = "cmbVariableTypes";
            this.cmbVariableTypes.Size = new System.Drawing.Size(380, 21);
            this.cmbVariableTypes.TabIndex = 4;
            this.cmbVariableTypes.SelectedIndexChanged += new System.EventHandler(this.cmbExportFormat_SelectedIndexChanged);
            // 
            // FrmVariableTypeSelector
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(498, 193);
            this.ControlBox = false;
            this.Controls.Add(this.grpVariableTypes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmVariableTypeSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select variable type...";
            this.Load += new System.EventHandler(this.FrmExportResults_Load);
            this.grpVariableTypes.ResumeLayout(false);
            this.grpVariableTypes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpVariableTypes;
        private System.Windows.Forms.Button btnConfigureVariableTypePlugin;
        private System.Windows.Forms.LinkLabel lnkReloadVariablePluginList;
        private System.Windows.Forms.Label lblVariableTypeTitle;
        private System.Windows.Forms.ComboBox cmbVariableTypes;
        private System.Windows.Forms.Label lblVariableTypeAuthorTitle;
        private System.Windows.Forms.Label lblVariableTypeDescriptionTitle;
        private System.Windows.Forms.Label lblVariableTypeDescription;
        private System.Windows.Forms.Label lblVariableTypeAuthor;
    }
}