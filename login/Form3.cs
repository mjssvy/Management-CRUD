using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=msi;Initial Catalog=crud;Integrated Security=True");
      
        void bindData()
        {//load data
            SqlCommand cmd = new SqlCommand("select * from [CRUD]", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void dataGridView1_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }



        private void Form3_Load(object sender, EventArgs e)
        {

            bindData();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //XOA
            if (!string.IsNullOrEmpty(textBox1.Text))
            { // Kiểm tra xem ID có tồn tại trong cơ sở dữ liệu không
                con.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM [CRUD] WHERE Id = '" + textBox1.Text + "'", con);
                int count = (int)checkCmd.ExecuteScalar();
                con.Close();
                if (count > 0)
                {// ID tồn tại, thực hiện xóa
                    con.Open();
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM [CRUD] WHERE Id='" + textBox1.Text + "'", con);
                    deleteCmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    con.Close();
                    bindData();
                }
                else
                {
                    MessageBox.Show("ID không tồn tại trong cơ sở dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để xóa");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Them 
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [CRUD] VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "',@DateBirth)", con);
            cmd.Parameters.AddWithValue("@DateBirth", dateTimePicker1.Value.Date); // Thêm giá trị ngày sinh
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert");
            con.Close();
            bindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {//sua
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [CRUD] SET Name = @Name, Address = @Address, Sex = @Sex, DateBirth = @DateBirth WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                cmd.Parameters.AddWithValue("@Sex", comboBox1.Text);
                cmd.Parameters.AddWithValue("@DateBirth", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@Id", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                con.Close();
                textBox1.Enabled = true;
                bindData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để cập nhật");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TIM KIEM THEO ID
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                SqlCommand cmd = new SqlCommand("select * from [CRUD] where Id= '" + textBox1.Text + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Please enter an Id to search");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindData(); // load lai data
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string idColumnName = dataGridView1.Columns["Id"].DataPropertyName;
                textBox1.Text = selectedRow.Cells[idColumnName].Value.ToString();
                textBox1.Enabled = false;
                textBox2.Text = selectedRow.Cells["Name"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Address"].Value.ToString();
                comboBox1.Text = selectedRow.Cells["Sex"].Value.ToString();
                if (dataGridView1.Columns.Contains("DateBirth"))
                {
                    object ngaySinhValue = selectedRow.Cells["DateBirth"].Value;
                    if (ngaySinhValue != null && ngaySinhValue != DBNull.Value && DateTime.TryParse(ngaySinhValue.ToString(), out DateTime ngaySinh))
                    {
                        dateTimePicker1.Value = ngaySinh;
                    }
                    else
                    {
                        dateTimePicker1.Value = DateTime.Now;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = selectedRow.Cells["Id"].Value.ToString();
                textBox1.Enabled = false;
                textBox2.Text = selectedRow.Cells["Name"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Address"].Value.ToString();
            }
        }
    }
}
