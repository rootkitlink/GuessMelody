﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class fGame : Form
    {
        public fGame()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            WMP.URL = Victoryna.list[0];
        }

        private void WMP_Enter(object sender, EventArgs e)
        {
            WMP.URL = Victoryna.list[0];
        }
    }
}
