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
    public partial class user_query_frm : Form
    {
        public user_query_frm()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void user_query_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_bootik_lebasDataSet.userTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.db_bootik_lebasDataSet.userTable);

        }

        void clearForm()
        {
            txt_user_cod.Clear();
            txt_username.Clear();
            txt_password.Clear();
            cmb_user_type.Text = "";
            txt_user_cod.Focus();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if (txt_username.Text.Length == 0)
            {
                dataGridView1.DataSource = userTableBindingSource;
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Length == 0)
            {
                MessageBox.Show("برخی فیلد ها مقداردهی نشده");
                return;
            }
            else
            {
                int k = userTableTableAdapter.InsertUser(txt_username.Text, txt_password.Text, cmb_user_type.SelectedItem.ToString());
                if (k > 0)
                {
                    this.userTableTableAdapter.Fill(this.db_bootik_lebasDataSet.userTable);
                    MessageBox.Show("رکورد جدید اضافه شد");
                    clearForm();
                    return;
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Length == 0)
            {
                MessageBox.Show("برخی فیلد ها مقداردهی نشده");
                return;
            }
            else
            {
                int k = userTableTableAdapter.DeleteUser(int.Parse(txt_user_cod.Text));
                if (k > 0)
                {
                    this.userTableTableAdapter.Fill(this.db_bootik_lebasDataSet.userTable);
                    MessageBox.Show("رکورد مورد نظر حذف شد");
                    clearForm();
                    return;
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Length == 0)
            {
                MessageBox.Show("برخی فیلد ها مقداردهی نشده");
                return;
            }
            else
            {
                int k = userTableTableAdapter.UpdateUser(txt_username.Text, txt_password.Text, cmb_user_type.SelectedItem.ToString(), int.Parse(txt_user_cod.Text));
                if (k > 0)
                {
                    this.userTableTableAdapter.Fill(this.db_bootik_lebasDataSet.userTable);
                    MessageBox.Show("رکورد مورد نظر ویرایش شد");
                    clearForm();
                    return;
                }
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

        private void txt_user_cod_TextChanged(object sender, EventArgs e)
        {
            if (txt_user_cod.Text.Length == 0)
            {
                clearForm();
                return;
            }
        }

        private void txt_user_cod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 'a' && e.KeyValue <= 'z' || e.KeyValue >= 'A' && e.KeyValue <= 'Z')
            {
                MessageBox.Show("لطفا عدد وارد کنید");
                txt_user_cod.Clear();
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = userTableTableAdapter.GetUserCod(int.Parse(txt_user_cod.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("چنین کدی وجود ندارد");
                    txt_user_cod.Clear();
                    txt_user_cod.Focus();
                    return;
                }

                txt_username.Text = dt.Rows[0][1].ToString();
                txt_password.Text = dt.Rows[0][2].ToString();
                cmb_user_type.Text = dt.Rows[0][3].ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // اطمینان از اینکه سطر انتخاب شده معتبر است
            if (e.RowIndex >= 0)
            {
                // دریافت مقادیر از سطر انتخاب شده
                txt_user_cod.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); // مقدار ستون اول
                txt_username.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); // مقدار ستون دوم
                txt_password.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmb_user_type.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();// می‌توانید به همین ترتیب مقادیر دیگر را نیز دریافت کنید
            }
        }

        private void pic_username_Click(object sender, EventArgs e)
        {
            DataTable dt = userTableTableAdapter.GetUserName(txt_username.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("چنین نام کاربری وجود ندارد");
                return;
            }
            else
            {
                dataGridView1.DataSource = dt;
                dataGridView1.DefaultCellStyle.BackColor = Color.PaleTurquoise;
            }
        }
    }
}
