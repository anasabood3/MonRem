using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MonremSys.Forms.Customers
{
    public partial class CustomerManage : Form
    {

        //Customers List Form
        private readonly CustomersList _parent;

        public CustomerManage(CustomersList parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        
        // --------------------------------- on Form Load -----------------------

        private void CustomerManage_Load(object sender, EventArgs e)
        {
            BindControl();
            var id = ((Customer)customerBindingSource.Current).Id;
            if (id !=0)
            {
                formTitle.Text = "Update Existing Customer";
                saveBtn.Text = "Update";
            }
            else
            {
                formTitle.Text = "Add New Customer";
                saveBtn.Text = "Save";
            }
        }

        private void BindControl()
        {
            //Clear all the old bindings
            fullNameTxt.DataBindings.Clear();
            phNumberTxt.DataBindings.Clear();
            addressTxt.DataBindings.Clear();
            saveBtn.DataBindings.Clear();


            fullNameTxt.DataBindings.Add("Text", customerBindingSource, "Name");
            phNumberTxt.DataBindings.Add("Text", customerBindingSource, "Phone_number");
            addressTxt.DataBindings.Add("Text", customerBindingSource, "Address");
            saveBtn.DataBindings.Add("Enabled", customerBindingSource, "IsValid");
        }

        //------------------------- Form Control Buttons Handling ------------------------------

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            fullNameTxt.Focus();
            this.Close();
            _parent.UpeateListInfo();
        }

        private void Save()
        {
            Customer _current = (Customer)customerBindingSource.Current;
            if (_current != null && _current.IsValid)
            {
                if(_current.Id ==0)
                    _current.AddintoDb();
                else
                    _current.UpdateinDb();
            }
            else
            {
                MessageBox.Show("Validation Erorr", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------------------------- Form Validation --------------------------------

        private void phNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valid_input = char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsControl(e.KeyChar);
            if (!valid_input)
                e.Handled = true;
        }
    }
}
