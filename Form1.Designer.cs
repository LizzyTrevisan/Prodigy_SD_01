namespace WindowsFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxTempType;
        private System.Windows.Forms.TextBox textBoxInputTemp;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textBoxOutput1;
        private System.Windows.Forms.TextBox textBoxOutput2;
        private System.Windows.Forms.Label labelInput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxTempType = new System.Windows.Forms.ComboBox();
            this.textBoxInputTemp = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxOutput1 = new System.Windows.Forms.TextBox();
            this.textBoxOutput2 = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTempType
            // 
            this.comboBoxTempType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTempType.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxTempType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTempType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTempType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBoxTempType.FormattingEnabled = true;
            this.comboBoxTempType.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.comboBoxTempType.Location = new System.Drawing.Point(169, 148);
            this.comboBoxTempType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTempType.Name = "comboBoxTempType";
            this.comboBoxTempType.Size = new System.Drawing.Size(199, 28);
            this.comboBoxTempType.TabIndex = 0;
            // 
            // textBoxInputTemp
            // 
            this.textBoxInputTemp.Location = new System.Drawing.Point(200, 66);
            this.textBoxInputTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInputTemp.Name = "textBoxInputTemp";
            this.textBoxInputTemp.Size = new System.Drawing.Size(132, 22);
            this.textBoxInputTemp.TabIndex = 1;
            this.textBoxInputTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonConvert.Location = new System.Drawing.Point(214, 202);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(100, 39);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // textBoxOutput1
            // 
            this.textBoxOutput1.Location = new System.Drawing.Point(200, 260);
            this.textBoxOutput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOutput1.Name = "textBoxOutput1";
            this.textBoxOutput1.ReadOnly = true;
            this.textBoxOutput1.Size = new System.Drawing.Size(132, 22);
            this.textBoxOutput1.TabIndex = 3;
            this.textBoxOutput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOutput2
            // 
            this.textBoxOutput2.Location = new System.Drawing.Point(200, 304);
            this.textBoxOutput2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOutput2.Name = "textBoxOutput2";
            this.textBoxOutput2.ReadOnly = true;
            this.textBoxOutput2.Size = new System.Drawing.Size(132, 22);
            this.textBoxOutput2.TabIndex = 4;
            this.textBoxOutput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelInput.Location = new System.Drawing.Point(164, 25);
            this.labelInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(207, 25);
            this.labelInput.TabIndex = 5;
            this.labelInput.Text = "Enter the Temperature";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInput.Click += new System.EventHandler(this.labelInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(182, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Converting from";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxOutput2);
            this.Controls.Add(this.textBoxOutput1);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxInputTemp);
            this.Controls.Add(this.comboBoxTempType);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
