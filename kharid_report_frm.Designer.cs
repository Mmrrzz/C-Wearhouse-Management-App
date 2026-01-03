namespace Lebas_Shop
{
    partial class kharid_report_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kharid_report_frm));
            this.cmb_search_date = new System.Windows.Forms.ComboBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_search_date = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_add_date = new System.Windows.Forms.PictureBox();
            this.pic_print = new System.Windows.Forms.PictureBox();
            this.pic_search_date = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.factCodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaTedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kharidFactorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_bootik_lebasDataSet = new Lebas_Shop.db_bootik_lebasDataSet();
            this.kharidFactorTableAdapter = new Lebas_Shop.db_bootik_lebasDataSetTableAdapters.kharidFactorTableAdapter();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.pic_add_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kharidFactorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_search_date
            // 
            this.cmb_search_date.FormattingEnabled = true;
            this.cmb_search_date.Items.AddRange(new object[] {
            "1403/9/24",
            "1403/9/25",
            "1403/9/26",
            "1403/10/2",
            "1403/10/3",
            "1403/10/4",
            "1403/10/5"});
            this.cmb_search_date.Location = new System.Drawing.Point(214, 36);
            this.cmb_search_date.Name = "cmb_search_date";
            this.cmb_search_date.Size = new System.Drawing.Size(121, 41);
            this.cmb_search_date.TabIndex = 19;
            this.cmb_search_date.TextChanged += new System.EventHandler(this.cmb_search_date_TextChanged);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(438, 36);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(136, 41);
            this.btn_print.TabIndex = 17;
            this.btn_print.Text = "چاپ فاکتور";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_search_date
            // 
            this.btn_search_date.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_search_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_date.ForeColor = System.Drawing.Color.White;
            this.btn_search_date.Location = new System.Drawing.Point(25, 36);
            this.btn_search_date.Name = "btn_search_date";
            this.btn_search_date.Size = new System.Drawing.Size(164, 41);
            this.btn_search_date.TabIndex = 18;
            this.btn_search_date.Text = "جستجوی تاریخ";
            this.btn_search_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search_date.UseVisualStyleBackColor = false;
            this.btn_search_date.Click += new System.EventHandler(this.btn_search_date_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(724, 43);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(91, 33);
            this.lbl_date.TabIndex = 15;
            this.lbl_date.Text = "lbl_date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "تاریخ : ";
            // 
            // pic_add_date
            // 
            this.pic_add_date.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_add_date.Image = global::Lebas_Shop.Properties.Resources.add2;
            this.pic_add_date.Location = new System.Drawing.Point(633, 42);
            this.pic_add_date.Name = "pic_add_date";
            this.pic_add_date.Size = new System.Drawing.Size(36, 27);
            this.pic_add_date.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_add_date.TabIndex = 20;
            this.pic_add_date.TabStop = false;
            this.pic_add_date.Click += new System.EventHandler(this.pic_add_date_Click);
            // 
            // pic_print
            // 
            this.pic_print.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_print.Image = global::Lebas_Shop.Properties.Resources.print;
            this.pic_print.Location = new System.Drawing.Point(529, 43);
            this.pic_print.Name = "pic_print";
            this.pic_print.Size = new System.Drawing.Size(36, 27);
            this.pic_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_print.TabIndex = 21;
            this.pic_print.TabStop = false;
            this.pic_print.Click += new System.EventHandler(this.pic_print_Click);
            // 
            // pic_search_date
            // 
            this.pic_search_date.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_search_date.Image = global::Lebas_Shop.Properties.Resources.search;
            this.pic_search_date.Location = new System.Drawing.Point(144, 42);
            this.pic_search_date.Name = "pic_search_date";
            this.pic_search_date.Size = new System.Drawing.Size(36, 27);
            this.pic_search_date.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_search_date.TabIndex = 22;
            this.pic_search_date.TabStop = false;
            this.pic_search_date.Click += new System.EventHandler(this.pic_search_date_Click);
            // 
            // pic_close
            // 
            this.pic_close.Image = global::Lebas_Shop.Properties.Resources.left_arrow_button_icon;
            this.pic_close.Location = new System.Drawing.Point(915, 9);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(53, 36);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 14;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-7, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 337);
            this.panel1.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factCodDataGridViewTextBoxColumn,
            this.kalaNameDataGridViewTextBoxColumn,
            this.kalaTedadDataGridViewTextBoxColumn,
            this.kalaPriceDataGridViewTextBoxColumn,
            this.factDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kharidFactorBindingSource;
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
            this.dataGridView1.Size = new System.Drawing.Size(994, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // factCodDataGridViewTextBoxColumn
            // 
            this.factCodDataGridViewTextBoxColumn.DataPropertyName = "factCod";
            this.factCodDataGridViewTextBoxColumn.HeaderText = "کد فاکتور";
            this.factCodDataGridViewTextBoxColumn.Name = "factCodDataGridViewTextBoxColumn";
            this.factCodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalaNameDataGridViewTextBoxColumn
            // 
            this.kalaNameDataGridViewTextBoxColumn.DataPropertyName = "kalaName";
            this.kalaNameDataGridViewTextBoxColumn.HeaderText = "نام کالا";
            this.kalaNameDataGridViewTextBoxColumn.Name = "kalaNameDataGridViewTextBoxColumn";
            // 
            // kalaTedadDataGridViewTextBoxColumn
            // 
            this.kalaTedadDataGridViewTextBoxColumn.DataPropertyName = "kalaTedad";
            this.kalaTedadDataGridViewTextBoxColumn.HeaderText = "تعداد";
            this.kalaTedadDataGridViewTextBoxColumn.Name = "kalaTedadDataGridViewTextBoxColumn";
            // 
            // kalaPriceDataGridViewTextBoxColumn
            // 
            this.kalaPriceDataGridViewTextBoxColumn.DataPropertyName = "kalaPrice";
            this.kalaPriceDataGridViewTextBoxColumn.HeaderText = "قیمت واحد";
            this.kalaPriceDataGridViewTextBoxColumn.Name = "kalaPriceDataGridViewTextBoxColumn";
            // 
            // factDateDataGridViewTextBoxColumn
            // 
            this.factDateDataGridViewTextBoxColumn.DataPropertyName = "factDate";
            this.factDateDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.factDateDataGridViewTextBoxColumn.Name = "factDateDataGridViewTextBoxColumn";
            // 
            // kharidFactorBindingSource
            // 
            this.kharidFactorBindingSource.DataMember = "kharidFactor";
            this.kharidFactorBindingSource.DataSource = this.db_bootik_lebasDataSet;
            // 
            // db_bootik_lebasDataSet
            // 
            this.db_bootik_lebasDataSet.DataSetName = "db_bootik_lebasDataSet";
            this.db_bootik_lebasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kharidFactorTableAdapter
            // 
            this.kharidFactorTableAdapter.ClearBeforeFill = true;
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.Key = "12c022025c9b4d89a7dfa7a2ec929374";
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
            this.stiReport1.ReportGuid = "0f13a4b1a4e549039bcc3897d4d022b4";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // kharid_report_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(977, 478);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_add_date);
            this.Controls.Add(this.pic_print);
            this.Controls.Add(this.pic_search_date);
            this.Controls.Add(this.cmb_search_date);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_search_date);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_close);
            this.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kharid_report_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست خرید";
            this.Load += new System.EventHandler(this.kharid_report_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_add_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kharidFactorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_add_date;
        private System.Windows.Forms.PictureBox pic_print;
        private System.Windows.Forms.PictureBox pic_search_date;
        private System.Windows.Forms.ComboBox cmb_search_date;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_search_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_bootik_lebasDataSet db_bootik_lebasDataSet;
        private System.Windows.Forms.BindingSource kharidFactorBindingSource;
        private db_bootik_lebasDataSetTableAdapters.kharidFactorTableAdapter kharidFactorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn factCodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaTedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factDateDataGridViewTextBoxColumn;
        private Stimulsoft.Report.StiReport stiReport1;
    }
}