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
using System.IO;

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
            DBFunct.ShowAllContact(phonebookDGV);
        }
        
        
        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            populate();
        }
        static string assemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private static string ConnectionString = String.Format("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={0}\\UGM_database.mdf;Integrated Security=True;Connect Timeout=30", assemblyPath);
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

        //search by click
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            DBFunct.Search(SearchBox.Text, phonebookDGV);

        }
        //search by fill textbox
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            DBFunct.Search(SearchBox.Text, phonebookDGV);
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

        private void MainNav_Load(object sender, EventArgs e)
        {

        }
    }
}
