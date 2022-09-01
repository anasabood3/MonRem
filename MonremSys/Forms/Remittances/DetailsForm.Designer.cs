
namespace MonremSys.Forms.Remittances
{
    partial class DetailsForm
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
            this.paymentDetils = new System.Windows.Forms.Label();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.copyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.receiverLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.none = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.detailsLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tileBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.tileBar.Controls.Add(this.paymentDetils);
            this.tileBar.Controls.Add(this.closeBtn);
            this.tileBar.CustomBorderColor = System.Drawing.Color.Silver;
            this.tileBar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4);
            this.tileBar.Name = "tileBar";
            this.tileBar.Size = new System.Drawing.Size(540, 39);
            this.tileBar.TabIndex = 16;
            // 
            // paymentDetils
            // 
            this.paymentDetils.AutoSize = true;
            this.paymentDetils.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDetils.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paymentDetils.Location = new System.Drawing.Point(7, 7);
            this.paymentDetils.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentDetils.Name = "paymentDetils";
            this.paymentDetils.Size = new System.Drawing.Size(129, 25);
            this.paymentDetils.TabIndex = 13;
            this.paymentDetils.Text = "Payment Details";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.closeBtn.HoverState.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(480, 1);
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
            this.saveBtn.Location = new System.Drawing.Point(406, 630);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 37);
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Text = "OK";
            this.saveBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // copyBtn
            // 
            this.copyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.copyBtn.BorderRadius = 5;
            this.copyBtn.BorderThickness = 1;
            this.copyBtn.FillColor = System.Drawing.Color.Transparent;
            this.copyBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.copyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.copyBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.copyBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.copyBtn.Location = new System.Drawing.Point(272, 630);
            this.copyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(112, 37);
            this.copyBtn.TabIndex = 26;
            this.copyBtn.Text = "Copy";
            this.copyBtn.Click += new System.EventHandler(this.CopyFullDetails);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorColor = System.Drawing.Color.Black;
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.tileBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // receiverLbl
            // 
            this.receiverLbl.BackColor = System.Drawing.Color.Transparent;
            this.receiverLbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiverLbl.Location = new System.Drawing.Point(25, 65);
            this.receiverLbl.Name = "receiverLbl";
            this.receiverLbl.Size = new System.Drawing.Size(73, 23);
            this.receiverLbl.TabIndex = 0;
            this.receiverLbl.Text = "Receiver:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(25, 122);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(60, 23);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Sender:";
            // 
            // none
            // 
            this.none.BackColor = System.Drawing.Color.Transparent;
            this.none.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.none.Location = new System.Drawing.Point(25, 350);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(38, 23);
            this.none.TabIndex = 3;
            this.none.Text = "Rate";
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.Color.Transparent;
            this.lbl7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(25, 407);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(89, 23);
            this.lbl7.TabIndex = 5;
            this.lbl7.Text = "Created At:";
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(25, 293);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(98, 23);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Commission:";
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(25, 236);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(67, 23);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Amount:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(25, 179);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(94, 23);
            this.guna2HtmlLabel8.TabIndex = 8;
            this.guna2HtmlLabel8.Text = "Destination:";
            // 
            // detailsLv
            // 
            this.detailsLv.BackColor = System.Drawing.SystemColors.Window;
            this.detailsLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.detailsLv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLv.FullRowSelect = true;
            this.detailsLv.GridLines = true;
            this.detailsLv.HideSelection = false;
            this.detailsLv.LabelWrap = false;
            this.detailsLv.Location = new System.Drawing.Point(30, 59);
            this.detailsLv.Name = "detailsLv";
            this.detailsLv.ShowGroups = false;
            this.detailsLv.Size = new System.Drawing.Size(483, 520);
            this.detailsLv.TabIndex = 27;
            this.detailsLv.UseCompatibleStateImageBehavior = false;
            this.detailsLv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.Width = 300;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 680);
            this.Controls.Add(this.detailsLv);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tileBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.tileBar.ResumeLayout(false);
            this.tileBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel tileBar;
        private System.Windows.Forms.Label paymentDetils;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2Button copyBtn;
        internal System.Windows.Forms.BindingSource detailsBindingSource;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel receiverLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel none;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl7;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private System.Windows.Forms.ListView detailsLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}