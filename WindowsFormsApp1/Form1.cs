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
    public partial class Form1 : Form
    {
        int ID;
        string Path;
        bool YeuThich;
        public Form1()
        {
            SqlConnection con;
            SqlCommand com;
            InitializeComponent();
            
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
            luutru.hienthi(dgvDSBH, " select id, tenbaihat, path, yeuthich, loibaihat from BaiHat ");
        }
        void lock_unlock(bool kt)
        {
            mnuHTDN.Enabled = kt;
            mnuHTDX.Enabled = mnuQLBH.Enabled = !kt;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lock_unlock(luutru.KT);
            
        }

        private void btn_bh_nn_Click(object sender, EventArgs e)
        {
            luutru.hienthi(dgvDSBH, " select top 100 id, tenbaihat, path, yeuthich, loibaihat from BaiHat ORDER BY luotnghe DESC "); 
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuHTDN_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
        }

        private void mnuHTDX_Click(object sender, EventArgs e)
        {
            luutru.KT = !luutru.KT;
            luutru.CON.Close();
            lock_unlock(luutru.KT);
        }

        private void btn_tcbh_Click(object sender, EventArgs e)
        {
            luutru.hienthi(dgvDSBH, " select id, tenbaihat, path, yeuthich, loibaihat from BaiHat ");
        }

        private void btn_bh_yt_Click(object sender, EventArgs e)
        {
            luutru.hienthi(dgvDSBH, " select id, tenbaihat, path, yeuthich, loibaihat from BaiHat where yeuthich = 1 ");
        }

        private void btn_Phat_Click(object sender, EventArgs e)
        {
            ID = int.Parse(dgvDSBH[0, dgvDSBH.CurrentCellAddress.Y].Value.ToString());
            txtDangPhat.Text = dgvDSBH[1, dgvDSBH.CurrentCellAddress.Y].Value.ToString();
            Path = dgvDSBH[2, dgvDSBH.CurrentCellAddress.Y].Value.ToString();
            YeuThich = bool.Parse(dgvDSBH[3, dgvDSBH.CurrentCellAddress.Y].Value.ToString());
            txtLoiBaiHat.Text = dgvDSBH[4, dgvDSBH.CurrentCellAddress.Y].Value.ToString();
            axWindowsMediaPlayer1.URL = Path;
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

        private void btn_yeuThich_Click(object sender, EventArgs e)
        {
            if(YeuThich == false)
            {
                try
                {
                    string sql = "update BaiHat set yeuthich = 1 where id = '" + ID + "'";
                    SqlCommand com = new SqlCommand(sql, luutru.CON);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Đã yêu thích.", "thông báo");
                    luutru.hienthi(dgvDSBH, "select id, tenbaihat, path, yeuthich, loibaihat from BaiHat");
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi - bài hát chưa đc yêu thích", "Thông báo");
                }
            }
            else
            {
                try
                {
                    string sql = "update BaiHat set yeuthich = 0 where id = '" + ID + "'";
                    SqlCommand com = new SqlCommand(sql, luutru.CON);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa yêu thích.", "thông báo");
                    luutru.hienthi(dgvDSBH, "select id, tenbaihat, path, yeuthich, loibaihat from BaiHat");
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi - bài hát chưa đc xóa yêu thích", "Thông báo");
                }
            }
        }

        

        private void dgvDSBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSBH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dgvDSBH[0, dgvDSBH.CurrentCellAddress.Y].Value.ToString());
            txtDangPhat.Text = dgvDSBH[1, dgvDSBH.CurrentCellAddress.Y].Value.ToString();
            Path = dgvDSBH[2, dgvDSBH.CurrentCellAddress.Y].Value.ToString();
            YeuThich = bool.Parse(dgvDSBH[3, dgvDSBH.CurrentCellAddress.Y].Value.ToString());
            txtLoiBaiHat.Text = dgvDSBH[4, dgvDSBH.CurrentCellAddress.Y].Value.ToString();
            axWindowsMediaPlayer1.URL = Path;
            Phat(ID);
        }

        private void mnuTCBH_Click(object sender, EventArgs e)
        {
            frmQLBH f = new frmQLBH();
            f.Show();
        }

        private void mnuTV_Click(object sender, EventArgs e)
        {
            //frmThuVien f = new frmThuVien();
            //f.Show();
        }
    }
}
