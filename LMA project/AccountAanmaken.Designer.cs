﻿
namespace LMA_project
{
    partial class AccountAanmaken
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
            this.TbWachtwoord = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TWachtwoord_bevestigen = new System.Windows.Forms.TextBox();
            this.btnAccountAanmaken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAccount_aanmaken
            // 
            this.LAccount_aanmaken.AutoSize = true;
            this.LAccount_aanmaken.Location = new System.Drawing.Point(541, 94);
            this.LAccount_aanmaken.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LAccount_aanmaken.Name = "LAccount_aanmaken";
            this.LAccount_aanmaken.Size = new System.Drawing.Size(215, 29);
            this.LAccount_aanmaken.TabIndex = 0;
            this.LAccount_aanmaken.Text = "Account aanmaken";
            // 
            // LNaam
            // 
            this.LNaam.AutoSize = true;
            this.LNaam.Location = new System.Drawing.Point(462, 281);
            this.LNaam.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LNaam.Name = "LNaam";
            this.LNaam.Size = new System.Drawing.Size(83, 29);
            this.LNaam.TabIndex = 1;
            this.LNaam.Text = "Naam:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(476, 370);
            this.LEmail.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(74, 29);
            this.LEmail.TabIndex = 2;
            this.LEmail.Text = "Email";
            // 
            // LWachtwoord
            // 
            this.LWachtwoord.AutoSize = true;
            this.LWachtwoord.Location = new System.Drawing.Point(462, 486);
            this.LWachtwoord.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LWachtwoord.Name = "LWachtwoord";
            this.LWachtwoord.Size = new System.Drawing.Size(153, 29);
            this.LWachtwoord.TabIndex = 3;
            this.LWachtwoord.Text = "Wachtwoord:";
            // 
            // LWachtwoord_bevestigen
            // 
            this.LWachtwoord_bevestigen.AutoSize = true;
            this.LWachtwoord_bevestigen.Location = new System.Drawing.Point(462, 598);
            this.LWachtwoord_bevestigen.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LWachtwoord_bevestigen.Name = "LWachtwoord_bevestigen";
            this.LWachtwoord_bevestigen.Size = new System.Drawing.Size(271, 29);
            this.LWachtwoord_bevestigen.TabIndex = 4;
            this.LWachtwoord_bevestigen.Text = "Wachtwoord bevestigen";
            // 
            // TNaam
            // 
            this.TNaam.Location = new System.Drawing.Point(819, 281);
            this.TNaam.Margin = new System.Windows.Forms.Padding(7);
            this.TNaam.Name = "TNaam";
            this.TNaam.Size = new System.Drawing.Size(228, 35);
            this.TNaam.TabIndex = 5;
            // 
            // TbWachtwoord
            // 
            this.TbWachtwoord.Location = new System.Drawing.Point(819, 480);
            this.TbWachtwoord.Margin = new System.Windows.Forms.Padding(7);
            this.TbWachtwoord.Name = "TbWachtwoord";
            this.TbWachtwoord.Size = new System.Drawing.Size(228, 35);
            this.TbWachtwoord.TabIndex = 6;
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(819, 370);
            this.TbEmail.Margin = new System.Windows.Forms.Padding(7);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(228, 35);
            this.TbEmail.TabIndex = 7;
            // 
            // TWachtwoord_bevestigen
            // 
            this.TWachtwoord_bevestigen.Location = new System.Drawing.Point(819, 582);
            this.TWachtwoord_bevestigen.Margin = new System.Windows.Forms.Padding(7);
            this.TWachtwoord_bevestigen.Name = "TWachtwoord_bevestigen";
            this.TWachtwoord_bevestigen.Size = new System.Drawing.Size(228, 35);
            this.TWachtwoord_bevestigen.TabIndex = 8;
            // 
            // btnAccountAanmaken
            // 
            this.btnAccountAanmaken.Location = new System.Drawing.Point(1197, 743);
            this.btnAccountAanmaken.Margin = new System.Windows.Forms.Padding(7);
            this.btnAccountAanmaken.Name = "btnAccountAanmaken";
            this.btnAccountAanmaken.Size = new System.Drawing.Size(233, 125);
            this.btnAccountAanmaken.TabIndex = 9;
            this.btnAccountAanmaken.Text = "Account aanmaken";
            this.btnAccountAanmaken.UseVisualStyleBackColor = true;
            this.btnAccountAanmaken.Click += new System.EventHandler(this.btnAccountAanmaken_Click);
            // 
            // AccountAanmaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1004);
            this.Controls.Add(this.btnAccountAanmaken);
            this.Controls.Add(this.TWachtwoord_bevestigen);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbWachtwoord);
            this.Controls.Add(this.TNaam);
            this.Controls.Add(this.LWachtwoord_bevestigen);
            this.Controls.Add(this.LWachtwoord);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LNaam);
            this.Controls.Add(this.LAccount_aanmaken);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "AccountAanmaken";
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
        private System.Windows.Forms.TextBox TbWachtwoord;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TWachtwoord_bevestigen;
        private System.Windows.Forms.Button btnAccountAanmaken;
    }
}