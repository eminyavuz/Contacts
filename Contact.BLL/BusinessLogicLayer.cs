using Contacts.Core;
using Contacts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;

namespace Contact.BLL
{
    public class BusinessLogicLayer
    {
        List<ContactSignup> records = new List<ContactSignup>();
        Contacts.Core.DatabaseLogicLayer DLL;
        public BusinessLogicLayer()
        {
            DLL = new Contacts.Core.DatabaseLogicLayer();

        }

        public int systemCheck(string userName, string password)
        {
            int result = 0;
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                User u = new User();
                u.userName = userName;
                u.password = password;
                result = DLL.systemCheck(u);
            }
            else
            {
                result = -100; // missing argument error
            }
            return result;

        }
        public int newRecord(Guid id, string name, string lastName, string phonenum1,
            string phonenum2, string phonenum3, string adress, string email, string website, string desc)
        {
            int result = 0;
            if (id != Guid.Empty && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(lastName) &&
                !string.IsNullOrEmpty(phonenum1))
            {
                ContactSignup c = new ContactSignup();
                c.Id = id;
                c.name = name;
                c.lastName = lastName;
                c.desc = desc;
                c.phoneNum1 = phonenum1;
                c.adress = adress;
                c.phoneNum2 = phonenum2;
                c.phoneNum3 = phonenum3;
                c.website = website;
                c.desc = desc;
                c.email = email;

                result = DLL.newRecord(c);
            }
           else
            {
                result = -100; //missing argument error
            }
         
            return result;
        }
      
        public int deleteRecord(Guid Id)
        {
            return DLL.deleteRecord(Id);
        }
       
                   
        public List<ContactSignup> getRecords()
        {

            List<ContactSignup> records = DLL.getRecords();

            return records;
        }

        public int getXmlData()
        {
            int result = 0;

            try
            {
                List<ContactSignup> records = getRecords();

                XDocument Doc = new XDocument(new XDeclaration("1.0.0.1", "UTF-8", "yes"),
                    new XElement("ContactRecords",
                    records.Select(I => new XElement("Record", new XElement("ID", I.Id),
                    new XElement("Name", I.name),
                    new XElement("Lastname", I.lastName),
                    new XElement("Telephonenumber", I.phoneNum1),
                    new XElement("Telephonenumber2", I.phoneNum2),
                    new XElement("Telephonenumber3", I.phoneNum3),
                    new XElement("EmailAdress", I.email),
                    new XElement("Adress", I.adress),
                    new XElement("WebSite", I.website),
                    new XElement("Description", I.desc)))));

                Doc.Save(@"c:\ContactsDB\GetXMLdata.xml");
                result = 1;


            }
            catch (Exception ex)
            {
                result = 0;
            }

            return result;
        }

        public int getCSVdata()
        {
            int result = 0;
            try
            {
                List<ContactSignup> records = getRecords();
                StreamWriter sw = new StreamWriter(@"C:\ContactsDB\GetCSVdata.csv");
                CsvHelper.CsvWriter cw = new CsvHelper.CsvWriter(sw);
                cw.WriteHeader(typeof(ContactSignup));
                foreach (ContactSignup item in records)
                {
                    cw.WriteRecord(item);

                }
                sw.Close();
                result = 1;

            }
            catch (Exception ex)
            {
                result = 0;

            }

            return result;
        }

        public int getJsonData()
        {
            int result = 0;
            try
            {
                List<ContactSignup> records = getRecords();
                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(records);
                File.WriteAllText(@"c:\getJsonData.json", jsonData);
                result = 1;


            }
            catch (Exception)
            {

                result = 0;
            }



            return result;
        }

        public int updateRecord(Guid id, string name, string lastName, string phonenum1,
            string phonenum2, string phonenum3, string adress, string email, string website, string desc)
        {
            int result = 0;
            if (id != Guid.Empty && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(lastName) &&
               !string.IsNullOrEmpty(phonenum1))
            {
                ContactSignup c = new ContactSignup();
                c.Id = id;
                c.name = name;
                c.lastName = lastName;
                c.desc = desc;
                c.phoneNum1 = phonenum1;
                c.adress = adress;
                c.phoneNum2 = phonenum2;
                c.phoneNum3 = phonenum3;
                c.website = website;
                c.desc = desc;
                c.email = email;
                result = DLL.updateRecord(c);

            }

            else { result = -100; }
            return result;
        }
    }
}
