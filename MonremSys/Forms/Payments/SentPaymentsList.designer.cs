
namespace MonremSys
{
    partial class SentPaymentsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentPaymentsList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.newBtn = new Guna.UI2.WinForms.Guna2Button();
            this.labla = new System.Windows.Forms.Label();
            this.paymentsCountLbl = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.viewFilterCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.sentpaymentsDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmMessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.settingsCMS = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.generateRecieptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPaymentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sentpaymentsDgv)).BeginInit();
            this.settingsCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.MediumBlue;
            this.guna2Panel2.BorderRadius = 1;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel2.Controls.Add(this.newBtn);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 813);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1291, 75);
            this.guna2Panel2.TabIndex = 10;
            // 
            // newBtn
            // 
            this.newBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.newBtn.BorderRadius = 5;
            this.newBtn.BorderThickness = 1;
            this.newBtn.FillColor = System.Drawing.Color.Transparent;
            this.newBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.newBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.newBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.newBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.newBtn.Location = new System.Drawing.Point(1166, 17);
            this.newBtn.Margin = new System.Windows.Forms.Padding(4);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(112, 37);
            this.newBtn.TabIndex = 2;
            this.newBtn.Text = "New";
            this.newBtn.Click += new System.EventHandler(this.NewItem);
            // 
            // labla
            // 
            this.labla.AutoSize = true;
            this.labla.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.labla.ForeColor = System.Drawing.Color.White;
            this.labla.Location = new System.Drawing.Point(95, 30);
            this.labla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labla.Name = "labla";
            this.labla.Size = new System.Drawing.Size(82, 21);
            this.labla.TabIndex = 1;
            this.labla.Text = "Payments";
            // 
            // paymentsCountLbl
            // 
            this.paymentsCountLbl.AutoSize = true;
            this.paymentsCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.paymentsCountLbl.ForeColor = System.Drawing.Color.White;
            this.paymentsCountLbl.Location = new System.Drawing.Point(23, 15);
            this.paymentsCountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentsCountLbl.Name = "paymentsCountLbl";
            this.paymentsCountLbl.Size = new System.Drawing.Size(40, 42);
            this.paymentsCountLbl.TabIndex = 0;
            this.paymentsCountLbl.Text = "0";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.viewFilterCombo);
            this.guna2Panel1.Controls.Add(this.searchTxt);
            this.guna2Panel1.Controls.Add(this.labla);
            this.guna2Panel1.Controls.Add(this.paymentsCountLbl);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1291, 75);
            this.guna2Panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(690, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "View only:";
            // 
            // viewFilterCombo
            // 
            this.viewFilterCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewFilterCombo.BackColor = System.Drawing.Color.Transparent;
            this.viewFilterCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.viewFilterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewFilterCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.viewFilterCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.viewFilterCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.viewFilterCombo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFilterCombo.ForeColor = System.Drawing.Color.White;
            this.viewFilterCombo.IntegralHeight = false;
            this.viewFilterCombo.ItemHeight = 30;
            this.viewFilterCombo.Items.AddRange(new object[] {
            "Today",
            "Yesterday",
            "This week",
            "This month",
            "All Items"});
            this.viewFilterCombo.Location = new System.Drawing.Point(797, 14);
            this.viewFilterCombo.Name = "viewFilterCombo";
            this.viewFilterCombo.Size = new System.Drawing.Size(179, 36);
            this.viewFilterCombo.StartIndex = 4;
            this.viewFilterCombo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.viewFilterCombo.TabIndex = 8;
            this.viewFilterCombo.SelectedIndexChanged += new System.EventHandler(this.FilterList);
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxt.AutoRoundedCorners = true;
            this.searchTxt.BorderRadius = 20;
            this.searchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxt.DefaultText = "";
            this.searchTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.searchTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.searchTxt.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.searchTxt.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchTxt.IconLeft")));
            this.searchTxt.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.searchTxt.IconLeftSize = new System.Drawing.Size(15, 15);
            this.searchTxt.Location = new System.Drawing.Point(994, 14);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(5);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PasswordChar = '\0';
            this.searchTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.searchTxt.PlaceholderText = "Search";
            this.searchTxt.SelectedText = "";
            this.searchTxt.Size = new System.Drawing.Size(267, 43);
            this.searchTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.searchTxt.TabIndex = 7;
            this.searchTxt.TextOffset = new System.Drawing.Point(5, 0);
            this.searchTxt.TextChanged += new System.EventHandler(this.SearchItem);
            // 
            // sentpaymentsDgv
            // 
            this.sentpaymentsDgv.AllowUserToAddRows = false;
            this.sentpaymentsDgv.AllowUserToDeleteRows = false;
            this.sentpaymentsDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.sentpaymentsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sentpaymentsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sentpaymentsDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.sentpaymentsDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sentpaymentsDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sentpaymentsDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sentpaymentsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sentpaymentsDgv.ColumnHeadersHeight = 40;
            this.sentpaymentsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sentpaymentsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sentpaymentsDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.sentpaymentsDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sentpaymentsDgv.EnableHeadersVisualStyles = false;
            this.sentpaymentsDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.sentpaymentsDgv.Location = new System.Drawing.Point(0, 75);
            this.sentpaymentsDgv.Margin = new System.Windows.Forms.Padding(4);
            this.sentpaymentsDgv.MultiSelect = false;
            this.sentpaymentsDgv.Name = "sentpaymentsDgv";
            this.sentpaymentsDgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sentpaymentsDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.sentpaymentsDgv.RowHeadersVisible = false;
            this.sentpaymentsDgv.RowHeadersWidth = 51;
            this.sentpaymentsDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.sentpaymentsDgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.sentpaymentsDgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.sentpaymentsDgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.sentpaymentsDgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.sentpaymentsDgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.sentpaymentsDgv.RowTemplate.DividerHeight = 5;
            this.sentpaymentsDgv.RowTemplate.Height = 40;
            this.sentpaymentsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sentpaymentsDgv.Size = new System.Drawing.Size(1291, 738);
            this.sentpaymentsDgv.TabIndex = 9;
            this.sentpaymentsDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.sentpaymentsDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.sentpaymentsDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.sentpaymentsDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.sentpaymentsDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.sentpaymentsDgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.sentpaymentsDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.sentpaymentsDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sentpaymentsDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sentpaymentsDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.sentpaymentsDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.sentpaymentsDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sentpaymentsDgv.ThemeStyle.HeaderStyle.Height = 40;
            this.sentpaymentsDgv.ThemeStyle.ReadOnly = true;
            this.sentpaymentsDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.sentpaymentsDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sentpaymentsDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sentpaymentsDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sentpaymentsDgv.ThemeStyle.RowsStyle.Height = 40;
            this.sentpaymentsDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sentpaymentsDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sentpaymentsDgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.settingsCM);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "id";
            this.Column1.FillWeight = 40.60914F;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 45;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "amount";
            this.Column3.FillWeight = 99.49239F;
            this.Column3.HeaderText = "Amount";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "rate";
            this.Column4.FillWeight = 99.49239F;
            this.Column4.HeaderText = "Rate";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "currency";
            this.Column5.FillWeight = 99.49239F;
            this.Column5.HeaderText = "Currency";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "value";
            this.Column6.FillWeight = 99.49239F;
            this.Column6.HeaderText = "USD Value";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "description";
            this.Column7.FillWeight = 99.49239F;
            this.Column7.HeaderText = "Description";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "payment_date";
            this.Column8.FillWeight = 99.49239F;
            this.Column8.HeaderText = "Payment Date";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // confirmMessageDialog
            // 
            this.confirmMessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.confirmMessageDialog.Caption = "Warning";
            this.confirmMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.confirmMessageDialog.Parent = null;
            this.confirmMessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.confirmMessageDialog.Text = null;
            // 
            // settingsCMS
            // 
            this.settingsCMS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsCMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.settingsCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateRecieptToolStripMenuItem,
            this.viewDetailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.copyPaymentDataToolStripMenuItem});
            this.settingsCMS.Name = "guna2ContextMenuStrip1";
            this.settingsCMS.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.settingsCMS.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.settingsCMS.RenderStyle.ColorTable = null;
            this.settingsCMS.RenderStyle.RoundedEdges = true;
            this.settingsCMS.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.settingsCMS.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.settingsCMS.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.settingsCMS.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.settingsCMS.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.settingsCMS.Size = new System.Drawing.Size(261, 164);
            // 
            // generateRecieptToolStripMenuItem
            // 
            this.generateRecieptToolStripMenuItem.Image = global::MonremSys.Properties.Resources.Cheque_32px;
            this.generateRecieptToolStripMenuItem.Name = "generateRecieptToolStripMenuItem";
            this.generateRecieptToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.generateRecieptToolStripMenuItem.Text = "  Generate Reciept";
            this.generateRecieptToolStripMenuItem.Click += new System.EventHandler(this.GenerateReceipt);
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Image = global::MonremSys.Properties.Resources.view_details_32px;
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.viewDetailsToolStripMenuItem.Text = "  View Details";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.ViewItemDetails);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::MonremSys.Properties.Resources.edit_row_32px;
            this.editToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.ShowShortcutKeys = false;
            this.editToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.editToolStripMenuItem.Text = "  Edit";
            this.editToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.editToolStripMenuItem.ToolTipText = "Edit remittance data (Ctrl + E)";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditItem);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::MonremSys.Properties.Resources.waste_32px;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.ShowShortcutKeys = false;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.deleteToolStripMenuItem.Text = "  Delete";
            this.deleteToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.deleteToolStripMenuItem.ToolTipText = "Delete a Remittance (Ctrl + D)";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteItem);
            // 
            // copyPaymentDataToolStripMenuItem
            // 
            this.copyPaymentDataToolStripMenuItem.Image = global::MonremSys.Properties.Resources.copy_32px;
            this.copyPaymentDataToolStripMenuItem.Name = "copyPaymentDataToolStripMenuItem";
            this.copyPaymentDataToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.copyPaymentDataToolStripMenuItem.Text = "Copy Payment Data";
            this.copyPaymentDataToolStripMenuItem.Click += new System.EventHandler(this.CopyPaymentData);
            // 
            // SentPaymentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1291, 888);
            this.Controls.Add(this.sentpaymentsDgv);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SentPaymentsList";
            this.Text = "SentPaymentsList";
            this.Load += new System.EventHandler(this.SentPaymentsList_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sentpaymentsDgv)).EndInit();
            this.settingsCMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox searchTxt;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button newBtn;
        private System.Windows.Forms.Label labla;
        private System.Windows.Forms.Label paymentsCountLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView sentpaymentsDgv;
        private Guna.UI2.WinForms.Guna2MessageDialog confirmMessageDialog;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip settingsCMS;
        private System.Windows.Forms.ToolStripMenuItem generateRecieptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyPaymentDataToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox viewFilterCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}