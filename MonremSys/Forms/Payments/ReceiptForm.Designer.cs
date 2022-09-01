
namespace MonremSys.Forms.Payments
{
    partial class ReceiptForm
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
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tileBar = new Guna.UI2.WinForms.Guna2Panel();
            this.RemDetails = new System.Windows.Forms.Label();
            this.copyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.okBtn = new Guna.UI2.WinForms.Guna2Button();
            this.formShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.formDrageControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.settingCMS = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.copyImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reciptPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tileBar.SuspendLayout();
            this.settingCMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reciptPB)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.closeBtn.HoverState.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(534, 1);
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
            this.tileBar.Size = new System.Drawing.Size(594, 39);
            this.tileBar.TabIndex = 29;
            // 
            // RemDetails
            // 
            this.RemDetails.AutoSize = true;
            this.RemDetails.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemDetails.Location = new System.Drawing.Point(7, 7);
            this.RemDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RemDetails.Name = "RemDetails";
            this.RemDetails.Size = new System.Drawing.Size(155, 25);
            this.RemDetails.TabIndex = 13;
            this.RemDetails.Text = "Remittance Receipt";
            // 
            // copyBtn
            // 
            this.copyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.copyBtn.BorderRadius = 5;
            this.copyBtn.BorderThickness = 1;
            this.copyBtn.FillColor = System.Drawing.Color.Transparent;
            this.copyBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.copyBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.copyBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.copyBtn.Location = new System.Drawing.Point(299, 663);
            this.copyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(135, 37);
            this.copyBtn.TabIndex = 31;
            this.copyBtn.Text = "Copy As Txt";
            this.copyBtn.Click += new System.EventHandler(this.CopyReceiptText);
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
            this.okBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.okBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.okBtn.Location = new System.Drawing.Point(454, 663);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(112, 37);
            this.okBtn.TabIndex = 30;
            this.okBtn.Text = "OK";
            // 
            // formShadow
            // 
            this.formShadow.TargetForm = this;
            // 
            // formDrageControl
            // 
            this.formDrageControl.DockIndicatorTransparencyValue = 0.6D;
            this.formDrageControl.TargetControl = this.tileBar;
            this.formDrageControl.UseTransparentDrag = true;
            // 
            // settingCMS
            // 
            this.settingCMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.settingCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyImageToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.settingCMS.Name = "settingCMS";
            this.settingCMS.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.settingCMS.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.settingCMS.RenderStyle.ColorTable = null;
            this.settingCMS.RenderStyle.RoundedEdges = true;
            this.settingCMS.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.settingCMS.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.settingCMS.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.settingCMS.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.settingCMS.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.settingCMS.Size = new System.Drawing.Size(173, 60);
            // 
            // copyImageToolStripMenuItem
            // 
            this.copyImageToolStripMenuItem.Name = "copyImageToolStripMenuItem";
            this.copyImageToolStripMenuItem.Size = new System.Drawing.Size(172, 28);
            this.copyImageToolStripMenuItem.Text = "Copy Image";
            this.copyImageToolStripMenuItem.Click += new System.EventHandler(this.CopyReciptImage);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(172, 28);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveReceiptImage);
            // 
            // reciptPB
            // 
            this.reciptPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reciptPB.BackColor = System.Drawing.Color.Transparent;
            this.reciptPB.BorderRadius = 2;
            this.reciptPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reciptPB.ImageRotate = 0F;
            this.reciptPB.Location = new System.Drawing.Point(21, 72);
            this.reciptPB.Name = "reciptPB";
            this.reciptPB.Size = new System.Drawing.Size(545, 576);
            this.reciptPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reciptPB.TabIndex = 32;
            this.reciptPB.TabStop = false;
            this.reciptPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reciptPB_MouseClick);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 716);
            this.Controls.Add(this.tileBar);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.reciptPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.tileBar.ResumeLayout(false);
            this.tileBar.PerformLayout();
            this.settingCMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reciptPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2Panel tileBar;
        private System.Windows.Forms.Label RemDetails;
        private Guna.UI2.WinForms.Guna2Button copyBtn;
        private Guna.UI2.WinForms.Guna2Button okBtn;
        private Guna.UI2.WinForms.Guna2ShadowForm formShadow;
        private Guna.UI2.WinForms.Guna2PictureBox reciptPB;
        private Guna.UI2.WinForms.Guna2DragControl formDrageControl;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip settingCMS;
        private System.Windows.Forms.ToolStripMenuItem copyImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}