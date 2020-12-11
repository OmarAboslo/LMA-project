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
            // DieetSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
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
    }
}