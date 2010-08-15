namespace FuzzyShrew.Model.Variables.Counter
{
    partial class FrmCounterConfigurationForm
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
            this.lblStartValue = new System.Windows.Forms.Label();
            this.lblEndValue = new System.Windows.Forms.Label();
            this.udStartValue = new System.Windows.Forms.NumericUpDown();
            this.udEndValue = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblFormat = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFormat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.udStartValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEndValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartValue
            // 
            this.lblStartValue.AutoSize = true;
            this.lblStartValue.Location = new System.Drawing.Point(12, 9);
            this.lblStartValue.Name = "lblStartValue";
            this.lblStartValue.Size = new System.Drawing.Size(61, 13);
            this.lblStartValue.TabIndex = 0;
            this.lblStartValue.Text = "Start value:";
            // 
            // lblEndValue
            // 
            this.lblEndValue.AutoSize = true;
            this.lblEndValue.Location = new System.Drawing.Point(12, 35);
            this.lblEndValue.Name = "lblEndValue";
            this.lblEndValue.Size = new System.Drawing.Size(59, 13);
            this.lblEndValue.TabIndex = 0;
            this.lblEndValue.Text = "End Value:";
            // 
            // udStartValue
            // 
            this.udStartValue.Location = new System.Drawing.Point(103, 7);
            this.udStartValue.Name = "udStartValue";
            this.udStartValue.Size = new System.Drawing.Size(120, 20);
            this.udStartValue.TabIndex = 1;
            this.udStartValue.ValueChanged += new System.EventHandler(this.udStartValue_ValueChanged);
            // 
            // udEndValue
            // 
            this.udEndValue.Location = new System.Drawing.Point(103, 33);
            this.udEndValue.Name = "udEndValue";
            this.udEndValue.Size = new System.Drawing.Size(120, 20);
            this.udEndValue.TabIndex = 1;
            this.udEndValue.ValueChanged += new System.EventHandler(this.udEndValue_ValueChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(116, 85);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(51, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(12, 61);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(42, 13);
            this.lblFormat.TabIndex = 0;
            this.lblFormat.Text = "Format:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(51, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(103, 60);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(120, 20);
            this.txtFormat.TabIndex = 3;
            this.txtFormat.Text = "00";
            this.txtFormat.TextChanged += new System.EventHandler(this.txtFormat_TextChanged);
            // 
            // FrmCounterConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 117);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.udEndValue);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.udStartValue);
            this.Controls.Add(this.lblEndValue);
            this.Controls.Add(this.lblStartValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCounterConfigurationForm";
            this.Text = "Counter configuration";
            ((System.ComponentModel.ISupportInitialize)(this.udStartValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udEndValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartValue;
        private System.Windows.Forms.Label lblEndValue;
        private System.Windows.Forms.NumericUpDown udStartValue;
        private System.Windows.Forms.NumericUpDown udEndValue;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFormat;
    }
}