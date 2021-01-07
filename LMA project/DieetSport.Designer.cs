namespace LMA_project
{
    partial class DieetSport
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
            this.buttonDieet = new System.Windows.Forms.Button();
            this.buttonTraining = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonDieet
            // 
            this.buttonDieet.Location = new System.Drawing.Point(796, 294);
            this.buttonDieet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonDieet.Name = "buttonDieet";
            this.buttonDieet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDieet.Size = new System.Drawing.Size(530, 178);
            this.buttonDieet.TabIndex = 10;
            this.buttonDieet.Text = "Dieet samenstellen";
            this.buttonDieet.UseVisualStyleBackColor = true;
            // 
            // buttonTraining
            // 
            this.buttonTraining.Location = new System.Drawing.Point(110, 294);
            this.buttonTraining.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonTraining.Name = "buttonTraining";
            this.buttonTraining.Size = new System.Drawing.Size(520, 178);
            this.buttonTraining.TabIndex = 9;
            this.buttonTraining.Text = "Training samenstellen";
            this.buttonTraining.UseVisualStyleBackColor = true;
            this.buttonTraining.Click += new System.EventHandler(this.buttonTraining_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-20, -7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1426, 119);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(-7, 697);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1435, 119);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // DieetSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1101);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonDieet);
            this.Controls.Add(this.buttonTraining);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DieetSport";
            this.Text = "DieetSport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDieet;
        private System.Windows.Forms.Button buttonTraining;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}