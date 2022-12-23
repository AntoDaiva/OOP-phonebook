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
            Contact contact = new Contact(NamaBox.Text, NomerBox.Text, EmailBox.Text, CompanyBox.Text, AlamatBox.Text);
            try
            {
                DBFunct.AddContact(contact);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
