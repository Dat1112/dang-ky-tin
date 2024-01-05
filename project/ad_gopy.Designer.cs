namespace project
{
    partial class ad_gopy
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ykien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtphanhoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnphanhoi = new System.Windows.Forms.Button();
            this.btntatca = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvg1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 232);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nội dung đã gửi";
            // 
            // dvg1
            // 
            this.dvg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.ykien,
            this.time,
            this.phanhoi});
            this.dvg1.Location = new System.Drawing.Point(20, 34);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(734, 182);
            this.dvg1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntatca);
            this.groupBox1.Controls.Add(this.txttim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btntim);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 87);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(118, 33);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(494, 22);
            this.txttim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên";
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(613, 33);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // masv
            // 
            this.masv.DataPropertyName = "masv";
            this.masv.HeaderText = "Mã sinh viên";
            this.masv.Name = "masv";
            // 
            // ykien
            // 
            this.ykien.DataPropertyName = "svgopy";
            this.ykien.HeaderText = "Ý Kiến";
            this.ykien.Name = "ykien";
            this.ykien.ReadOnly = true;
            this.ykien.Width = 225;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Thời gian";
            this.time.Name = "time";
            this.time.Width = 150;
            // 
            // phanhoi
            // 
            this.phanhoi.DataPropertyName = "phanhoi";
            this.phanhoi.HeaderText = "Phản hồi";
            this.phanhoi.Name = "phanhoi";
            this.phanhoi.Width = 225;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtphanhoi);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnphanhoi);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(59, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 80);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // txtphanhoi
            // 
            this.txtphanhoi.Location = new System.Drawing.Point(118, 33);
            this.txtphanhoi.Name = "txtphanhoi";
            this.txtphanhoi.Size = new System.Drawing.Size(494, 22);
            this.txtphanhoi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phản hồi";
            // 
            // btnphanhoi
            // 
            this.btnphanhoi.Location = new System.Drawing.Point(613, 33);
            this.btnphanhoi.Name = "btnphanhoi";
            this.btnphanhoi.Size = new System.Drawing.Size(75, 23);
            this.btnphanhoi.TabIndex = 2;
            this.btnphanhoi.Text = "gửi";
            this.btnphanhoi.UseVisualStyleBackColor = true;
            this.btnphanhoi.Click += new System.EventHandler(this.btnphanhoi_Click);
            // 
            // btntatca
            // 
            this.btntatca.Location = new System.Drawing.Point(613, 58);
            this.btntatca.Name = "btntatca";
            this.btntatca.Size = new System.Drawing.Size(75, 23);
            this.btntatca.TabIndex = 3;
            this.btntatca.Text = "Tất cả";
            this.btntatca.UseVisualStyleBackColor = true;
            this.btntatca.Click += new System.EventHandler(this.btntatca_Click);
            // 
            // ad_gopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ad_gopy";
            this.Text = "ad_gopy";
            this.Load += new System.EventHandler(this.ad_gopy_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ykien;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanhoi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtphanhoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnphanhoi;
        private System.Windows.Forms.Button btntatca;
    }
}