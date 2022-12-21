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
            populate();
        }

    public void populate()
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
        public SqlConnection Con = new SqlConnection(ConnectionString);
        
        //add
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.ShowDialog();
            populate();

        }

        //delete
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selected_id == "")
            {
                MessageBox.Show("Select The Row to Delete");
            }
            else
            {
                DeleteConfirm deleteConfirm = new DeleteConfirm(this);
                deleteConfirm.ShowDialog();
                populate();
            }
        }

        //edit
        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            editForm.ShowDialog();
            populate();
        }

    private void Search()
        {
            Con.Open();
            string query = "select * from phonebook where Nama like '%" + SearchBox.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            phonebookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }


        //input selected row
        public string selected_id;
        public string selected_name;
        public string selected_number;
        public string selected_email;
        public string selected_alamat;
        public string selected_company;
        private void phonebookDGV_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in phonebookDGV.SelectedRows)
            {
                selected_id = row.Cells[0].Value.ToString();
                selected_name = row.Cells[1].Value.ToString();
                selected_number = row.Cells[2].Value.ToString();
                selected_email = row.Cells[3].Value.ToString();
                selected_alamat = row.Cells[4].Value.ToString();
                selected_company = row.Cells[5].Value.ToString();
            }
        }
    }
}
