namespace Contacts.UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.entr_bttn = new System.Windows.Forms.Button();
            this.usrnm_tx = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.Label();
            this.pswrd_tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.entr_bttn);
            this.groupBox2.Controls.Add(this.usrnm_tx);
            this.groupBox2.Controls.Add(this.User);
            this.groupBox2.Controls.Add(this.pswrd_tx);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(211, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 212);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Sign up";
            // 
            // entr_bttn
            // 
            this.entr_bttn.Location = new System.Drawing.Point(114, 133);
            this.entr_bttn.Name = "entr_bttn";
            this.entr_bttn.Size = new System.Drawing.Size(272, 33);
            this.entr_bttn.TabIndex = 2;
            this.entr_bttn.Text = "Enter";
            this.entr_bttn.UseVisualStyleBackColor = true;
            this.entr_bttn.Click += new System.EventHandler(this.entr_bttn_Click);
            // 
            // usrnm_tx
            // 
            this.usrnm_tx.Location = new System.Drawing.Point(112, 47);
            this.usrnm_tx.Name = "usrnm_tx";
            this.usrnm_tx.Size = new System.Drawing.Size(275, 22);
            this.usrnm_tx.TabIndex = 1;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(30, 53);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(76, 16);
            this.User.TabIndex = 0;
            this.User.Text = "User Name";
            // 
            // pswrd_tx
            // 
            this.pswrd_tx.Location = new System.Drawing.Point(112, 91);
            this.pswrd_tx.Name = "pswrd_tx";
            this.pswrd_tx.PasswordChar = '*';
            this.pswrd_tx.Size = new System.Drawing.Size(275, 22);
            this.pswrd_tx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 241);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button entr_bttn;
        private System.Windows.Forms.TextBox usrnm_tx;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox pswrd_tx;
        private System.Windows.Forms.Label label1;
    }
}

