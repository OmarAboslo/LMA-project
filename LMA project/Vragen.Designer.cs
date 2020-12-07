namespace LMA_project
{
    partial class Vragen
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
            this.buttonNormaal = new System.Windows.Forms.Button();
            this.buttonSnel = new System.Windows.Forms.Button();
            this.buttonZoSnelMogelijk = new System.Windows.Forms.Button();
            this.textBoxGewensteGewicht = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNee = new System.Windows.Forms.Button();
            this.buttonJa = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wat is het gewenste gewicht?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hoe snel wil je aankomen of afvallen?";
            // 
            // buttonNormaal
            // 
            this.buttonNormaal.Location = new System.Drawing.Point(72, 151);
            this.buttonNormaal.Name = "buttonNormaal";
            this.buttonNormaal.Size = new System.Drawing.Size(131, 30);
            this.buttonNormaal.TabIndex = 2;
            this.buttonNormaal.Text = "Normaal";
            this.buttonNormaal.UseVisualStyleBackColor = true;
            // 
            // buttonSnel
            // 
            this.buttonSnel.Location = new System.Drawing.Point(314, 151);
            this.buttonSnel.Name = "buttonSnel";
            this.buttonSnel.Size = new System.Drawing.Size(136, 30);
            this.buttonSnel.TabIndex = 3;
            this.buttonSnel.Text = "Snel";
            this.buttonSnel.UseVisualStyleBackColor = true;
            // 
            // buttonZoSnelMogelijk
            // 
            this.buttonZoSnelMogelijk.Location = new System.Drawing.Point(525, 151);
            this.buttonZoSnelMogelijk.Name = "buttonZoSnelMogelijk";
            this.buttonZoSnelMogelijk.Size = new System.Drawing.Size(142, 30);
            this.buttonZoSnelMogelijk.TabIndex = 4;
            this.buttonZoSnelMogelijk.Text = "Zo snel mogelijk";
            this.buttonZoSnelMogelijk.UseVisualStyleBackColor = true;
            // 
            // textBoxGewensteGewicht
            // 
            this.textBoxGewensteGewicht.Location = new System.Drawing.Point(503, 43);
            this.textBoxGewensteGewicht.Multiline = true;
            this.textBoxGewensteGewicht.Name = "textBoxGewensteGewicht";
            this.textBoxGewensteGewicht.Size = new System.Drawing.Size(164, 38);
            this.textBoxGewensteGewicht.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(632, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Heb je een ziekte of ben je allergisch voor iets specifieks?";
            // 
            // buttonNee
            // 
            this.buttonNee.Location = new System.Drawing.Point(419, 280);
            this.buttonNee.Name = "buttonNee";
            this.buttonNee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonNee.Size = new System.Drawing.Size(142, 30);
            this.buttonNee.TabIndex = 8;
            this.buttonNee.Text = "Nee";
            this.buttonNee.UseVisualStyleBackColor = true;
            // 
            // buttonJa
            // 
            this.buttonJa.Location = new System.Drawing.Point(165, 280);
            this.buttonJa.Name = "buttonJa";
            this.buttonJa.Size = new System.Drawing.Size(136, 30);
            this.buttonJa.TabIndex = 7;
            this.buttonJa.Text = "Ja";
            this.buttonJa.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(646, 408);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonOk.Size = new System.Drawing.Size(142, 30);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // Vragen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonNee);
            this.Controls.Add(this.buttonJa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGewensteGewicht);
            this.Controls.Add(this.buttonZoSnelMogelijk);
            this.Controls.Add(this.buttonSnel);
            this.Controls.Add(this.buttonNormaal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Vragen";
            this.Text = "Vragen";
            this.Load += new System.EventHandler(this.Vragen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNormaal;
        private System.Windows.Forms.Button buttonSnel;
        private System.Windows.Forms.Button buttonZoSnelMogelijk;
        private System.Windows.Forms.TextBox textBoxGewensteGewicht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNee;
        private System.Windows.Forms.Button buttonJa;
        private System.Windows.Forms.Button buttonOk;
    }
}