namespace project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.chkluu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(265, 324);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(217, 20);
            this.txtmatkhau.TabIndex = 1;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(265, 272);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(217, 20);
            this.txttaikhoan.TabIndex = 0;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(265, 360);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(75, 23);
            this.btndangnhap.TabIndex = 2;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(407, 360);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // chkluu
            // 
            this.chkluu.AutoSize = true;
            this.chkluu.ForeColor = System.Drawing.Color.Black;
            this.chkluu.Location = new System.Drawing.Point(265, 389);
            this.chkluu.Name = "chkluu";
            this.chkluu.Size = new System.Drawing.Size(99, 17);
            this.chkluu.TabIndex = 5;
            this.chkluu.Text = "Lưu đăng nhập";
            this.chkluu.UseVisualStyleBackColor = true;
            this.chkluu.CheckedChanged += new System.EventHandler(this.chkluu_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 499);
            this.Controls.Add(this.chkluu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.txtmatkhau);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.CheckBox chkluu;
    }
}

