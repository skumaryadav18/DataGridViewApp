﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mdi : Form
    {
        public mdi()
        {
            InitializeComponent();
        }

        private void mdi_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void textBoxOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxOperations tbObj = new TextBoxOperations();
            tbObj.Show();
            tbObj.MdiParent = this;
        }
    }
}
