using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Music
{
    public partial class frm_QLBH : Form
    {
        public frm_QLBH()
        {

            InitializeComponent();
            loadDataToGrv();
        }
        void loadDataToGrv()
        {
            dgvQLBH.AutoGenerateColumns = false;
            using (My_list_musicEntities db = new My_list_musicEntities())
            {
                dgvQLBH.DataSource = luu.CreateDataTable<BaiHat>(db.BaiHat.ToList<BaiHat>());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
