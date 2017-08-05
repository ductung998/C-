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
    public partial class frm03HCN : Form
    {
        public frm03HCN()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            thChuvi.Text = System.Convert.ToString(System.Convert.ToInt32(thDai.Text) + System.Convert.ToInt32(thRong.Text));
            thDientich.Text = System.Convert.ToString(System.Convert.ToInt32(thDai.Text)*System.Convert.ToInt32(thRong.Text));              
        
        }
    }
}
