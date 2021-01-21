
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LAccount_aanmaken = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LWachtwoord = new System.Windows.Forms.Label();
            this.LWachtwoord_bevestigen = new System.Windows.Forms.Label();
            this.TWachtwoord = new System.Windows.Forms.TextBox();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.TWachtwoord_bevestigen = new System.Windows.Forms.TextBox();
            this.BOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btterug = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LAccount_aanmaken
            // 
            this.LAccount_aanmaken.AutoSize = true;
            this.LAccount_aanmaken.Font = new System.Drawing.Font("Gabriola", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAccount_aanmaken.Location = new System.Drawing.Point(147, -6);
            this.LAccount_aanmaken.Name = "LAccount_aanmaken";
            this.LAccount_aanmaken.Size = new System.Drawing.Size(441, 118);
            this.LAccount_aanmaken.TabIndex = 0;
            this.LAccount_aanmaken.Text = "Account aanmaken";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(356, 298);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(86, 54);
            this.LEmail.TabIndex = 2;
            this.LEmail.Text = "Email:";
            // 
            // LWachtwoord
            // 
            this.LWachtwoord.AutoSize = true;
            this.LWachtwoord.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold);
            this.LWachtwoord.Location = new System.Drawing.Point(314, 361);
            this.LWachtwoord.Name = "LWachtwoord";
            this.LWachtwoord.Size = new System.Drawing.Size(151, 54);
            this.LWachtwoord.TabIndex = 3;
            this.LWachtwoord.Text = "Wachtwoord:";
            // 
            // LWachtwoord_bevestigen
            // 
            this.LWachtwoord_bevestigen.AutoSize = true;
            this.LWachtwoord_bevestigen.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold);
            this.LWachtwoord_bevestigen.Location = new System.Drawing.Point(273, 424);
            this.LWachtwoord_bevestigen.Name = "LWachtwoord_bevestigen";
            this.LWachtwoord_bevestigen.Size = new System.Drawing.Size(259, 54);
            this.LWachtwoord_bevestigen.TabIndex = 4;
            this.LWachtwoord_bevestigen.Text = "Wachtwoord bevestigen:";
            // 
            // TWachtwoord
            // 
            this.TWachtwoord.Location = new System.Drawing.Point(538, 372);
            this.TWachtwoord.Multiline = true;
            this.TWachtwoord.Name = "TWachtwoord";
            this.TWachtwoord.Size = new System.Drawing.Size(146, 33);
            this.TWachtwoord.TabIndex = 6;
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(538, 303);
            this.TEmail.Multiline = true;
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(146, 34);
            this.TEmail.TabIndex = 7;
            // 
            // TWachtwoord_bevestigen
            // 
            this.TWachtwoord_bevestigen.Location = new System.Drawing.Point(538, 434);
            this.TWachtwoord_bevestigen.Multiline = true;
            this.TWachtwoord_bevestigen.Name = "TWachtwoord_bevestigen";
            this.TWachtwoord_bevestigen.Size = new System.Drawing.Size(146, 33);
            this.TWachtwoord_bevestigen.TabIndex = 8;
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(649, 668);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(138, 36);
            this.BOk.TabIndex = 9;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btterug);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LAccount_aanmaken);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 103);
            this.panel1.TabIndex = 10;
            // 
            // btterug
            // 
            this.btterug.Location = new System.Drawing.Point(0, 0);
            this.btterug.Name = "btterug";
            this.btterug.Size = new System.Drawing.Size(101, 42);
            this.btterug.TabIndex = 68;
            this.btterug.Text = "Terug";
            this.btterug.UseVisualStyleBackColor = true;
            this.btterug.Click += new System.EventHandler(this.btterug_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(681, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(2, 192);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 539);
            this.panel2.TabIndex = 66;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 716);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.TWachtwoord_bevestigen);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.TWachtwoord);
            this.Controls.Add(this.LWachtwoord_bevestigen);
            this.Controls.Add(this.LWachtwoord);
            this.Controls.Add(this.LEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btterug;
    }
}