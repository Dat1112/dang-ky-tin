﻿namespace project
{
    partial class canhcao
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
            this.btntatca = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txttim = new System.Windows.Forms.TextBox();
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẢNH CÁO HỌC VỤ";
            // 
            // btntatca
            // 
            this.btntatca.Location = new System.Drawing.Point(348, 73);
            this.btntatca.Name = "btntatca";
            this.btntatca.Size = new System.Drawing.Size(75, 23);
            this.btntatca.TabIndex = 16;
            this.btntatca.Text = "Tất cả";
            this.btntatca.UseVisualStyleBackColor = true;
            this.btntatca.Click += new System.EventHandler(this.btntatca_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(348, 44);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 15;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tìm kiếm";
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(254, 42);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(82, 20);
            this.txttim.TabIndex = 13;
            // 
            // dvg1
            // 
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mon,
            this.diem});
            this.dvg1.Location = new System.Drawing.Point(6, 30);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(241, 150);
            this.dvg1.TabIndex = 12;
            // 
            // mon
            // 
            this.mon.DataPropertyName = "mon";
            this.mon.HeaderText = "Môn";
            this.mon.Name = "mon";
            // 
            // diem
            // 
            this.diem.DataPropertyName = "diem";
            this.diem.HeaderText = "Điểm trung bình";
            this.diem.Name = "diem";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvg1);
            this.groupBox1.Controls.Add(this.btntatca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttim);
            this.groupBox1.Location = new System.Drawing.Point(704, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 186);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // canhcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "canhcao";
            this.Text = "canhcao";
            this.Load += new System.EventHandler(this.canhcao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntatca;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}