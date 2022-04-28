namespace FrmSport
{
    partial class Exercice
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
            this.TxtSport = new System.Windows.Forms.TextBox();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.BtnLeave = new System.Windows.Forms.Button();
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
            this.GrpSaisieSport.Controls.Add(this.BtnAjout);
            this.GrpSaisieSport.Controls.Add(this.TxtSport);
            this.GrpSaisieSport.Location = new System.Drawing.Point(106, 341);
            this.GrpSaisieSport.Name = "GrpSaisieSport";
            this.GrpSaisieSport.Size = new System.Drawing.Size(397, 73);
            this.GrpSaisieSport.TabIndex = 1;
            this.GrpSaisieSport.TabStop = false;
            this.GrpSaisieSport.Text = "Saisie d\'un sport";
            // 
            // TxtSport
            // 
            this.TxtSport.Location = new System.Drawing.Point(6, 26);
            this.TxtSport.Name = "TxtSport";
            this.TxtSport.Size = new System.Drawing.Size(255, 27);
            this.TxtSport.TabIndex = 0;
            // 
            // BtnAjout
            // 
            this.BtnAjout.Location = new System.Drawing.Point(287, 26);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(104, 29);
            this.BtnAjout.TabIndex = 1;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            // 
            // BtnLeave
            // 
            this.BtnLeave.Location = new System.Drawing.Point(509, 365);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(122, 29);
            this.BtnLeave.TabIndex = 2;
            this.BtnLeave.Text = "Quitter";
            this.BtnLeave.UseVisualStyleBackColor = true;
            // 
            // Exercice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLeave);
            this.Controls.Add(this.GrpSaisieSport);
            this.Controls.Add(this.GrpSports);
            this.Name = "Exercice";
            this.Text = "Exercice 2";
            this.GrpSaisieSport.ResumeLayout(false);
            this.GrpSaisieSport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GrpSports;
        private GroupBox GrpSaisieSport;
        private Button BtnAjout;
        private TextBox TxtSport;
        private Button BtnLeave;
    }
}