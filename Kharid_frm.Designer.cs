namespace Lebas_Shop
{
    partial class Kharid_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_add = new System.Windows.Forms.PictureBox();
            this.txt_kala_tedad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kala_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kala_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kala_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_jam_kol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kalaCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalatedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaJam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pic_print = new System.Windows.Forms.PictureBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pic_show_kala = new System.Windows.Forms.PictureBox();
            this.pic_save = new System.Windows.Forms.PictureBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_show_kala = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.db_bootik_lebasDataSet = new Lebas_Shop.db_bootik_lebasDataSet();
            this.kalaTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kalaTableTableAdapter = new Lebas_Shop.db_bootik_lebasDataSetTableAdapters.kalaTableTableAdapter();
            this.kharidFactorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kharidFactorTableAdapter = new Lebas_Shop.db_bootik_lebasDataSetTableAdapters.kharidFactorTableAdapter();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_add)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_show_kala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kharidFactorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.pic_add);
            this.groupBox1.Controls.Add(this.txt_kala_tedad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_kala_price);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_kala_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_kala_cod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pic_add
            // 
            this.pic_add.Image = global::Lebas_Shop.Properties.Resources.add2;
            this.pic_add.Location = new System.Drawing.Point(46, 18);
            this.pic_add.Name = "pic_add";
            this.pic_add.Size = new System.Drawing.Size(75, 61);
            this.pic_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_add.TabIndex = 2;
            this.pic_add.TabStop = false;
            this.pic_add.Click += new System.EventHandler(this.pic_add_Click);
            // 
            // txt_kala_tedad
            // 
            this.txt_kala_tedad.Location = new System.Drawing.Point(152, 29);
            this.txt_kala_tedad.Name = "txt_kala_tedad";
            this.txt_kala_tedad.Size = new System.Drawing.Size(95, 40);
            this.txt_kala_tedad.TabIndex = 1;
            this.txt_kala_tedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_kala_tedad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_kala_tedad_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "تعداد";
            // 
            // txt_kala_price
            // 
            this.txt_kala_price.Location = new System.Drawing.Point(346, 29);
            this.txt_kala_price.Name = "txt_kala_price";
            this.txt_kala_price.ReadOnly = true;
            this.txt_kala_price.Size = new System.Drawing.Size(93, 40);
            this.txt_kala_price.TabIndex = 1;
            this.txt_kala_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "قیمت";
            // 
            // txt_kala_name
            // 
            this.txt_kala_name.Location = new System.Drawing.Point(536, 29);
            this.txt_kala_name.Name = "txt_kala_name";
            this.txt_kala_name.ReadOnly = true;
            this.txt_kala_name.Size = new System.Drawing.Size(133, 40);
            this.txt_kala_name.TabIndex = 1;
            this.txt_kala_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام";
            // 
            // txt_kala_cod
            // 
            this.txt_kala_cod.Location = new System.Drawing.Point(743, 29);
            this.txt_kala_cod.Name = "txt_kala_cod";
            this.txt_kala_cod.Size = new System.Drawing.Size(89, 40);
            this.txt_kala_cod.TabIndex = 0;
            this.txt_kala_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_kala_cod.TextChanged += new System.EventHandler(this.txt_kala_cod_TextChanged);
            this.txt_kala_cod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_kala_cod_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(838, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد کالا";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_jam_kol);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-8, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 297);
            this.panel1.TabIndex = 1;
            // 
            // txt_jam_kol
            // 
            this.txt_jam_kol.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_jam_kol.Location = new System.Drawing.Point(28, 237);
            this.txt_jam_kol.Name = "txt_jam_kol";
            this.txt_jam_kol.Size = new System.Drawing.Size(152, 40);
            this.txt_jam_kol.TabIndex = 4;
            this.txt_jam_kol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(184, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "جمع کل";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kalaCod,
            this.kalaName,
            this.kalaprice,
            this.kalatedad,
            this.kalaJam});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(984, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // kalaCod
            // 
            this.kalaCod.HeaderText = "کد کالا";
            this.kalaCod.Name = "kalaCod";
            // 
            // kalaName
            // 
            this.kalaName.HeaderText = "نام کالا";
            this.kalaName.Name = "kalaName";
            // 
            // kalaprice
            // 
            this.kalaprice.HeaderText = "قیمت واحد";
            this.kalaprice.Name = "kalaprice";
            // 
            // kalatedad
            // 
            this.kalatedad.HeaderText = "تعداد خرید";
            this.kalatedad.Name = "kalatedad";
            // 
            // kalaJam
            // 
            this.kalaJam.HeaderText = "جمع ردیف";
            this.kalaJam.Name = "kalaJam";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Red;
            this.contextMenuStrip1.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 42);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(126, 38);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.pic_print);
            this.groupBox2.Controls.Add(this.lbl_date);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pic_show_kala);
            this.groupBox2.Controls.Add(this.pic_save);
            this.groupBox2.Controls.Add(this.btn_print);
            this.groupBox2.Controls.Add(this.btn_show_kala);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Location = new System.Drawing.Point(4, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(963, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // pic_print
            // 
            this.pic_print.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_print.Image = global::Lebas_Shop.Properties.Resources.print;
            this.pic_print.Location = new System.Drawing.Point(457, 23);
            this.pic_print.Name = "pic_print";
            this.pic_print.Size = new System.Drawing.Size(32, 28);
            this.pic_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_print.TabIndex = 3;
            this.pic_print.TabStop = false;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_date.Location = new System.Drawing.Point(91, 29);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(91, 33);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "lbl_date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(178, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "تاریخ : ";
            // 
            // pic_show_kala
            // 
            this.pic_show_kala.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_show_kala.Image = global::Lebas_Shop.Properties.Resources.dress;
            this.pic_show_kala.Location = new System.Drawing.Point(648, 23);
            this.pic_show_kala.Name = "pic_show_kala";
            this.pic_show_kala.Size = new System.Drawing.Size(32, 28);
            this.pic_show_kala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_show_kala.TabIndex = 3;
            this.pic_show_kala.TabStop = false;
            this.pic_show_kala.Click += new System.EventHandler(this.pic_show_kala_Click);
            // 
            // pic_save
            // 
            this.pic_save.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_save.Image = global::Lebas_Shop.Properties.Resources.save;
            this.pic_save.Location = new System.Drawing.Point(835, 23);
            this.pic_save.Name = "pic_save";
            this.pic_save.Size = new System.Drawing.Size(32, 28);
            this.pic_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_save.TabIndex = 3;
            this.pic_save.TabStop = false;
            this.pic_save.Click += new System.EventHandler(this.pic_save_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(451, 17);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(134, 42);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "چاپ فاکتور";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_show_kala
            // 
            this.btn_show_kala.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_show_kala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_kala.ForeColor = System.Drawing.Color.White;
            this.btn_show_kala.Location = new System.Drawing.Point(639, 17);
            this.btn_show_kala.Name = "btn_show_kala";
            this.btn_show_kala.Size = new System.Drawing.Size(134, 42);
            this.btn_show_kala.TabIndex = 0;
            this.btn_show_kala.Text = "جدول کالا";
            this.btn_show_kala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show_kala.UseVisualStyleBackColor = false;
            this.btn_show_kala.Click += new System.EventHandler(this.btn_show_kala_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(824, 17);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(119, 42);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "ذخیره";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // db_bootik_lebasDataSet
            // 
            this.db_bootik_lebasDataSet.DataSetName = "db_bootik_lebasDataSet";
            this.db_bootik_lebasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kalaTableBindingSource
            // 
            this.kalaTableBindingSource.DataMember = "kalaTable";
            this.kalaTableBindingSource.DataSource = this.db_bootik_lebasDataSet;
            // 
            // kalaTableTableAdapter
            // 
            this.kalaTableTableAdapter.ClearBeforeFill = true;
            // 
            // kharidFactorBindingSource
            // 
            this.kharidFactorBindingSource.DataMember = "kharidFactor";
            this.kharidFactorBindingSource.DataSource = this.db_bootik_lebasDataSet;
            // 
            // kharidFactorTableAdapter
            // 
            this.kharidFactorTableAdapter.ClearBeforeFill = true;
            // 
            // pic_close
            // 
            this.pic_close.Image = global::Lebas_Shop.Properties.Resources.left_arrow_button_icon;
            this.pic_close.Location = new System.Drawing.Point(920, 6);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(38, 35);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 4;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // Kharid_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(970, 517);
            this.ControlBox = false;
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kharid_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم خرید";
            this.Load += new System.EventHandler(this.Kharid_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_add)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_show_kala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kharidFactorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_add;
        private System.Windows.Forms.TextBox txt_kala_tedad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kala_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kala_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kala_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_jam_kol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalatedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaJam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pic_print;
        private System.Windows.Forms.PictureBox pic_show_kala;
        private System.Windows.Forms.PictureBox pic_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_show_kala;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private db_bootik_lebasDataSet db_bootik_lebasDataSet;
        private System.Windows.Forms.BindingSource kalaTableBindingSource;
        private db_bootik_lebasDataSetTableAdapters.kalaTableTableAdapter kalaTableTableAdapter;
        private System.Windows.Forms.BindingSource kharidFactorBindingSource;
        private db_bootik_lebasDataSetTableAdapters.kharidFactorTableAdapter kharidFactorTableAdapter;
        private System.Windows.Forms.PictureBox pic_close;
    }
}