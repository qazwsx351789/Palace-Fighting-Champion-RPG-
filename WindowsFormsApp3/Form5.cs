using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private int x, up, down, N, i, queen ,over;
        bool IsToForm1 = false;
        string check1, vs1;
        private void button1_Click(object sender, EventArgs e)
        {
            if(over == 1)
            {
                IsToForm1 = true;
                this.Close(); //強制關閉Form5
            }
            else if (i % 2 == 0)
            {
                button1.Text = "猜測";
                label6.Text = "Your";
                textBox1.Enabled = true;
                Random rnd = new Random();
                queen = rnd.Next(down + 1, up);
                label10.Text = queen.ToString();
                if (!(queen < down | queen > up))
                {
                    if (queen > N)
                    {
                        label8.Text = "比" + queen.ToString() + "小";
                        up = queen;
                        label5.Text = up.ToString();
                        i++;
                    }
                    if (queen < N)
                    {
                        label8.Text = "比" + queen.ToString() + "大";
                        down = queen;
                        label1.Text = down.ToString();
                        i++;
                    }
                    if (queen == N)
                    {
                        label8.Text = "咖妃猜中了!答案是 " + queen.ToString();
                        textBox1.Text = "";
                        vs1 = "NO";
                        button1.Text = "結束";
                        over++;

                    }
                }
            }
            else
            {

                label6.Text = "咖妃's";
                button1.Text = "咖妃猜";
                textBox1.Enabled = false;
                try
                {
                    x = int.Parse(textBox1.Text);
                    if (x < down | x > up)
                    {
                        label8.Text = "你的猜測不在目前範圍內";
                        textBox1.Text = "";
                        i++;
                    }
                    else
                    {
                        if (x > N)
                        {
                            label8.Text = "比" + x.ToString() + "小";
                            up = x;
                            label5.Text = up.ToString();
                            textBox1.Text = "";
                            i++;
                        }
                        if (x < N)
                        {
                            label8.Text = "比" + x.ToString() + "大";
                            down = x;
                            label1.Text = down.ToString();
                            textBox1.Text = "";
                            i++;
                        }
                        if (x == N)
                        {
                            label8.Text = "猜中了!答案是 " + x.ToString();
                            textBox1.Text = "";
                            vs1 = "YES";
                            button1.Text = "結束";
                            over++;

                        }
                    }
                
                    
                }
                catch(FormatException ex)
                {
                    DialogResult False;
                    False = MessageBox.Show("請輸入整數數字", "格式不正確", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    button1.Text = "猜測";
                    label6.Text = "Your";
                    textBox1.Enabled = true;
                    textBox1.Text = "";
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            N = ran.Next(1, 100);
            Console.WriteLine("{0}", N);
            label10.Text = "";
            label1.Text = "0";
            label5.Text = "100";
            label6.Text = "Your";
            up = 100;
            down = 0;
            i = 1;
        }
        public void VS1(string vs1)
        {
            check1 = vs1;
        }
        protected override void OnClosing(CancelEventArgs e) //在視窗關閉時觸發
        {
            base.OnClosing(e);
            if (IsToForm1) //判斷是否要回到Form1
            {
                this.DialogResult = DialogResult.Yes; //利用DialogResult傳遞訊息
                Form1 form1 = (Form1)this.Owner; //取得父視窗的參考
                form1.VS1(vs1);
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }

        }
    }
}
