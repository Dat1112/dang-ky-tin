namespace project
{
    partial class tkb
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
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg1
            // 
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t,
            this.t2,
            this.t3,
            this.t4,
            this.t5,
            this.t6,
            this.t7});
            this.dvg1.Location = new System.Drawing.Point(0, 167);
            this.dvg1.Name = "dvg1";
            this.dvg1.Size = new System.Drawing.Size(802, 150);
            this.dvg1.TabIndex = 0;
            this.dvg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // t
            // 
            this.t.HeaderText = "Tiết";
            this.t.Name = "t";
            this.t.Width = 75;
            // 
            // t2
            // 
            this.t2.DataPropertyName = "malop";
            this.t2.HeaderText = "Thứ Hai";
            this.t2.Name = "t2";
            this.t2.Width = 115;
            // 
            // t3
            // 
            this.t3.DataPropertyName = "malop";
            this.t3.HeaderText = "Thứ Ba";
            this.t3.Name = "t3";
            this.t3.Width = 115;
            // 
            // t4
            // 
            this.t4.DataPropertyName = "malop";
            this.t4.HeaderText = "Thứ Tư";
            this.t4.Name = "t4";
            this.t4.Width = 115;
            // 
            // t5
            // 
            this.t5.DataPropertyName = "malop";
            this.t5.HeaderText = "Thứ Năm";
            this.t5.Name = "t5";
            this.t5.Width = 115;
            // 
            // t6
            // 
            this.t6.DataPropertyName = "malop";
            this.t6.HeaderText = "Thứ Sáu";
            this.t6.Name = "t6";
            this.t6.Width = 115;
            // 
            // t7
            // 
            this.t7.DataPropertyName = "malop";
            this.t7.HeaderText = "Thứ Bảy";
            this.t7.Name = "t7";
            this.t7.Width = 115;
            // 
            // tkb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvg1);
            this.Name = "tkb";
            this.Text = "tkb";
            this.Load += new System.EventHandler(this.tkb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2;
        private System.Windows.Forms.DataGridViewTextBoxColumn t3;
        private System.Windows.Forms.DataGridViewTextBoxColumn t4;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5;
        private System.Windows.Forms.DataGridViewTextBoxColumn t6;
        private System.Windows.Forms.DataGridViewTextBoxColumn t7;
    }
}