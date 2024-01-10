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
    public partial class Form2 : Form
    {
        private TuyenSinh tuyenSinh;

        public Form2(TuyenSinh tuyenSinh)
        {
            InitializeComponent();
            this.tuyenSinh = tuyenSinh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra khối thi và tạo đối tượng thí sinh tương ứng
            ThiSinh thiSinh;
            if (radioButton1.Checked)
            {
                thiSinh = new ThiSinhKhoiA();
                ((ThiSinhKhoiA)thiSinh).Mon1 = "Toán";
                ((ThiSinhKhoiA)thiSinh).Mon2 = "Lý";
                ((ThiSinhKhoiA)thiSinh).Mon3 = "Hoá";
            }
            else if (radioButton2.Checked)
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
            thiSinh.SoBaoDanh = textBox1.Text;
            thiSinh.HoTen = textBox2.Text;
            thiSinh.DiaChi = textBox3.Text;
            thiSinh.MucUuTien = Convert.ToInt32(textBox4.Text);

            // Thêm thí sinh vào danh sách
            tuyenSinh.ThemThiSinh(thiSinh);

            MessageBox.Show("Thêm thí sinh thành công!");
            ClearForm();
        }

        private void ClearForm()
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }

            private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
