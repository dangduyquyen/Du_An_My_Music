using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmQLBH : Form
    {
        int ID;
        string _Path;
        public frmQLBH()
        {
            InitializeComponent();
            
            

        }

        private void frmQLBH_Activated(object sender, EventArgs e)
        {   
            // kết nối đế sql server
            try
            {
                luutru.CON = new SqlConnection("server=DESKTOP-HVNL2AM\\SQLEXPRESS;uid=sa;pwd=123123;database=My_list_music");
                luutru.CON.Open();

            }
            catch
            {
                MessageBox.Show("ket noi that bai", "thong bao");
            }
            luutru.hienthi(dgvQLBH, "select *  from BaiHat");
            btn_them.Enabled = btn_sua.Enabled = btn_xoa.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
           
            try
            {
                string sql = "update BaiHat set tenbaihat = N'" + txt_input_tenBaiHat.Text + "', tencasi =  N'" + txt_input_tenCaSi.Text + "', path = N'" + txt_path.Text + "', loibaihat = N'" + txt_input_loiBaiHat.Text + "' where id = " + ID +"";
                SqlCommand com = new SqlCommand(sql, luutru.CON);
                com.ExecuteNonQuery();
                MessageBox.Show("cập nhật thành công.", "thông báo");
                luutru.hienthi(dgvQLBH, "select * from BaiHat");

                btn_sua.Enabled = btn_xoa.Enabled = false;
                
                txt_input_tenBaiHat.Text = "";
                txt_input_tenCaSi.Text = "";
                txt_path.Text = "";
                txt_input_loiBaiHat.Text = "";

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi - ko thể cập nhật", "Thông báo");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
        }

        private void dgvQLBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvQLBH[0, dgvQLBH.CurrentCellAddress.Y].Value.ToString());
            
            txt_input_tenBaiHat.Text = dgvQLBH[1,dgvQLBH.CurrentCellAddress.Y].Value.ToString();
            txt_input_tenCaSi.Text = dgvQLBH[2, dgvQLBH.CurrentCellAddress.Y].Value.ToString();
            txt_path.Text  = dgvQLBH[3, dgvQLBH.CurrentCellAddress.Y].Value.ToString();
            _Path = txt_path.Text;
            txt_input_loiBaiHat.Text = dgvQLBH[6, dgvQLBH.CurrentCellAddress.Y].Value.ToString();
            btn_sua.Enabled = btn_xoa.Enabled = true;
            Phat(ID);
        }
        public void Phat(int ID)
        {
            try
            {
                string sql = "update BaiHat set luotnghe = (luotnghe + 1) where id = '" + ID + "'";
                SqlCommand com = new SqlCommand(sql, luutru.CON);
                com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("...", "Thông báo");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into BaiHat(tenbaihat, tencasi, path, luotnghe, yeuthich, loibaihat) values(N'"+ txt_input_tenBaiHat.Text + "'," +
                    " N'"+ txt_input_tenCaSi.Text + "', N'"+ txt_path.Text +"', "+ 0 +", "+ 0 + ", N'"+ txt_input_loiBaiHat.Text +"')";
                SqlCommand com = new SqlCommand(sql, luutru.CON);
                com.ExecuteNonQuery();
                MessageBox.Show("Thêm bài hát thành công.", "thông báo");
                luutru.hienthi(dgvQLBH, "select * from BaiHat");
                btn_them.Enabled = false;
                txt_input_tenBaiHat.Text = "";
                txt_input_tenCaSi.Text = "";
                txt_path.Text = "";
                txt_input_loiBaiHat.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công", "Thông báo");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM BaiHat WHERE id = "+ ID +"";
                SqlCommand com = new SqlCommand(sql, luutru.CON);
                com.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công.", "thông báo");
                luutru.hienthi(dgvQLBH, "select * from BaiHat");

                btn_sua.Enabled = btn_xoa.Enabled = false;

                txt_input_tenBaiHat.Text = "";
                txt_input_tenCaSi.Text = "";
                txt_path.Text = "";
                txt_input_loiBaiHat.Text = "";

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi - ko thể Xóa", "Thông báo");
            }
        }

        private void dgvQLBH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            axWindowsMediaPlayer1.URL = _Path;
        }
    }
}
