using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ADONet_dataset
{
    internal class DBFunct
    {
        private readonly MainNav _parent;
        public DBFunct(MainNav parent)
        {
            _parent = parent;
        }

        

        public static SqlConnection GetConnection()
        {
            string assemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string sql = String.Format("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={0}\\UGM_database.mdf;Integrated Security=True;Connect Timeout=30", assemblyPath);
            SqlConnection con = new SqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Can't connect to db", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddContact(Contact contact)
        {
            string sql = "insert into phonebook (Nama, no_telp, Email, Alamat, Company) values('" + contact.Name + "','" + contact.Number + "','" + contact.Email + "','" + contact.Address + "','" + contact.Company + "')";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contact added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Contact not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteContact(int id)
        {
            string sql = "delete from phonebook where Id=" + id + "";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Contact not deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void EditContact(Contact contact, int id)
        {
            string sql = "update phonebook set Nama='" + contact.Name + "',Email = '"+contact.Email+"',No_telp='" + contact.Number + "',Alamat='" + contact.Address + "', Company='"+contact.Company+"' where Id='" + id + "'";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Contact added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Contact not edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void ShowAllContact(DataGridView dgv)
        {
            SqlConnection con = GetConnection();
            string query = "select * from phonebook";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            con.Close();
        }
        public static void Search(string query,DataGridView dgv)
        {
            SqlConnection con = GetConnection();
            string sql = "select * from phonebook where Nama like '%" + query + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
