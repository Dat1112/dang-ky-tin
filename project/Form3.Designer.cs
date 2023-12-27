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
            this.label2 = new System.Windows.Forms.Label();
            this.btndangky = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btntrangthai = new System.Windows.Forms.Button();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dvg1
            // 
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.malop,
            this.sotin,
            this.sv,
            this.svmax});
            this.dvg1.Location = new System.Drawing.Point(135, 209);
            this.dvg1.Name = "dvg1";
            this.dvg1.ReadOnly = true;
            this.dvg1.Size = new System.Drawing.Size(542, 150);
            this.dvg1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "DANH SÁCH CÁC LỚP ĐANG MỞ ĐĂNG KÝ";
            // 
            // btndangky
            // 
            this.btndangky.Location = new System.Drawing.Point(360, 381);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(75, 23);
            this.btndangky.TabIndex = 3;
            this.btndangky.Text = "Đăng ký";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(250, 127);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(320, 20);
            this.txttim.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm kiếm";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(602, 124);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 6;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btntrangthai
            // 
            this.btntrangthai.Location = new System.Drawing.Point(602, 153);
            this.btntrangthai.Name = "btntrangthai";
            this.btntrangthai.Size = new System.Drawing.Size(75, 23);
            this.btntrangthai.TabIndex = 7;
            this.btntrangthai.Text = "Tất cả";
            this.btntrangthai.UseVisualStyleBackColor = true;
            this.btntrangthai.Click += new System.EventHandler(this.btntrangthai_Click);
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntrangthai);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvg1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Activated += new System.EventHandler(this.Form3_Activated);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.Label label2;
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
    }
}