namespace ts2
{
    public partial class Form1 : Form
    {
        private TuyenSinh tuyenSinh;
        public Form1()
        {
            InitializeComponent();
            tuyenSinh = new TuyenSinh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 themSinhVienForm = new Form2(tuyenSinh);
            themSinhVienForm.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 hienThiSinhVienForm = new Form3(tuyenSinh);
            hienThiSinhVienForm.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 timKiemForm = new Form4(tuyenSinh);
            timKiemForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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