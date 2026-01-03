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
    public partial class color_frm : Form
    {
        public color_frm()
        {
            InitializeComponent();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void color_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_bootik_lebasDataSet.optionTable' table. You can move, or remove it, as needed.
            this.optionTableTableAdapter.Fill(this.db_bootik_lebasDataSet.optionTable);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (lbl_color.BackColor.ToArgb().ToString() == "-986896")
            {
                MessageBox.Show("رنگ را انتخاب کنید");
                return;
            }
            else
            {
                int k = optionTableTableAdapter.UpdateColor(1, lbl_color.BackColor.ToArgb().ToString());
                if (k > 0)
                {
                    MessageBox.Show("تغییرات ذخیره شد");
                    return;
                }
            }
        }

        private void pic_select_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_color.BackColor = colorDialog1.Color;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            btn_save_Click(null, null);
        }
    }
}
