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
            this.label2 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtykien
            // 
            this.txtykien.Location = new System.Drawing.Point(168, 49);
            this.txtykien.Name = "txtykien";
            this.txtykien.Size = new System.Drawing.Size(494, 20);
            this.txtykien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ý kiến của sinh viên:";
            // 
            // btngui
            // 
            this.btngui.Location = new System.Drawing.Point(372, 244);
            this.btngui.Name = "btngui";
            this.btngui.Size = new System.Drawing.Size(75, 23);
            this.btngui.TabIndex = 2;
            this.btngui.Text = "Gửi";
            this.btngui.UseVisualStyleBackColor = true;
            this.btngui.Click += new System.EventHandler(this.btngui_Click);
            // 
            // dvg1
            // 
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ykien});
            this.dvg1.Location = new System.Drawing.Point(145, 273);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(542, 121);
            this.dvg1.TabIndex = 3;
            this.dvg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg1_CellContentClick);
            // 
            // ykien
            // 
            this.ykien.DataPropertyName = "svgopy";
            this.ykien.HeaderText = "Ý Kiến";
            this.ykien.Name = "ykien";
            this.ykien.ReadOnly = true;
            this.ykien.Width = 500;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(301, 400);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(465, 400);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // gopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvg1);
            this.Controls.Add(this.btngui);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtykien);
            this.Name = "gopy";
            this.Text = "gopy";
            this.Load += new System.EventHandler(this.gopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtykien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngui;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ykien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
    }
}