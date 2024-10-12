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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int LabelX
        {
            get { return Convert.ToInt32(textBox1.Text); }
            set { textBox1.Text = value.ToString(); }
        }
        public int LabelY
        {
            get { return Convert.ToInt32(textBox2.Text); }
            set { textBox2.Text = value.ToString(); }
        }
        public string LabelText
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public event EventHandler Apply;    // 3.이벤트 선언

        private void button1_Click(object sender, EventArgs e)
        {
            // 사용자 Apply 이벤트 발생
            if (Apply != null)
            {
                Apply(this, new EventArgs()); //매개변수 타입이 같아야 함!
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
