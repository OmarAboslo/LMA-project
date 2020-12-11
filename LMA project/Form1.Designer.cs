
namespace LMA_project
{
    partial class Form1
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
            this.LAccount_aanmaken = new System.Windows.Forms.Label();
            this.LNaam = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LWachtwoord = new System.Windows.Forms.Label();
            this.LWachtwoord_bevestigen = new System.Windows.Forms.Label();
            this.TNaam = new System.Windows.Forms.TextBox();
            this.TWachtwoord = new System.Windows.Forms.TextBox();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.TWachtwoord_bevestigen = new System.Windows.Forms.TextBox();
            this.BOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAccount_aanmaken
            // 
            this.LAccount_aanmaken.AutoSize = true;
            this.LAccount_aanmaken.Location = new System.Drawing.Point(396, 78);
            this.LAccount_aanmaken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAccount_aanmaken.Name = "LAccount_aanmaken";
            this.LAccount_aanmaken.Size = new System.Drawing.Size(129, 17);
            this.LAccount_aanmaken.TabIndex = 0;
            this.LAccount_aanmaken.Text = "Account aanmaken";
            // 
            // LNaam
            // 
            this.LNaam.AutoSize = true;
            this.LNaam.Location = new System.Drawing.Point(271, 160);
            this.LNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNaam.Name = "LNaam";
            this.LNaam.Size = new System.Drawing.Size(49, 17);
            this.LNaam.TabIndex = 1;
            this.LNaam.Text = "Naam:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(271, 204);
            this.LEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(42, 17);
            this.LEmail.TabIndex = 2;
            this.LEmail.Text = "Email";
            // 
            // LWachtwoord
            // 
            this.LWachtwoord.AutoSize = true;
            this.LWachtwoord.Location = new System.Drawing.Point(271, 251);
            this.LWachtwoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LWachtwoord.Name = "LWachtwoord";
            this.LWachtwoord.Size = new System.Drawing.Size(90, 17);
            this.LWachtwoord.TabIndex = 3;
            this.LWachtwoord.Text = "Wachtwoord:";
            // 
            // LWachtwoord_bevestigen
            // 
            this.LWachtwoord_bevestigen.AutoSize = true;
            this.LWachtwoord_bevestigen.Location = new System.Drawing.Point(224, 296);
            this.LWachtwoord_bevestigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LWachtwoord_bevestigen.Name = "LWachtwoord_bevestigen";
            this.LWachtwoord_bevestigen.Size = new System.Drawing.Size(159, 17);
            this.LWachtwoord_bevestigen.TabIndex = 4;
            this.LWachtwoord_bevestigen.Text = "Wachtwoord bevestigen";
            // 
            // TNaam
            // 
            this.TNaam.Location = new System.Drawing.Point(430, 155);
            this.TNaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TNaam.Name = "TNaam";
            this.TNaam.Size = new System.Drawing.Size(132, 22);
            this.TNaam.TabIndex = 5;
            // 
            // TWachtwoord
            // 
            this.TWachtwoord.Location = new System.Drawing.Point(430, 251);
            this.TWachtwoord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TWachtwoord.Name = "TWachtwoord";
            this.TWachtwoord.Size = new System.Drawing.Size(132, 22);
            this.TWachtwoord.TabIndex = 6;
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(430, 204);
            this.TEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(132, 22);
            this.TEmail.TabIndex = 7;
            // 
            // TWachtwoord_bevestigen
            // 
            this.TWachtwoord_bevestigen.Location = new System.Drawing.Point(430, 296);
            this.TWachtwoord_bevestigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TWachtwoord_bevestigen.Name = "TWachtwoord_bevestigen";
            this.TWachtwoord_bevestigen.Size = new System.Drawing.Size(132, 22);
            this.TWachtwoord_bevestigen.TabIndex = 8;
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(684, 410);
            this.BOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(133, 69);
            this.BOk.TabIndex = 9;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.TWachtwoord_bevestigen);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.TWachtwoord);
            this.Controls.Add(this.TNaam);
            this.Controls.Add(this.LWachtwoord_bevestigen);
            this.Controls.Add(this.LWachtwoord);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LNaam);
            this.Controls.Add(this.LAccount_aanmaken);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAccount_aanmaken;
        private System.Windows.Forms.Label LNaam;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LWachtwoord;
        private System.Windows.Forms.Label LWachtwoord_bevestigen;
        private System.Windows.Forms.TextBox TNaam;
        private System.Windows.Forms.TextBox TWachtwoord;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.TextBox TWachtwoord_bevestigen;
        private System.Windows.Forms.Button BOk;
    }
}