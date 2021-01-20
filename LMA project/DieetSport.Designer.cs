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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieetSport));
            this.buttonDieet = new System.Windows.Forms.Button();
            this.buttonTraining = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHand = new System.Windows.Forms.Button();
            this.btnAut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Helplabel = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDieet
            // 
            this.buttonDieet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDieet.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDieet.Location = new System.Drawing.Point(328, 171);
            this.buttonDieet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDieet.Name = "buttonDieet";
            this.buttonDieet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDieet.Size = new System.Drawing.Size(182, 61);
            this.buttonDieet.TabIndex = 10;
            this.buttonDieet.Text = "Dieet samenstellen";
            this.buttonDieet.UseVisualStyleBackColor = true;
            this.buttonDieet.Click += new System.EventHandler(this.buttonDieet_Click);
            this.buttonDieet.MouseLeave += new System.EventHandler(this.buttonDieet_MouseLeave);
            this.buttonDieet.MouseHover += new System.EventHandler(this.buttonDieet_MouseHover);
            // 
            // buttonTraining
            // 
            this.buttonTraining.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTraining.Location = new System.Drawing.Point(42, 170);
            this.buttonTraining.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTraining.Name = "buttonTraining";
            this.buttonTraining.Size = new System.Drawing.Size(182, 61);
            this.buttonTraining.TabIndex = 9;
            this.buttonTraining.Text = "Training samenstellen";
            this.buttonTraining.UseVisualStyleBackColor = true;
            this.buttonTraining.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonTraining_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHand);
            this.panel1.Controls.Add(this.btnAut);
            this.panel1.Location = new System.Drawing.Point(227, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 398);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 68);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hoe wilt u uw dieet stellen?";
            // 
            // btnHand
            // 
            this.btnHand.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHand.Location = new System.Drawing.Point(328, 170);
            this.btnHand.Name = "btnHand";
            this.btnHand.Size = new System.Drawing.Size(182, 61);
            this.btnHand.TabIndex = 1;
            this.btnHand.Text = "Handmatig";
            this.btnHand.UseVisualStyleBackColor = true;
            this.btnHand.Click += new System.EventHandler(this.btnHand_Click);
            // 
            // btnAut
            // 
            this.btnAut.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnAut.Location = new System.Drawing.Point(55, 170);
            this.btnAut.Name = "btnAut";
            this.btnAut.Size = new System.Drawing.Size(182, 61);
            this.btnAut.TabIndex = 0;
            this.btnAut.Text = "Automatisch";
            this.btnAut.UseVisualStyleBackColor = true;
            this.btnAut.Click += new System.EventHandler(this.btnAut_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Helplabel);
            this.panel2.Controls.Add(this.tbResult);
            this.panel2.Controls.Add(this.buttonTraining);
            this.panel2.Controls.Add(this.buttonDieet);
            this.panel2.Location = new System.Drawing.Point(227, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 398);
            this.panel2.TabIndex = 12;
            // 
            // Helplabel
            // 
            this.Helplabel.AutoSize = true;
            this.Helplabel.Location = new System.Drawing.Point(393, 257);
            this.Helplabel.Name = "Helplabel";
            this.Helplabel.Size = new System.Drawing.Size(0, 13);
            this.Helplabel.TabIndex = 68;
            this.Helplabel.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Helplabel_HelpRequested);
            // 
            // tbResult
            // 
            this.tbResult.AutoSize = true;
            this.tbResult.Location = new System.Drawing.Point(234, 301);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(0, 13);
            this.tbResult.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 111);
            this.panel3.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(665, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(3, 194);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 534);
            this.panel4.TabIndex = 66;
            // 
            // DieetSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 716);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DieetSport";
            this.Text = "DieetSport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Helplabel;
        public System.Windows.Forms.Label tbResult;
    }
}