﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch8_ex8_8_2206
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // 리스트 상자의 선택 항목을 콤보 상자에 추가
                comboBox1.Items.Add(listBox1.SelectedItem);
                //comboBox1.items.Insert(0,listBox1.SelectedItem);
                // 리스트 상자에서 선택 항목을 삭제
                listBox1.Items.Remove(listBox1.SelectedItem);  }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {   // <<
                //  리스트 상자의 선택 항목을 콤보 상자에 추가
                listBox1.Items.Add(comboBox1.SelectedItem);
                // 리스트 상자의 선택 항목을 삭제
                comboBox1.Items.Remove(comboBox1.SelectedItem);}
        }
    }
}
