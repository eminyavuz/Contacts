using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts.UI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lb_lic_Click(object sender, EventArgs e)
        {

        }

        private void bttn_lic_Click(object sender, EventArgs e)
        {
            if (tx_lic.Text == "f3299e9c-4a28-4bcc-a8fb-45139bdc823d")
            {
                string HDDSN=string.Empty;
                string MACADDSTR=string.Empty;
                string driver = "C";
                ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + driver + ":\"");
                disk.Get();
                HDDSN = disk["VolumeSerialNumber"].ToString();
                foreach(NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if(nic.OperationalStatus== OperationalStatus.Up)
                    {
                        MACADDSTR = nic.GetPhysicalAddress().ToString();
                        break;
                    }
                }
                
                if(!string.IsNullOrEmpty(MACADDSTR)&& !string.IsNullOrEmpty(HDDSN))
                {
                    RegistryKey RK = Registry.CurrentUser.CreateSubKey("Contacts", true);
                    RK.SetValue("HDDSerialNumber", HDDSN);
                    RK.SetValue("MACAddress", MACADDSTR);
                }


                MessageBox.Show("Key activated sucsessfully. Please reboot application", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

               System.Threading.Thread.Sleep(2000);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invaild licanse key", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
