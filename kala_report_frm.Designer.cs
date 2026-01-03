namespace Lebas_Shop
{
    partial class kala_report_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kala_report_frm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kalaCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaMojodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_bootik_lebasDataSet = new Lebas_Shop.db_bootik_lebasDataSet();
            this.kalaTableTableAdapter = new Lebas_Shop.db_bootik_lebasDataSetTableAdapters.kalaTableTableAdapter();
            this.btn_search_name = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_search_name = new System.Windows.Forms.TextBox();
            this.pic_print = new System.Windows.Forms.PictureBox();
            this.pic_search_date = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-8, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 385);
            this.panel1.TabIndex = 0;
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
            this.dataGridView1.Size = new System.Drawing.Size(860, 385);
            this.dataGridView1.TabIndex = 0;
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
            this.kalaPriceDataGridViewTextBoxColumn.HeaderText = "قیمت واحد";
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
            // btn_search_name
            // 
            this.btn_search_name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_search_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_name.ForeColor = System.Drawing.Color.White;
            this.btn_search_name.Location = new System.Drawing.Point(16, 21);
            this.btn_search_name.Name = "btn_search_name";
            this.btn_search_name.Size = new System.Drawing.Size(141, 40);
            this.btn_search_name.TabIndex = 2;
            this.btn_search_name.Text = "جستجوی نام";
            this.btn_search_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search_name.UseVisualStyleBackColor = false;
            this.btn_search_name.Click += new System.EventHandler(this.btn_search_name_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(364, 22);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(142, 40);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "چاپ گزارش";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "تاریخ : ";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(618, 26);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(91, 33);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "lbl_date";
            // 
            // txt_search_name
            // 
            this.txt_search_name.Location = new System.Drawing.Point(172, 21);
            this.txt_search_name.Name = "txt_search_name";
            this.txt_search_name.Size = new System.Drawing.Size(144, 40);
            this.txt_search_name.TabIndex = 7;
            this.txt_search_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search_name.TextChanged += new System.EventHandler(this.txt_search_name_TextChanged);
            this.txt_search_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_name_KeyDown);
            // 
            // pic_print
            // 
            this.pic_print.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_print.Image = global::Lebas_Shop.Properties.Resources.print;
            this.pic_print.Location = new System.Drawing.Point(469, 30);
            this.pic_print.Name = "pic_print";
            this.pic_print.Size = new System.Drawing.Size(31, 25);
            this.pic_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_print.TabIndex = 4;
            this.pic_print.TabStop = false;
            this.pic_print.Click += new System.EventHandler(this.pic_print_Click);
            // 
            // pic_search_date
            // 
            this.pic_search_date.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_search_date.Image = global::Lebas_Shop.Properties.Resources.search;
            this.pic_search_date.Location = new System.Drawing.Point(119, 28);
            this.pic_search_date.Name = "pic_search_date";
            this.pic_search_date.Size = new System.Drawing.Size(31, 25);
            this.pic_search_date.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_search_date.TabIndex = 4;
            this.pic_search_date.TabStop = false;
            this.pic_search_date.Click += new System.EventHandler(this.pic_search_date_Click);
            // 
            // pic_close
            // 
            this.pic_close.Image = global::Lebas_Shop.Properties.Resources.left_arrow_button_icon;
            this.pic_close.Location = new System.Drawing.Point(797, 5);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(35, 33);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 1;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.Key = "5cbcb840c15f4f3494e4a27ebeedb735";
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "8f53c12923e04186be871c91ece57bec";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // kala_report_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(844, 479);
            this.ControlBox = false;
            this.Controls.Add(this.txt_search_name);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_print);
            this.Controls.Add(this.pic_search_date);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_search_name);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kala_report_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش کالا";
            this.Load += new System.EventHandler(this.kala_report_frm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pic_close;
        private db_bootik_lebasDataSet db_bootik_lebasDataSet;
        private System.Windows.Forms.BindingSource kalaTableBindingSource;
        private db_bootik_lebasDataSetTableAdapters.kalaTableTableAdapter kalaTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaMojodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_search_name;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.PictureBox pic_search_date;
        private System.Windows.Forms.PictureBox pic_print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txt_search_name;
        private Stimulsoft.Report.StiReport stiReport1;
    }
}