using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiform3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private Form2 dlg;
        private void OnApply(object sender, EventArgs e)    // 1. 이벤트 처리기 작성
        {   //form2 => form1 정보 전달
            label1.Left = dlg.LabelX;
            label1.Top = dlg.LabelY;
            label1.Text = dlg.LabelText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dlg == null || dlg.IsDisposed)  //모덜리스 방식
            {
                dlg = new Form2();
                dlg.Owner = this;
                dlg.Apply += new EventHandler(OnApply); // 4. 이벤트 등록
                // form2 => form1 정보 전달
                dlg.LabelX = label1.Left;
                dlg.LabelY = label1.Top;
                dlg.LabelText = label1.Text;
                dlg.Show(); // 모덜리스 방식
            }

        }
    }
}
