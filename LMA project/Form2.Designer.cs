
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LGebruikersnaam
            // 
            this.LGebruikersnaam.AutoSize = true;
            this.LGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGebruikersnaam.Location = new System.Drawing.Point(225, 228);
            this.LGebruikersnaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LGebruikersnaam.Name = "LGebruikersnaam";
            this.LGebruikersnaam.Size = new System.Drawing.Size(225, 32);
            this.LGebruikersnaam.TabIndex = 0;
            this.LGebruikersnaam.Text = "Gebruikersnaam";
            // 
            // LWachtwoord
            // 
            this.LWachtwoord.AutoSize = true;
            this.LWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LWachtwoord.Location = new System.Drawing.Point(225, 275);
            this.LWachtwoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LWachtwoord.Name = "LWachtwoord";
            this.LWachtwoord.Size = new System.Drawing.Size(172, 32);
            this.LWachtwoord.TabIndex = 1;
            this.LWachtwoord.Text = "Wachtwoord";
            // 
            // LInloggen
            // 
            this.LInloggen.AutoSize = true;
            this.LInloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInloggen.Location = new System.Drawing.Point(368, 7);
            this.LInloggen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LInloggen.Name = "LInloggen";
            this.LInloggen.Size = new System.Drawing.Size(350, 91);
            this.LInloggen.TabIndex = 2;
            this.LInloggen.Text = "Inloggen";
            // 
            // TGebruikersnaam
            // 
            this.TGebruikersnaam.Location = new System.Drawing.Point(477, 224);
            this.TGebruikersnaam.Margin = new System.Windows.Forms.Padding(4);
            this.TGebruikersnaam.Multiline = true;
            this.TGebruikersnaam.Name = "TGebruikersnaam";
            this.TGebruikersnaam.Size = new System.Drawing.Size(180, 36);
            this.TGebruikersnaam.TabIndex = 3;
            // 
            // TWachtwoord
            // 
            this.TWachtwoord.Location = new System.Drawing.Point(478, 275);
            this.TWachtwoord.Margin = new System.Windows.Forms.Padding(4);
            this.TWachtwoord.Multiline = true;
            this.TWachtwoord.Name = "TWachtwoord";
            this.TWachtwoord.Size = new System.Drawing.Size(179, 36);
            this.TWachtwoord.TabIndex = 4;
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(478, 342);
            this.BOk.Margin = new System.Windows.Forms.Padding(4);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(166, 43);
            this.BOk.TabIndex = 10;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // BAccoun_maken
            // 
            this.BAccoun_maken.Location = new System.Drawing.Point(806, 441);
            this.BAccoun_maken.Margin = new System.Windows.Forms.Padding(4);
            this.BAccoun_maken.Name = "BAccoun_maken";
            this.BAccoun_maken.Size = new System.Drawing.Size(160, 43);
            this.BAccoun_maken.TabIndex = 11;
            this.BAccoun_maken.Text = "Account Maken";
            this.BAccoun_maken.UseVisualStyleBackColor = true;
            this.BAccoun_maken.Click += new System.EventHandler(this.BAccoun_maken_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(822, 398);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Geen Account?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LInloggen);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 115);
            this.panel1.TabIndex = 13;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BAccoun_maken);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.TWachtwoord);
            this.Controls.Add(this.TGebruikersnaam);
            this.Controls.Add(this.LWachtwoord);
            this.Controls.Add(this.LGebruikersnaam);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}