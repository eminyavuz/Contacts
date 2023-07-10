using Contacts.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core
{
    public class DatabaseLogicLayer
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader reader;
        List<ContactSignup> records = new List<ContactSignup>();
        public DatabaseLogicLayer()
        {
            records = new List<ContactSignup>();

            string connectionString = "Data Source=.;Initial Catalog=Contacts;Integrated Security=True;";
            con = new SqlConnection(connectionString);

        }
        public void setCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
        }
        public int contCheck(ContactSignup c)
        {
            int result = 0;
            try
            {

                string query = "SELECT * FROM ContactInfos WHERE name = @name AND lastName = @lastname";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", c.name);
                cmd.Parameters.AddWithValue("@lastname", c.lastName);
                setCon();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = -101;

                }
                else result = 1;
                setCon();


            }
            catch (Exception)
            {

                throw;
            }


            return result;

        }

        public int newRecord(ContactSignup c)
        {
            int result = 0;

            int response = contCheck(c);

            if (response == 1)
            {
                try
                {

                    cmd = new SqlCommand("spNewRecord", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("Id", Guid.NewGuid()));
                    cmd.Parameters.Add(new SqlParameter("name", c.name));
                    cmd.Parameters.Add(new SqlParameter("lastname", c.lastName));
                    cmd.Parameters.Add(new SqlParameter("phoneNumber1", c.phoneNum1));
                    cmd.Parameters.Add(new SqlParameter("phoneNumber2", c.phoneNum2));
                    cmd.Parameters.Add(new SqlParameter("phoneNumber3", c.phoneNum3));
                    cmd.Parameters.Add(new SqlParameter("descript", c.desc));
                    cmd.Parameters.Add(new SqlParameter("website", c.website));
                    cmd.Parameters.Add(new SqlParameter("address", c.adress));
                    cmd.Parameters.Add(new SqlParameter("email", c.email));
                    setCon();

                    result = cmd.ExecuteNonQuery();


                }
                catch (Exception)
                {

                    result = 0;
                }
                setCon();

                return result;
            }
            else return response;

        }
        public int systemCheck(User c)
        {
            int result = 0;
            try
            {
                string query = "SELECT * FROM Users WHERE userName = @Username AND userPassword = @Password";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userName", c.userName);
                cmd.Parameters.AddWithValue("@Password", c.password);
                setCon();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    result = 1;
                }

            }
            catch (Exception)
            {
                result = 0;
            }
            setCon();
            return result;
        }
        public int updateRecord(ContactSignup c)
        {
            int result = 0;
            try
            {
                cmd = new SqlCommand("spUpdateRecord", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Id", c.Id));
                cmd.Parameters.Add(new SqlParameter("name", c.name));
                cmd.Parameters.Add(new SqlParameter("lastname", c.lastName));
                cmd.Parameters.Add(new SqlParameter("phoneNumber1", c.phoneNum1));
                cmd.Parameters.Add(new SqlParameter("phoneNumber2", c.phoneNum2));
                cmd.Parameters.Add(new SqlParameter("phoneNumber3", c.phoneNum3));
                cmd.Parameters.Add(new SqlParameter("descript", c.desc));
                cmd.Parameters.Add(new SqlParameter("website", c.website));
                cmd.Parameters.Add(new SqlParameter("address", c.adress));
                cmd.Parameters.Add(new SqlParameter("email", c.email));
                setCon();
                result = cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

                result = -1;
            }
            setCon();
            return result;
        }
        public int deleteRecord(Guid Id)
        {


            int result = 0;
            try
            {
                cmd = new SqlCommand("spDeleteRecord", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", System.Data.SqlDbType.UniqueIdentifier).Value = Id;
                setCon();

                result = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                result = -1;
            }
            finally
            {

            }
            setCon();
            return result;
        }
        public List<ContactSignup> getRecords()
        {
            List<ContactSignup> records = new List<ContactSignup>();
            cmd = new SqlCommand("GetAll", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            setCon();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ContactSignup c = new ContactSignup
                {
                    name = (string)reader[0],
                    Id = (Guid)reader[1],
                    lastName = (string)reader[2],
                    phoneNum1 = (string)reader[3],
                    phoneNum2 = (string)reader[4],
                    phoneNum3 = (string)reader[5],
                    website = (string)reader[6],
                    email = (string)reader[7],
                    desc = (string)reader[8],
                    adress = (string)reader[9],
                }
                ;

                records.Add(c);
            }
            records.Sort((x, y) => (x.name + x.lastName).CompareTo((y.name + y.lastName)));
            setCon();
            return records;

        }
    }

    }
