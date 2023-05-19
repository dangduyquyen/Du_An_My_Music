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

namespace WindowsFormsApp1
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                luutru.CON = new SqlConnection("server=DESKTOP-HVNL2AM\\SQLEXPRESS;uid=sa;pwd=123123;database=My_list_music");
                luutru.CON.Open();
                SqlCommand com = new SqlCommand("Select * from TaiKhoan where " +
                    "username ='" + textBoxUsername.Text + "' and password = '" + textBoxpassword.Text + "'", luutru.CON);
                com.ExecuteNonQuery();
                SqlDataReader drd = com.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(drd);
                if (table.Rows.Count > 0)
                {
                    luutru.KT = !luutru.KT;
                    Close();
                }
                else
                {
                    MessageBox.Show("Username hoac password khong chinh xac!", "thong bao");
                }
            }
            catch
            {
                MessageBox.Show("khong the ket noi server, hoat du lieu nhap ko dung", "thong bao");
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
