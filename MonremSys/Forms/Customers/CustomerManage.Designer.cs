
namespace MonremSys.Forms.Customers
{
    partial class CustomerManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tileBar = new Guna.UI2.WinForms.Guna2Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.phNumberTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.formShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.fullnameValidation = new System.Windows.Forms.Label();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tileBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.tileBar.Controls.Add(this.formTitle);
            this.tileBar.Controls.Add(this.closeBtn);
            this.tileBar.CustomBorderColor = System.Drawing.Color.Silver;
            this.tileBar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4);
            this.tileBar.Name = "tileBar";
            this.tileBar.Size = new System.Drawing.Size(446, 39);
            this.tileBar.TabIndex = 2;
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formTitle.Location = new System.Drawing.Point(7, 7);
            this.formTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(151, 25);
            this.formTitle.TabIndex = 13;
            this.formTitle.Text = "Add New Customer";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.closeBtn.HoverState.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(386, 1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(60, 36);
            this.closeBtn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Full Name";
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.BorderThickness = 2;
            this.fullNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "Name", true));
            this.fullNameTxt.DefaultText = "";
            this.fullNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.fullNameTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.fullNameTxt.ForeColor = System.Drawing.Color.Black;
            this.fullNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.fullNameTxt.IconRight = global::MonremSys.Properties.Resources.user_32px;
            this.fullNameTxt.Location = new System.Drawing.Point(29, 98);
            this.fullNameTxt.MaxLength = 50;
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.PasswordChar = '\0';
            this.fullNameTxt.PlaceholderText = "Required";
            this.fullNameTxt.SelectedText = "";
            this.fullNameTxt.Size = new System.Drawing.Size(373, 36);
            this.fullNameTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.fullNameTxt.TabIndex = 7;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(MonremSys.Customer);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone Number";
            // 
            // phNumberTxt
            // 
            this.phNumberTxt.BorderThickness = 2;
            this.phNumberTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phNumberTxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "Phone_number", true));
            this.phNumberTxt.DefaultText = "";
            this.phNumberTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phNumberTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phNumberTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phNumberTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phNumberTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.phNumberTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.phNumberTxt.ForeColor = System.Drawing.Color.Black;
            this.phNumberTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.phNumberTxt.IconRight = global::MonremSys.Properties.Resources.phone_32px;
            this.phNumberTxt.Location = new System.Drawing.Point(29, 189);
            this.phNumberTxt.MaxLength = 15;
            this.phNumberTxt.Name = "phNumberTxt";
            this.phNumberTxt.PasswordChar = '\0';
            this.phNumberTxt.PlaceholderText = "Required";
            this.phNumberTxt.SelectedText = "";
            this.phNumberTxt.Size = new System.Drawing.Size(373, 36);
            this.phNumberTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.phNumberTxt.TabIndex = 9;
            this.phNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phNumberTxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address";
            // 
            // addressTxt
            // 
            this.addressTxt.BorderThickness = 2;
            this.addressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTxt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "Address", true));
            this.addressTxt.DefaultText = "";
            this.addressTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.addressTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.addressTxt.ForeColor = System.Drawing.Color.Black;
            this.addressTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.addressTxt.IconRight = global::MonremSys.Properties.Resources.next_location_32px;
            this.addressTxt.Location = new System.Drawing.Point(29, 276);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.PasswordChar = '\0';
            this.addressTxt.PlaceholderText = "Optional";
            this.addressTxt.SelectedText = "";
            this.addressTxt.Size = new System.Drawing.Size(373, 36);
            this.addressTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.addressTxt.TabIndex = 11;
            // 
            // formShadow
            // 
            this.formShadow.TargetForm = this;
            // 
            // fullnameValidation
            // 
            this.fullnameValidation.AutoSize = true;
            this.fullnameValidation.ForeColor = System.Drawing.Color.Red;
            this.fullnameValidation.Location = new System.Drawing.Point(29, 354);
            this.fullnameValidation.Name = "fullnameValidation";
            this.fullnameValidation.Size = new System.Drawing.Size(0, 17);
            this.fullnameValidation.TabIndex = 15;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.saveBtn.BorderRadius = 5;
            this.saveBtn.BorderThickness = 1;
            this.saveBtn.FillColor = System.Drawing.Color.Transparent;
            this.saveBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.saveBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.saveBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(321, 411);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 37);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formDragControl
            // 
            this.formDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.formDragControl.TargetControl = this.tileBar;
            this.formDragControl.UseTransparentDrag = true;
            // 
            // CustomerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(446, 475);
            this.Controls.Add(this.fullnameValidation);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phNumberTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullNameTxt);
            this.Controls.Add(this.tileBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerManage";
            this.Load += new System.EventHandler(this.CustomerManage_Load);
            this.tileBar.ResumeLayout(false);
            this.tileBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel tileBar;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox fullNameTxt;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox phNumberTxt;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox addressTxt;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2ShadowForm formShadow;
        public System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label fullnameValidation;
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
    }
}