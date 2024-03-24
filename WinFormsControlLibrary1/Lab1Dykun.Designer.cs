namespace WinFormsControlLibrary1
{
    partial class Lab1Dykun
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxInput = new TextBox();
            lblInput = new Label();
            lblResult = new Label();
            cmbBox1 = new ComboBox();
            lblResultMeter = new Label();
            lblUnit = new Label();
            SuspendLayout();
            // 
            // txtBoxInput
            // 
            txtBoxInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxInput.Location = new Point(90, 70);
            txtBoxInput.Name = "txtBoxInput";
            txtBoxInput.Size = new Size(182, 34);
            txtBoxInput.TabIndex = 0;
            txtBoxInput.TextChanged += txtBoxInput_TextChanged;
            txtBoxInput.KeyPress += txtBoxInput_KeyPress;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblInput.Location = new Point(90, 37);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(104, 28);
            lblInput.TabIndex = 2;
            lblInput.Text = "Значення:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResult.Location = new Point(91, 117);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(134, 28);
            lblResult.TabIndex = 4;
            lblResult.Text = "Результат (м):";
            // 
            // cmbBox1
            // 
            cmbBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbBox1.FormattingEnabled = true;
            cmbBox1.Items.AddRange(new object[] { "мм", "см", "дм", "м" });
            cmbBox1.Location = new Point(278, 70);
            cmbBox1.Name = "cmbBox1";
            cmbBox1.Size = new Size(106, 36);
            cmbBox1.TabIndex = 5;
            cmbBox1.SelectedIndexChanged += cmbBox1_SelectedIndexChanged;
            // 
            // lblResultMeter
            // 
            lblResultMeter.AutoSize = true;
            lblResultMeter.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResultMeter.Location = new Point(90, 150);
            lblResultMeter.Name = "lblResultMeter";
            lblResultMeter.Size = new Size(26, 31);
            lblResultMeter.TabIndex = 6;
            lblResultMeter.Text = "0";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUnit.Location = new Point(278, 8);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(101, 56);
            lblUnit.TabIndex = 7;
            lblUnit.Text = "Одиниця\r\nдовжини:";
            // 
            // Lab1Dykun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblUnit);
            Controls.Add(lblResultMeter);
            Controls.Add(cmbBox1);
            Controls.Add(lblResult);
            Controls.Add(lblInput);
            Controls.Add(txtBoxInput);
            Name = "Lab1Dykun";
            Size = new Size(493, 213);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput;
        private Label lblInput;
        private Label lblResult;
        private ComboBox cmbBox1;
        private Label lblResultMeter;
        private Label lblUnit;
    }
}
