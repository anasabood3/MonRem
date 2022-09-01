
namespace MonremSys.Forms.Settings
{
    partial class DestinationManageForm
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
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.tileBar = new Guna.UI2.WinForms.Guna2Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.destinationStateCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.destinationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tileBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.saveBtn.Location = new System.Drawing.Point(282, 299);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 37);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // destinationNameTxt
            // 
            this.destinationNameTxt.BorderThickness = 2;
            this.destinationNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.destinationNameTxt.DefaultText = "";
            this.destinationNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.destinationNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.destinationNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.destinationNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.destinationNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.destinationNameTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.destinationNameTxt.ForeColor = System.Drawing.Color.Black;
            this.destinationNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.destinationNameTxt.IconRight = global::MonremSys.Properties.Resources.next_location_32px;
            this.destinationNameTxt.Location = new System.Drawing.Point(22, 99);
            this.destinationNameTxt.Name = "destinationNameTxt";
            this.destinationNameTxt.PasswordChar = '\0';
            this.destinationNameTxt.PlaceholderText = "Add the right name of destination";
            this.destinationNameTxt.SelectedText = "";
            this.destinationNameTxt.Size = new System.Drawing.Size(373, 36);
            this.destinationNameTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.destinationNameTxt.TabIndex = 15;
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
            this.tileBar.Size = new System.Drawing.Size(407, 39);
            this.tileBar.TabIndex = 14;
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formTitle.Location = new System.Drawing.Point(7, 7);
            this.formTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(163, 25);
            this.formTitle.TabIndex = 13;
            this.formTitle.Text = "Add New Destination";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.closeBtn.HoverState.IconColor = System.Drawing.Color.White;
            this.closeBtn.IconColor = System.Drawing.Color.Gray;
            this.closeBtn.Location = new System.Drawing.Point(347, 1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(60, 36);
            this.closeBtn.TabIndex = 0;
            // 
            // destinationStateCheckBox
            // 
            this.destinationStateCheckBox.AutoSize = true;
            this.destinationStateCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.destinationStateCheckBox.CheckedState.BorderRadius = 0;
            this.destinationStateCheckBox.CheckedState.BorderThickness = 0;
            this.destinationStateCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.destinationStateCheckBox.Location = new System.Drawing.Point(25, 200);
            this.destinationStateCheckBox.Name = "destinationStateCheckBox";
            this.destinationStateCheckBox.Size = new System.Drawing.Size(89, 20);
            this.destinationStateCheckBox.TabIndex = 18;
            this.destinationStateCheckBox.Text = "Is Active ?";
            this.destinationStateCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.destinationStateCheckBox.UncheckedState.BorderRadius = 0;
            this.destinationStateCheckBox.UncheckedState.BorderThickness = 0;
            this.destinationStateCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.tileBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // DestinationManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 358);
            this.Controls.Add(this.destinationStateCheckBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destinationNameTxt);
            this.Controls.Add(this.tileBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DestinationManageForm";
            this.Text = "DestinationManageForm";
            this.Load += new System.EventHandler(this.DestinationManageForm_Load);
            this.tileBar.ResumeLayout(false);
            this.tileBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox destinationNameTxt;
        private Guna.UI2.WinForms.Guna2Panel tileBar;
        private System.Windows.Forms.Label formTitle;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2CheckBox destinationStateCheckBox;
        public System.Windows.Forms.BindingSource destinationBindingSource;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}