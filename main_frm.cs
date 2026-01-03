using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lebas_Shop
{
    public partial class main_frm : Form
    {
        public main_frm()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void فروشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forosh_frm ff = new forosh_frm();
            ff.ShowDialog();
        }

        private void خریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kharid_frm kf = new Kharid_frm();
            kf.ShowDialog();
        }

        private void لیستکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kala_report_frm krf = new kala_report_frm();
            krf.ShowDialog();
        }

        private void لیستمشتریانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moshtari_report_frm mrf = new moshtari_report_frm();
            mrf.ShowDialog();
        }

        private void لیستفاکتورهایفروشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forosh_report_frm frf = new forosh_report_frm();
            frf.ShowDialog();
        }

        private void لیستفاکتورهایخریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kharid_report_frm khrf = new kharid_report_frm();
            khrf.ShowDialog();
        }

        private void کالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kala_quey_frm kqf = new kala_quey_frm();
            kqf.ShowDialog();
        }

        private void مشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moshtari_query_frm mqf = new moshtari_query_frm();
            mqf.ShowDialog();
        }

        private void کاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_query_frm uqf = new user_query_frm();
            uqf.ShowDialog();
        }

        private void تعیینتصویرزمینهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            background_frm bf = new background_frm();
            bf.ShowDialog();
        }

        private void تعیینرنگمنوهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_frm cf = new color_frm();
            cf.ShowDialog();
        }

        private void main_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_bootik_lebasDataSet.optionTable' table. You can move, or remove it, as needed.
            this.optionTableTableAdapter.Fill(this.db_bootik_lebasDataSet.optionTable);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void main_frm_Activated(object sender, EventArgs e)
        {
            DataTable dt = optionTableTableAdapter.GetOption();
            pictureBox1.ImageLocation = dt.Rows[0][1].ToString();
            menuStrip1.ForeColor = Color.FromArgb(int.Parse(dt.Rows[0][2].ToString()));
        }
    }
}
