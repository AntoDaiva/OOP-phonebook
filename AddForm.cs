using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONet_dataset
{
    public partial class AddForm : Form
    {
        private MainNav _parent;
        public AddForm(MainNav parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void AddForm_Load(object sender, EventArgs e)
        { 
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _parent.Con.Open();
                string query = "insert into phonebook values(" + IdBox.Text + ",'" + NamaBox.Text + "','" + NomerBox.Text + "','" + EmailBox.Text + "','" + AlamatBox.Text + "','" + CompanyBox.Text + "')";
                SqlCommand cmd = new SqlCommand(query, _parent.Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contact Added");
                _parent.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
