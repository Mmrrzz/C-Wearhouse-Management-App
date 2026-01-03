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

namespace Lebas_Shop
{
    public partial class login_frm : Form
    {
        public login_frm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_eye_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '•')
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '•';
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_username.Clear();
            txt_username.Focus();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            btn_exit_Click(null, null);
        }

        private void login_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_bootik_lebasDataSet.userTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.db_bootik_lebasDataSet.userTable);

            PersianCalendar p_c = new PersianCalendar();
            lbl_date.Text = p_c.GetYear(DateTime.Now).ToString() + "/"
                + p_c.GetMonth(DateTime.Now).ToString() + "/" +
                p_c.GetDayOfMonth(DateTime.Now).ToString();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            DataTable dt = userTableTableAdapter.GetUser(txt_username.Text, txt_password.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("شما اجازه ورود ندارید / نام کاربری یا رمز عبور صحیح نمیباشد", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
                return;
            }

            main_frm m_f = new main_frm();
            if (dt.Rows[0][3].ToString() != "مدیر")
            {
                m_f.گزارشاتToolStripMenuItem.Visible = false;
                m_f.کاربرToolStripMenuItem.Visible = false;
            }

            m_f.ShowDialog();
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(null, null);
            }
        }

        private void pic_login_Click(object sender, EventArgs e)
        {
            btn_login_Click(null, null);
        }
    }
}
