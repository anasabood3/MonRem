
namespace MonremSys.Forms.Customers
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
            this.detailsLV = new System.Windows.Forms.ListView();
            this.identiefier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.okBtn = new Guna.UI2.WinForms.Guna2Button();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tileBar = new Guna.UI2.WinForms.Guna2Panel();
            this.RemDetails = new System.Windows.Forms.Label();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.copyDataBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tileBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsLV
            // 
            this.detailsLV.AutoArrange = false;
            this.detailsLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.identiefier,
            this.data});
            this.detailsLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLV.FullRowSelect = true;
            this.detailsLV.GridLines = true;
            this.detailsLV.HideSelection = false;
            this.detailsLV.Location = new System.Drawing.Point(25, 55);
            this.detailsLV.Name = "detailsLV";
            this.detailsLV.Size = new System.Drawing.Size(394, 406);
            this.detailsLV.TabIndex = 0;
            this.detailsLV.UseCompatibleStateImageBehavior = false;
            this.detailsLV.View = System.Windows.Forms.View.Details;
            // 
            // identiefier
            // 
            this.identiefier.Text = "#";
            this.identiefier.Width = 125;
            // 
            // data
            // 
            this.data.Text = "Data";
            this.data.Width = 300;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.okBtn.BorderRadius = 5;
            this.okBtn.BorderThickness = 1;
            this.okBtn.FillColor = System.Drawing.Color.Transparent;
            this.okBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.okBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.okBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.okBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.okBtn.Location = new System.Drawing.Point(307, 491);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(112, 37);
            this.okBtn.TabIndex = 14;
            this.okBtn.Text = "OK";
            this.okBtn.Click += new System.EventHandler(this.Ok);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.closeBtn.HoverState.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconColor = System.Drawing.Color.Gray;
            this.closeBtn.Location = new System.Drawing.Point(387, 1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(60, 36);
            this.closeBtn.TabIndex = 0;
            // 
            // tileBar
            // 
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.tileBar.Controls.Add(this.RemDetails);
            this.tileBar.Controls.Add(this.closeBtn);
            this.tileBar.CustomBorderColor = System.Drawing.Color.Silver;
            this.tileBar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4);
            this.tileBar.Name = "tileBar";
            this.tileBar.Size = new System.Drawing.Size(447, 39);
            this.tileBar.TabIndex = 17;
            // 
            // RemDetails
            // 
            this.RemDetails.AutoSize = true;
            this.RemDetails.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemDetails.Location = new System.Drawing.Point(7, 7);
            this.RemDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RemDetails.Name = "RemDetails";
            this.RemDetails.Size = new System.Drawing.Size(136, 25);
            this.RemDetails.TabIndex = 13;
            this.RemDetails.Text = "Customer Details";
            // 
            // dragControl
            // 
            this.dragControl.DockIndicatorTransparencyValue = 0.6D;
            this.dragControl.TargetControl = this.tileBar;
            this.dragControl.UseTransparentDrag = true;
            // 
            // copyDataBtn
            // 
            this.copyDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyDataBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.copyDataBtn.BorderRadius = 5;
            this.copyDataBtn.BorderThickness = 1;
            this.copyDataBtn.FillColor = System.Drawing.Color.Transparent;
            this.copyDataBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyDataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.copyDataBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.copyDataBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.copyDataBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.copyDataBtn.Location = new System.Drawing.Point(166, 491);
            this.copyDataBtn.Margin = new System.Windows.Forms.Padding(4);
            this.copyDataBtn.Name = "copyDataBtn";
            this.copyDataBtn.Size = new System.Drawing.Size(124, 37);
            this.copyDataBtn.TabIndex = 18;
            this.copyDataBtn.Text = "Copy data";
            this.copyDataBtn.Click += new System.EventHandler(this.CopyFullDetails);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 541);
            this.Controls.Add(this.copyDataBtn);
            this.Controls.Add(this.tileBar);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.detailsLV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.tileBar.ResumeLayout(false);
            this.tileBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView detailsLV;
        private System.Windows.Forms.ColumnHeader identiefier;
        private System.Windows.Forms.ColumnHeader data;
        private Guna.UI2.WinForms.Guna2Button okBtn;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2Panel tileBar;
        private System.Windows.Forms.Label RemDetails;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        internal System.Windows.Forms.BindingSource detailsBindingSource;
        private Guna.UI2.WinForms.Guna2Button copyDataBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}