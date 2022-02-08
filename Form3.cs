using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";
            ofd.Filter = "All Files(*.*) | *.*";
            DialogResult dResult = ofd.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                txtFile.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfld = new SaveFileDialog();
            sfld.Filter = "Text Files (*.txt) | *.txt";
            if (sfld.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfld.FileName);
                sw.Write(txtFile.Text);
                sw.Close();
            }
        }
    }
}
