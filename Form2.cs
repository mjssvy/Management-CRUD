using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TuyenSinh.Form1;

namespace TuyenSinh
{
    public partial class Form2 : Form
    {

        private TuyenSinh tuyenSinh;

        public Form2(TuyenSinh tuyenSinh)
        {
            InitializeComponent();
            this.tuyenSinh = tuyenSinh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra khối thi và tạo đối tượng thí sinh tương ứng
            ThiSinh thiSinh;
            if (radKhoiA.Checked)
            {
                thiSinh = new ThiSinhKhoiA();
                ((ThiSinhKhoiA)thiSinh).Mon1 = "Toán";
                ((ThiSinhKhoiA)thiSinh).Mon2 = "Lý";
                ((ThiSinhKhoiA)thiSinh).Mon3 = "Hoá";
            }
            else if (radKhoiB.Checked)
            {
                thiSinh = new ThiSinhKhoiB();
                ((ThiSinhKhoiB)thiSinh).Mon1 = "Toán";
                ((ThiSinhKhoiB)thiSinh).Mon2 = "Hoá";
                ((ThiSinhKhoiB)thiSinh).Mon3 = "Sinh";
            }
            else
            {
                thiSinh = new ThiSinhKhoiC();
                ((ThiSinhKhoiC)thiSinh).Mon1 = "Văn";
                ((ThiSinhKhoiC)thiSinh).Mon2 = "Sử";
                ((ThiSinhKhoiC)thiSinh).Mon3 = "Địa";
            }

            // Đọc thông tin từ các textbox
            thiSinh.SoBaoDanh = txtSoBaoDanh.Text;
            thiSinh.HoTen = txtHoTen.Text;
            thiSinh.DiaChi = txtDiaChi.Text;
            thiSinh.MucUuTien = Convert.ToInt32(txtMucUuTien.Text);

            // Thêm thí sinh vào danh sách
            tuyenSinh.ThemThiSinh(thiSinh);

            MessageBox.Show("Thêm thí sinh thành công!");
           
        }

       
    }
}

