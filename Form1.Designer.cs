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
            this.Sport1 = new System.Windows.Forms.Label();
            this.GrpSaisieSport = new System.Windows.Forms.GroupBox();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.TxtSport = new System.Windows.Forms.TextBox();
            this.BtnLeave = new System.Windows.Forms.Button();
            this.GrpSports.SuspendLayout();
            this.GrpSaisieSport.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpSports
            // 
            this.GrpSports.Controls.Add(this.Sport1);
            this.GrpSports.Location = new System.Drawing.Point(106, 46);
            this.GrpSports.Name = "GrpSports";
            this.GrpSports.Size = new System.Drawing.Size(250, 125);
            this.GrpSports.TabIndex = 0;
            this.GrpSports.TabStop = false;
            this.GrpSports.Text = "Sports";
            this.GrpSports.Enter += new System.EventHandler(this.GrpSports_Enter);
            // 
            // Sport1
            // 
            this.Sport1.AutoSize = true;
            this.Sport1.Location = new System.Drawing.Point(6, 32);
            this.Sport1.Name = "Sport1";
            this.Sport1.Size = new System.Drawing.Size(0, 20);
            this.Sport1.TabIndex = 0;
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
            // BtnAjout
            // 
            this.BtnAjout.Location = new System.Drawing.Point(287, 26);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(104, 29);
            this.BtnAjout.TabIndex = 1;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // TxtSport
            // 
            this.TxtSport.Location = new System.Drawing.Point(6, 26);
            this.TxtSport.Name = "TxtSport";
            this.TxtSport.Size = new System.Drawing.Size(255, 27);
            this.TxtSport.TabIndex = 0;
            this.TxtSport.TextChanged += new System.EventHandler(this.TxtSport_TextChanged);
            // 
            // BtnLeave
            // 
            this.BtnLeave.Location = new System.Drawing.Point(509, 367);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(122, 29);
            this.BtnLeave.TabIndex = 2;
            this.BtnLeave.Text = "Quitter";
            this.BtnLeave.UseVisualStyleBackColor = true;
            this.BtnLeave.Click += new System.EventHandler(this.BtnLeave_Click);
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
            this.Load += new System.EventHandler(this.Exercice_Load);
            this.GrpSports.ResumeLayout(false);
            this.GrpSports.PerformLayout();
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
        private Label Sport1;
    }
}