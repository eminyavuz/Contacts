namespace Contacts.UI
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.txt_path = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttn_path = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(198, 58);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(283, 22);
            this.txt_path.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bttn_path
            // 
            this.bttn_path.Location = new System.Drawing.Point(198, 86);
            this.bttn_path.Name = "bttn_path";
            this.bttn_path.Size = new System.Drawing.Size(283, 38);
            this.bttn_path.TabIndex = 2;
            this.bttn_path.Text = "Browse";
            this.bttn_path.UseVisualStyleBackColor = true;
            this.bttn_path.Click += new System.EventHandler(this.bttn_path_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(193, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please insert XML path";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 167);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_path);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xml import";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttn_path;
        private System.Windows.Forms.Label label1;
    }
}