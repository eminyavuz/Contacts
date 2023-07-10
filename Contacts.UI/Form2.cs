using Contacts.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts.UI
{
    public partial class MainForm : Form
    {
   
        Contact.BLL.BusinessLogicLayer BLL;

        public MainForm()
        {
            
            InitializeComponent();
           
            BLL = new Contact.BLL.BusinessLogicLayer();
         

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bttn_add_Click(object sender, EventArgs e)
        {
           int result= BLL.newRecord(Guid.NewGuid(), txt_name.Text, txt_lastName.Text,
                txt_phonenum1.Text, txt_phonenum2.Text, txt_phonenum3.Text, txt_email.Text, txt_email.Text
                , txt_website.Text, txt_desc.Text) ;
            if (result > 0)
            {
                MessageBox.Show("Record added succsessfully", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fill();
            }
            else if(result == -100)
            {
                MessageBox.Show("There must be Name last name and a phone number", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == -101)
            {
                MessageBox.Show("This person already exist", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record could not be added","İnformation", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void fill()
        {
            List<ContactSignup> myrecords = BLL.getRecords();
         
            
            if(myrecords!=null && myrecords.Count >= 0)
            {
               
                listBox1.DataSource = myrecords; 
                
              
            }
            
          
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
           ContactSignup cont= (ContactSignup) listBox.SelectedItem;
            txt_name.Text = cont.name;
            txt_lastName.Text = cont.lastName;
            txt_email.Text = cont.email;
            txt_adress.Text = cont.adress;  
            txt_desc.Text = cont.desc;
            txt_phonenum1.Text = cont.phoneNum1;
            txt_phonenum2.Text = cont.phoneNum2;
            txt_phonenum3.Text = cont.phoneNum3;
            txt_website.Text = cont.website;
           
            groupBox2.Text = "Update record";

        }

        private void bttn_up_Click(object sender, EventArgs e)  
        {
            if (listBox1.SelectedItem != null)
            {
                ContactSignup cont= (ContactSignup)listBox1.SelectedItem;
                int result =BLL.updateRecord(cont.Id, txt_name.Text, txt_lastName.Text,txt_phonenum1.Text,txt_phonenum2.Text,txt_phonenum3.Text,
                    txt_adress.Text ,txt_email.Text,txt_website.Text,txt_desc.Text);
                if (result > 0)
                {
                    MessageBox.Show("Record has been updated sucsessfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    fill();
                }
                else if (result == -100)
                {
                    MessageBox.Show("There is a missing argument","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Record could not be updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bttn_del_Click(object sender, EventArgs e)
        {
            Button b= new Button();
            Guid del = ((ContactSignup)listBox1.SelectedItem).Id;
            int result = BLL.deleteRecord(del);
            if (result > 0)
            {
                MessageBox.Show("Record has been removed sucsessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                fill();
            }
            else
            {
                MessageBox.Show("Record could not be removed", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttn_getxml_Click(object sender, EventArgs e)
        {
           int result= BLL.getXmlData();
            if (result > 0)
            {
                lbl_data.Text = " Satate: Xml data has exported succsessfully";
            }
            else
            {
                lbl_data.Text = " Satate: Data could not be exported";
            }
        }

        private void bttn_getCsv_Click(object sender, EventArgs e)
         {
            int result= BLL.getCSVdata();
            
            if (result > 0)
            {
                lbl_data.Text = " Satate: CSV data has exported succsessfully";
            }
            else
            {
                lbl_data.Text = " Satate: Data could not be exported";
            }
        }

        private void txt_website_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_clear_Click(object sender, EventArgs e)
        {
            groupBox2.Text = "New Recordd";
            txt_adress.Text=String.Empty;
            txt_desc.Text=String.Empty;
            txt_email.Text=String.Empty;    
            txt_lastName.Text=String.Empty;
            txt_name.Text=String.Empty;
            txt_phonenum1.Text=String.Empty;    
            txt_phonenum2.Text=String.Empty;
            txt_phonenum3.Text=String.Empty;    
            txt_website.Text=String.Empty;
            
     }

        private void bttn_getJson_Click(object sender, EventArgs e)
        {
        int result=BLL.getJsonData();
            if(result > 0)
            {
                lbl_data.Text = "Json data has exported succsessfully";
            }
            else
            {
                lbl_data.Text = "Data could not be exported";
            }
        }

        private void bttn_ımpxml_Click(object sender, EventArgs e)
        {
          Form4 form = new Form4();
            form.Show();
        }
    }
}
