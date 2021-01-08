
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
            this.LEmail = new System.Windows.Forms.Label();
            this.LWachtwoord = new System.Windows.Forms.Label();
            this.LWachtwoord_bevestigen = new System.Windows.Forms.Label();
            this.TWachtwoord = new System.Windows.Forms.TextBox();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.TWachtwoord_bevestigen = new System.Windows.Forms.TextBox();
            this.BOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LAccount_aanmaken
            // 
            this.LAccount_aanmaken.AutoSize = true;
            this.LAccount_aanmaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAccount_aanmaken.Location = new System.Drawing.Point(169, 7);
            this.LAccount_aanmaken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAccount_aanmaken.Name = "LAccount_aanmaken";
            this.LAccount_aanmaken.Size = new System.Drawing.Size(734, 91);
            this.LAccount_aanmaken.TabIndex = 0;
            this.LAccount_aanmaken.Text = "Account aanmaken";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(419, 203);
            this.LEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(57, 24);
            this.LEmail.TabIndex = 2;
            this.LEmail.Text = "Email";
            // 
            // LWachtwoord
            // 
            this.LWachtwoord.AutoSize = true;
            this.LWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LWachtwoord.Location = new System.Drawing.Point(380, 250);
            this.LWachtwoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LWachtwoord.Name = "LWachtwoord";
            this.LWachtwoord.Size = new System.Drawing.Size(121, 24);
            this.LWachtwoord.TabIndex = 3;
            this.LWachtwoord.Text = "Wachtwoord:";
            // 
            // LWachtwoord_bevestigen
            // 
            this.LWachtwoord_bevestigen.AutoSize = true;
            this.LWachtwoord_bevestigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LWachtwoord_bevestigen.Location = new System.Drawing.Point(318, 293);
            this.LWachtwoord_bevestigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LWachtwoord_bevestigen.Name = "LWachtwoord_bevestigen";
            this.LWachtwoord_bevestigen.Size = new System.Drawing.Size(218, 24);
            this.LWachtwoord_bevestigen.TabIndex = 4;
            this.LWachtwoord_bevestigen.Text = "Wachtwoord bevestigen:";
            // 
            // TWachtwoord
            // 
            this.TWachtwoord.Location = new System.Drawing.Point(554, 250);
            this.TWachtwoord.Margin = new System.Windows.Forms.Padding(4);
            this.TWachtwoord.Name = "TWachtwoord";
            this.TWachtwoord.Size = new System.Drawing.Size(132, 22);
            this.TWachtwoord.TabIndex = 6;
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(554, 203);
            this.TEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(132, 22);
            this.TEmail.TabIndex = 7;
            // 
            // TWachtwoord_bevestigen
            // 
            this.TWachtwoord_bevestigen.Location = new System.Drawing.Point(554, 295);
            this.TWachtwoord_bevestigen.Margin = new System.Windows.Forms.Padding(4);
            this.TWachtwoord_bevestigen.Name = "TWachtwoord_bevestigen";
            this.TWachtwoord_bevestigen.Size = new System.Drawing.Size(132, 22);
            this.TWachtwoord_bevestigen.TabIndex = 8;
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(721, 443);
            this.BOk.Margin = new System.Windows.Forms.Padding(4);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(184, 44);
            this.BOk.TabIndex = 9;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LAccount_aanmaken);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 113);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMA_project.Properties.Resources.Shopping_Cart_Food_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.TWachtwoord_bevestigen);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.TWachtwoord);
            this.Controls.Add(this.LWachtwoord_bevestigen);
            this.Controls.Add(this.LWachtwoord);
            this.Controls.Add(this.LEmail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAccount_aanmaken;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LWachtwoord;
        private System.Windows.Forms.Label LWachtwoord_bevestigen;
        private System.Windows.Forms.TextBox TWachtwoord;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.TextBox TWachtwoord_bevestigen;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}