﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorillaTag_Downloader
{
    public partial class credits : Form
    {
        public credits()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main man = new Main();
            man.Show();
        }
    }
}
