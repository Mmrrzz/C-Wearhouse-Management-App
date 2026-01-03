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
    public partial class moshtari_query_frm : Form
    {
        public moshtari_query_frm()
        {
            InitializeComponent();
        }

        private void moshtari_query_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_bootik_lebasDataSet.moshTable' table. You can move, or remove it, as needed.
            this.moshTableTableAdapter.Fill(this.db_bootik_lebasDataSet.moshTable);

        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clearForm()
        {
            txt_mosh_cod.Clear();
            txt_mosh_name.Clear();
            txt_mosh_phone.Clear();
            txt_mosh_address.Clear();
            txt_mosh_cod.Focus();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_mosh_name.Text.Length == 0)
            {
                MessageBox.Show("برخی فیلد ها مقداردهی نشده");
                return;
            }
            else
            {
                int k = moshTableTableAdapter.InsertMoshtari(txt_mosh_name.Text, txt_mosh_phone.Text, txt_mosh_address.Text);
                if (k > 0)
                {
                    this.moshTableTableAdapter.Fill(this.db_bootik_lebasDataSet.moshTable);
                    MessageBox.Show("رکورد جدید اضافه شد");
                    clearForm();
                    return;
                }
            }
        }

        private void txt_mosh_cod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 'a' && e.KeyValue <= 'z' || e.KeyValue >= 'A' && e.KeyValue <= 'Z')
            {
                MessageBox.Show("لطفا عدد وارد کنید");
                txt_mosh_cod.Clear();
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = moshTableTableAdapter.GetMoshtari(int.Parse(txt_mosh_cod.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("چنین کدی وجود ندارد");
                    clearForm();
                    return;
                }

                txt_mosh_name.Text = dt.Rows[0][1].ToString();
                txt_mosh_phone.Text = dt.Rows[0][2].ToString();
                txt_mosh_address.Text = dt.Rows[0][3].ToString();
            }
        }

        private void txt_mosh_cod_TextChanged(object sender, EventArgs e)
        {
            if (txt_mosh_cod.Text.Length == 0)
            {
                clearForm();
                return;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_mosh_name.Text.Length == 0)
            {
                MessageBox.Show("برخی فیلد ها مقداردهی نشده");
                return;
            }
            else
            {
                int k = moshTableTableAdapter.DeleteMoshtari(int.Parse(txt_mosh_cod.Text));
                if (k > 0)
                {
                    this.moshTableTableAdapter.Fill(this.db_bootik_lebasDataSet.moshTable);
                    MessageBox.Show("رکورد مورد نظر حذف شد");
                    clearForm();
                    return;
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_mosh_name.Text.Length == 0)
            {
                MessageBox.Show("برخی فیلد ها مقداردهی نشده");
                return;
            }
            else
            {
                int k = moshTableTableAdapter.UpdateMoshtari2(txt_mosh_name.Text, txt_mosh_phone.Text, txt_mosh_address.Text, int.Parse(txt_mosh_cod.Text));
                if (k > 0)
                {
                    this.moshTableTableAdapter.Fill(this.db_bootik_lebasDataSet.moshTable);
                    MessageBox.Show("رکورد مورد نظر ویرایش شد");
                    clearForm();
                    return;
                }
            }
        }

        private void txt_mosh_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 'a' && e.KeyValue <= 'z' || e.KeyValue >= 'A' && e.KeyValue <= 'Z')
            {
                MessageBox.Show("لطفا عدد وارد کنید");
                txt_mosh_phone.Clear();
                return;
            }
        }

        private void txt_mosh_phone_TextChanged(object sender, EventArgs e)
        {
            if (txt_mosh_phone.Text.Length > 11)
            {
                MessageBox.Show("تعداد ارقام بیشتر از حد مجاز است");
                txt_mosh_phone.Clear();
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // اطمینان از اینکه سطر انتخاب شده معتبر است
            if (e.RowIndex >= 0)
            {
                // دریافت مقادیر از سطر انتخاب شده
                txt_mosh_cod.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); // مقدار ستون اول
                txt_mosh_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); // مقدار ستون دوم
                txt_mosh_phone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_mosh_address.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();// می‌توانید به همین ترتیب مقادیر دیگر را نیز دریافت کنید
            }
        }

        private void pic_search_name_Click(object sender, EventArgs e)
        {
            DataTable dt = moshTableTableAdapter.GetMoshName(txt_mosh_name.Text);
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

        private void txt_mosh_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_mosh_name.Text.Length == 0)
            {
                dataGridView1.DataSource = moshTableBindingSource;
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

