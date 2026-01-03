using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;
using Stimulsoft.Report.Viewer;

namespace Lebas_Shop
{
    public partial class kharid_report_frm : Form
    {
        public kharid_report_frm()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kharid_report_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_bootik_lebasDataSet.kharidFactor' table. You can move, or remove it, as needed.
            this.kharidFactorTableAdapter.Fill(this.db_bootik_lebasDataSet.kharidFactor);

        }

        private void btn_search_date_Click(object sender, EventArgs e)
        {
            DataTable dt = kharidFactorTableAdapter.GetFactKharidDate(cmb_search_date.SelectedItem.ToString());
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("چنین تاریخی وجود ندارد");
                return;
            }
            else
            {
                dataGridView1.DataSource = dt;
                dataGridView1.DefaultCellStyle.BackColor = Color.PaleTurquoise;
            }
        }

        private void pic_search_date_Click(object sender, EventArgs e)
        {
            btn_search_date_Click(null, null);
        }

        private void cmb_search_date_TextChanged(object sender, EventArgs e)
        {
            if (cmb_search_date.Text.Length == 0)
            {
                dataGridView1.DataSource = kharidFactorBindingSource;
            }
        }

        private void pic_add_date_Click(object sender, EventArgs e)
        {
            cmb_search_date.Items.Add(lbl_date.Text);
            MessageBox.Show("تاریخ امروز به لیست تاریخ اضافه شد");
            return;
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
