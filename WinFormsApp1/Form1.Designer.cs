namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lab1Dykun1 = new WinFormsControlLibrary1.Lab1Dykun();
            SuspendLayout();
            // 
            // lab1Dykun1
            // 
            lab1Dykun1.Location = new Point(138, 95);
            lab1Dykun1.Meters = 0D;
            lab1Dykun1.Name = "lab1Dykun1";
            lab1Dykun1.Number = 0D;
            lab1Dykun1.Size = new Size(408, 237);
            lab1Dykun1.TabIndex = 0;
            lab1Dykun1.Unit = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 450);
            Controls.Add(lab1Dykun1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private WinFormsControlLibrary1.Lab1Dykun lab1Dykun1;
    }
}
