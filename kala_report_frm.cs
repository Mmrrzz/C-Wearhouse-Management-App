using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Stimulsoft.Report;
using Stimulsoft.Report.Viewer;


namespace Lebas_Shop
{
    public partial class kala_report_frm : Form
    {
        public kala_report_frm()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kala_report_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_bootik_lebasDataSet.kalaTable' table. You can move, or remove it, as needed.
            this.kalaTableTableAdapter.Fill(this.db_bootik_lebasDataSet.kalaTable);

            PersianCalendar p_c = new PersianCalendar();
            lbl_date.Text = p_c.GetYear(DateTime.Now).ToString() + "/"
                + p_c.GetMonth(DateTime.Now).ToString() + "/" +
                p_c.GetDayOfMonth(DateTime.Now).ToString();
        }

        private void btn_search_name_Click(object sender, EventArgs e)
        {
            DataTable dt = kalaTableTableAdapter.GetKalaName(txt_search_name.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("چنین نامی وجود ندارد");
                return;
            }
            else
            {
                dataGridView1.DataSource = dt;
                dataGridView1.DefaultCellStyle.BackColor = Color.PaleTurquoise;
            }
        }

        private void txt_search_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search_name_Click(null, null);
            }
        }

        private void txt_search_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_search_name.Text.Length == 0)
            {
                dataGridView1.DataSource = kalaTableBindingSource;
            }
        }

        private void pic_search_date_Click(object sender, EventArgs e)
        {
            btn_search_name_Click(null, null);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            stiReport1.Show();
        }

        private void pic_print_Click(object sender, EventArgs e)
        {
            btn_print_Click(null, null);
        }
    }
}
