namespace Turkey_Run
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.addAthButton = new System.Windows.Forms.Button();
            this.insertTimeButton = new System.Windows.Forms.Button();
            this.sctLogo = new System.Windows.Forms.PictureBox();
            this.getResButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // addAthButton
            // 
            this.addAthButton.Location = new System.Drawing.Point(37, 67);
            this.addAthButton.Name = "addAthButton";
            this.addAthButton.Size = new System.Drawing.Size(75, 23);
            this.addAthButton.TabIndex = 0;
            this.addAthButton.Text = "Add Athlete";
            this.addAthButton.UseVisualStyleBackColor = true;
            this.addAthButton.Click += new System.EventHandler(this.addAthButton_Click);
            // 
            // insertTimeButton
            // 
            this.insertTimeButton.Location = new System.Drawing.Point(37, 132);
            this.insertTimeButton.Name = "insertTimeButton";
            this.insertTimeButton.Size = new System.Drawing.Size(75, 23);
            this.insertTimeButton.TabIndex = 1;
            this.insertTimeButton.Text = "Import Times";
            this.insertTimeButton.UseVisualStyleBackColor = true;
            this.insertTimeButton.Click += new System.EventHandler(this.insertTimeButton_Click);
            // 
            // sctLogo
            // 
            this.sctLogo.Image = ((System.Drawing.Image)(resources.GetObject("sctLogo.Image")));
            this.sctLogo.Location = new System.Drawing.Point(72, -1);
            this.sctLogo.Name = "sctLogo";
            this.sctLogo.Size = new System.Drawing.Size(383, 388);
            this.sctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sctLogo.TabIndex = 2;
            this.sctLogo.TabStop = false;
            // 
            // getResButton
            // 
            this.getResButton.Location = new System.Drawing.Point(37, 194);
            this.getResButton.Name = "getResButton";
            this.getResButton.Size = new System.Drawing.Size(75, 23);
            this.getResButton.TabIndex = 3;
            this.getResButton.Text = "Get Results";
            this.getResButton.UseVisualStyleBackColor = true;
            this.getResButton.Click += new System.EventHandler(this.getResButton_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 387);
            this.Controls.Add(this.getResButton);
            this.Controls.Add(this.insertTimeButton);
            this.Controls.Add(this.addAthButton);
            this.Controls.Add(this.sctLogo);
            this.Name = "main";
            this.Text = "SCT Turkey Run Database";
            ((System.ComponentModel.ISupportInitialize)(this.sctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAthButton;
        private System.Windows.Forms.Button insertTimeButton;
        private System.Windows.Forms.PictureBox sctLogo;
        private System.Windows.Forms.Button getResButton;
    }
}

