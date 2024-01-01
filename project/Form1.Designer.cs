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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BackColor = System.Drawing.Color.Black;
            this.txtmatkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatkhau.ForeColor = System.Drawing.Color.White;
            this.txtmatkhau.Location = new System.Drawing.Point(92, 210);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(200, 13);
            this.txtmatkhau.TabIndex = 1;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.BackColor = System.Drawing.Color.Black;
            this.txttaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttaikhoan.ForeColor = System.Drawing.Color.White;
            this.txttaikhoan.Location = new System.Drawing.Point(92, 158);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(200, 13);
            this.txttaikhoan.TabIndex = 0;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangnhap.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.ForeColor = System.Drawing.Color.Black;
            this.btndangnhap.Location = new System.Drawing.Point(92, 258);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(200, 36);
            this.btndangnhap.TabIndex = 2;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Black;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(92, 300);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(200, 36);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // chkluu
            // 
            this.chkluu.AutoSize = true;
            this.chkluu.ForeColor = System.Drawing.Color.White;
            this.chkluu.Location = new System.Drawing.Point(92, 342);
            this.chkluu.Name = "chkluu";
            this.chkluu.Size = new System.Drawing.Size(99, 17);
            this.chkluu.TabIndex = 5;
            this.chkluu.Text = "Lưu đăng nhập";
            this.chkluu.UseVisualStyleBackColor = true;
            this.chkluu.CheckedChanged += new System.EventHandler(this.chkluu_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txttaikhoan);
            this.panel1.Controls.Add(this.chkluu);
            this.panel1.Controls.Add(this.txtmatkhau);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btndangnhap);
            this.panel1.Location = new System.Drawing.Point(561, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 401);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 67);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 28);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(42, 202);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 28);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(92, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(92, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(892, 398);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.CheckBox chkluu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

