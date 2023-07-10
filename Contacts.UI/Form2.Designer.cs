namespace Contacts.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bttn_clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.RichTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.txt_phonenum3 = new System.Windows.Forms.TextBox();
            this.txt_phonenum2 = new System.Windows.Forms.TextBox();
            this.txt_phonenum1 = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_desc = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.bttn_ımpxml = new System.Windows.Forms.Button();
            this.bttn_getJson = new System.Windows.Forms.Button();
            this.bttn_getCsv = new System.Windows.Forms.Button();
            this.bttn_getxml = new System.Windows.Forms.Button();
            this.bttn_add = new System.Windows.Forms.Button();
            this.bttn_up = new System.Windows.Forms.Button();
            this.bttn_del = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacts";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 532);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(258, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Record";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 295);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bttn_clear);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txt_adress);
            this.tabPage2.Controls.Add(this.txt_email);
            this.tabPage2.Controls.Add(this.txt_website);
            this.tabPage2.Controls.Add(this.txt_phonenum3);
            this.tabPage2.Controls.Add(this.txt_phonenum2);
            this.tabPage2.Controls.Add(this.txt_phonenum1);
            this.tabPage2.Controls.Add(this.txt_lastName);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_name);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personal İnformation";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // bttn_clear
            // 
            this.bttn_clear.Location = new System.Drawing.Point(130, 226);
            this.bttn_clear.Name = "bttn_clear";
            this.bttn_clear.Size = new System.Drawing.Size(223, 25);
            this.bttn_clear.TabIndex = 9;
            this.bttn_clear.Text = "Clear";
            this.bttn_clear.UseVisualStyleBackColor = true;
            this.bttn_clear.Click += new System.EventHandler(this.bttn_clear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Adresss";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(385, 39);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(342, 181);
            this.txt_adress.TabIndex = 8;
            this.txt_adress.Text = "";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(131, 198);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(222, 22);
            this.txt_email.TabIndex = 7;
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(131, 169);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(222, 22);
            this.txt_website.TabIndex = 6;
            this.txt_website.TextChanged += new System.EventHandler(this.txt_website_TextChanged);
            // 
            // txt_phonenum3
            // 
            this.txt_phonenum3.Location = new System.Drawing.Point(130, 140);
            this.txt_phonenum3.Name = "txt_phonenum3";
            this.txt_phonenum3.Size = new System.Drawing.Size(222, 22);
            this.txt_phonenum3.TabIndex = 5;
            // 
            // txt_phonenum2
            // 
            this.txt_phonenum2.Location = new System.Drawing.Point(131, 110);
            this.txt_phonenum2.Name = "txt_phonenum2";
            this.txt_phonenum2.Size = new System.Drawing.Size(222, 22);
            this.txt_phonenum2.TabIndex = 4;
            // 
            // txt_phonenum1
            // 
            this.txt_phonenum1.Location = new System.Drawing.Point(131, 78);
            this.txt_phonenum1.Name = "txt_phonenum1";
            this.txt_phonenum1.Size = new System.Drawing.Size(222, 22);
            this.txt_phonenum1.TabIndex = 3;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(131, 47);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(222, 22);
            this.txt_lastName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email adress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Website";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact Number 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contact Number 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact Number ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(131, 19);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(222, 22);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_desc);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(780, 266);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Description";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(3, 3);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(776, 262);
            this.txt_desc.TabIndex = 0;
            this.txt_desc.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_data);
            this.groupBox3.Controls.Add(this.bttn_ımpxml);
            this.groupBox3.Controls.Add(this.bttn_getJson);
            this.groupBox3.Controls.Add(this.bttn_getCsv);
            this.groupBox3.Controls.Add(this.bttn_getxml);
            this.groupBox3.Location = new System.Drawing.Point(258, 438);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(799, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Export / Import";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_data.Location = new System.Drawing.Point(42, 16);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(155, 25);
            this.lbl_data.TabIndex = 1;
            this.lbl_data.Text = "State : Holding...";
            // 
            // bttn_ımpxml
            // 
            this.bttn_ımpxml.Location = new System.Drawing.Point(615, 44);
            this.bttn_ımpxml.Name = "bttn_ımpxml";
            this.bttn_ımpxml.Size = new System.Drawing.Size(137, 69);
            this.bttn_ımpxml.TabIndex = 0;
            this.bttn_ımpxml.Text = "IMPORT XML";
            this.bttn_ımpxml.UseVisualStyleBackColor = true;
            this.bttn_ımpxml.Click += new System.EventHandler(this.bttn_ımpxml_Click);
            // 
            // bttn_getJson
            // 
            this.bttn_getJson.Location = new System.Drawing.Point(426, 44);
            this.bttn_getJson.Name = "bttn_getJson";
            this.bttn_getJson.Size = new System.Drawing.Size(137, 69);
            this.bttn_getJson.TabIndex = 0;
            this.bttn_getJson.Text = "EXPORT JSON";
            this.bttn_getJson.UseVisualStyleBackColor = true;
            this.bttn_getJson.Click += new System.EventHandler(this.bttn_getJson_Click);
            // 
            // bttn_getCsv
            // 
            this.bttn_getCsv.Location = new System.Drawing.Point(237, 44);
            this.bttn_getCsv.Name = "bttn_getCsv";
            this.bttn_getCsv.Size = new System.Drawing.Size(137, 69);
            this.bttn_getCsv.TabIndex = 0;
            this.bttn_getCsv.Text = "EXPORT CSV";
            this.bttn_getCsv.UseVisualStyleBackColor = true;
            this.bttn_getCsv.Click += new System.EventHandler(this.bttn_getCsv_Click);
            // 
            // bttn_getxml
            // 
            this.bttn_getxml.Location = new System.Drawing.Point(47, 44);
            this.bttn_getxml.Name = "bttn_getxml";
            this.bttn_getxml.Size = new System.Drawing.Size(137, 69);
            this.bttn_getxml.TabIndex = 0;
            this.bttn_getxml.Text = "EXPORT XML";
            this.bttn_getxml.UseVisualStyleBackColor = true;
            this.bttn_getxml.Click += new System.EventHandler(this.bttn_getxml_Click);
            // 
            // bttn_add
            // 
            this.bttn_add.Location = new System.Drawing.Point(268, 348);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(780, 39);
            this.bttn_add.TabIndex = 9;
            this.bttn_add.Text = "Add New Record";
            this.bttn_add.UseVisualStyleBackColor = true;
            this.bttn_add.Click += new System.EventHandler(this.bttn_add_Click);
            // 
            // bttn_up
            // 
            this.bttn_up.Location = new System.Drawing.Point(268, 393);
            this.bttn_up.Name = "bttn_up";
            this.bttn_up.Size = new System.Drawing.Size(386, 39);
            this.bttn_up.TabIndex = 10;
            this.bttn_up.Text = "Update Record";
            this.bttn_up.UseVisualStyleBackColor = true;
            this.bttn_up.Click += new System.EventHandler(this.bttn_up_Click);
            // 
            // bttn_del
            // 
            this.bttn_del.Location = new System.Drawing.Point(661, 394);
            this.bttn_del.Name = "bttn_del";
            this.bttn_del.Size = new System.Drawing.Size(386, 38);
            this.bttn_del.TabIndex = 11;
            this.bttn_del.Text = "Delete Record";
            this.bttn_del.UseVisualStyleBackColor = true;
            this.bttn_del.Click += new System.EventHandler(this.bttn_del_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 582);
            this.Controls.Add(this.bttn_del);
            this.Controls.Add(this.bttn_up);
            this.Controls.Add(this.bttn_add);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txt_adress;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.TextBox txt_phonenum3;
        private System.Windows.Forms.TextBox txt_phonenum2;
        private System.Windows.Forms.TextBox txt_phonenum1;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox txt_desc;
        private System.Windows.Forms.Button bttn_add;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Button bttn_ımpxml;
        private System.Windows.Forms.Button bttn_getJson;
        private System.Windows.Forms.Button bttn_getCsv;
        private System.Windows.Forms.Button bttn_getxml;
        private System.Windows.Forms.Button bttn_up;
        private System.Windows.Forms.Button bttn_del;
        private System.Windows.Forms.Button bttn_clear;
    }
}