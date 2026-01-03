namespace Lebas_Shop
{
    partial class color_frm
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
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pic_select = new System.Windows.Forms.PictureBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.db_bootik_lebasDataSet = new Lebas_Shop.db_bootik_lebasDataSet();
            this.optionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.optionTableTableAdapter = new Lebas_Shop.db_bootik_lebasDataSetTableAdapters.optionTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_close
            // 
            this.pic_close.Image = global::Lebas_Shop.Properties.Resources.left_arrow_button_icon;
            this.pic_close.Location = new System.Drawing.Point(392, 3);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(36, 32);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 1;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pic_select);
            this.groupBox1.Controls.Add(this.lbl_color);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox3.Image = global::Lebas_Shop.Properties.Resources.save;
            this.pictureBox3.Location = new System.Drawing.Point(205, 135);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pic_select
            // 
            this.pic_select.Image = global::Lebas_Shop.Properties.Resources.color;
            this.pic_select.Location = new System.Drawing.Point(197, 34);
            this.pic_select.Name = "pic_select";
            this.pic_select.Size = new System.Drawing.Size(35, 33);
            this.pic_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_select.TabIndex = 1;
            this.pic_select.TabStop = false;
            this.pic_select.Click += new System.EventHandler(this.pic_select_Click);
            // 
            // lbl_color
            // 
            this.lbl_color.BackColor = System.Drawing.Color.White;
            this.lbl_color.Location = new System.Drawing.Point(61, 15);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(98, 65);
            this.lbl_color.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "رنگ منو ها";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(192, 130);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 43);
            this.btn_save.TabIndex = 2;
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
            // optionTableBindingSource
            // 
            this.optionTableBindingSource.DataMember = "optionTable";
            this.optionTableBindingSource.DataSource = this.db_bootik_lebasDataSet;
            // 
            // optionTableTableAdapter
            // 
            this.optionTableTableAdapter.ClearBeforeFill = true;
            // 
            // color_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(436, 234);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pic_close);
            this.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "color_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعیین رنگ منو ها";
            this.Load += new System.EventHandler(this.color_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pic_select;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private db_bootik_lebasDataSet db_bootik_lebasDataSet;
        private System.Windows.Forms.BindingSource optionTableBindingSource;
        private db_bootik_lebasDataSetTableAdapters.optionTableTableAdapter optionTableTableAdapter;
    }
}