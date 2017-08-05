using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Bai03
{
    public partial class frm03Triangle : Form
    {
        public frm03Triangle()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            thchuvi.Text = System.Convert.ToString(
                System.Convert.ToInt32(tha.Text)
                + System.Convert.ToInt32(thb.Text)
                + System.Convert.ToInt32(thc.Text)
                );
            thdientich.Text = System.Convert.ToString(Math.Round(Math.Sqrt(
                System.Convert.ToDouble(thchuvi.Text)
                * System.Convert.ToDouble(tha.Text)
                * System.Convert.ToDouble(thb.Text)
                * System.Convert.ToDouble(thc.Text)
                ),2));
        }
    }
}
