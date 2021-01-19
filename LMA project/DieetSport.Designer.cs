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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHand = new System.Windows.Forms.Button();
            this.btnAut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDieet
            // 
            this.buttonDieet.Location = new System.Drawing.Point(372, 151);
            this.buttonDieet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDieet.Name = "buttonDieet";
            this.buttonDieet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDieet.Size = new System.Drawing.Size(227, 80);
            this.buttonDieet.TabIndex = 10;
            this.buttonDieet.Text = "Dieet samenstellen";
            this.buttonDieet.UseVisualStyleBackColor = true;
            this.buttonDieet.Click += new System.EventHandler(this.buttonDieet_Click);
            // 
            // buttonTraining
            // 
            this.buttonTraining.Location = new System.Drawing.Point(81, 151);
            this.buttonTraining.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTraining.Name = "buttonTraining";
            this.buttonTraining.Size = new System.Drawing.Size(223, 80);
            this.buttonTraining.TabIndex = 9;
            this.buttonTraining.Text = "Training samenstellen";
            this.buttonTraining.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHand);
            this.panel1.Controls.Add(this.btnAut);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 442);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hoe wilt u uw dieet stellen?";
            // 
            // btnHand
            // 
            this.btnHand.Location = new System.Drawing.Point(375, 151);
            this.btnHand.Name = "btnHand";
            this.btnHand.Size = new System.Drawing.Size(227, 80);
            this.btnHand.TabIndex = 1;
            this.btnHand.Text = "Handmatig";
            this.btnHand.UseVisualStyleBackColor = true;
            this.btnHand.Click += new System.EventHandler(this.btnHand_Click);
            // 
            // btnAut
            // 
            this.btnAut.Location = new System.Drawing.Point(84, 151);
            this.btnAut.Name = "btnAut";
            this.btnAut.Size = new System.Drawing.Size(223, 80);
            this.btnAut.TabIndex = 0;
            this.btnAut.Text = "Automatisch";
            this.btnAut.UseVisualStyleBackColor = true;
            this.btnAut.Click += new System.EventHandler(this.btnAut_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbResult);
            this.panel2.Controls.Add(this.buttonTraining);
            this.panel2.Controls.Add(this.buttonDieet);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 433);
            this.panel2.TabIndex = 12;
            // 
            // tbResult
            // 
            this.tbResult.AutoSize = true;
            this.tbResult.Location = new System.Drawing.Point(304, 323);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(0, 13);
            this.tbResult.TabIndex = 14;
            // 
            // DieetSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DieetSport";
            this.Text = "DieetSport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDieet;
        private System.Windows.Forms.Button buttonTraining;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnHand;
        public System.Windows.Forms.Button btnAut;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label tbResult;
    }
}