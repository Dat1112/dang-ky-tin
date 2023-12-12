using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form2 : Form
    {
        bool isthoat = true;
        public Form2()
        {
            InitializeComponent();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            isthoat = false;
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isthoat)
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
       

        private void btndki_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
            label1.Text = btndki.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());
            label1.Text = button2.Text;
        }

        private void btncanhan_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "CÁ NHÂN";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5());
            label1.Text = button3.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = Properties.Settings.Default.ten;
        }
    }
}
