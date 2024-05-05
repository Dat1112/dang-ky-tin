namespace project
{
    partial class ad_thongbao
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtnoidung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnphanhoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.ykien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntatca = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtnoidung);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(57, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 98);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // txtnoidung
            // 
            this.txtnoidung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnoidung.Location = new System.Drawing.Point(110, 28);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(472, 15);
            this.txtnoidung.TabIndex = 0;
            this.txtnoidung.TextChanged += new System.EventHandler(this.txtnoidung_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội dung";
            // 
            // btnphanhoi
            // 
            this.btnphanhoi.Location = new System.Drawing.Point(21, 13);
            this.btnphanhoi.Name = "btnphanhoi";
            this.btnphanhoi.Size = new System.Drawing.Size(75, 23);
            this.btnphanhoi.TabIndex = 2;
            this.btnphanhoi.Text = "gửi";
            this.btnphanhoi.UseVisualStyleBackColor = true;
            this.btnphanhoi.Click += new System.EventHandler(this.btnphanhoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvg1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 326);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nội dung đã gửi";
            // 
            // dvg1
            // 
            this.dvg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ykien,
            this.time});
            this.dvg1.Location = new System.Drawing.Point(6, 33);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(632, 276);
            this.dvg1.TabIndex = 3;
            // 
            // ykien
            // 
            this.ykien.DataPropertyName = "news";
            this.ykien.HeaderText = "Thông báo";
            this.ykien.Name = "ykien";
            this.ykien.ReadOnly = true;
            this.ykien.Width = 450;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Thời gian";
            this.time.Name = "time";
            this.time.Width = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntatca);
            this.groupBox1.Controls.Add(this.btntim);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnphanhoi);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Location = new System.Drawing.Point(670, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // btntatca
            // 
            this.btntatca.Location = new System.Drawing.Point(21, 129);
            this.btntatca.Name = "btntatca";
            this.btntatca.Size = new System.Drawing.Size(75, 23);
            this.btntatca.TabIndex = 6;
            this.btntatca.Text = "Tất cả";
            this.btntatca.UseVisualStyleBackColor = true;
            this.btntatca.Click += new System.EventHandler(this.btntatca_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(21, 42);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 5;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(21, 100);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(21, 71);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // ad_thongbao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "ad_thongbao";
            this.Text = "ad_thongbao";
            this.Load += new System.EventHandler(this.ad_thongbao_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtnoidung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnphanhoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ykien;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Button btntatca;
    }
}