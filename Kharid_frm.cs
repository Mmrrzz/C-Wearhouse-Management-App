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
using DGVPrinterHelper;

namespace Lebas_Shop
{
    public partial class Kharid_frm : Form
    {
        public Kharid_frm()
        {
            InitializeComponent();
        }

        private void Kharid_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_bootik_lebasDataSet.kharidFactor' table. You can move, or remove it, as needed.
            this.kharidFactorTableAdapter.Fill(this.db_bootik_lebasDataSet.kharidFactor);
            // TODO: This line of code loads data into the 'db_bootik_lebasDataSet.kalaTable' table. You can move, or remove it, as needed.
            this.kalaTableTableAdapter.Fill(this.db_bootik_lebasDataSet.kalaTable);


            PersianCalendar p_c = new PersianCalendar();
            lbl_date.Text = p_c.GetYear(DateTime.Now).ToString() + "/"
                + p_c.GetMonth(DateTime.Now).ToString() + "/" +
                p_c.GetDayOfMonth(DateTime.Now).ToString();

            contextMenuStrip1.ForeColor = Color.White;
        }

        void clearKala()
        {
            txt_kala_cod.Clear();
            txt_kala_name.Clear();
            txt_kala_price.Clear();
            txt_kala_tedad.Clear();
            txt_kala_cod.Focus();
        }

        void sumcheck()
        {
            int jamekol = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                jamekol += int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            txt_jam_kol.Text = jamekol.ToString();
        }

        private void txt_kala_cod_TextChanged(object sender, EventArgs e)
        {
            if (txt_kala_cod.Text.Length == 0)
            {
                txt_kala_name.Clear();
                txt_kala_price.Clear();
                txt_kala_tedad.Clear();
            }
        }

        private void txt_kala_cod_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue >= 'a' && e.KeyValue <= 'z' || e.KeyValue >= 'A' && e.KeyValue <= 'Z')
            {
                MessageBox.Show("لطفا عدد وارد کنید");
                txt_kala_cod.Clear();
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = kalaTableTableAdapter.GetKala(int.Parse(txt_kala_cod.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("چنین کدی موجود نیست");
                    txt_kala_cod.Clear();
                    txt_kala_cod.Focus();
                    return;
                }

                txt_kala_name.Text = dt.Rows[0][1].ToString();
                txt_kala_price.Text = dt.Rows[0][3].ToString();
                txt_kala_tedad.Focus();
            }
        }

        private void pic_add_Click(object sender, EventArgs e)
        {
            string[] radif = new string[5];
            radif[0] = txt_kala_cod.Text;
            radif[1] = txt_kala_name.Text;
            radif[2] = txt_kala_price.Text;
            radif[3] = txt_kala_tedad.Text;
            radif[4] = (int.Parse(radif[2]) * int.Parse(radif[3])).ToString();
            dataGridView1.Rows.Add(radif);
            sumcheck();
            clearKala();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                sumcheck();
            }
        }

        private void txt_kala_tedad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 'a' && e.KeyValue <= 'z' || e.KeyValue >= 'A' && e.KeyValue <= 'Z')
            {
                MessageBox.Show("لطفا عدد وارد کنید");
                txt_kala_tedad.Clear();
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                pic_add_Click(null, null);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // زیاد کردن تعداد فروش از موجودی دیتابیس
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                DataTable dt = kalaTableTableAdapter.GetKala(int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                if (dt.Rows.Count > 0)
                {
                    // مقدار فروخته شده را به موجودی اضافه کنید
                    int kharidTedad = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());

                    // به روز رسانی موجودی در دیتابیس
                    int k = kalaTableTableAdapter.UpdateMojodi2(kharidTedad, int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()));

                    if (k > 0)
                    {
                        this.kalaTableTableAdapter.Fill(this.db_bootik_lebasDataSet.kalaTable);
                        MessageBox.Show("تغییر در موجودی انبار اعمال شد");
                    }
                }
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("کالایی انتخاب نشده است");
                return;
            }
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                int kalaTedad, kalaPrice;

                if (int.TryParse(dataGridView1.Rows[i].Cells[2].Value.ToString(), out kalaTedad) &&
                    int.TryParse(dataGridView1.Rows[i].Cells[3].Value.ToString(), out kalaPrice))
                {
                    int k = kharidFactorTableAdapter.InsertKharidFactor(dataGridView1.Rows[i].Cells[1].Value.ToString(), kalaPrice, kalaTedad, lbl_date.Text);
                }
                else
                {
                    // مدیریت خطا: نمایش پیام یا انجام اقدام مناسب
                    MessageBox.Show("لطفاً مقادیر عددی صحیح وارد کنید.");
                }
            }
            dataGridView1.Rows.Clear();
            MessageBox.Show("فاکتور ثبت گردید");
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_save_Click(object sender, EventArgs e)
        {
            btn_save_Click(null, null);
        }

        private void btn_show_kala_Click(object sender, EventArgs e)
        {
            kala_report_frm krf = new kala_report_frm();
            krf.ShowDialog();
        }

        private void pic_show_kala_Click(object sender, EventArgs e)
        {
            btn_show_kala_Click(null, null);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "فاکتور خرید";
            print.SubTitle = String.Format("محصولات خریداری شده", print.SubTitleColor = Color.Black, print);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = true;
            print.PorportionalColumns = true;
            print.Footer = "فروشگاه لباس";
            print.FooterSpacing = 15;
            print.PrintPreviewDataGridView(dataGridView1);
        }
    }
}