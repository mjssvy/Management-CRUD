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
    public partial class Form3 : Form
    {
        private TuyenSinh tuyenSinh;

        public Form3(TuyenSinh tuyenSinh)
        {
            InitializeComponent();
            this.tuyenSinh = tuyenSinh;
            HienThiDanhSachThiSinh();
        }

        private void HienThiDanhSachThiSinh()
        {
            List<ThiSinh> danhSachThiSinh = tuyenSinh.LayDanhSachThiSinh();

            foreach (ThiSinh thiSinh in danhSachThiSinh)
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

                listBox1.Items.Add($"Số báo danh: {thiSinh.SoBaoDanh}, Họ tên: {thiSinh.HoTen}, Địa Chỉ: {thiSinh.DiaChi}, Mức ưu tiên: {thiSinh.MucUuTien} Khối thi: {khoiThi}");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
