namespace project
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntatca = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbogt = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmoi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtdonvi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.btndoi = new System.Windows.Forms.Button();
            this.dtmngaysinh = new System.Windows.Forms.DateTimePicker();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH HỌC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "nganh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btntatca
            // 
            this.btntatca.Location = new System.Drawing.Point(22, 72);
            this.btntatca.Name = "btntatca";
            this.btntatca.Size = new System.Drawing.Size(75, 23);
            this.btntatca.TabIndex = 11;
            this.btntatca.Text = "Kết quả";
            this.btntatca.UseVisualStyleBackColor = true;
            this.btntatca.Click += new System.EventHandler(this.btntatca_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(22, 43);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 10;
            this.btntimkiem.Text = "Chương trình";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dvg1
            // 
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.tin,
            this.hocky,
            this.diem});
            this.dvg1.Location = new System.Drawing.Point(6, 60);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(593, 194);
            this.dvg1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dvg1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 260);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả học tập";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btntimkiem);
            this.groupBox3.Controls.Add(this.btntatca);
            this.groupBox3.Location = new System.Drawing.Point(616, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 152);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtmngaysinh);
            this.groupBox2.Controls.Add(this.btndoi);
            this.groupBox2.Controls.Add(this.cbogt);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtten);
            this.groupBox2.Controls.Add(this.txtdonvi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtquequan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtchucvu);
            this.groupBox2.Location = new System.Drawing.Point(23, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 136);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cá nhân";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbogt
            // 
            this.cbogt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbogt.FormattingEnabled = true;
            this.cbogt.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbogt.Location = new System.Drawing.Point(79, 91);
            this.cbogt.Name = "cbogt";
            this.cbogt.Size = new System.Drawing.Size(114, 21);
            this.cbogt.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtmoi);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtcu);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(463, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 104);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin tài khoản";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "????????";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Mã sinh viên:";
            // 
            // txtmoi
            // 
            this.txtmoi.BackColor = System.Drawing.Color.White;
            this.txtmoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmoi.Location = new System.Drawing.Point(80, 77);
            this.txtmoi.Name = "txtmoi";
            this.txtmoi.Size = new System.Drawing.Size(114, 15);
            this.txtmoi.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mật khẩu cũ";
            // 
            // txtcu
            // 
            this.txtcu.BackColor = System.Drawing.Color.White;
            this.txtcu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcu.Location = new System.Drawing.Point(80, 47);
            this.txtcu.Name = "txtcu";
            this.txtcu.Size = new System.Drawing.Size(114, 15);
            this.txtcu.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Mật khẩu mới";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(421, 97);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(36, 23);
            this.btnluu.TabIndex = 17;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Giới tính";
            // 
            // txtten
            // 
            this.txtten.BackColor = System.Drawing.Color.White;
            this.txtten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(79, 33);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(114, 15);
            this.txtten.TabIndex = 5;
            // 
            // txtdonvi
            // 
            this.txtdonvi.BackColor = System.Drawing.Color.White;
            this.txtdonvi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdonvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdonvi.Location = new System.Drawing.Point(295, 63);
            this.txtdonvi.Name = "txtdonvi";
            this.txtdonvi.Size = new System.Drawing.Size(114, 15);
            this.txtdonvi.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quê quán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đơn vị";
            // 
            // txtquequan
            // 
            this.txtquequan.BackColor = System.Drawing.Color.White;
            this.txtquequan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtquequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquequan.Location = new System.Drawing.Point(295, 33);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(114, 15);
            this.txtquequan.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày sinh";
            // 
            // txtchucvu
            // 
            this.txtchucvu.BackColor = System.Drawing.Color.White;
            this.txtchucvu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchucvu.Location = new System.Drawing.Point(295, 97);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(114, 15);
            this.txtchucvu.TabIndex = 11;
            // 
            // btndoi
            // 
            this.btndoi.Location = new System.Drawing.Point(671, 79);
            this.btndoi.Name = "btndoi";
            this.btndoi.Size = new System.Drawing.Size(75, 37);
            this.btndoi.TabIndex = 20;
            this.btndoi.Text = "Đổi mật khẩu";
            this.btndoi.UseVisualStyleBackColor = true;
            this.btndoi.Click += new System.EventHandler(this.btndoi_Click);
            // 
            // dtmngaysinh
            // 
            this.dtmngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtmngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmngaysinh.Location = new System.Drawing.Point(76, 58);
            this.dtmngaysinh.Name = "dtmngaysinh";
            this.dtmngaysinh.Size = new System.Drawing.Size(117, 20);
            this.dtmngaysinh.TabIndex = 19;
            this.dtmngaysinh.Value = new System.DateTime(2024, 1, 5, 0, 0, 0, 0);
            // 
            // ten
            // 
            this.ten.DataPropertyName = "mon";
            this.ten.HeaderText = "Tên học phần";
            this.ten.Name = "ten";
            this.ten.Width = 250;
            // 
            // tin
            // 
            this.tin.DataPropertyName = "sotin";
            this.tin.HeaderText = "Số tín";
            this.tin.Name = "tin";
            // 
            // hocky
            // 
            this.hocky.DataPropertyName = "hocky";
            this.hocky.HeaderText = "Học kỳ";
            this.hocky.Name = "hocky";
            // 
            // diem
            // 
            this.diem.DataPropertyName = "diem";
            this.diem.HeaderText = "Điểm trung binh";
            this.diem.Name = "diem";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntatca;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtdonvi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txtmoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbogt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btndoi;
        private System.Windows.Forms.DateTimePicker dtmngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tin;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
    }
}