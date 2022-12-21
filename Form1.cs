using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADONet_dataset
{
    public partial class MainNav : Form
    {
        public MainNav()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    
    private void populate()
        {
            Con.Open();
            string query = "select * from phonebook";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            phonebookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\anton\things\kuliah\sem 3\OOP\ADONet_dataset\UGM_database.mdf"";Integrated Security=True;Connect Timeout=30";
        SqlConnection Con = new SqlConnection(ConnectionString);
              
        private void AddBtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                Con.Open();
                string query = "insert into phonebook values(" + IdBox.Text + ",'" + NamaBox.Text + "','" + NomerBox.Text + "','" + AlamatBox.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contact Added");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void phonebookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdBox.Text = phonebookDGV.SelectedRows[0].Cells[0].Value.ToString();
            NamaBox.Text = phonebookDGV.SelectedRows[0].Cells[01].Value.ToString();
            NomerBox.Text = phonebookDGV.SelectedRows[0].Cells[2].Value.ToString();
            AlamatBox.Text = phonebookDGV.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(IdBox.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from phonebook where Id=" + IdBox.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NamaBox.Text == "" || NomerBox.Text == "" || AlamatBox.Text=="")
            {
                MessageBox.Show("Missing Information");
                return;
            }
            try
            {
                Con.Open();
                string query = "update phonebook set Nama='" + NamaBox.Text + "',No_telp='" + NomerBox.Text + "',Alamat='" + AlamatBox.Text + "' where Id='"+ IdBox.Text+"'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contact Edited Successfully");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SearchBox.Text);
        }
    }
}
