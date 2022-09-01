
namespace MonremSys.Forms.Payments
{
    partial class PaymentManageForm
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
            this.CurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountNum = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rateNum = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.commissionNum = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.currencyCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tileBar = new Guna.UI2.WinForms.Guna2Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.formShadowControl = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNum)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionNum)).BeginInit();
            this.tileBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.BorderThickness = 2;
            this.descriptionTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTxt.DefaultText = "";
            this.descriptionTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.descriptionTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.descriptionTxt.ForeColor = System.Drawing.Color.Black;
            this.descriptionTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.descriptionTxt.Location = new System.Drawing.Point(18, 53);
            this.descriptionTxt.MaxLength = 120;
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.PasswordChar = '\0';
            this.descriptionTxt.PlaceholderText = "Approve (Amount) for (Receiver) as  (Reason)";
            this.descriptionTxt.SelectedText = "";
            this.descriptionTxt.Size = new System.Drawing.Size(370, 153);
            this.descriptionTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.descriptionTxt.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Description";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.descriptionTxt);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(27, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 220);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other Info";
            // 
            // amountNum
            // 
            this.amountNum.BackColor = System.Drawing.Color.Transparent;
            this.amountNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountNum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountNum.ForeColor = System.Drawing.Color.Black;
            this.amountNum.Location = new System.Drawing.Point(12, 58);
            this.amountNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amountNum.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.amountNum.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountNum.Name = "amountNum";
            this.amountNum.Size = new System.Drawing.Size(182, 45);
            this.amountNum.TabIndex = 39;
            this.amountNum.ThousandsSeparator = true;
            this.amountNum.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.amountNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.amountNum);
            this.groupBox3.Controls.Add(this.rateNum);
            this.groupBox3.Controls.Add(this.commissionNum);
            this.groupBox3.Controls.Add(this.currencyCombo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(27, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 220);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount";
            // 
            // rateNum
            // 
            this.rateNum.BackColor = System.Drawing.Color.Transparent;
            this.rateNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rateNum.DecimalPlaces = 2;
            this.rateNum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateNum.ForeColor = System.Drawing.Color.Black;
            this.rateNum.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.rateNum.Location = new System.Drawing.Point(12, 135);
            this.rateNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rateNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.rateNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rateNum.Name = "rateNum";
            this.rateNum.Size = new System.Drawing.Size(182, 45);
            this.rateNum.TabIndex = 38;
            this.rateNum.ThousandsSeparator = true;
            this.rateNum.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.rateNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // commissionNum
            // 
            this.commissionNum.BackColor = System.Drawing.Color.Transparent;
            this.commissionNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commissionNum.DecimalPlaces = 2;
            this.commissionNum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commissionNum.ForeColor = System.Drawing.Color.Black;
            this.commissionNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.commissionNum.Location = new System.Drawing.Point(203, 135);
            this.commissionNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.commissionNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.commissionNum.Name = "commissionNum";
            this.commissionNum.Size = new System.Drawing.Size(182, 45);
            this.commissionNum.TabIndex = 37;
            this.commissionNum.ThousandsSeparator = true;
            this.commissionNum.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            // 
            // currencyCombo
            // 
            this.currencyCombo.BackColor = System.Drawing.Color.Transparent;
            this.currencyCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.currencyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.currencyCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.currencyCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.currencyCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.currencyCombo.ItemHeight = 30;
            this.currencyCombo.Items.AddRange(new object[] {
            "USD ($)",
            "SYP",
            "EUR (€)",
            "LBP",
            "ETB",
            "CNY"});
            this.currencyCombo.Location = new System.Drawing.Point(203, 60);
            this.currencyCombo.Name = "currencyCombo";
            this.currencyCombo.Size = new System.Drawing.Size(182, 36);
            this.currencyCombo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.currencyCombo.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Comission";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Currency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Amount";
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
            this.tileBar.Size = new System.Drawing.Size(455, 39);
            this.tileBar.TabIndex = 37;
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formTitle.Location = new System.Drawing.Point(7, 7);
            this.formTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(124, 25);
            this.formTitle.TabIndex = 13;
            this.formTitle.Text = "Approve Money";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.closeBtn.HoverState.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(395, 1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(60, 36);
            this.closeBtn.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.saveBtn.BorderRadius = 5;
            this.saveBtn.BorderThickness = 1;
            this.saveBtn.FillColor = System.Drawing.Color.Transparent;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.saveBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.saveBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(316, 536);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 37);
            this.saveBtn.TabIndex = 38;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formDragControl
            // 
            this.formDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.formDragControl.TargetControl = this.tileBar;
            this.formDragControl.UseTransparentDrag = true;
            // 
            // formShadowControl
            // 
            this.formShadowControl.TargetForm = this;
            // 
            // PaymentManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 604);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tileBar);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentManageForm";
            this.Text = "PaymentManageForm";
            this.Load += new System.EventHandler(this.OnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionNum)).EndInit();
            this.tileBar.ResumeLayout(false);
            this.tileBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.BindingSource CurrencyBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.BindingSource PaymentBindingSource;
        private Guna.UI2.WinForms.Guna2NumericUpDown amountNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2NumericUpDown rateNum;
        private Guna.UI2.WinForms.Guna2NumericUpDown commissionNum;
        private Guna.UI2.WinForms.Guna2ComboBox currencyCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel tileBar;
        private System.Windows.Forms.Label formTitle;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private Guna.UI2.WinForms.Guna2ShadowForm formShadowControl;
    }
}