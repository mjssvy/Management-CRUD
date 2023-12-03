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
    public partial class Form3 : Form
    {
        private ManagerCandidate managerCandidate;

        public Form3(ManagerCandidate managerCandidate)
        {
            InitializeComponent();
            this.managerCandidate = managerCandidate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ThiSinh> thiSinhs = managerCandidate.ThiSinhs;
            if (thiSinhs.Count > 0)
            {
                string thongTinThiSinh = "";
                foreach (ThiSinh thiSinh in thiSinhs)
                {
                    thongTinThiSinh += thiSinh.ToString() + "\n";
                }
                MessageBox.Show(thongTinThiSinh, "Thông tin thí sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chưa có thông tin thí sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
