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
            this.label4 = new System.Windows.Forms.Label();
            this.txttim = new System.Windows.Forms.TextBox();
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH HỌC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // btntatca
            // 
            this.btntatca.Location = new System.Drawing.Point(630, 150);
            this.btntatca.Name = "btntatca";
            this.btntatca.Size = new System.Drawing.Size(75, 23);
            this.btntatca.TabIndex = 11;
            this.btntatca.Text = "Tất cả";
            this.btntatca.UseVisualStyleBackColor = true;
            this.btntatca.Click += new System.EventHandler(this.btntatca_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(630, 121);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 10;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tìm kiếm";
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(214, 124);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(379, 20);
            this.txttim.TabIndex = 8;
            // 
            // dvg1
            // 
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.tin});
            this.dvg1.Location = new System.Drawing.Point(167, 179);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(494, 210);
            this.dvg1.TabIndex = 12;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "mon";
            this.ten.HeaderText = "Tên học phần";
            this.ten.Name = "ten";
            this.ten.Width = 350;
            // 
            // tin
            // 
            this.tin.DataPropertyName = "sotin";
            this.tin.HeaderText = "Số tín";
            this.tin.Name = "tin";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvg1);
            this.Controls.Add(this.btntatca);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntatca;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tin;
    }
}