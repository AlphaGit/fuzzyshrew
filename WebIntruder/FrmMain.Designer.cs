namespace WebIntruder
{
    partial class FrmMain
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
            this.lblURLTitle = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.grpHeaders = new System.Windows.Forms.GroupBox();
            this.dgHeaders = new System.Windows.Forms.DataGridView();
            this.colHeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeaderValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpGETParameters = new System.Windows.Forms.GroupBox();
            this.dgGETParameters = new System.Windows.Forms.DataGridView();
            this.colGetParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGetParameterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpVariables = new System.Windows.Forms.GroupBox();
            this.dgVariables = new System.Windows.Forms.DataGridView();
            this.colVariablesVariableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVariableVariableSource = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colVariableConfigure = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnHeaderAdd = new System.Windows.Forms.Button();
            this.btnHeaderRemove = new System.Windows.Forms.Button();
            this.btnGETParameterAdd = new System.Windows.Forms.Button();
            this.btnGETParameterRemove = new System.Windows.Forms.Button();
            this.btnVariableAdd = new System.Windows.Forms.Button();
            this.btnVariableRemove = new System.Windows.Forms.Button();
            this.grpResultExpressions = new System.Windows.Forms.GroupBox();
            this.dgResultExpressions = new System.Windows.Forms.DataGridView();
            this.colExpressionsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpressionsRegex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExpressionAdd = new System.Windows.Forms.Button();
            this.btnExpressionRemove = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSaveConfiguration = new System.Windows.Forms.Button();
            this.btnLoadConfiguration = new System.Windows.Forms.Button();
            this.ofOpenConfig = new System.Windows.Forms.OpenFileDialog();
            this.sdSaveConfig = new System.Windows.Forms.SaveFileDialog();
            this.grpPOSTParameters = new System.Windows.Forms.GroupBox();
            this.dgPOSTParameters = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPOSTParameterAdd = new System.Windows.Forms.Button();
            this.btnPOSTParameterRemove = new System.Windows.Forms.Button();
            this.ddMethod = new System.Windows.Forms.ComboBox();
            this.grpHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeaders)).BeginInit();
            this.grpGETParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGETParameters)).BeginInit();
            this.grpVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVariables)).BeginInit();
            this.grpResultExpressions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultExpressions)).BeginInit();
            this.grpPOSTParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPOSTParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // lblURLTitle
            // 
            this.lblURLTitle.AutoSize = true;
            this.lblURLTitle.Location = new System.Drawing.Point(15, 13);
            this.lblURLTitle.Name = "lblURLTitle";
            this.lblURLTitle.Size = new System.Drawing.Size(32, 13);
            this.lblURLTitle.TabIndex = 0;
            this.lblURLTitle.Text = "URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(50, 10);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(521, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // grpHeaders
            // 
            this.grpHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHeaders.Controls.Add(this.dgHeaders);
            this.grpHeaders.Location = new System.Drawing.Point(12, 43);
            this.grpHeaders.Name = "grpHeaders";
            this.grpHeaders.Size = new System.Drawing.Size(559, 111);
            this.grpHeaders.TabIndex = 2;
            this.grpHeaders.TabStop = false;
            this.grpHeaders.Text = "Headers";
            // 
            // dgHeaders
            // 
            this.dgHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgHeaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHeaderName,
            this.colHeaderValue});
            this.dgHeaders.Location = new System.Drawing.Point(6, 19);
            this.dgHeaders.MultiSelect = false;
            this.dgHeaders.Name = "dgHeaders";
            this.dgHeaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHeaders.Size = new System.Drawing.Size(547, 86);
            this.dgHeaders.TabIndex = 0;
            this.dgHeaders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHeaders_CellContentClick);
            // 
            // colHeaderName
            // 
            this.colHeaderName.DataPropertyName = "Name";
            this.colHeaderName.HeaderText = "Header Name";
            this.colHeaderName.Name = "colHeaderName";
            // 
            // colHeaderValue
            // 
            this.colHeaderValue.DataPropertyName = "Value";
            this.colHeaderValue.HeaderText = "Header Value";
            this.colHeaderValue.Name = "colHeaderValue";
            // 
            // grpGETParameters
            // 
            this.grpGETParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGETParameters.Controls.Add(this.dgGETParameters);
            this.grpGETParameters.Location = new System.Drawing.Point(12, 160);
            this.grpGETParameters.Name = "grpGETParameters";
            this.grpGETParameters.Size = new System.Drawing.Size(559, 111);
            this.grpGETParameters.TabIndex = 5;
            this.grpGETParameters.TabStop = false;
            this.grpGETParameters.Text = "GET Parameters";
            // 
            // dgGETParameters
            // 
            this.dgGETParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgGETParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGETParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGETParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGetParameterName,
            this.colGetParameterValue});
            this.dgGETParameters.Location = new System.Drawing.Point(6, 19);
            this.dgGETParameters.Name = "dgGETParameters";
            this.dgGETParameters.Size = new System.Drawing.Size(547, 86);
            this.dgGETParameters.TabIndex = 0;
            this.dgGETParameters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGETParameters_CellContentClick);
            // 
            // colGetParameterName
            // 
            this.colGetParameterName.DataPropertyName = "Name";
            this.colGetParameterName.HeaderText = "Parameter Name";
            this.colGetParameterName.Name = "colGetParameterName";
            // 
            // colGetParameterValue
            // 
            this.colGetParameterValue.DataPropertyName = "Value";
            this.colGetParameterValue.HeaderText = "Parameter Value";
            this.colGetParameterValue.Name = "colGetParameterValue";
            // 
            // grpVariables
            // 
            this.grpVariables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVariables.Controls.Add(this.dgVariables);
            this.grpVariables.Location = new System.Drawing.Point(12, 415);
            this.grpVariables.Name = "grpVariables";
            this.grpVariables.Size = new System.Drawing.Size(559, 111);
            this.grpVariables.TabIndex = 8;
            this.grpVariables.TabStop = false;
            this.grpVariables.Text = "Variables";
            // 
            // dgVariables
            // 
            this.dgVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVariablesVariableID,
            this.colVariableVariableSource,
            this.colVariableConfigure});
            this.dgVariables.Location = new System.Drawing.Point(6, 19);
            this.dgVariables.Name = "dgVariables";
            this.dgVariables.Size = new System.Drawing.Size(547, 86);
            this.dgVariables.TabIndex = 0;
            this.dgVariables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVariables_CellContentClick);
            this.dgVariables.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVariables_CellValidated);
            // 
            // colVariablesVariableID
            // 
            this.colVariablesVariableID.DataPropertyName = "VariableID";
            this.colVariablesVariableID.FillWeight = 127.1574F;
            this.colVariablesVariableID.HeaderText = "Variable ID";
            this.colVariablesVariableID.Name = "colVariablesVariableID";
            // 
            // colVariableVariableSource
            // 
            this.colVariableVariableSource.FillWeight = 127.1574F;
            this.colVariableVariableSource.HeaderText = "Variable Source";
            this.colVariableVariableSource.Name = "colVariableVariableSource";
            // 
            // colVariableConfigure
            // 
            this.colVariableConfigure.FillWeight = 45.68528F;
            this.colVariableConfigure.HeaderText = "Configure";
            this.colVariableConfigure.Name = "colVariableConfigure";
            this.colVariableConfigure.Text = "...";
            // 
            // btnHeaderAdd
            // 
            this.btnHeaderAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeaderAdd.Location = new System.Drawing.Point(577, 62);
            this.btnHeaderAdd.Name = "btnHeaderAdd";
            this.btnHeaderAdd.Size = new System.Drawing.Size(104, 23);
            this.btnHeaderAdd.TabIndex = 3;
            this.btnHeaderAdd.Text = "Add";
            this.btnHeaderAdd.UseVisualStyleBackColor = true;
            this.btnHeaderAdd.Click += new System.EventHandler(this.btnHeaderAdd_Click);
            // 
            // btnHeaderRemove
            // 
            this.btnHeaderRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeaderRemove.Location = new System.Drawing.Point(577, 91);
            this.btnHeaderRemove.Name = "btnHeaderRemove";
            this.btnHeaderRemove.Size = new System.Drawing.Size(104, 23);
            this.btnHeaderRemove.TabIndex = 4;
            this.btnHeaderRemove.Text = "Remove";
            this.btnHeaderRemove.UseVisualStyleBackColor = true;
            this.btnHeaderRemove.Click += new System.EventHandler(this.btnHeaderRemove_Click);
            // 
            // btnGETParameterAdd
            // 
            this.btnGETParameterAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGETParameterAdd.Location = new System.Drawing.Point(577, 179);
            this.btnGETParameterAdd.Name = "btnGETParameterAdd";
            this.btnGETParameterAdd.Size = new System.Drawing.Size(104, 23);
            this.btnGETParameterAdd.TabIndex = 6;
            this.btnGETParameterAdd.Text = "Add";
            this.btnGETParameterAdd.UseVisualStyleBackColor = true;
            this.btnGETParameterAdd.Click += new System.EventHandler(this.btnGETParameterAdd_Click);
            // 
            // btnGETParameterRemove
            // 
            this.btnGETParameterRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGETParameterRemove.Location = new System.Drawing.Point(577, 208);
            this.btnGETParameterRemove.Name = "btnGETParameterRemove";
            this.btnGETParameterRemove.Size = new System.Drawing.Size(104, 23);
            this.btnGETParameterRemove.TabIndex = 7;
            this.btnGETParameterRemove.Text = "Remove";
            this.btnGETParameterRemove.UseVisualStyleBackColor = true;
            this.btnGETParameterRemove.Click += new System.EventHandler(this.btnGETParameterRemove_Click);
            // 
            // btnVariableAdd
            // 
            this.btnVariableAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVariableAdd.Location = new System.Drawing.Point(577, 434);
            this.btnVariableAdd.Name = "btnVariableAdd";
            this.btnVariableAdd.Size = new System.Drawing.Size(104, 23);
            this.btnVariableAdd.TabIndex = 9;
            this.btnVariableAdd.Text = "Add";
            this.btnVariableAdd.UseVisualStyleBackColor = true;
            this.btnVariableAdd.Click += new System.EventHandler(this.btnVariableAdd_Click);
            // 
            // btnVariableRemove
            // 
            this.btnVariableRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVariableRemove.Location = new System.Drawing.Point(577, 463);
            this.btnVariableRemove.Name = "btnVariableRemove";
            this.btnVariableRemove.Size = new System.Drawing.Size(104, 23);
            this.btnVariableRemove.TabIndex = 10;
            this.btnVariableRemove.Text = "Remove";
            this.btnVariableRemove.UseVisualStyleBackColor = true;
            this.btnVariableRemove.Click += new System.EventHandler(this.btnVariableRemove_Click);
            // 
            // grpResultExpressions
            // 
            this.grpResultExpressions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResultExpressions.Controls.Add(this.dgResultExpressions);
            this.grpResultExpressions.Location = new System.Drawing.Point(12, 532);
            this.grpResultExpressions.Name = "grpResultExpressions";
            this.grpResultExpressions.Size = new System.Drawing.Size(559, 111);
            this.grpResultExpressions.TabIndex = 11;
            this.grpResultExpressions.TabStop = false;
            this.grpResultExpressions.Text = "Result expressions to search";
            // 
            // dgResultExpressions
            // 
            this.dgResultExpressions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResultExpressions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgResultExpressions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultExpressions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExpressionsName,
            this.colExpressionsRegex});
            this.dgResultExpressions.Location = new System.Drawing.Point(6, 19);
            this.dgResultExpressions.Name = "dgResultExpressions";
            this.dgResultExpressions.Size = new System.Drawing.Size(547, 86);
            this.dgResultExpressions.TabIndex = 0;
            this.dgResultExpressions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResultExpressions_CellContentClick);
            // 
            // colExpressionsName
            // 
            this.colExpressionsName.DataPropertyName = "Name";
            this.colExpressionsName.HeaderText = "Expression Name";
            this.colExpressionsName.Name = "colExpressionsName";
            // 
            // colExpressionsRegex
            // 
            this.colExpressionsRegex.DataPropertyName = "Regex";
            this.colExpressionsRegex.HeaderText = "Expression Regex";
            this.colExpressionsRegex.Name = "colExpressionsRegex";
            // 
            // btnExpressionAdd
            // 
            this.btnExpressionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpressionAdd.Location = new System.Drawing.Point(577, 551);
            this.btnExpressionAdd.Name = "btnExpressionAdd";
            this.btnExpressionAdd.Size = new System.Drawing.Size(104, 23);
            this.btnExpressionAdd.TabIndex = 12;
            this.btnExpressionAdd.Text = "Add";
            this.btnExpressionAdd.UseVisualStyleBackColor = true;
            this.btnExpressionAdd.Click += new System.EventHandler(this.btnExpressionAdd_Click);
            // 
            // btnExpressionRemove
            // 
            this.btnExpressionRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpressionRemove.Location = new System.Drawing.Point(577, 580);
            this.btnExpressionRemove.Name = "btnExpressionRemove";
            this.btnExpressionRemove.Size = new System.Drawing.Size(104, 23);
            this.btnExpressionRemove.TabIndex = 13;
            this.btnExpressionRemove.Text = "Remove";
            this.btnExpressionRemove.UseVisualStyleBackColor = true;
            this.btnExpressionRemove.Click += new System.EventHandler(this.btnExpressionRemove_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(577, 654);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 38);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSaveConfiguration
            // 
            this.btnSaveConfiguration.Location = new System.Drawing.Point(12, 654);
            this.btnSaveConfiguration.Name = "btnSaveConfiguration";
            this.btnSaveConfiguration.Size = new System.Drawing.Size(146, 23);
            this.btnSaveConfiguration.TabIndex = 15;
            this.btnSaveConfiguration.Text = "Save configuration...";
            this.btnSaveConfiguration.UseVisualStyleBackColor = true;
            this.btnSaveConfiguration.Click += new System.EventHandler(this.btnSaveConfiguration_Click);
            // 
            // btnLoadConfiguration
            // 
            this.btnLoadConfiguration.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadConfiguration.Location = new System.Drawing.Point(164, 654);
            this.btnLoadConfiguration.Name = "btnLoadConfiguration";
            this.btnLoadConfiguration.Size = new System.Drawing.Size(146, 23);
            this.btnLoadConfiguration.TabIndex = 15;
            this.btnLoadConfiguration.Text = "Load Configuration...";
            this.btnLoadConfiguration.UseVisualStyleBackColor = false;
            this.btnLoadConfiguration.Click += new System.EventHandler(this.btnLoadConfiguration_Click);
            // 
            // ofOpenConfig
            // 
            this.ofOpenConfig.CheckFileExists = false;
            this.ofOpenConfig.CheckPathExists = false;
            this.ofOpenConfig.DefaultExt = "xml";
            this.ofOpenConfig.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            this.ofOpenConfig.Title = "Open configuration file...";
            // 
            // sdSaveConfig
            // 
            this.sdSaveConfig.CheckPathExists = false;
            this.sdSaveConfig.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            this.sdSaveConfig.SupportMultiDottedExtensions = true;
            this.sdSaveConfig.Title = "Save configuration file...";
            // 
            // grpPOSTParameters
            // 
            this.grpPOSTParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPOSTParameters.Controls.Add(this.dgPOSTParameters);
            this.grpPOSTParameters.Location = new System.Drawing.Point(12, 277);
            this.grpPOSTParameters.Name = "grpPOSTParameters";
            this.grpPOSTParameters.Size = new System.Drawing.Size(559, 111);
            this.grpPOSTParameters.TabIndex = 5;
            this.grpPOSTParameters.TabStop = false;
            this.grpPOSTParameters.Text = "POST Parameters";
            // 
            // dgPOSTParameters
            // 
            this.dgPOSTParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPOSTParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPOSTParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPOSTParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgPOSTParameters.Location = new System.Drawing.Point(6, 19);
            this.dgPOSTParameters.Name = "dgPOSTParameters";
            this.dgPOSTParameters.Size = new System.Drawing.Size(547, 86);
            this.dgPOSTParameters.TabIndex = 0;
            this.dgPOSTParameters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGETParameters_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Parameter Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn2.HeaderText = "Parameter Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnPOSTParameterAdd
            // 
            this.btnPOSTParameterAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPOSTParameterAdd.Location = new System.Drawing.Point(577, 296);
            this.btnPOSTParameterAdd.Name = "btnPOSTParameterAdd";
            this.btnPOSTParameterAdd.Size = new System.Drawing.Size(104, 23);
            this.btnPOSTParameterAdd.TabIndex = 6;
            this.btnPOSTParameterAdd.Text = "Add";
            this.btnPOSTParameterAdd.UseVisualStyleBackColor = true;
            this.btnPOSTParameterAdd.Click += new System.EventHandler(this.btnPOSTParameterAdd_Click);
            // 
            // btnPOSTParameterRemove
            // 
            this.btnPOSTParameterRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPOSTParameterRemove.Location = new System.Drawing.Point(577, 325);
            this.btnPOSTParameterRemove.Name = "btnPOSTParameterRemove";
            this.btnPOSTParameterRemove.Size = new System.Drawing.Size(104, 23);
            this.btnPOSTParameterRemove.TabIndex = 7;
            this.btnPOSTParameterRemove.Text = "Remove";
            this.btnPOSTParameterRemove.UseVisualStyleBackColor = true;
            this.btnPOSTParameterRemove.Click += new System.EventHandler(this.btnPOSTParameterRemove_Click);
            // 
            // ddMethod
            // 
            this.ddMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddMethod.FormattingEnabled = true;
            this.ddMethod.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.ddMethod.Location = new System.Drawing.Point(577, 10);
            this.ddMethod.Name = "ddMethod";
            this.ddMethod.Size = new System.Drawing.Size(104, 21);
            this.ddMethod.TabIndex = 16;
            this.ddMethod.SelectedIndexChanged += new System.EventHandler(this.ddMethod_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 704);
            this.Controls.Add(this.ddMethod);
            this.Controls.Add(this.btnLoadConfiguration);
            this.Controls.Add(this.btnSaveConfiguration);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExpressionRemove);
            this.Controls.Add(this.btnVariableRemove);
            this.Controls.Add(this.btnPOSTParameterRemove);
            this.Controls.Add(this.btnGETParameterRemove);
            this.Controls.Add(this.btnHeaderRemove);
            this.Controls.Add(this.btnExpressionAdd);
            this.Controls.Add(this.btnVariableAdd);
            this.Controls.Add(this.btnPOSTParameterAdd);
            this.Controls.Add(this.btnGETParameterAdd);
            this.Controls.Add(this.btnHeaderAdd);
            this.Controls.Add(this.grpResultExpressions);
            this.Controls.Add(this.grpVariables);
            this.Controls.Add(this.grpPOSTParameters);
            this.Controls.Add(this.grpGETParameters);
            this.Controls.Add(this.grpHeaders);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURLTitle);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebIntruder";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpHeaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHeaders)).EndInit();
            this.grpGETParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGETParameters)).EndInit();
            this.grpVariables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVariables)).EndInit();
            this.grpResultExpressions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResultExpressions)).EndInit();
            this.grpPOSTParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPOSTParameters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURLTitle;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.GroupBox grpHeaders;
        private System.Windows.Forms.DataGridView dgHeaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeaderValue;
        private System.Windows.Forms.GroupBox grpGETParameters;
        private System.Windows.Forms.DataGridView dgGETParameters;
        private System.Windows.Forms.GroupBox grpVariables;
        private System.Windows.Forms.DataGridView dgVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGetParameterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGetParameterValue;
        private System.Windows.Forms.Button btnHeaderAdd;
        private System.Windows.Forms.Button btnHeaderRemove;
        private System.Windows.Forms.Button btnGETParameterAdd;
        private System.Windows.Forms.Button btnGETParameterRemove;
        private System.Windows.Forms.Button btnVariableAdd;
        private System.Windows.Forms.Button btnVariableRemove;
        private System.Windows.Forms.GroupBox grpResultExpressions;
        private System.Windows.Forms.DataGridView dgResultExpressions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpressionsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpressionsRegex;
        private System.Windows.Forms.Button btnExpressionAdd;
        private System.Windows.Forms.Button btnExpressionRemove;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariablesVariableID;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVariableVariableSource;
        private System.Windows.Forms.DataGridViewButtonColumn colVariableConfigure;
        private System.Windows.Forms.Button btnSaveConfiguration;
        private System.Windows.Forms.Button btnLoadConfiguration;
        private System.Windows.Forms.OpenFileDialog ofOpenConfig;
        private System.Windows.Forms.SaveFileDialog sdSaveConfig;
        private System.Windows.Forms.GroupBox grpPOSTParameters;
        private System.Windows.Forms.DataGridView dgPOSTParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnPOSTParameterAdd;
        private System.Windows.Forms.Button btnPOSTParameterRemove;
        private System.Windows.Forms.ComboBox ddMethod;
    }
}

