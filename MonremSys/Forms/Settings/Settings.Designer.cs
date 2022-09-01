
namespace MonremSys.Forms.Settings
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.destinationListCMS = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRemittanceDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmMessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2Panel_top = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2TabControl2 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.companyEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.companyPhNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.companyAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.companyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newDestinationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.destinationsDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destionation_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.added_at_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.safetyLevelAmout = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.destinationListCMS.SuspendLayout();
            this.guna2Panel_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2TabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsDgv)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.safetyLevelAmout)).BeginInit();
            this.SuspendLayout();
            // 
            // destinationListCMS
            // 
            this.destinationListCMS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationListCMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.destinationListCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.copyRemittanceDataToolStripMenuItem});
            this.destinationListCMS.Name = "guna2ContextMenuStrip1";
            this.destinationListCMS.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.destinationListCMS.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.destinationListCMS.RenderStyle.ColorTable = null;
            this.destinationListCMS.RenderStyle.RoundedEdges = true;
            this.destinationListCMS.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.destinationListCMS.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.destinationListCMS.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.destinationListCMS.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.destinationListCMS.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.destinationListCMS.Size = new System.Drawing.Size(143, 100);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::MonremSys.Properties.Resources.edit_row_32px;
            this.editToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.ShowShortcutKeys = false;
            this.editToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
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
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.deleteToolStripMenuItem.Text = "  Delete";
            this.deleteToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.deleteToolStripMenuItem.ToolTipText = "Delete a Remittance (Ctrl + D)";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteItem);
            // 
            // copyRemittanceDataToolStripMenuItem
            // 
            this.copyRemittanceDataToolStripMenuItem.Image = global::MonremSys.Properties.Resources.copy_32px;
            this.copyRemittanceDataToolStripMenuItem.Name = "copyRemittanceDataToolStripMenuItem";
            this.copyRemittanceDataToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.copyRemittanceDataToolStripMenuItem.Text = "Copy";
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
            // guna2Panel_top
            // 
            this.guna2Panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.guna2Panel_top.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.guna2Panel_top.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel_top.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.guna2Panel_top.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel_top.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel_top.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel_top.Name = "guna2Panel_top";
            this.guna2Panel_top.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.guna2Panel_top.Size = new System.Drawing.Size(440, 40);
            this.guna2Panel_top.TabIndex = 42;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.Location = new System.Drawing.Point(388, 1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(52, 36);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 647);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 45);
            this.panel1.TabIndex = 38;
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
            this.saveBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.saveBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.saveBtn.HoverState.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(327, 4);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(98, 37);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.SaveSettings);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.guna2TabControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 695);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // guna2TabControl2
            // 
            this.guna2TabControl2.Controls.Add(this.tabPage4);
            this.guna2TabControl2.Controls.Add(this.tabPage5);
            this.guna2TabControl2.Controls.Add(this.tabPage1);
            this.guna2TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl2.ItemSize = new System.Drawing.Size(120, 40);
            this.guna2TabControl2.Location = new System.Drawing.Point(3, 3);
            this.guna2TabControl2.Name = "guna2TabControl2";
            this.guna2TabControl2.SelectedIndex = 0;
            this.guna2TabControl2.Size = new System.Drawing.Size(434, 638);
            this.guna2TabControl2.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl2.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl2.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl2.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl2.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl2.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl2.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl2.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl2.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl2.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl2.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl2.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl2.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl2.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl2.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl2.TabButtonSize = new System.Drawing.Size(120, 40);
            this.guna2TabControl2.TabIndex = 40;
            this.guna2TabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(426, 590);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Company Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.companyEmail);
            this.groupBox1.Controls.Add(this.companyPhNumber);
            this.groupBox1.Controls.Add(this.companyAddress);
            this.groupBox1.Controls.Add(this.companyName);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Info";
            // 
            // companyEmail
            // 
            this.companyEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companyEmail.AutoRoundedCorners = true;
            this.companyEmail.BorderRadius = 20;
            this.companyEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyEmail.DefaultText = "";
            this.companyEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.companyEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.companyEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companyEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companyEmail.FillColor = System.Drawing.Color.Snow;
            this.companyEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.companyEmail.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyEmail.ForeColor = System.Drawing.Color.Black;
            this.companyEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.companyEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("companyEmail.IconLeft")));
            this.companyEmail.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.companyEmail.IconLeftSize = new System.Drawing.Size(15, 15);
            this.companyEmail.Location = new System.Drawing.Point(28, 252);
            this.companyEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyEmail.Name = "companyEmail";
            this.companyEmail.PasswordChar = '\0';
            this.companyEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.companyEmail.PlaceholderText = "E-mail";
            this.companyEmail.SelectedText = "";
            this.companyEmail.Size = new System.Drawing.Size(351, 43);
            this.companyEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.companyEmail.TabIndex = 11;
            this.companyEmail.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // companyPhNumber
            // 
            this.companyPhNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companyPhNumber.AutoRoundedCorners = true;
            this.companyPhNumber.BorderRadius = 20;
            this.companyPhNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyPhNumber.DefaultText = "";
            this.companyPhNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.companyPhNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.companyPhNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companyPhNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companyPhNumber.FillColor = System.Drawing.Color.Snow;
            this.companyPhNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.companyPhNumber.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyPhNumber.ForeColor = System.Drawing.Color.Black;
            this.companyPhNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.companyPhNumber.IconLeft = ((System.Drawing.Image)(resources.GetObject("companyPhNumber.IconLeft")));
            this.companyPhNumber.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.companyPhNumber.IconLeftSize = new System.Drawing.Size(15, 15);
            this.companyPhNumber.Location = new System.Drawing.Point(28, 184);
            this.companyPhNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyPhNumber.Name = "companyPhNumber";
            this.companyPhNumber.PasswordChar = '\0';
            this.companyPhNumber.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.companyPhNumber.PlaceholderText = "Phone Number";
            this.companyPhNumber.SelectedText = "";
            this.companyPhNumber.Size = new System.Drawing.Size(351, 43);
            this.companyPhNumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.companyPhNumber.TabIndex = 10;
            this.companyPhNumber.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // companyAddress
            // 
            this.companyAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companyAddress.AutoRoundedCorners = true;
            this.companyAddress.BorderRadius = 20;
            this.companyAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyAddress.DefaultText = "";
            this.companyAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.companyAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.companyAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companyAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companyAddress.FillColor = System.Drawing.Color.Snow;
            this.companyAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.companyAddress.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyAddress.ForeColor = System.Drawing.Color.Black;
            this.companyAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.companyAddress.IconLeft = ((System.Drawing.Image)(resources.GetObject("companyAddress.IconLeft")));
            this.companyAddress.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.companyAddress.IconLeftSize = new System.Drawing.Size(15, 15);
            this.companyAddress.Location = new System.Drawing.Point(28, 116);
            this.companyAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyAddress.Name = "companyAddress";
            this.companyAddress.PasswordChar = '\0';
            this.companyAddress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.companyAddress.PlaceholderText = "Address";
            this.companyAddress.SelectedText = "";
            this.companyAddress.Size = new System.Drawing.Size(351, 43);
            this.companyAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.companyAddress.TabIndex = 9;
            this.companyAddress.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // companyName
            // 
            this.companyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companyName.AutoRoundedCorners = true;
            this.companyName.BorderRadius = 20;
            this.companyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyName.DefaultText = "";
            this.companyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.companyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.companyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companyName.FillColor = System.Drawing.Color.Snow;
            this.companyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.companyName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.ForeColor = System.Drawing.Color.Black;
            this.companyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.companyName.IconLeft = ((System.Drawing.Image)(resources.GetObject("companyName.IconLeft")));
            this.companyName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.companyName.IconLeftSize = new System.Drawing.Size(15, 15);
            this.companyName.Location = new System.Drawing.Point(28, 48);
            this.companyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyName.Name = "companyName";
            this.companyName.PasswordChar = '\0';
            this.companyName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.companyName.PlaceholderText = "Company Name";
            this.companyName.SelectedText = "";
            this.companyName.Size = new System.Drawing.Size(351, 43);
            this.companyName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.companyName.TabIndex = 8;
            this.companyName.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.Controls.Add(this.panel2);
            this.tabPage5.Controls.Add(this.destinationsDgv);
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(426, 590);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Destenations";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.newDestinationBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 49);
            this.panel2.TabIndex = 42;
            // 
            // newDestinationBtn
            // 
            this.newDestinationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newDestinationBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.newDestinationBtn.BorderRadius = 5;
            this.newDestinationBtn.FillColor = System.Drawing.Color.Transparent;
            this.newDestinationBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDestinationBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.newDestinationBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.newDestinationBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.newDestinationBtn.HoverState.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDestinationBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.newDestinationBtn.Image = global::MonremSys.Properties.Resources.add_32px;
            this.newDestinationBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.newDestinationBtn.Location = new System.Drawing.Point(371, 5);
            this.newDestinationBtn.Margin = new System.Windows.Forms.Padding(4);
            this.newDestinationBtn.Name = "newDestinationBtn";
            this.newDestinationBtn.Size = new System.Drawing.Size(45, 37);
            this.newDestinationBtn.TabIndex = 6;
            this.newDestinationBtn.Click += new System.EventHandler(this.AddDestination);
            // 
            // destinationsDgv
            // 
            this.destinationsDgv.AllowUserToAddRows = false;
            this.destinationsDgv.AllowUserToDeleteRows = false;
            this.destinationsDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.destinationsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.destinationsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.destinationsDgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.destinationsDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.destinationsDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.destinationsDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.destinationsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.destinationsDgv.ColumnHeadersHeight = 40;
            this.destinationsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.destinationsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_,
            this.destionation_name,
            this.state,
            this.added_at_});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.destinationsDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.destinationsDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationsDgv.EnableHeadersVisualStyles = false;
            this.destinationsDgv.GridColor = System.Drawing.Color.WhiteSmoke;
            this.destinationsDgv.Location = new System.Drawing.Point(3, 3);
            this.destinationsDgv.Name = "destinationsDgv";
            this.destinationsDgv.ReadOnly = true;
            this.destinationsDgv.RowHeadersVisible = false;
            this.destinationsDgv.RowHeadersWidth = 51;
            this.destinationsDgv.RowTemplate.Height = 24;
            this.destinationsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.destinationsDgv.Size = new System.Drawing.Size(420, 584);
            this.destinationsDgv.TabIndex = 41;
            this.destinationsDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.destinationsDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.destinationsDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.destinationsDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.destinationsDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.destinationsDgv.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.destinationsDgv.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.destinationsDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.destinationsDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.destinationsDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.destinationsDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.destinationsDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.destinationsDgv.ThemeStyle.HeaderStyle.Height = 40;
            this.destinationsDgv.ThemeStyle.ReadOnly = true;
            this.destinationsDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.destinationsDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.destinationsDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.destinationsDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.destinationsDgv.ThemeStyle.RowsStyle.Height = 24;
            this.destinationsDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.destinationsDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.destinationsDgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ViewSettingsCM);
            // 
            // id_
            // 
            this.id_.DataPropertyName = "id";
            this.id_.HeaderText = "#";
            this.id_.MinimumWidth = 6;
            this.id_.Name = "id_";
            this.id_.ReadOnly = true;
            this.id_.Visible = false;
            // 
            // destionation_name
            // 
            this.destionation_name.DataPropertyName = "name";
            this.destionation_name.FillWeight = 152.9745F;
            this.destionation_name.HeaderText = "Name";
            this.destionation_name.MinimumWidth = 6;
            this.destionation_name.Name = "destionation_name";
            this.destionation_name.ReadOnly = true;
            this.destionation_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // state
            // 
            this.state.DataPropertyName = "active";
            this.state.FillWeight = 71.43016F;
            this.state.HeaderText = "Active";
            this.state.MinimumWidth = 6;
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.state.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // added_at_
            // 
            this.added_at_.DataPropertyName = "added_at";
            this.added_at_.FillWeight = 157.0117F;
            this.added_at_.HeaderText = "Adding Date";
            this.added_at_.MinimumWidth = 6;
            this.added_at_.Name = "added_at_";
            this.added_at_.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 590);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Other";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.clearBtn);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(9, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 180);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Reset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "• Data can not be recovered";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "• All data will be removed";
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BorderColor = System.Drawing.Color.Red;
            this.clearBtn.BorderRadius = 5;
            this.clearBtn.BorderThickness = 1;
            this.clearBtn.FillColor = System.Drawing.Color.Transparent;
            this.clearBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Red;
            this.clearBtn.HoverState.BorderColor = System.Drawing.Color.Red;
            this.clearBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.clearBtn.HoverState.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(287, 133);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(98, 37);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.safetyLevelAmout);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(8, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 132);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saftey Limit Warning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "• Warn me when amount greater than:";
            // 
            // safetyLevelAmout
            // 
            this.safetyLevelAmout.BackColor = System.Drawing.Color.Transparent;
            this.safetyLevelAmout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.safetyLevelAmout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safetyLevelAmout.ForeColor = System.Drawing.Color.Black;
            this.safetyLevelAmout.Location = new System.Drawing.Point(233, 73);
            this.safetyLevelAmout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.safetyLevelAmout.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.safetyLevelAmout.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.safetyLevelAmout.Name = "safetyLevelAmout";
            this.safetyLevelAmout.Size = new System.Drawing.Size(159, 45);
            this.safetyLevelAmout.TabIndex = 40;
            this.safetyLevelAmout.ThousandsSeparator = true;
            this.safetyLevelAmout.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.safetyLevelAmout.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Other";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel_top;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(440, 735);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.guna2Panel_top);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.destinationListCMS.ResumeLayout(false);
            this.guna2Panel_top.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2TabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destinationsDgv)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.safetyLevelAmout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContextMenuStrip destinationListCMS;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyRemittanceDataToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2MessageDialog confirmMessageDialog;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel_top;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox companyEmail;
        private Guna.UI2.WinForms.Guna2TextBox companyPhNumber;
        private Guna.UI2.WinForms.Guna2TextBox companyAddress;
        private Guna.UI2.WinForms.Guna2TextBox companyName;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button newDestinationBtn;
        private Guna.UI2.WinForms.Guna2DataGridView destinationsDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn destionation_name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn added_at_;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown safetyLevelAmout;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}