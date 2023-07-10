using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool lc = licanseCheck1();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            if (lc)
            {
                Application.Run(new Form1());
                
            }
            else
            {
                Application.Run(new Form3());
            }
        }       

        static bool licanseCheck1()
        {
            RegistryKey RK = Registry.CurrentUser.OpenSubKey("Contacts");
            if (RK != null)
            {
                string HDDSN = RK.GetValue("HDDSerialNumber").ToString();
                string MACADD = RK.GetValue("MACAddress").ToString();
                return true;

            }


            return false;

        }
    
        
    }
}
