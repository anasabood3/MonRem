using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonremSys
{
    static class Receipt
    {
        public static void GetReceipt(Bitmap receipt_image)
        {

            try
            {
                receipt_image.Save("./data/new.jpg");

            }
            catch (Exception Error)
            {
                MessageBox.Show("Technical Erorr:" + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
