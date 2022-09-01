using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonremSys.Forms.Settings
{
    public partial class DestinationManageForm : Form
    {

        //Customers List Form
        private readonly Settings _parent;


        public DestinationManageForm(Settings parent)
        {
            InitializeComponent();
            _parent = parent;
        }


        // --------------------------------- on Form Load -----------------------

        private void DestinationManageForm_Load(object sender, EventArgs e)
        {
            BindControl();
            var id = ((Destination)destinationBindingSource.Current).Id;
            if (id != 0)
            {
                formTitle.Text = "Update Existing Destination";
                saveBtn.Text = "Update";
            }
            else
            {
                formTitle.Text = "Add New Destination";
                saveBtn.Text = "Save";
            }
        }

        private void BindControl()
        {
            //Clear all the old bindings
            destinationNameTxt.DataBindings.Clear();
            destinationStateCheckBox.DataBindings.Clear();
            saveBtn.DataBindings.Clear();


            destinationStateCheckBox.DataBindings.Add("Checked", destinationBindingSource, "Is_active");
            destinationNameTxt.DataBindings.Add("Text", destinationBindingSource, "Name");
            saveBtn.DataBindings.Add("Enabled", destinationBindingSource, "IsValid");
        }

        //------------------------- Form Control Buttons Handling ------------------------------

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            destinationNameTxt.Focus();
            this.Close();
            _parent.Display();
        }

        private void Save()
        {
            Destination _current = (Destination)destinationBindingSource.Current;
            if (_current != null && _current.IsValid)
            {
                if (_current.Id == 0)
                    _current.AddintoDb();
                else
                    _current.UpdateinDb();
            }
            else
            {
                MessageBox.Show("Validation Erorr", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
