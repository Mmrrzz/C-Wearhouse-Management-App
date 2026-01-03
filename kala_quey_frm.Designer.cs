namespace Lebas_Shop
{
    partial class kala_quey_frm
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
            this.kalaCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaMojodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_bootik_lebasDataSet = new Lebas_Shop.db_bootik_lebasDataSet();
            this.kalaTableTableAdapter = new Lebas_Shop.db_bootik_lebasDataSetTableAdapters.kalaTableTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_delete = new System.Windows.Forms.PictureBox();
            this.pic_update = new System.Windows.Forms.PictureBox();
            this.pic_insert = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.pic_search_name = new System.Windows.Forms.PictureBox();
            this.txt_kala_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kala_mojodi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kala_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kala_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_insert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-7, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 302);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kalaCodDataGridViewTextBoxColumn,
            this.kalaNameDataGridViewTextBoxColumn,
            this.kalaMojodiDataGridViewTextBoxColumn,
            this.kalaPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kalaTableBindingSource;
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
            this.dataGridView1.Size = new System.Drawing.Size(1018, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kalaCodDataGridViewTextBoxColumn
            // 
            this.kalaCodDataGridViewTextBoxColumn.DataPropertyName = "kalaCod";
            this.kalaCodDataGridViewTextBoxColumn.HeaderText = "کد کالا";
            this.kalaCodDataGridViewTextBoxColumn.Name = "kalaCodDataGridViewTextBoxColumn";
            this.kalaCodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalaNameDataGridViewTextBoxColumn
            // 
            this.kalaNameDataGridViewTextBoxColumn.DataPropertyName = "kalaName";
            this.kalaNameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.kalaNameDataGridViewTextBoxColumn.Name = "kalaNameDataGridViewTextBoxColumn";
            // 
            // kalaMojodiDataGridViewTextBoxColumn
            // 
            this.kalaMojodiDataGridViewTextBoxColumn.DataPropertyName = "kalaMojodi";
            this.kalaMojodiDataGridViewTextBoxColumn.HeaderText = "موجودی";
            this.kalaMojodiDataGridViewTextBoxColumn.Name = "kalaMojodiDataGridViewTextBoxColumn";
            // 
            // kalaPriceDataGridViewTextBoxColumn
            // 
            this.kalaPriceDataGridViewTextBoxColumn.DataPropertyName = "kalaPrice";
            this.kalaPriceDataGridViewTextBoxColumn.HeaderText = "قیمت";
            this.kalaPriceDataGridViewTextBoxColumn.Name = "kalaPriceDataGridViewTextBoxColumn";
            // 
            // kalaTableBindingSource
            // 
            this.kalaTableBindingSource.DataMember = "kalaTable";
            this.kalaTableBindingSource.DataSource = this.db_bootik_lebasDataSet;
            // 
            // db_bootik_lebasDataSet
            // 
            this.db_bootik_lebasDataSet.DataSetName = "db_bootik_lebasDataSet";
            this.db_bootik_lebasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kalaTableTableAdapter
            // 
            this.kalaTableTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.pic_delete);
            this.groupBox1.Controls.Add(this.pic_update);
            this.groupBox1.Controls.Add(this.pic_insert);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.pic_search_name);
            this.groupBox1.Controls.Add(this.txt_kala_price);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_kala_mojodi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_kala_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_kala_cod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pic_delete
            // 
            this.pic_delete.BackColor = System.Drawing.Color.DarkRed;
            this.pic_delete.Image = global::Lebas_Shop.Properties.Resources.delete;
            this.pic_delete.Location = new System.Drawing.Point(512, 140);
            this.pic_delete.Name = "pic_delete";
            this.pic_delete.Size = new System.Drawing.Size(33, 29);
            this.pic_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_delete.TabIndex = 5;
            this.pic_delete.TabStop = false;
            this.pic_delete.Click += new System.EventHandler(this.pic_delete_Click);
            // 
            // pic_update
            // 
            this.pic_update.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_update.Image = global::Lebas_Shop.Properties.Resources.update;
            this.pic_update.Location = new System.Drawing.Point(200, 140);
            this.pic_update.Name = "pic_update";
            this.pic_update.Size = new System.Drawing.Size(36, 29);
            this.pic_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_update.TabIndex = 5;
            this.pic_update.TabStop = false;
            this.pic_update.Click += new System.EventHandler(this.pic_update_Click);
            // 
            // pic_insert
            // 
            this.pic_insert.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_insert.Image = global::Lebas_Shop.Properties.Resources.add2;
            this.pic_insert.Location = new System.Drawing.Point(785, 140);
            this.pic_insert.Name = "pic_insert";
            this.pic_insert.Size = new System.Drawing.Size(36, 29);
            this.pic_insert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_insert.TabIndex = 5;
            this.pic_insert.TabStop = false;
            this.pic_insert.Click += new System.EventHandler(this.pic_insert_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lebas_Shop.Properties.Resources.dress;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(187, 134);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 42);
            this.btn_update.TabIndex = 3;
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
            this.btn_delete.Location = new System.Drawing.Point(499, 134);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(127, 42);
            this.btn_delete.TabIndex = 3;
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
            this.btn_insert.Location = new System.Drawing.Point(774, 134);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(127, 42);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "افزودن";
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // pic_search_name
            // 
            this.pic_search_name.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_search_name.Image = global::Lebas_Shop.Properties.Resources.search;
            this.pic_search_name.Location = new System.Drawing.Point(714, 29);
            this.pic_search_name.Name = "pic_search_name";
            this.pic_search_name.Size = new System.Drawing.Size(40, 33);
            this.pic_search_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_search_name.TabIndex = 2;
            this.pic_search_name.TabStop = false;
            this.pic_search_name.Click += new System.EventHandler(this.pic_search_name_Click);
            // 
            // txt_kala_price
            // 
            this.txt_kala_price.Location = new System.Drawing.Point(187, 26);
            this.txt_kala_price.Name = "txt_kala_price";
            this.txt_kala_price.Size = new System.Drawing.Size(100, 40);
            this.txt_kala_price.TabIndex = 3;
            this.txt_kala_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_kala_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_kala_price_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "قیمت";
            // 
            // txt_kala_mojodi
            // 
            this.txt_kala_mojodi.Location = new System.Drawing.Point(355, 26);
            this.txt_kala_mojodi.Name = "txt_kala_mojodi";
            this.txt_kala_mojodi.Size = new System.Drawing.Size(100, 40);
            this.txt_kala_mojodi.TabIndex = 2;
            this.txt_kala_mojodi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_kala_mojodi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_kala_mojodi_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "موجودی";
            // 
            // txt_kala_name
            // 
            this.txt_kala_name.Location = new System.Drawing.Point(543, 26);
            this.txt_kala_name.Name = "txt_kala_name";
            this.txt_kala_name.Size = new System.Drawing.Size(139, 40);
            this.txt_kala_name.TabIndex = 1;
            this.txt_kala_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام";
            // 
            // txt_kala_cod
            // 
            this.txt_kala_cod.Location = new System.Drawing.Point(775, 26);
            this.txt_kala_cod.Name = "txt_kala_cod";
            this.txt_kala_cod.Size = new System.Drawing.Size(83, 40);
            this.txt_kala_cod.TabIndex = 0;
            this.txt_kala_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_kala_cod.TextChanged += new System.EventHandler(this.txt_kala_cod_TextChanged);
            this.txt_kala_cod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_kala_cod_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(864, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد کالا";
            // 
            // pic_close
            // 
            this.pic_close.Image = global::Lebas_Shop.Properties.Resources.left_arrow_button_icon;
            this.pic_close.Location = new System.Drawing.Point(948, 8);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(46, 35);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 0;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // kala_quey_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1003, 562);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_close);
            this.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kala_quey_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کالا";
            this.Load += new System.EventHandler(this.kala_quey_frm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_insert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_bootik_lebasDataSet db_bootik_lebasDataSet;
        private System.Windows.Forms.BindingSource kalaTableBindingSource;
        private db_bootik_lebasDataSetTableAdapters.kalaTableTableAdapter kalaTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaMojodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.PictureBox pic_search_name;
        private System.Windows.Forms.TextBox txt_kala_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kala_mojodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kala_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kala_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_delete;
        private System.Windows.Forms.PictureBox pic_update;
        private System.Windows.Forms.PictureBox pic_insert;
    }
}