﻿namespace LMA_project
{
    partial class Pushup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pushup));
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnNotes = new System.Windows.Forms.Button();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.btnNotes2 = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(325, 642);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(238, 51);
            this.inputTextBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(636, 642);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 51);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(946, 642);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 51);
            this.textBox2.TabIndex = 3;
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(128, 500);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(151, 66);
            this.btnNotes.TabIndex = 4;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // tbNotes
            // 
            this.tbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotes.Location = new System.Drawing.Point(354, 162);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(764, 426);
            this.tbNotes.TabIndex = 5;
            // 
            // btnNotes2
            // 
            this.btnNotes2.Location = new System.Drawing.Point(128, 500);
            this.btnNotes2.Name = "btnNotes2";
            this.btnNotes2.Size = new System.Drawing.Size(151, 66);
            this.btnNotes2.TabIndex = 6;
            this.btnNotes2.Text = "Notes";
            this.btnNotes2.UseVisualStyleBackColor = true;
            this.btnNotes2.Click += new System.EventHandler(this.btnNotes2_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(657, 843);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(197, 86);
            this.btnTerug.TabIndex = 7;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(118, 90);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home.TabIndex = 19;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pushup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnNotes2);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pushup";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Button btnNotes2;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.PictureBox Home;
    }
}