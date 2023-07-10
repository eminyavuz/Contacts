namespace Contacts.UI
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.gb_lic = new System.Windows.Forms.GroupBox();
            this.bttn_lic = new System.Windows.Forms.Button();
            this.tx_lic = new System.Windows.Forms.TextBox();
            this.lb_lic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_lic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_lic
            // 
            this.gb_lic.Controls.Add(this.bttn_lic);
            this.gb_lic.Controls.Add(this.tx_lic);
            this.gb_lic.Controls.Add(this.lb_lic);
            this.gb_lic.Location = new System.Drawing.Point(231, 21);
            this.gb_lic.Name = "gb_lic";
            this.gb_lic.Size = new System.Drawing.Size(358, 147);
            this.gb_lic.TabIndex = 1;
            this.gb_lic.TabStop = false;
            this.gb_lic.Text = "Licanse Control";
            // 
            // bttn_lic
            // 
            this.bttn_lic.Location = new System.Drawing.Point(19, 82);
            this.bttn_lic.Name = "bttn_lic";
            this.bttn_lic.Size = new System.Drawing.Size(316, 28);
            this.bttn_lic.TabIndex = 2;
            this.bttn_lic.Text = "Apply";
            this.bttn_lic.UseVisualStyleBackColor = true;
            this.bttn_lic.Click += new System.EventHandler(this.bttn_lic_Click);
            // 
            // tx_lic
            // 
            this.tx_lic.Location = new System.Drawing.Point(19, 54);
            this.tx_lic.Name = "tx_lic";
            this.tx_lic.Size = new System.Drawing.Size(316, 22);
            this.tx_lic.TabIndex = 1;
            this.tx_lic.Text = "f3299e9c-4a28-4bcc-a8fb-45139bdc823d";
            // 
            // lb_lic
            // 
            this.lb_lic.AutoSize = true;
            this.lb_lic.Location = new System.Drawing.Point(16, 35);
            this.lb_lic.Name = "lb_lic";
            this.lb_lic.Size = new System.Drawing.Size(190, 16);
            this.lb_lic.TabIndex = 0;
            this.lb_lic.Text = "Please insert your Licanse Key";
            this.lb_lic.Click += new System.EventHandler(this.lb_lic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 180);
            this.Controls.Add(this.gb_lic);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licanse Control";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gb_lic.ResumeLayout(false);
            this.gb_lic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_lic;
        private System.Windows.Forms.Button bttn_lic;
        private System.Windows.Forms.TextBox tx_lic;
        private System.Windows.Forms.Label lb_lic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}