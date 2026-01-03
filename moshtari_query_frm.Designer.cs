namespace Lebas_Shop
{
    partial class moshtari_query_frm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.moshCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_bootik_lebasDataSet = new Lebas_Shop.db_bootik_lebasDataSet();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.moshTableTableAdapter = new Lebas_Shop.db_bootik_lebasDataSetTableAdapters.moshTableTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_search_name = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_delete = new System.Windows.Forms.PictureBox();
            this.pic_update = new System.Windows.Forms.PictureBox();
            this.pic_insert = new System.Windows.Forms.PictureBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_mosh_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mosh_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mosh_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mosh_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moshTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_insert)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-8, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 301);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moshCodDataGridViewTextBoxColumn,
            this.moshNameDataGridViewTextBoxColumn,
            this.moshPhoneDataGridViewTextBoxColumn,
            this.moshAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.moshTableBindingSource;
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
            this.dataGridView1.Size = new System.Drawing.Size(1099, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // moshCodDataGridViewTextBoxColumn
            // 
            this.moshCodDataGridViewTextBoxColumn.DataPropertyName = "moshCod";
            this.moshCodDataGridViewTextBoxColumn.HeaderText = "کد مشتری";
            this.moshCodDataGridViewTextBoxColumn.Name = "moshCodDataGridViewTextBoxColumn";
            this.moshCodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moshNameDataGridViewTextBoxColumn
            // 
            this.moshNameDataGridViewTextBoxColumn.DataPropertyName = "moshName";
            this.moshNameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.moshNameDataGridViewTextBoxColumn.Name = "moshNameDataGridViewTextBoxColumn";
            // 
            // moshPhoneDataGridViewTextBoxColumn
            // 
            this.moshPhoneDataGridViewTextBoxColumn.DataPropertyName = "moshPhone";
            this.moshPhoneDataGridViewTextBoxColumn.HeaderText = "شماره تلفن";
            this.moshPhoneDataGridViewTextBoxColumn.Name = "moshPhoneDataGridViewTextBoxColumn";
            // 
            // moshAddressDataGridViewTextBoxColumn
            // 
            this.moshAddressDataGridViewTextBoxColumn.DataPropertyName = "moshAddress";
            this.moshAddressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.moshAddressDataGridViewTextBoxColumn.Name = "moshAddressDataGridViewTextBoxColumn";
            // 
            // moshTableBindingSource
            // 
            this.moshTableBindingSource.DataMember = "moshTable";
            this.moshTableBindingSource.DataSource = this.db_bootik_lebasDataSet;
            // 
            // db_bootik_lebasDataSet
            // 
            this.db_bootik_lebasDataSet.DataSetName = "db_bootik_lebasDataSet";
            this.db_bootik_lebasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pic_close
            // 
            this.pic_close.Image = global::Lebas_Shop.Properties.Resources.left_arrow_button_icon;
            this.pic_close.Location = new System.Drawing.Point(1038, 3);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(38, 35);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 1;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // moshTableTableAdapter
            // 
            this.moshTableTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.pic_search_name);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pic_delete);
            this.groupBox1.Controls.Add(this.pic_update);
            this.groupBox1.Controls.Add(this.pic_insert);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.txt_mosh_address);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_mosh_phone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_mosh_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_mosh_cod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pic_search_name
            // 
            this.pic_search_name.Image = global::Lebas_Shop.Properties.Resources.search;
            this.pic_search_name.Location = new System.Drawing.Point(803, 26);
            this.pic_search_name.Name = "pic_search_name";
            this.pic_search_name.Size = new System.Drawing.Size(30, 32);
            this.pic_search_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_search_name.TabIndex = 13;
            this.pic_search_name.TabStop = false;
            this.pic_search_name.Click += new System.EventHandler(this.pic_search_name_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lebas_Shop.Properties.Resources.buyer;
            this.pictureBox1.Location = new System.Drawing.Point(19, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pic_delete
            // 
            this.pic_delete.BackColor = System.Drawing.Color.DarkRed;
            this.pic_delete.Image = global::Lebas_Shop.Properties.Resources.delete;
            this.pic_delete.Location = new System.Drawing.Point(560, 124);
            this.pic_delete.Name = "pic_delete";
            this.pic_delete.Size = new System.Drawing.Size(33, 29);
            this.pic_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_delete.TabIndex = 9;
            this.pic_delete.TabStop = false;
            this.pic_delete.Click += new System.EventHandler(this.pic_delete_Click);
            // 
            // pic_update
            // 
            this.pic_update.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_update.Image = global::Lebas_Shop.Properties.Resources.update;
            this.pic_update.Location = new System.Drawing.Point(215, 124);
            this.pic_update.Name = "pic_update";
            this.pic_update.Size = new System.Drawing.Size(36, 29);
            this.pic_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_update.TabIndex = 10;
            this.pic_update.TabStop = false;
            this.pic_update.Click += new System.EventHandler(this.pic_update_Click);
            // 
            // pic_insert
            // 
            this.pic_insert.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_insert.Image = global::Lebas_Shop.Properties.Resources.add2;
            this.pic_insert.Location = new System.Drawing.Point(864, 124);
            this.pic_insert.Name = "pic_insert";
            this.pic_insert.Size = new System.Drawing.Size(36, 29);
            this.pic_insert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_insert.TabIndex = 11;
            this.pic_insert.TabStop = false;
            this.pic_insert.Click += new System.EventHandler(this.pic_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(202, 118);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 42);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "ویرایش";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkRed;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(547, 118);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(127, 42);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "حذف";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.Location = new System.Drawing.Point(853, 118);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(127, 42);
            this.btn_insert.TabIndex = 8;
            this.btn_insert.Text = "افزودن";
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_mosh_address
            // 
            this.txt_mosh_address.Location = new System.Drawing.Point(202, 24);
            this.txt_mosh_address.Name = "txt_mosh_address";
            this.txt_mosh_address.Size = new System.Drawing.Size(145, 40);
            this.txt_mosh_address.TabIndex = 3;
            this.txt_mosh_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "آدرس";
            // 
            // txt_mosh_phone
            // 
            this.txt_mosh_phone.Location = new System.Drawing.Point(415, 24);
            this.txt_mosh_phone.Name = "txt_mosh_phone";
            this.txt_mosh_phone.Size = new System.Drawing.Size(129, 40);
            this.txt_mosh_phone.TabIndex = 2;
            this.txt_mosh_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mosh_phone.TextChanged += new System.EventHandler(this.txt_mosh_phone_TextChanged);
            this.txt_mosh_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mosh_phone_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "شماره تلفن";
            // 
            // txt_mosh_name
            // 
            this.txt_mosh_name.Location = new System.Drawing.Point(638, 24);
            this.txt_mosh_name.Name = "txt_mosh_name";
            this.txt_mosh_name.Size = new System.Drawing.Size(133, 40);
            this.txt_mosh_name.TabIndex = 1;
            this.txt_mosh_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mosh_name.TextChanged += new System.EventHandler(this.txt_mosh_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام";
            // 
            // txt_mosh_cod
            // 
            this.txt_mosh_cod.Location = new System.Drawing.Point(853, 24);
            this.txt_mosh_cod.Name = "txt_mosh_cod";
            this.txt_mosh_cod.Size = new System.Drawing.Size(80, 40);
            this.txt_mosh_cod.TabIndex = 0;
            this.txt_mosh_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mosh_cod.TextChanged += new System.EventHandler(this.txt_mosh_cod_TextChanged);
            this.txt_mosh_cod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mosh_cod_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(933, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد مشتری";
            // 
            // moshtari_query_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1084, 532);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "moshtari_query_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشتری";
            this.Load += new System.EventHandler(this.moshtari_query_frm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moshTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_insert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_bootik_lebasDataSet db_bootik_lebasDataSet;
        private System.Windows.Forms.BindingSource moshTableBindingSource;
        private db_bootik_lebasDataSetTableAdapters.moshTableTableAdapter moshTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_mosh_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mosh_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mosh_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mosh_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_delete;
        private System.Windows.Forms.PictureBox pic_update;
        private System.Windows.Forms.PictureBox pic_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_search_name;
    }
}