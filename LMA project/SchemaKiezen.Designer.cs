namespace LMA_project
{
    partial class SchemaKiezen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchemaKiezen));
            this.btnVoorgesteld = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoorgesteld
            // 
            this.btnVoorgesteld.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.btnVoorgesteld.Location = new System.Drawing.Point(328, 395);
            this.btnVoorgesteld.Name = "btnVoorgesteld";
            this.btnVoorgesteld.Size = new System.Drawing.Size(242, 126);
            this.btnVoorgesteld.TabIndex = 0;
            this.btnVoorgesteld.Text = "Voorgesteld trainingsschema";
            this.btnVoorgesteld.UseVisualStyleBackColor = true;
            this.btnVoorgesteld.Click += new System.EventHandler(this.btnVoorgesteld_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.button2.Location = new System.Drawing.Point(862, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 126);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eigen trainingsschema creëren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Font = new System.Drawing.Font("Gill Sans MT", 10F);
            this.btnTerug.Location = new System.Drawing.Point(631, 898);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(197, 86);
            this.btnTerug.TabIndex = 8;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
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
            // 
            // SchemaKiezen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1101);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVoorgesteld);
            this.MaximumSize = new System.Drawing.Size(1694, 1180);
            this.MinimumSize = new System.Drawing.Size(1694, 1180);
            this.Name = "SchemaKiezen";
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoorgesteld;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.PictureBox Home;
    }
}