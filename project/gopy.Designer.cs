namespace project
{
    partial class gopy
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
            this.txtykien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btngui = new System.Windows.Forms.Button();
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.ykien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtykien
            // 
            this.txtykien.Location = new System.Drawing.Point(118, 33);
            this.txtykien.Name = "txtykien";
            this.txtykien.Size = new System.Drawing.Size(494, 22);
            this.txtykien.TabIndex = 0;
            this.txtykien.TextChanged += new System.EventHandler(this.txtykien_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ý kiến của sinh viên:";
            // 
            // btngui
            // 
            this.btngui.Location = new System.Drawing.Point(292, 98);
            this.btngui.Name = "btngui";
            this.btngui.Size = new System.Drawing.Size(75, 23);
            this.btngui.TabIndex = 2;
            this.btngui.Text = "Gửi";
            this.btngui.UseVisualStyleBackColor = true;
            this.btngui.Click += new System.EventHandler(this.btngui_Click);
            // 
            // dvg1
            // 
            this.dvg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ykien,
            this.time,
            this.phanhoi});
            this.dvg1.Location = new System.Drawing.Point(36, 34);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(643, 121);
            this.dvg1.TabIndex = 3;
            this.dvg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg1_CellContentClick);
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
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(250, 161);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(414, 161);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtykien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btngui);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 127);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvg1);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(51, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 217);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nội dung đã gửi";
            // 
            // gopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "gopy";
            this.Text = "gopy";
            this.Load += new System.EventHandler(this.gopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtykien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngui;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ykien;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanhoi;
    }
}