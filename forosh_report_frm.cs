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
    public partial class forosh_report_frm : Form
    {
        public forosh_report_frm()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void forosh_report_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_bootik_lebasDataSet.foroshFactor' table. You can move, or remove it, as needed.
            this.foroshFactorTableAdapter.Fill(this.db_bootik_lebasDataSet.foroshFactor);

            PersianCalendar p_c = new PersianCalendar();
            lbl_date.Text = p_c.GetYear(DateTime.Now).ToString() + "/"
                + p_c.GetMonth(DateTime.Now).ToString() + "/" +
                p_c.GetDayOfMonth(DateTime.Now).ToString();
        }

        private void btn_search_date_Click(object sender, EventArgs e)
        {
            DataTable dt = foroshFactorTableAdapter.GetFactForoshDate(cmb_search_date.SelectedItem.ToString());
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

        private void cmb_search_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btn_search_date_Click(null, null);
            }
        }

        private void cmb_search_date_TextChanged(object sender, EventArgs e)
        {
            if (cmb_search_date.Text.Length == 0)
            {
                dataGridView1.DataSource = foroshFactorBindingSource;
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
