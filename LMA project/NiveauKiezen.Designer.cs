namespace LMA_project
{
    partial class NiveauKiezen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NiveauKiezen));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.button1.Location = new System.Drawing.Point(1190, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 126);
            this.button1.TabIndex = 0;
            this.button1.Text = "Professioneel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.button2.Location = new System.Drawing.Point(734, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 129);
            this.button2.TabIndex = 1;
            this.button2.Text = "Intermediate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.button3.Location = new System.Drawing.Point(248, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 126);
            this.button3.TabIndex = 2;
            this.button3.Text = "Beginner";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20F);
            this.label1.Location = new System.Drawing.Point(401, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(899, 83);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wat voor trainingsschema zoekt u?";
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.btnTerug.Location = new System.Drawing.Point(757, 815);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(197, 86);
            this.btnTerug.TabIndex = 8;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 963);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1670, 151);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-44, -30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1771, 161);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // Home
            // 
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(3, 137);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(118, 90);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home.TabIndex = 19;
            this.Home.TabStop = false;
            // 
            // NiveauKiezen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1101);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1694, 1180);
            this.MinimumSize = new System.Drawing.Size(1694, 1180);
            this.Name = "NiveauKiezen";
            this.Text = "NiveauKiezen";
            this.Load += new System.EventHandler(this.NiveauKiezen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}