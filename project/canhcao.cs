﻿using System;
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
    public partial class canhcao : Form
    {
        public canhcao()
        {
            InitializeComponent();
        }

        private void Load_dvg1()
        {
            string a = Properties.Settings.Default.tkhoan;
            dvg1.DataSource = thuvien.bang("Select mon,diem from ketqua where ma = '" + a + "' and diem <3");
            dvg1.Refresh();
        }
        private void canhcao_Load(object sender, EventArgs e)
        {
            Load_dvg1();
        }

        private void btntatca_Click(object sender, EventArgs e)
        {
            Load_dvg1();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string a = Properties.Settings.Default.tkhoan;
            string b = txttim.Text.Trim();
            dvg1.DataSource = thuvien.bang("Select mon,diem from ketqua where ma = '" + a + "'and (mon like '%" + b + "%'or diem like '%" + b + "%')");
        }
    }
}
