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
using System.Data;

namespace login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;

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
                    string tk = textBox1.Text;
                    string mk = textBox2.Text;
                    
                    //// Thiết lập thuộc tính UseSystemPasswordChar thành true để ẩn mật khẩu
                    //textBox2.UseSystemPasswordChar = true;
                // Kiểm tra xem CheckBox có được chọn không
               

                string loai = GetSelectedRadioButtonText();
                    string sql = "select * from [login] where Tk = '" + tk + "' and mk = '" + mk + "'and loai = '" + loai + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dt = cmd.ExecuteReader();

                    if (dt.HasRows)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        Form3 Form3 = new Form3();
                        Form3.Show();
                        this.Hide();

                }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập, mật khẩu hoặc loại tài khoản không đúng!");
                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại tài khoản!");
                }
          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
