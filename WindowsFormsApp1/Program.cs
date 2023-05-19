using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class luutru
    {
        private static bool kt = true;
        private static SqlConnection con = null;

        public static bool KT
        {
            get { return kt; }
            set { kt = value; }
        }

        public static SqlConnection CON
        {
            get { return con; }
            set { con = value; }
        }

        public static void hienthi(DataGridView dgv, String s)
        {
            SqlCommand com = new SqlCommand(s, con);
            SqlDataReader drd = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(drd);
            dgv.DataSource = table;
            table.Columns.Add("TT");
            for (int i = 0; i <= table.Rows.Count - 1; i++)
            {
                table.Rows[i]["TT"] = i + 1;
            }
            dgv.DataSource = table;
            drd.Close();
        }
        public static void loadCombobox(ComboBox cmb, string s)
        {
            cmb.Items.Clear();
            SqlCommand com = new SqlCommand(s, con);
            SqlDataReader drd = com.ExecuteReader();
            while (drd.Read()) cmb.Items.Add(drd[0]);
            cmb.SelectedIndex = 0;
            drd.Close();

        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
