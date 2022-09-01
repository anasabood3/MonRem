
using MonremSys.Forms.Box;
using MonremSys.Forms.Dashboard;
using MonremSys.Forms.Payments;
using MonremSys.Forms.Remittances;
using MonremSys.Forms.Settings;
using MonremSys.Forms.Help;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MonremSys
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            LoadChildForm(new ResponsiveDashboard());
        }

        //Menu Sliding Managment --------------------------------------

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Timers Control The Animation Effect

            if (MenuPanel.Width > 60)
            {
                MenuPanel.Width = 60;
                miniLogo.Visible = true;
            }
            else
            {
                MenuPanel.Width = 240;
                miniLogo.Visible = false;
            }
                
            
        }








        // Manage Container form size in runtime
        //METHOD TO RESIZE/RESIZE FORM RUNTIME
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //DRAW RECTANGLE / EXCLUDE PANEL CORNER 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.containerInnerFormPanel.Region = region;
            this.Invalidate();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void tileBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Load other Forms inside main form
        private void LoadChildForm(object form)
        {
            if (this.containerInnerFormPanel.Controls.Count > 0)
                this.containerInnerFormPanel.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.containerInnerFormPanel.Controls.Add(fh);
            this.containerInnerFormPanel.Tag = fh;
            fh.Show();
        }


        // Menu Items Clicking Management

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            
            LoadChildForm(new ResponsiveDashboard());
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
           
            LoadChildForm(new CustomersList());
        }

        private void sentPaysBtn_Click(object sender, EventArgs e)
        {
           
            LoadChildForm(new SentPaymentsList());
        }

        private void boxBtn_Click(object sender, EventArgs e)
        {
            
            LoadChildForm(new BoxList());
        }

        private void sentRemsBtn_Click(object sender, EventArgs e)
        {
           
           
            LoadChildForm(new SentRemittancesList());
        }

        private void receivedRemsBtn_Click(object sender, EventArgs e)
        {
           
            
            LoadChildForm(new ReceivedRemittancesList());
        }

        
        private void receivedPaysBtn_Click(object sender, EventArgs e)
        {
            LoadChildForm(new ReceivedPaymentsList());
        }


        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            Forms.Help.Help help = new Forms.Help.Help();
            help.Show();
        }
    }
}
