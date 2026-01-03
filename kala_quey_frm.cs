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
    public partial class kala_quey_frm : Form
    {
        public kala_quey_frm()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kala_quey_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_bootik_lebasDataSet.kalaTable' table. You can move, or remove it, as needed.
            this.kalaTableTableAdapter.Fill(this.db_bootik_lebasDataSet.kalaTable);

        }

        void clearForm()
        {
            txt_kala_cod.Clear();
            txt_kala_name.Clear();
            txt_kala_mojodi.Clear();
            txt_kala_price.Clear();
            txt_kala_cod.Focus();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_kala_name.Text.Length == 0)
            {
                MessageBox.Show("برخی فیلد ها مقداردهی نشده");
                return;
            }
            else
            {
                int k = kalaTableTableAdapter.InsertKala(txt_kala_name.Text, int.Parse(txt_kala_mojodi.Text), int.Parse(txt_kala_price.Text));
                if (k > 0)
                {
                    this.kalaTableTableAdapter.Fill(this.db_bootik_lebasDataSet.kalaTable);
                    MessageBox.Show("کالای جدید ثبت شد");
                    clearForm();
                    return;
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_kala_name.Text.Length == 0)
            {
                MessageBox.Show("برخی فیلد ها مقداردهی نشده");
                return;
            }
            else
            {
                int k = kalaTableTableAdapter.DeleteKala(int.Parse(txt_kala_cod.Text));
                if (k > 0)
                {
                    this.kalaTableTableAdapter.Fill(this.db_bootik_lebasDataSet.kalaTable);
                    MessageBox.Show("کالای مورد نظر حذف شد");
                    clearForm();
                    return;
                }
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
                    clearForm();
                    return;
                }
                txt_kala_name.Text = dt.Rows[0][1].ToString();
                txt_kala_mojodi.Text = dt.Rows[0][2].ToString();
                txt_kala_price.Text = dt.Rows[0][3].ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_kala_name.Text.Length == 0)
            {
                MessageBox.Show("برخی فیلد ها مقداردهی نشده");
                return;
            }
            else
            {
                int k = kalaTableTableAdapter.UpdateKala(txt_kala_name.Text, int.Parse(txt_kala_mojodi.Text), int.Parse(txt_kala_price.Text), int.Parse(txt_kala_cod.Text));
                if (k > 0)
                {
                    this.kalaTableTableAdapter.Fill(this.db_bootik_lebasDataSet.kalaTable);
                    MessageBox.Show("کالای مورد نظر ویرایش شد");
                    clearForm();
                    return;
                }
            }
        }

        private void txt_kala_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 'a' && e.KeyValue <= 'z' || e.KeyValue >= 'A' && e.KeyValue <= 'Z')
            {
                MessageBox.Show("لطفا عدد وارد کنید");
                txt_kala_price.Clear();
                return;
            }
        }

        private void txt_kala_mojodi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 'a' && e.KeyValue <= 'z' || e.KeyValue >= 'A' && e.KeyValue <= 'Z')
            {
                MessageBox.Show("لطفا عدد وارد کنید");
                txt_kala_mojodi.Clear();
                return;
            }
        }

        private void txt_kala_cod_TextChanged(object sender, EventArgs e)
        {
            if (txt_kala_cod.Text.Length == 0)
            {
                dataGridView1.DataSource = kalaTableBindingSource;
                clearForm();
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // اطمینان از اینکه سطر انتخاب شده معتبر است
            if (e.RowIndex >= 0)
            {
                // دریافت مقادیر از سطر انتخاب شده
                txt_kala_cod.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); // مقدار ستون اول
                txt_kala_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); // مقدار ستون دوم
                txt_kala_mojodi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_kala_price.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();// می‌توانید به همین ترتیب مقادیر دیگر را نیز دریافت کنید
            }
        }

        private void pic_search_name_Click(object sender, EventArgs e)
        {
            DataTable dt = kalaTableTableAdapter.GetKala(int.Parse(txt_kala_cod.Text));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("چنین کدی وجود ندارد");
                return;
            }
            else
            {
                dataGridView1.DataSource = dt;
                dataGridView1.DefaultCellStyle.BackColor = Color.PaleTurquoise;
            }
        }

        private void pic_insert_Click(object sender, EventArgs e)
        {
            btn_insert_Click(null, null);
        }

        private void pic_delete_Click(object sender, EventArgs e)
        {
            btn_delete_Click(null, null);
        }

        private void pic_update_Click(object sender, EventArgs e)
        {
            btn_update_Click(null, null);
        }
    }
}
