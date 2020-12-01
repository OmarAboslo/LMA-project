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
            this.button1 = new System.Windows.Forms.Button();
            this.butBasketbal = new System.Windows.Forms.Button();
            this.butVoetballen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "zwemmen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // butBasketbal
            // 
            this.butBasketbal.Location = new System.Drawing.Point(308, 128);
            this.butBasketbal.Name = "butBasketbal";
            this.butBasketbal.Size = new System.Drawing.Size(192, 63);
            this.butBasketbal.TabIndex = 10;
            this.butBasketbal.Text = "Basketbal";
            this.butBasketbal.UseVisualStyleBackColor = true;
            // 
            // butVoetballen
            // 
            this.butVoetballen.Location = new System.Drawing.Point(45, 128);
            this.butVoetballen.Name = "butVoetballen";
            this.butVoetballen.Size = new System.Drawing.Size(192, 63);
            this.butVoetballen.TabIndex = 9;
            this.butVoetballen.Text = "Voetaballen";
            this.butVoetballen.UseVisualStyleBackColor = true;
            this.butVoetballen.Click += new System.EventHandler(this.butVoetballen_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sport en beweging";
            // 
            // Sport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butBasketbal);
            this.Controls.Add(this.butVoetballen);
            this.Controls.Add(this.label1);
            this.Name = "Sport";
            this.Text = "Sport";
            this.Load += new System.EventHandler(this.Sport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butBasketbal;
        private System.Windows.Forms.Button butVoetballen;
        private System.Windows.Forms.Label label1;
    }
}