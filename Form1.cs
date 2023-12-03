using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static TuyenSinh.Form1;

namespace TuyenSinh
{
    public partial class Form1 : Form
    {
        //public class TuyenSinh
        //{
        //    public string SoBaoDanh { get; set; }
        //    public string HoTen { get; set; }
        //    public string DiaChi { get; set; }
        //    public string MucUuTien { get; set; }

        //    public TuyenSinh(string soBaoDanh, string hoTen, string diaChi, string mucUuTien)
        //    {
        //        SoBaoDanh = soBaoDanh;
        //        HoTen = hoTen;
        //        DiaChi = diaChi;
        //        MucUuTien = mucUuTien;
        //    }

        //    public override string ToString()
        //    {
        //        return $"Số báo danh: {SoBaoDanh}, Họ tên: {HoTen}, Địa chỉ: {DiaChi}, Mức ưu tiên: {MucUuTien}";
        //    }
        //}
        //public class ManagerCandidate
        //{
        //    private List<ThiSinh> thiSinhs;

        //    public ManagerCandidate()
        //    {
        //        thiSinhs = new List<ThiSinh>();
        //    }

        //    public void AddThiSinh(ThiSinh thiSinh)
        //    {
        //        thiSinhs.Add(thiSinh);
        //    }

        //    public void ShowThongTin()
        //    {
        //        foreach (ThiSinh thiSinh in thiSinhs)
        //        {
        //            Console.WriteLine(thiSinh.ToString());
        //        }
        //    }

        //    public ThiSinh TimKiemThiSinh(string soBaoDanh)
        //    {
        //        return thiSinhs.Find(ts => ts.SoBaoDanh == soBaoDanh);
        //    }
        //    public List<ThiSinh> ThiSinhs // Thêm thuộc tính công khai
        //    {
        //        get { return thiSinhs; }
        //    }
        //}
        //private List<ThiSinh> thiSinhs;



        private TuyenSinh tuyenSinh;


        public Form1()
        {
            InitializeComponent();
            tuyenSinh = new TuyenSinh();
        }

        private void candidateAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 themSinhVienForm = new ThemSinhVienForm(tuyenSinh);
            themSinhVienForm.ShowDialog();

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 hienThiSinhVienForm = new HienThiSinhVienForm(tuyenSinh);
            hienThiSinhVienForm.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    public class ThiSinh
    {
        public string SoBaoDanh { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int MucUuTien { get; set; }
    }

    public class ThiSinhKhoiA : ThiSinh
    {
        public string Mon1 { get; set; }
        public string Mon2 { get; set; }
        public string Mon3 { get; set; }
    }

    public class ThiSinhKhoiB : ThiSinh
    {
        public string Mon1 { get; set; }
        public string Mon2 { get; set; }
        public string Mon3 { get; set; }
    }

    public class ThiSinhKhoiC : ThiSinh
    {
        public string Mon1 { get; set; }
        public string Mon2 { get; set; }
        public string Mon3 { get; set; }
    }

    public class TuyenSinh
    {
        private List<ThiSinh> danhSachThiSinh;

        public TuyenSinh()
        {
            danhSachThiSinh = new List<ThiSinh>();
        }

        public void ThemThiSinh(ThiSinh thiSinh)
        {
            danhSachThiSinh.Add(thiSinh);
        }

        public List<ThiSinh> LayDanhSachThiSinh()
        {
            return danhSachThiSinh;
        }

        public ThiSinh TimKiemTheoSoBaoDanh(string soBaoDanh)
        {
            return danhSachThiSinh.Find(x => x.SoBaoDanh == soBaoDanh);
        }
    }
}