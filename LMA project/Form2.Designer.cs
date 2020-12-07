
namespace LMA_project
{
    partial class Form2
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
            this.TGebruikersnaam = new System.Windows.Forms.TextBox();
            this.TWachtwoord = new System.Windows.Forms.TextBox();
            this.BOk = new System.Windows.Forms.Button();
            this.BAccoun_maken = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LGebruikersnaam
            // 
            this.LGebruikersnaam.AutoSize = true;
            this.LGebruikersnaam.Location = new System.Drawing.Point(230, 87);
            this.LGebruikersnaam.Name = "LGebruikersnaam";
            this.LGebruikersnaam.Size = new System.Drawing.Size(84, 13);
            this.LGebruikersnaam.TabIndex = 0;
            this.LGebruikersnaam.Text = "Gebruikersnaam";
            // 
            // LWachtwoord
            // 
            this.LWachtwoord.AutoSize = true;
            this.LWachtwoord.Location = new System.Drawing.Point(230, 170);
            this.LWachtwoord.Name = "LWachtwoord";
            this.LWachtwoord.Size = new System.Drawing.Size(68, 13);
            this.LWachtwoord.TabIndex = 1;
            this.LWachtwoord.Text = "Wachtwoord";
            // 
            // LInloggen
            // 
            this.LInloggen.AutoSize = true;
            this.LInloggen.Location = new System.Drawing.Point(337, 21);
            this.LInloggen.Name = "LInloggen";
            this.LInloggen.Size = new System.Drawing.Size(48, 13);
            this.LInloggen.TabIndex = 2;
            this.LInloggen.Text = "Inloggen";
            // 
            // TGebruikersnaam
            // 
            this.TGebruikersnaam.Location = new System.Drawing.Point(345, 80);
            this.TGebruikersnaam.Name = "TGebruikersnaam";
            this.TGebruikersnaam.Size = new System.Drawing.Size(100, 20);
            this.TGebruikersnaam.TabIndex = 3;
            // 
            // TWachtwoord
            // 
            this.TWachtwoord.Location = new System.Drawing.Point(345, 167);
            this.TWachtwoord.Name = "TWachtwoord";
            this.TWachtwoord.Size = new System.Drawing.Size(100, 20);
            this.TWachtwoord.TabIndex = 4;
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(345, 278);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(100, 56);
            this.BOk.TabIndex = 10;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            // 
            // BAccoun_maken
            // 
            this.BAccoun_maken.Location = new System.Drawing.Point(625, 337);
            this.BAccoun_maken.Name = "BAccoun_maken";
            this.BAccoun_maken.Size = new System.Drawing.Size(100, 56);
            this.BAccoun_maken.TabIndex = 11;
            this.BAccoun_maken.Text = "Account Maken";
            this.BAccoun_maken.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Geen Account?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BAccoun_maken);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.TWachtwoord);
            this.Controls.Add(this.TGebruikersnaam);
            this.Controls.Add(this.LInloggen);
            this.Controls.Add(this.LWachtwoord);
            this.Controls.Add(this.LGebruikersnaam);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LGebruikersnaam;
        private System.Windows.Forms.Label LWachtwoord;
        private System.Windows.Forms.Label LInloggen;
        private System.Windows.Forms.TextBox TGebruikersnaam;
        private System.Windows.Forms.TextBox TWachtwoord;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.Button BAccoun_maken;
        private System.Windows.Forms.Label label1;
    }
}