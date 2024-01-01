namespace project
{
    partial class Form3
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
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndangky = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btntrangthai = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dvg1
            // 
            this.dvg1.BackgroundColor = System.Drawing.Color.White;
            this.dvg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.malop,
            this.sotin,
            this.sv,
            this.svmax});
            this.dvg1.Location = new System.Drawing.Point(7, 98);
            this.dvg1.Name = "dvg1";
            this.dvg1.ReadOnly = true;
            this.dvg1.Size = new System.Drawing.Size(550, 217);
            this.dvg1.TabIndex = 1;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "mon";
            this.ten.HeaderText = "Tên học phần";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã lớp";
            this.malop.Name = "malop";
            this.malop.ReadOnly = true;
            this.malop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sotin
            // 
            this.sotin.DataPropertyName = "sotin";
            this.sotin.HeaderText = "Số tín";
            this.sotin.Name = "sotin";
            this.sotin.ReadOnly = true;
            this.sotin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sv
            // 
            this.sv.DataPropertyName = "sv";
            this.sv.HeaderText = "Sỹ số";
            this.sv.Name = "sv";
            this.sv.ReadOnly = true;
            this.sv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // svmax
            // 
            this.svmax.DataPropertyName = "svmax";
            this.svmax.HeaderText = "Lịch học";
            this.svmax.Name = "svmax";
            this.svmax.ReadOnly = true;
            this.svmax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btndangky
            // 
            this.btndangky.Location = new System.Drawing.Point(62, 125);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(92, 23);
            this.btndangky.TabIndex = 3;
            this.btndangky.Text = "Đăng ký";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // txttim
            // 
            this.txttim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(250, 137);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(319, 22);
            this.txttim.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm kiếm";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(62, 67);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(92, 23);
            this.btntimkiem.TabIndex = 6;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btntrangthai
            // 
            this.btntrangthai.Location = new System.Drawing.Point(62, 96);
            this.btntrangthai.Name = "btntrangthai";
            this.btntrangthai.Size = new System.Drawing.Size(92, 23);
            this.btntrangthai.TabIndex = 7;
            this.btntrangthai.Text = "Tất cả";
            this.btntrangthai.UseVisualStyleBackColor = true;
            this.btntrangthai.Click += new System.EventHandler(this.btntrangthai_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dvg1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 333);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(73, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(428, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "DANH SÁCH CÁC LỚP ĐANG MỞ ĐĂNG KÝ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.btntrangthai);
            this.groupBox1.Controls.Add(this.btndangky);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(606, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 266);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(62, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Activated += new System.EventHandler(this.Form3_Activated);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btntrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotin;
        private System.Windows.Forms.DataGridViewTextBoxColumn sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn svmax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}