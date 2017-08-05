using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap.Bai02
{
    public partial class frm02Hanghoa : Form
    {
        public frm02Hanghoa()
        {
            InitializeComponent();
        }

        private void btnXuattextbox_Click(object sender, EventArgs e)
        {
            lblXuat.Text = "Thanh toán bằng: " + (chkTienmat.Checked ? "Tiền mặt" : "Chuyển khoản");
            lblXuat.Text += "\nVận chuyển bằng: " + (rdOto.Checked ? "Ô tô" :(
                rdTauhoa.Checked ? "Tàu hỏa" : "Máy bay"));
            thXuattextbox.Text = "Hàng hóa\t\t\tSố lượng\t\t\tTổng tiền \r\n";
            thXuattextbox.Text += thTenhang.Text + "\t\t\t" + thSoluong.Text + "\t\t\t" + thTongtien.Text;
        }

        private void btnMessbox_Click(object sender, EventArgs e)
        {
            string str = "Tên hàng: " + thTenhang.Text;
            str += "\nSố lượng: " + thSoluong.Text;
            str += "\nTổng tiền: " + thTongtien.Text;
            MessageBox.Show(str, "Kết quả");
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            thSoluong.Clear();
            thTenhang.Clear();
            thTongtien.Clear();
            thXuattextbox.Clear();
            rdOto.Checked = true;
        }

        private void thSoluong_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
