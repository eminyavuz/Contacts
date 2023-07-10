using Contacts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
    
namespace Contacts.UI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bttn_path_Click(object sender, EventArgs e)
        {
            int result = path();
            if (result > 0)
            {
                MessageBox.Show("Xml data has sucsessfully isnerted","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                System.Threading.Thread.Sleep(3000);
                this.Close();
            }
            else
            {
                MessageBox.Show("Xml data could not be isnerted. Please check your nodes and path", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int path()
        {
            int result = 0;
            string path = @txt_path.Text;
            if(!string.IsNullOrEmpty(path))
            {
                XDocument xdoc = XDocument.Load(path);
                List<XElement> read = xdoc.Descendants("Contact").ToList();
          

        
            List<ContactSignup> records = new List<ContactSignup>();
                foreach (XElement x in read)
                {
                    try
                    {
                        ContactSignup record = new ContactSignup();
                        record.Id = Guid.Parse(x.Element("ID").Value);
                        record.name = x.Element("Name").Value;
                        record.lastName = x.Element("lastName").Value;
                        record.phoneNum1 = x.Element("TelephoneNumber1").Value;
                        record.phoneNum2 = x.Element("TelephoneNumber2").Value;
                        record.phoneNum3 = x.Element("TelephoneNumber3").Value;
                        record.website = x.Element("Website").Value.ToString();
                        record.desc = x.Element("Description").Value;
                        record.adress = x.Element("Address").Value;
                        record.email = x.Element("Email").Value;
                        records.Add(record);
                        result = 1;
                    }
                    catch (Exception)
                    {
                        result = 0;


                    }
                }


            }
            return result;
        }
    }
}
