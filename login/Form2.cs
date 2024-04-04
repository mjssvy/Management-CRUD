using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=msi;Initial Catalog=crud;Integrated Security=True");
        private string GetSelectedRadioButtonText()
        {
            if (radioButton1.Checked)
                return radioButton1.Text;
            else if (radioButton2.Checked)
                return radioButton2.Text;
            else
                return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedRadioButtonText = GetSelectedRadioButtonText();

            if (!string.IsNullOrEmpty(selectedRadioButtonText))
            {
                con.Open();
                string tk = textBox2.Text;
                string mk = textBox3.Text;
                string loai = GetSelectedRadioButtonText();
                string tenDN = textBox1.Text;

                // Kiểm tra xem tên đăng nhập đã tồn tại chưa
                string checkExistQuery = "SELECT COUNT(*) FROM [login] WHERE Tk = @tk";
                SqlCommand checkExistCmd = new SqlCommand(checkExistQuery, con);
                checkExistCmd.Parameters.AddWithValue("@tk", tk);

                int existingAccountsCount = (int)checkExistCmd.ExecuteScalar();

                if (existingAccountsCount > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn một tên đăng nhập khác.");
                }
                else
                {
                    // Nếu tên đăng nhập chưa tồn tại, thực hiện thêm vào cơ sở dữ liệu
                    string insertQuery = "INSERT INTO [login] (Tk, mk, loai, tenDN) VALUES (@tk, @mk, @loai, @tenDN)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@tk", tk);
                    insertCmd.Parameters.AddWithValue("@mk", mk);
                    insertCmd.Parameters.AddWithValue("@loai", loai);
                    insertCmd.Parameters.AddWithValue("@tenDN", tenDN);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Đăng ký thành công!");
                }

                con.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
