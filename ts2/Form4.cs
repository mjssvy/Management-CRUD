using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ts2
{
    public partial class Form4 : Form
    {
        private TuyenSinh tuyenSinh;
        public Form4(TuyenSinh tuyenSinh)
        {
            InitializeComponent();
            this.tuyenSinh = tuyenSinh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string soBaoDanh = textBox1.Text;
            ThiSinh thiSinh = tuyenSinh.TimKiemTheoSoBaoDanh(soBaoDanh);

            if (thiSinh != null)
            {
                string khoiThi = "";
                if (thiSinh is ThiSinhKhoiA)
                {
                    khoiThi = "Khối A";
                }
                else if (thiSinh is ThiSinhKhoiB)
                {
                    khoiThi = "Khối B";
                }
                else if (thiSinh is ThiSinhKhoiC)
                {
                    khoiThi = "Khối C";
                }

                MessageBox.Show($"Số báo danh: {thiSinh.SoBaoDanh}, Họ tên: {thiSinh.HoTen}, Địa Chỉ: {thiSinh.DiaChi}, Mức ưu tiên: {thiSinh.MucUuTien} Khối thi: {khoiThi}");
            }
            else
            {
                MessageBox.Show("Không tìm thấy thí sinh");
            }
        }
    }
}
