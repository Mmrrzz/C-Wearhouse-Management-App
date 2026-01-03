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
    public partial class background_frm : Form
    {
        public background_frm()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void background_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_bootik_lebasDataSet.optionTable' table. You can move, or remove it, as needed.
            this.optionTableTableAdapter.Fill(this.db_bootik_lebasDataSet.optionTable);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "openFileDialog1")
            {
                MessageBox.Show("تصویر را انتخاب کنید");
                return;
            }
            else
            {
                int k = optionTableTableAdapter.UpdatePicture(1, openFileDialog1.FileName);
                if (k > 0)
                {
                    MessageBox.Show("تغییرات ذخیره شد");
                    return;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            btn_save_Click(null, null);
        }

        private void pic_select_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Picture File | *.jpg;*.png;*.jpeg; | All Files | *.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pic_backgr.ImageLocation = openFileDialog1.FileName;
        }
    }
}
