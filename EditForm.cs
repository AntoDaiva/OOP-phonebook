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
    public partial class EditForm : Form
    {
        private MainNav _parent;
        public EditForm(MainNav parent)
        {
            InitializeComponent();
            _parent = parent;
            NamaBox.Text = _parent.selected_name.TrimEnd();
            NomerBox.Text = _parent.selected_number.TrimEnd();
            EmailBox.Text = _parent.selected_email.TrimEnd();
            AlamatBox.Text = _parent.selected_alamat.TrimEnd();
            CompanyBox.Text = _parent.selected_company.TrimEnd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact(NamaBox.Text, NomerBox.Text, EmailBox.Text, CompanyBox.Text, AlamatBox.Text);
            try
            {
                DBFunct.EditContact(contact, int.Parse(_parent.selected_id));
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
