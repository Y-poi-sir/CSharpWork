using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tsetOfFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            bool flag = true ;
            double numFirst=0 ;
            if (double.TryParse(textBox1.Text, out num))
            {
                numFirst = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                flag = false;
            };
            double numSecond=0;
            if (double.TryParse(textBox2.Text, out num))
            {
                 numSecond = Convert.ToDouble(textBox2.Text);
            }
            else
            {
                flag = false;
            };

            if (flag) { label3.Text = numFirst + "+" + numSecond + "=" + (numFirst + numSecond);
            }else{
                label3.Text = "输入的值不为数字，请检查";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num;
            bool flag = true;
            double numFirst = 0;
            if (double.TryParse(textBox1.Text, out num))
            {
                numFirst = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                flag = false;
            };
            double numSecond = 0;
            if (double.TryParse(textBox2.Text, out num))
            {
                numSecond = Convert.ToDouble(textBox2.Text);
            }
            else
            {
                flag = false;
            };
            if (flag)
            {
                label3.Text = numFirst + "-" + numSecond + "=" + (numFirst - numSecond);
            }
            else
            {
                label3.Text = "输入的值不为数字，请检查";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num;
            bool flag = true;
            double numFirst =0;
            if (double.TryParse(textBox1.Text, out num))
            {
                numFirst = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                flag = false;
            };
            double numSecond = 0;
            if (double.TryParse(textBox2.Text, out num))
            {
                numSecond = Convert.ToDouble(textBox2.Text);
            }
            else
            {
                flag = false;
            };
            if (flag)
            {
                label3.Text = numFirst + "*" + numSecond + "=" + (numFirst * numSecond);
            }
            else
            {
                label3.Text = "输入的值不为数字，请检查";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num;
            bool flag = true;
            double numFirst = 0;
            if (double.TryParse(textBox1.Text, out num))
            {
                numFirst = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                flag = false;
            };
            double numSecond = 0;
            if (double.TryParse(textBox2.Text, out num))
            {
                numSecond = Convert.ToDouble(textBox2.Text);
            }
            else
            {
                flag = false;
            };
            if(numSecond==0){
                label3.Text = "除数不能为0，请重新输入";
            }
            else if (flag)
            {
                label3.Text = numFirst + "/" + numSecond + "=" + (numFirst / numSecond);
            }
            else
            {
                label3.Text = "输入的值不为数字，请检查";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否退出?", "提示:", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)   //如果单击“是”按钮
            {
                e.Cancel = false;                 //关闭窗体
            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;                  //不执行操作
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
