namespace Lebas_Shop
{
    partial class login_frm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_eye = new System.Windows.Forms.PictureBox();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.pic_login = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.db_bootik_lebasDataSet = new Lebas_Shop.db_bootik_lebasDataSet();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableTableAdapter = new Lebas_Shop.db_bootik_lebasDataSetTableAdapters.userTableTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.pic_eye);
            this.groupBox1.Controls.Add(this.pic_exit);
            this.groupBox1.Controls.Add(this.pic_login);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pic_eye
            // 
            this.pic_eye.BackColor = System.Drawing.SystemColors.Window;
            this.pic_eye.Image = global::Lebas_Shop.Properties.Resources._5518752821543238880_128;
            this.pic_eye.Location = new System.Drawing.Point(9, 79);
            this.pic_eye.Name = "pic_eye";
            this.pic_eye.Size = new System.Drawing.Size(40, 26);
            this.pic_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_eye.TabIndex = 4;
            this.pic_eye.TabStop = false;
            this.pic_eye.Click += new System.EventHandler(this.pic_eye_Click);
            // 
            // pic_exit
            // 
            this.pic_exit.BackColor = System.Drawing.Color.DarkRed;
            this.pic_exit.Image = global::Lebas_Shop.Properties.Resources.exit;
            this.pic_exit.Location = new System.Drawing.Point(21, 164);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(34, 31);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_exit.TabIndex = 4;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // pic_login
            // 
            this.pic_login.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pic_login.Image = global::Lebas_Shop.Properties.Resources.login;
            this.pic_login.Location = new System.Drawing.Point(166, 164);
            this.pic_login.Name = "pic_login";
            this.pic_login.Size = new System.Drawing.Size(34, 31);
            this.pic_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_login.TabIndex = 4;
            this.pic_login.TabStop = false;
            this.pic_login.Click += new System.EventHandler(this.pic_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkRed;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(8, 160);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(127, 39);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "انصراف";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(154, 160);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(123, 39);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "ورود";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(8, 72);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '•';
            this.txt_password.Size = new System.Drawing.Size(185, 40);
            this.txt_password.TabIndex = 1;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "رمز عبور";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(8, 16);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(185, 40);
            this.txt_username.TabIndex = 0;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_username_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاریخ : ";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(76, 297);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(91, 33);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "lbl_date";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lebas_Shop.Properties.Resources.Remove_bg_ai_1730579510416;
            this.pictureBox2.Location = new System.Drawing.Point(300, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pic_close
            // 
            this.pic_close.Image = global::Lebas_Shop.Properties.Resources.exit;
            this.pic_close.Location = new System.Drawing.Point(531, 8);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(31, 27);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 2;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // db_bootik_lebasDataSet
            // 
            this.db_bootik_lebasDataSet.DataSetName = "db_bootik_lebasDataSet";
            this.db_bootik_lebasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "userTable";
            this.userTableBindingSource.DataSource = this.db_bootik_lebasDataSet;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(577, 340);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pic_close);
            this.Font = new System.Drawing.Font("B Koodak", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "احراز هویت";
            this.Load += new System.EventHandler(this.login_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_bootik_lebasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pic_login;
        private System.Windows.Forms.PictureBox pic_exit;
        private System.Windows.Forms.PictureBox pic_eye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_date;
        private db_bootik_lebasDataSet db_bootik_lebasDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private db_bootik_lebasDataSetTableAdapters.userTableTableAdapter userTableTableAdapter;
    }
}

