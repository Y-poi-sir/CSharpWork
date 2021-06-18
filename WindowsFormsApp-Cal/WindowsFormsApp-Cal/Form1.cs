using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_sign.Items.Add("+");
            comboBox_sign.Items.Add("-");
            comboBox_sign.Items.Add("*");
            comboBox_sign.Items.Add("/");
        }


        private void button_Click_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0;
            try
            {
                a = double.Parse(textBox_num1.Text);
                b = double.Parse(textBox_num2.Text);

                switch (comboBox_sign.Text)
                {
                    case "+":
                        textBox_result.Text = Convert.ToString(a + b);
                        break;
                    case "-":
                        textBox_result.Text = Convert.ToString(a - b);
                        break;
                    case "*":
                        textBox_result.Text = Convert.ToString(a * b);
                        break;
                    case "/":
                        if (b != 0)
                            textBox_result.Text = Convert.ToString(a / b);
                        else
                            textBox_result.Text = "除0错误";
                        break;
                    default:
                        textBox_result.Text = "输入符号错误";
                        break;
                }
            }
            catch (FormatException)
            {
                textBox_result.Text = "输入内容不是数字";
            }
            catch (OverflowException)
            {
                textBox_result.Text = "溢出";
            }
        }
    }
}