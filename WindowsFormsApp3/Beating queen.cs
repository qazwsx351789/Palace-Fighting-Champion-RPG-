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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string child = "Blood Bond Test";
        string toxic = "Poisoning";
        string good = "Praise";
        string you = "Secure";
        string[] queen;
        int ini = 100;
        int Queen = 300;
        int round = 1;
        int skill1 = 20, skill4 = 30;
        string check;
        string vs;
        public void VS(string vs)
        {
             check = vs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ini = ini + skill1;
            label3.Visible = true;
            
            label3.Text = "You used Flattery, increasing health by" + skill1;
            label2.Text = ini.ToString();
            start();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            skill4 = skill4 * 2;
            button4.Text = "Taunt (causing damage to be " + skill4 + ")";
            label3.Visible = true;
            label3.Text = "You used Taunt, causing damage to be " + skill4;
            start();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Queen = Queen - skill4;
            label3.Visible = true;
            label3.Text = "You used Frame, reducing the Empress's health by " + skill4;
            label9.Text = Queen.ToString();
            if(Queen<=0)
            {
                button6.Visible = true;
                vs = "YES";
            }
            else
            {
                start();
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label4.Text = "";
            label2.Text = ini.ToString();
            label6.Text = round.ToString();
            label9.Text = Queen.ToString();
            queen = new string[] { child, toxic, good, you };
        }

        int counter1;
        private void button3_Click(object sender, EventArgs e)
        {
            skill1 = skill1 + 20;
            button1.Text = "Play the Victim ( healing increasing by " + skill1 + ")";
            label3.Visible = true;
            label3.Text = "You used Play the Victim, increasing healing by 20.";
            start();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label11.Text = "Your turn";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Visible = false;
            round++;
            label6.Text = round.ToString();
        }
        int queenAttack = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1++;
            if(counter1 == 2)
            {
                label3.Visible = false;
                
                label11.Text = "Empress's turn";
            }
            if (counter1 == 4)
            {
                Random ran = new Random();
                int i = ran.Next(0, 4);
                label3.Visible = true;
                if (i==3)
                {
                    label3.Text = "The Empress uses" + queen[i]+ "，You safely passed this round.";
                }
                else if (i == 2)
                {
                    label3.Text = "The Empress uses" + queen[i] + ", increasing the Empress's attack power by 20.";
                    queenAttack = queenAttack + 20;
                }
                else if(i == 1)
                {
                    label3.Text = "The Empress uses" + queen[i] + ", you get" + queenAttack + "dameges";
                    ini = ini - queenAttack;
                    label2.Text = ini.ToString();
                    if(ini<=0)
                    {
                        vs = "NO";
                        button6.Visible = true;
                        button6.Text = "Fail...";
                        timer1.Enabled = false;
                    }
                }
                else if (i == 0)
                {
                    label3.Text = "The Empress uses" + queen[i] + ", restoring 50 health points to the Empress.";
                    Queen = Queen + 50;
                    label9.Text = Queen.ToString();
                }


            }
            if (counter1 == 6)
            {
                button5.Visible = true;
                timer1.Enabled = false;
            }

        }

        bool IsToForm1 = false; //紀錄是否要回到Form1
        private void button6_Click(object sender, EventArgs e)
        {
            IsToForm1 = true;
            this.Close(); //強制關閉Form2
        }
        protected override void OnClosing(CancelEventArgs e) //在視窗關閉時觸發
        {
            base.OnClosing(e);
            if (IsToForm1) //判斷是否要回到Form1
            {
                this.DialogResult = DialogResult.Yes; //利用DialogResult傳遞訊息
                Core_Form form1 = (Core_Form)this.Owner; //取得父視窗的參考
                form1.VS(vs);
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }

        }

        private void start()
        {
            counter1 = 0;
            
            timer1.Enabled = true;	     // 暫停計時器
        }
    }
}
