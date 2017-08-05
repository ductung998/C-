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
    public partial class frm03CVDT : Form
    {
        public frm03CVDT()
        {
            InitializeComponent();
        }

        double Pi = 3.14;

        private void btTinh_Click(object sender, EventArgs e)
        {
            int r = System.Convert.ToInt32(R.Text);
            //double P = 2 * r * Pi;
            //double S = r * r * Pi;
            //MessageBox.Show("Chu vi: " + System.Convert.ToString(P)
            //    + "\n Dien tich: " + System.Convert.ToString(S));
            P.Text = System.Convert.ToString(r * 2 * Pi);
            S.Text = System.Convert.ToString(r * r * Pi);
        }

        private void btRedo_Click(object sender, EventArgs e)
        {
            R.Clear();
            S.Clear();
            P.Clear();
        }
    }
}
