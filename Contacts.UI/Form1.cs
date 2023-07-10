using System;
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
    public partial class Form1 : Form
    {
        Contact.BLL.BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL= new Contact.BLL.BusinessLogicLayer();
          
        }

        private void entr_bttn_Click(object sender, EventArgs e)
        {
            int result =BLL.systemCheck(usrnm_tx.Text,pswrd_tx.Text);
            if(result >0)
            {
            
                MainForm form = new MainForm();
                
                form.Show();
               this.Hide();
               

            }
            else if(result == -100)
            {
                MessageBox.Show("There is an missing argument please check your informations and try again", "İnformation", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("User not found", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
