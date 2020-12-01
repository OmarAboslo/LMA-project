namespace LMA_project
{
    partial class Sport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextbGewicht = new System.Windows.Forms.TextBox();
            this.TextbLengte = new System.Windows.Forms.TextBox();
            this.textbGeboortedatm = new System.Windows.Forms.TextBox();
            this.butOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gewicht:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lengte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geboortedatum:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TextbGewicht
            // 
            this.TextbGewicht.Location = new System.Drawing.Point(456, 181);
            this.TextbGewicht.Multiline = true;
            this.TextbGewicht.Name = "TextbGewicht";
            this.TextbGewicht.Size = new System.Drawing.Size(158, 31);
            this.TextbGewicht.TabIndex = 3;
            // 
            // TextbLengte
            // 
            this.TextbLengte.Location = new System.Drawing.Point(456, 244);
            this.TextbLengte.Multiline = true;
            this.TextbLengte.Name = "TextbLengte";
            this.TextbLengte.Size = new System.Drawing.Size(158, 31);
            this.TextbLengte.TabIndex = 4;
            // 
            // textbGeboortedatm
            // 
            this.textbGeboortedatm.Location = new System.Drawing.Point(456, 314);
            this.textbGeboortedatm.Multiline = true;
            this.textbGeboortedatm.Name = "textbGeboortedatm";
            this.textbGeboortedatm.Size = new System.Drawing.Size(158, 31);
            this.textbGeboortedatm.TabIndex = 5;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(680, 516);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(121, 28);
            this.butOk.TabIndex = 6;
            this.butOk.Text = "Ok";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMA_project.Properties.Resources.soso;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Sport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(813, 556);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.textbGeboortedatm);
            this.Controls.Add(this.TextbLengte);
            this.Controls.Add(this.TextbGewicht);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sport";
            this.Text = "Sport";
            this.Load += new System.EventHandler(this.Sport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextbGewicht;
        private System.Windows.Forms.TextBox TextbLengte;
        private System.Windows.Forms.TextBox textbGeboortedatm;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}