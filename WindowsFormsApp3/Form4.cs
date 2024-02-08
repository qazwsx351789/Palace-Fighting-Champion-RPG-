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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string child = "滴血認親";
        string toxic = "下毒";
        string good = "抬舉";
        string you = "拉攏";
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
            
            label3.Text = "你使用諂媚，血量加" + skill1;
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
            button4.Text = "陷害(造成" + skill4 + "傷害)";
            label3.Visible = true;
            label3.Text = "你使用嘲諷，傷害變為"+skill4;
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
            label3.Text = "你使用陷害，皇后血量減少" + skill4;
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
            button1.Text = "諂媚(血量 + " + skill1 + ")";
            label3.Visible = true;
            label3.Text = "你使用裝可憐，回血增加20";
            start();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label11.Text = "你的回合";
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
                
                label11.Text = "皇后的回合";
            }
            if (counter1 == 4)
            {
                Random ran = new Random();
                int i = ran.Next(0, 4);
                label3.Visible = true;
                if (i==3)
                {
                    label3.Text = "皇后對你使用"+ queen[i]+"，平安度過這一回合";
                }
                else if (i == 2)
                {
                    label3.Text = "皇后對你使用" + queen[i] + "，皇后攻擊力加20";
                    queenAttack = queenAttack + 20;
                }
                else if(i == 1)
                {
                    label3.Text = "皇后對你使用" + queen[i] + "，你受到" + queenAttack + "點傷害";
                    ini = ini - queenAttack;
                    label2.Text = ini.ToString();
                    if(ini<=0)
                    {
                        vs = "NO";
                        button6.Visible = true;
                        button6.Text = "失敗...";
                        timer1.Enabled = false;
                    }
                }
                else if (i == 0)
                {
                    label3.Text = "皇后對你使用" + queen[i] + "，皇后血量回復50點";
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
                Form1 form1 = (Form1)this.Owner; //取得父視窗的參考
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
