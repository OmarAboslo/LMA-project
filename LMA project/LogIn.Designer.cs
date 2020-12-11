
namespace LMA_project
{
    partial class LogIn
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
            this.LGebruikersnaam = new System.Windows.Forms.Label();
            this.LWachtwoord = new System.Windows.Forms.Label();
            this.LInloggen = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.btnAccountAanmaken = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LGebruikersnaam
            // 
            this.LGebruikersnaam.AutoSize = true;
            this.LGebruikersnaam.Location = new System.Drawing.Point(537, 194);
            this.LGebruikersnaam.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LGebruikersnaam.Name = "LGebruikersnaam";
            this.LGebruikersnaam.Size = new System.Drawing.Size(191, 29);
            this.LGebruikersnaam.TabIndex = 0;
            this.LGebruikersnaam.Text = "Gebruikersnaam";
            // 
            // LWachtwoord
            // 
            this.LWachtwoord.AutoSize = true;
            this.LWachtwoord.Location = new System.Drawing.Point(567, 277);
            this.LWachtwoord.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LWachtwoord.Name = "LWachtwoord";
            this.LWachtwoord.Size = new System.Drawing.Size(147, 29);
            this.LWachtwoord.TabIndex = 1;
            this.LWachtwoord.Text = "Wachtwoord";
            // 
            // LInloggen
            // 
            this.LInloggen.AutoSize = true;
            this.LInloggen.Location = new System.Drawing.Point(786, 47);
            this.LInloggen.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LInloggen.Name = "LInloggen";
            this.LInloggen.Size = new System.Drawing.Size(107, 29);
            this.LInloggen.TabIndex = 2;
            this.LInloggen.Text = "Inloggen";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(749, 185);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(7);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(228, 35);
            this.tbEmail.TabIndex = 3;
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(749, 268);
            this.tbWachtwoord.Margin = new System.Windows.Forms.Padding(7);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(228, 35);
            this.tbWachtwoord.TabIndex = 4;
            this.tbWachtwoord.UseSystemPasswordChar = true;
            // 
            // btnAccountAanmaken
            // 
            this.btnAccountAanmaken.Location = new System.Drawing.Point(1458, 752);
            this.btnAccountAanmaken.Margin = new System.Windows.Forms.Padding(7);
            this.btnAccountAanmaken.Name = "btnAccountAanmaken";
            this.btnAccountAanmaken.Size = new System.Drawing.Size(233, 125);
            this.btnAccountAanmaken.TabIndex = 11;
            this.btnAccountAanmaken.Text = "Account Maken";
            this.btnAccountAanmaken.UseVisualStyleBackColor = true;
            this.btnAccountAanmaken.Click += new System.EventHandler(this.btnAccountAanmaken_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1451, 620);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Geen Account?";
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(776, 408);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(212, 101);
            this.btnInloggen.TabIndex = 13;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click_1);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1004);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccountAanmaken);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.LInloggen);
            this.Controls.Add(this.LWachtwoord);
            this.Controls.Add(this.LGebruikersnaam);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LGebruikersnaam;
        private System.Windows.Forms.Label LWachtwoord;
        private System.Windows.Forms.Label LInloggen;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.Button btnAccountAanmaken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInloggen;
    }
}