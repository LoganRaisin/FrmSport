namespace FrmSport
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
            this.GrpSports = new System.Windows.Forms.GroupBox();
            this.GrpSaisieSport = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GrpSaisieSport.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpSports
            // 
            this.GrpSports.Location = new System.Drawing.Point(106, 42);
            this.GrpSports.Name = "GrpSports";
            this.GrpSports.Size = new System.Drawing.Size(250, 125);
            this.GrpSports.TabIndex = 0;
            this.GrpSports.TabStop = false;
            this.GrpSports.Text = "Sports";
            // 
            // GrpSaisieSport
            // 
            this.GrpSaisieSport.Controls.Add(this.button1);
            this.GrpSaisieSport.Controls.Add(this.textBox1);
            this.GrpSaisieSport.Location = new System.Drawing.Point(106, 341);
            this.GrpSaisieSport.Name = "GrpSaisieSport";
            this.GrpSaisieSport.Size = new System.Drawing.Size(397, 73);
            this.GrpSaisieSport.TabIndex = 1;
            this.GrpSaisieSport.TabStop = false;
            this.GrpSaisieSport.Text = "Saisie d\'un sport";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 27);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrpSaisieSport);
            this.Controls.Add(this.GrpSports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrpSaisieSport.ResumeLayout(false);
            this.GrpSaisieSport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GrpSports;
        private GroupBox GrpSaisieSport;
        private Button button1;
        private TextBox textBox1;
    }
}