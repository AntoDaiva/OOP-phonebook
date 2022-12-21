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
    public partial class DeleteConfirm : Form
    {
        private MainNav _parent;
        public DeleteConfirm(MainNav parent)
        {
            InitializeComponent();
            _parent = parent;
            NameLabel.Text = _parent.selected_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                _parent.Con.Open();
                string query = "delete from phonebook where Id=" + _parent.selected_id + "";
                SqlCommand cmd = new SqlCommand(query, _parent.Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contact Deleted Successfully");
                _parent.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            this.Close();
        }
    }
}
