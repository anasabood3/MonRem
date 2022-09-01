
namespace MonremSys.Forms.Remittances
{
    partial class PayForm
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
            this.Formtitle = new System.Windows.Forms.Label();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tileBar = new Guna.UI2.WinForms.Guna2Panel();
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.payInfoTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.attachBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.okBtn = new Guna.UI2.WinForms.Guna2Button();
            this.attachDialog = new System.Windows.Forms.OpenFileDialog();
            this.pathTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.cameraBtn = new Guna.UI2.WinForms.Guna2Button();
            this.attachmentPb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warningdialoge = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.tileBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Formtitle
            // 
            this.Formtitle.AutoSize = true;
            this.Formtitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formtitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Formtitle.Location = new System.Drawing.Point(7, 7);
            this.Formtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Formtitle.Name = "Formtitle";
            this.Formtitle.Size = new System.Drawing.Size(125, 25);
            this.Formtitle.TabIndex = 13;
            this.Formtitle.Text = "Pay Remittance";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.closeBtn.HoverState.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(522, 1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(60, 36);
            this.closeBtn.TabIndex = 0;
            // 
            // tileBar
            // 
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.tileBar.Controls.Add(this.Formtitle);
            this.tileBar.Controls.Add(this.closeBtn);
            this.tileBar.CustomBorderColor = System.Drawing.Color.Silver;
            this.tileBar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4);
            this.tileBar.Name = "tileBar";
            this.tileBar.Size = new System.Drawing.Size(582, 39);
            this.tileBar.TabIndex = 18;
            // 
            // formDragControl
            // 
            this.formDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.formDragControl.TargetControl = this.tileBar;
            this.formDragControl.UseTransparentDrag = true;
            // 
            // payInfoTxt
            // 
            this.payInfoTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.payInfoTxt.DefaultText = "";
            this.payInfoTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.payInfoTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.payInfoTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.payInfoTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.payInfoTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.payInfoTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.payInfoTxt.ForeColor = System.Drawing.Color.Black;
            this.payInfoTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.payInfoTxt.Location = new System.Drawing.Point(12, 566);
            this.payInfoTxt.MaxLength = 120;
            this.payInfoTxt.Multiline = true;
            this.payInfoTxt.Name = "payInfoTxt";
            this.payInfoTxt.PasswordChar = '\0';
            this.payInfoTxt.PlaceholderText = "add any inforamtion that can prove payment operaiton success  ...";
            this.payInfoTxt.SelectedText = "";
            this.payInfoTxt.Size = new System.Drawing.Size(558, 96);
            this.payInfoTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.payInfoTxt.TabIndex = 30;
            // 
            // attachBtn
            // 
            this.attachBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.attachBtn.BorderColor = System.Drawing.Color.Gray;
            this.attachBtn.BorderThickness = 1;
            this.attachBtn.FillColor = System.Drawing.Color.Gainsboro;
            this.attachBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.attachBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.attachBtn.Location = new System.Drawing.Point(437, 480);
            this.attachBtn.Margin = new System.Windows.Forms.Padding(4);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(132, 34);
            this.attachBtn.TabIndex = 31;
            this.attachBtn.Text = "Upload Image";
            this.attachBtn.Click += new System.EventHandler(this.UploadAttachment);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Inforamtion of Receiver Customer:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.cancelBtn.BorderRadius = 5;
            this.cancelBtn.BorderThickness = 1;
            this.cancelBtn.FillColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.cancelBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.cancelBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(338, 689);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 37);
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.Cancel);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.okBtn.BorderRadius = 5;
            this.okBtn.BorderThickness = 1;
            this.okBtn.FillColor = System.Drawing.Color.Transparent;
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.okBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.okBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.okBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.okBtn.Location = new System.Drawing.Point(458, 689);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(112, 37);
            this.okBtn.TabIndex = 34;
            this.okBtn.Text = "Pay";
            this.okBtn.Click += new System.EventHandler(this.PayRemittance);
            // 
            // attachDialog
            // 
            this.attachDialog.FileName = "openFileDialog1";
            this.attachDialog.Filter = "Images|*.png;*.bmp;*.jpg";
            this.attachDialog.InitialDirectory = ".";
            // 
            // pathTxt
            // 
            this.pathTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathTxt.DefaultText = "";
            this.pathTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pathTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pathTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pathTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pathTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pathTxt.Location = new System.Drawing.Point(12, 431);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.PasswordChar = '\0';
            this.pathTxt.PlaceholderText = "";
            this.pathTxt.SelectedText = "";
            this.pathTxt.Size = new System.Drawing.Size(557, 36);
            this.pathTxt.TabIndex = 35;
            // 
            // cameraBtn
            // 
            this.cameraBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraBtn.BorderColor = System.Drawing.Color.Gray;
            this.cameraBtn.BorderThickness = 1;
            this.cameraBtn.Enabled = false;
            this.cameraBtn.FillColor = System.Drawing.Color.Gainsboro;
            this.cameraBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.cameraBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cameraBtn.Image = global::MonremSys.Properties.Resources.icons8_camera_32;
            this.cameraBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.cameraBtn.Location = new System.Drawing.Point(286, 480);
            this.cameraBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cameraBtn.Name = "cameraBtn";
            this.cameraBtn.Size = new System.Drawing.Size(132, 34);
            this.cameraBtn.TabIndex = 36;
            // 
            // attachmentPb
            // 
            this.attachmentPb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentPb.BackColor = System.Drawing.Color.Transparent;
            this.attachmentPb.BorderRadius = 2;
            this.attachmentPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attachmentPb.ErrorImage = global::MonremSys.Properties.Resources.webcolours_unknown;
            this.attachmentPb.Image = global::MonremSys.Properties.Resources.webcolours_unknown;
            this.attachmentPb.ImageLocation = "";
            this.attachmentPb.ImageRotate = 0F;
            this.attachmentPb.Location = new System.Drawing.Point(12, 61);
            this.attachmentPb.Name = "attachmentPb";
            this.attachmentPb.Size = new System.Drawing.Size(558, 363);
            this.attachmentPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.attachmentPb.TabIndex = 29;
            this.attachmentPb.TabStop = false;
            // 
            // warningdialoge
            // 
            this.warningdialoge.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel;
            this.warningdialoge.Caption = "Be Carefull";
            this.warningdialoge.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.warningdialoge.Parent = null;
            this.warningdialoge.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.warningdialoge.Text = null;
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 745);
            this.Controls.Add(this.cameraBtn);
            this.Controls.Add(this.pathTxt);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.payInfoTxt);
            this.Controls.Add(this.attachmentPb);
            this.Controls.Add(this.tileBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayForm";
            this.Text = "PayForm";
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.tileBar.ResumeLayout(false);
            this.tileBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Formtitle;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2Panel tileBar;
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private Guna.UI2.WinForms.Guna2PictureBox attachmentPb;
        private Guna.UI2.WinForms.Guna2TextBox payInfoTxt;
        private Guna.UI2.WinForms.Guna2Button attachBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button okBtn;
        private System.Windows.Forms.OpenFileDialog attachDialog;
        internal System.Windows.Forms.BindingSource PayBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox pathTxt;
        private Guna.UI2.WinForms.Guna2Button cameraBtn;
        private Guna.UI2.WinForms.Guna2MessageDialog warningdialoge;
    }
}