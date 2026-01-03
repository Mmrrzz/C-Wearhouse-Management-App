namespace Lebas_Shop
{
    partial class user_query_frm
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
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWoordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_bootik_lebasDataSet = new Lebas_Shop.db_bootik_lebasDataSet();
            this.userTableTableAdapter = new Lebas_Shop.db_bootik_lebasDataSetTableAdapters.userTableTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_username = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_delete = new System.Windows.Forms.PictureBox();
            this.pic_update = new System.Windows.Forms.PictureBox();
            this.pic_insert = new System.Windows.Forms.PictureBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.cmb_user_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_insert)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_close
            // 
            this.pic_close.Image = global::Lebas_Shop.Properties.Resources.left_arrow_button_icon;
            this.pic_close.Location = new System.Drawing.Point(936, 3);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(51, 35);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 0;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-8, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 300);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userCodDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passWoordDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userTableBindingSource;
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
            this.dataGridView1.Size = new System.Drawing.Size(1008, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // userCodDataGridViewTextBoxColumn
            // 
            this.userCodDataGridViewTextBoxColumn.DataPropertyName = "userCod";
            this.userCodDataGridViewTextBoxColumn.HeaderText = "کد کاربر";
            this.userCodDataGridViewTextBoxColumn.Name = "userCodDataGridViewTextBoxColumn";
            this.userCodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "نام کاربری";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passWoordDataGridViewTextBoxColumn
            // 
            this.passWoordDataGridViewTextBoxColumn.DataPropertyName = "passWoord";
            this.passWoordDataGridViewTextBoxColumn.HeaderText = "رمز عبور";
            this.passWoordDataGridViewTextBoxColumn.Name = "passWoordDataGridViewTextBoxColumn";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "userType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "نوع کاربر";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "userTable";
            this.userTableBindingSource.DataSource = this.db_bootik_lebasDataSet;
            // 
            // db_bootik_lebasDataSet
            // 
            this.db_bootik_lebasDataSet.DataSetName = "db_bootik_lebasDataSet";
            this.db_bootik_lebasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.pic_username);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pic_delete);
            this.groupBox1.Controls.Add(this.pic_update);
            this.groupBox1.Controls.Add(this.pic_insert);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.cmb_user_type);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_user_cod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pic_username
            // 
            this.pic_username.Image = global::Lebas_Shop.Properties.Resources.search;
            this.pic_username.Location = new System.Drawing.Point(736, 14);
            this.pic_username.Name = "pic_username";
            this.pic_username.Size = new System.Drawing.Size(33, 31);
            this.pic_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_username.TabIndex = 19;
            this.pic_username.TabStop = false;
            this.pic_username.Click += new System.EventHandler(this.pic_username_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lebas_Shop.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(5, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pic_delete
            // 
            this.pic_delete.BackColor = System.Drawing.Color.DarkRed;
            this.pic_delete.Image = global::Lebas_Shop.Properties.Resources.delete;
            this.pic_delete.Location = new System.Drawing.Point(480, 110);
            this.pic_delete.Name = "pic_delete";
            this.pic_delete.Size = new System.Drawing.Size(33, 29);
            this.pic_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_delete.TabIndex = 15;
            this.pic_delete.TabStop = false;
            this.pic_delete.Click += new System.EventHandler(this.pic_delete_Click);
            // 
            // pic_update
            // 
            this.pic_update.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_update.Image = global::Lebas_Shop.Properties.Resources.update;
            this.pic_update.Location = new System.Drawing.Point(196, 110);
            this.pic_update.Name = "pic_update";
            this.pic_update.Size = new System.Drawing.Size(36, 29);
            this.pic_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_update.TabIndex = 16;
            this.pic_update.TabStop = false;
            this.pic_update.Click += new System.EventHandler(this.pic_update_Click);
            // 
            // pic_insert
            // 
            this.pic_insert.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_insert.Image = global::Lebas_Shop.Properties.Resources.add2;
            this.pic_insert.Location = new System.Drawing.Point(775, 110);
            this.pic_insert.Name = "pic_insert";
            this.pic_insert.Size = new System.Drawing.Size(36, 29);
            this.pic_insert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_insert.TabIndex = 17;
            this.pic_insert.TabStop = false;
            this.pic_insert.Click += new System.EventHandler(this.pic_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(183, 104);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 42);
            this.btn_update.TabIndex = 12;
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
            this.btn_delete.Location = new System.Drawing.Point(467, 104);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(127, 42);
            this.btn_delete.TabIndex = 13;
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
            this.btn_insert.Location = new System.Drawing.Point(764, 104);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(127, 42);
            this.btn_insert.TabIndex = 14;
            this.btn_insert.Text = "افزودن";
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // cmb_user_type
            // 
            this.cmb_user_type.FormattingEnabled = true;
            this.cmb_user_type.Items.AddRange(new object[] {
            "مدیر",
            "عادی"});
            this.cmb_user_type.Location = new System.Drawing.Point(183, 12);
            this.cmb_user_type.Name = "cmb_user_type";
            this.cmb_user_type.Size = new System.Drawing.Size(82, 41);
            this.cmb_user_type.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "نوع کاربر";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(359, 11);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(105, 40);
            this.txt_password.TabIndex = 2;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "رمز عبور";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(555, 11);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(102, 40);
            this.txt_username.TabIndex = 1;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام کاربری";
            // 
            // txt_user_cod
            // 
            this.txt_user_cod.Location = new System.Drawing.Point(798, 11);
            this.txt_user_cod.Name = "txt_user_cod";
            this.txt_user_cod.Size = new System.Drawing.Size(62, 40);
            this.txt_user_cod.TabIndex = 0;
            this.txt_user_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_user_cod.TextChanged += new System.EventHandler(this.txt_user_cod_TextChanged);
            this.txt_user_cod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_user_cod_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(864, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد";
            // 
            // user_query_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(992, 498);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_close);
            this.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "user_query_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کاربران";
            this.Load += new System.EventHandler(this.user_query_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_insert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_bootik_lebasDataSet db_bootik_lebasDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private db_bootik_lebasDataSetTableAdapters.userTableTableAdapter userTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWoordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_user_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_delete;
        private System.Windows.Forms.PictureBox pic_update;
        private System.Windows.Forms.PictureBox pic_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
    }
}