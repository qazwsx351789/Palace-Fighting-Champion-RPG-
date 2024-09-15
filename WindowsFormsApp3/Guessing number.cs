using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps3
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
                button1.Text = "Guess";
                label6.Text = "Your";
                textBox1.Enabled = true;
                Random rnd = new Random();
                queen = rnd.Next(down + 1, up);
                label10.Text = queen.ToString();
                if (!(queen < down | queen > up))
                {
                    if (queen > N)
                    {
                        label8.Text = "Smaller than " + queen.ToString();
                        up = queen;
                        label5.Text = up.ToString();
                        i++;
                    }
                    if (queen < N)
                    {
                        label8.Text = "Larger than " + queen.ToString() ;
                        down = queen;
                        label1.Text = down.ToString();
                        i++;
                    }
                    if (queen == N)
                    {
                        label8.Text = "Concubine Ka guessed correctly! The answer is: " + queen.ToString();
                        textBox1.Text = "";
                        vs1 = "NO";
                        button1.Text = "Finished";
                        over++;

                    }
                }
            }
            else
            {

                label6.Text = "Concubine Ka's";
                button1.Text = "Concubine Ka guesses";
                textBox1.Enabled = false;
                try
                {
                    x = int.Parse(textBox1.Text);
                    if (x < down | x > up)
                    {
                        label8.Text = "Your guess is not within the current range.";
                        textBox1.Text = "";
                        i++;
                    }
                    else
                    {
                        if (x > N)
                        {
                            label8.Text = "Smaller than " + x.ToString();
                            up = x;
                            label5.Text = up.ToString();
                            textBox1.Text = "";
                            i++;
                        }
                        if (x < N)
                        {
                            label8.Text = "Larger than" + x.ToString() ;
                            down = x;
                            label1.Text = down.ToString();
                            textBox1.Text = "";
                            i++;
                        }
                        if (x == N)
                        {
                            label8.Text = "Correct! The answer is " + x.ToString();
                            textBox1.Text = "";
                            vs1 = "YES";
                            button1.Text = "Finished";
                            over++;

                        }
                    }
                
                    
                }
                catch(FormatException ex)
                {
                    DialogResult False;
                    False = MessageBox.Show("Please enter an integer.", "Incorrect format.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    button1.Text = "Guess";
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
                Core_Form form1 = (Core_Form)this.Owner; //取得父視窗的參考
                form1.VS1(vs1);
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }

        }
    }
}
