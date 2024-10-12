using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mutiform2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();    // 객체 선언과 생성
            dlg.Owner = this;
            dlg.ShowDialog();
            dlg.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
