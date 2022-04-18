using System;
using System.Windows.Forms;

namespace SoftKeyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_text = "";
            if (SoftKeyboard.SoftKeyboard9.Show("请输入", ref input_text))
            {
                // 用户点了“完成”，则执行这里
                textBox1.Text = input_text;
            }
            else
            {
                // 用户点了“取消”，则执行这里
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input_text = "";
            if (SoftKeyboard.SoftKeyboard26.Show("请输入", ref input_text))
            {
                // 用户点了“完成”，则执行这里
                textBox1.Text = input_text;
            }
            else
            {
                // 用户点了“取消”，则执行这里
            }
        }
    }
}
