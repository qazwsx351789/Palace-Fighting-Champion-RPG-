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
    public partial class Core_Form : Form
    {
        int loveNum = 10;
        int kaNum = 0;
        int tonNum = 0;
        int counter1, counter2,counter3,counter4,counter5,counter6,counter7;
        private string name;
        string check ,check1;

        public Core_Form()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            textBox2.Visible = false;
            pictureBox2.Visible = false;
            love.Visible = false;
            love.Text = "好感度 : " + loveNum;
            Reset();
            button4.Visible = false;
            button5.Visible = false;
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(final == 0)
            {
                name = textBox1.Text;
                if (name == "")
                {
                    MessageBox.Show("請先輸入名字！", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    hint.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = false;
                    label2.Visible = false;
                    textBox1.Visible = false;
                    button1.Visible = false;
                    timer1.Enabled = true;
                    love.Visible = true;

                }
            }
            else
            {
                pictureBox1.Image = imageList1.Images[0];
                ka.Visible = false;
                ton.Visible = false;
                label3.Visible = true;
                finalT.Enabled = true;
                button1.Visible = false;
                label1.Visible = false;

            }
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        int N = 0;
        int B5 = 0;
        int B4 = 0;
        int fail = 0;
        int T = 0;
        int final = 0;
        private void textBox2_Click(object sender, EventArgs e)
        {
            if(N == 0)
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = imageList1.Images[6];
                N++;
            }
            if(N == 2)
            {
                textBox2.Text = "嬤嬤 : " + name + "小主萬安，我是您的教養嬤嬤，今天是您進宮的第一天。\r\n"
                + "這個存菊堂以後就是您的住處了，有甚麼問題就問小亮子吧。";
                N++;
            }

            if (N == 4)
            {
                textBox2.Text = "";
                textBox2.Visible = false;
                hint.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button2.Text = "打賞嬤嬤，讓小亮子送他回去。";
                button3.Text = "點頭示意，自己默默走進去。";
                N++;
            }
            if (N == 6)
            {
                textBox2.Text = "旁白: 皇上召你侍寢，你想怎麼打扮 ?";
                N++;
            }
            if (N == 8)
            {
                textBox2.Text = "";
                hint.Visible = false;
                textBox2.Visible = false;
                button4.Visible = true;
                button5.Visible = true;
                N++;
            }
            if(B5==1)
            {
                

                this.Hide();
                Form2 form2 = new Form2(); //創建子視窗

                switch (form2.ShowDialog(this))
                {
                    case DialogResult.Yes: //Form2中按下ToForm1按鈕
                        this.Show(); //顯示父視窗
                        break;
                    default:
                        break;
                }
                textBox2.Text = "你平安度過了第一夜";
                B5--;
            }
            if (B4 == 1)
            {


                this.Hide();
                Form3 form2 = new Form3(); //創建子視窗

                switch (form2.ShowDialog(this))
                {
                    case DialogResult.Yes: //Form2中按下ToForm1按鈕
                        this.Show(); //顯示父視窗

                        break;
                    default:
                        break;
                }
                textBox2.Text = "你平安度過了第一夜";
                B4--;
            }
            if (N == 10)
            {
                hint.Visible = false;
                textBox2.Text = "";
                textBox2.Visible = false;
                timer3.Enabled = true;
                N++;
            }
            if(N==12)
            {
                textBox2.Text = "旁白:侍寢後的第一天早晨，你依規定來向皇后請安。";
                pictureBox2.Visible = true;
                pictureBox2.Image = imageList1.Images[13];
                N++;
            }
            if(N==14)
            {
                textBox2.Text = name + ": 皇后娘娘萬福金安。";
                N++;
            }
            if(N==16)
            {
                textBox2.Text = "旁白: 皇后想跟你一較高下";
                N++;
            }
            if(N==18)
            {
                this.Hide();
                Form4 form4 = new Form4(); //創建子視窗
                
                switch (form4.ShowDialog(this))
                {
                    case DialogResult.Yes: //Form2中按下ToForm1按鈕
                        this.Show(); //顯示父視窗
                        if(check == "YES")
                        {
                            textBox2.Text = "皇后覺得你很強，不敢弄你。";
                            loveNum = loveNum + 20;
                            love.Text = "好感度 : " + loveNum;

                        }
                        else if(check == "NO")
                        {
                            textBox2.Text = "皇后覺得你很好欺負，派人陷害你進冷宮";
                            fail++;
                        }
                        break;
                    default:
                        break;
                }
                N++;
            }
            if(N==20)
            {
                if(fail==1)
                {
                    FAIL();
                }
                else
                {
                    hint.Visible = false;
                    label1.Visible = false;
                    textBox2.Text = "";
                    textBox2.Visible = false;
                    pictureBox2.Visible = false;
                    timer4.Enabled = true;
                    N++;
                }
            }

            if (B5==0 && B4==0 && kaNum == 0 && tonNum == 0)
            {
                N++;
            }

            if(kaNum == 2)
            {
                this.Hide();
                Form5 form5 = new Form5(); //創建子視窗
                
                
                switch (form5.ShowDialog(this))
                {
                    case DialogResult.Yes: //Form2中按下ToForm1按鈕
                        this.Show(); //顯示父視窗
                        if (check1 == "YES")
                        {
                            textBox2.Text = "咖妃覺得你沒有讓她，生氣把你趕走。";
                            loveNum = loveNum - 10;
                            love.Text = "好感度 : " + loveNum;
                            kaNum = kaNum - 2;


                        }
                        else if (check1 == "NO")
                        {
                            textBox2.Text = "咖妃邀請你加入他的陣營";
                            loveNum = loveNum + 20;
                            love.Text = "好感度 : " + loveNum;
                            kaNum = kaNum - 2;
                        }
                        
                        break;
                    default:
                        break;
                 
                }
                N=22;
                


            }

            if(kaNum == 1)
            {
                textBox2.Text = "咖妃:妹妹來啦，快坐下!陪姊姊玩猜數字吧。";
                kaNum++;
                N = 21;
            }


            if (tonNum == 5)
            {
                textBox2.Text = "";
                hint.Visible = false;
                textBox2.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button2.Text = name + " : 多謝娘娘提醒，嬪妾以後都聽從您的話。";
                button3.Text = name + " : 多謝娘娘提醒，嬪妾會看著辦的。";
                tonNum = 0;

                N = 22;
            }

            if (tonNum == 4)
            {
                textBox2.Text = "躺嬪:(小聲)妹妹可有聽說咖妃娘娘勾結朝政之事?妹妹要謹慎選邊站阿。";
                pictureBox2.Image = imageList1.Images[19];
                tonNum++;
            }


            if(tonNum == 3)
            {
                textBox2.Text = "";
                hint.Visible = false;
                textBox2.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button2.Text = name + " : 當然可以，皇上還是很喜歡姐姐的。";
                button3.Text = name + " : 皇上不來見姐姐肯定有他的道理，姊姊再等等吧。";
                
            }


            if(tonNum == 2)
            {
                textBox2.Text = "";
                hint.Visible = false;
                textBox2.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button2.Text = name + " : 托姊姊的福，一切都好。";
                button3.Text = name + " : 皇上對我很好~送我好多東西呢!";
                
            }
            if(tonNum == 1)
            {
                textBox2.Text = "躺嬪: 妹妹早阿，宮裡的生活都還習慣嗎 ?";
                tonNum++;
            }

            if (N == 23)
            {
                if (loveNum <= 0)
                {
                    FAIL();
                }
                else
                {
                    hint.Visible = false;
                    textBox2.Text = "";
                    textBox2.Visible = false;
                    pictureBox2.Visible = false;
                    timer6.Enabled = true;
                    N++;
                }
                
                
            }


        }
        public void VS(string vs)
        {
            check = vs;
        }
        public void VS1(string vs1)
        {
            check1 = vs1;
        }
        private void Reset()
        {
            counter1 = 0;
            counter2 = 6;
            counter3 = 10;
            counter4 = 13;
            counter5 = 18;
            counter6 = 13;
            counter7 = 0;

            timer1.Enabled = false;	     // 暫停計時器
        }
        private void FAIL()
        {
            label1.Text = "旋風宮鬥冠軍";
            label1.Visible = false;
            textBox2.Text = "";
            pictureBox1.Image = imageList1.Images[14];
            pictureBox2.Visible = false;
            textBox2.Visible = false;
            love.Visible = false;
            restart.Visible = true;
            hint.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1++;
            if (counter1 == 6)
            {
                timer1.Enabled = false;
            }
            else if(counter1 < 6)
            {
                pictureBox1.Image = imageList1.Images[counter1];
            }

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(T==1)
            {
                hint.Visible = true;
                textBox2.Visible = true;
                loveNum = loveNum + 10;
                button2.Visible = false;
                button3.Visible = false;
                love.Text = "好感度 : " + loveNum;
                textBox2.Text = "躺嬪:皇上已經很久沒有來看我了...你願意在皇上跟前幫我說兩句話嗎?";
                T++;
                tonNum++;
            }
            else if(T==2)
            {
                hint.Visible = true;
                textBox2.Visible = true;
                loveNum = loveNum + 10;
                button2.Visible = false;
                button3.Visible = false;
                love.Text = "好感度 : " + loveNum;
                textBox2.Text = "小亮子:" + name + "小主，皇上約了您用晚膳，該出發了。";
                pictureBox2.Image = imageList1.Images[20];
                T++;
                tonNum++;
            }
            else if(T==3)
            {
                
                loveNum = loveNum - 10;

                button2.Visible = false;
                button3.Visible = false;
                love.Text = "好感度 : " + loveNum;
                pictureBox2.Visible = false;
                if (loveNum <= 0)
                {
                    FAIL();
                }
                else
                {
                    timer6.Enabled = true;
                }
               

                

            }
            else
            {
                loveNum = loveNum + 10;
                button2.Visible = false;
                button3.Visible = false;
                pictureBox2.Visible = false;
                love.Text = "好感度 : " + loveNum;
                timer2.Enabled = true;
                T++;
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter2--;
            if(counter2>2)
            {
                pictureBox1.Image = imageList1.Images[counter2];
            }
            else if(counter2 == 2)
            {
                
                label1.Visible = true;
                label1.Text = "第一夜";
                counter2 = counter2 - 6;
            }
            else if(counter2<-6&&counter2>-10)
            {
                pictureBox1.Image = imageList1.Images[counter2*(-1)];
            }
            else if(counter2==-10)
            {
                timer2.Enabled = false;
                textBox2.Visible = true;
                hint.Visible = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loveNum = loveNum + 10;
            love.Text = "好感度 : " + loveNum;
            button4.Visible = false;
            button5.Visible = false;
            textBox2.Visible = true;
            hint.Visible = true;
            textBox2.Text = "旁白:皇上看你穿著淡雅，冰雪聰明，考你個謎題";
            B4++;

        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            loveNum = loveNum - 10;
            love.Text = "好感度 : " + loveNum;
            hint.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            textBox2.Visible = true;
            textBox2.Text = "旁白:皇上不喜歡鮮豔的穿著，罰你寫五題數學題再回去。";
            B5++;

        }

 

        private void timer6_Tick(object sender, EventArgs e)
        {
            counter6--;
            if (counter6 > 9)
            {
                pictureBox1.Image = imageList1.Images[counter6];
            }
            else if (counter6 == 9)
            {


                counter6 = counter6 - 21;
            }
            else if (counter6 < -14 && counter6 > -18)
            {
                pictureBox1.Image = imageList1.Images[counter6 * (-1)];
            }
            else if (counter6 == -18)
            {
                label1.Visible = true;
                label1.Text = "選擇去哪個嬪妃的宮裡聊天";
                timer6.Enabled = false;
                ka.Visible = true;
                ton.Visible = true;
                counter6 = 13;
                if(k==1)
                {
                    ka.Enabled = false;

                }
                if(t==1 )
                {
                    ton.Enabled = false;
                }
                if(t+k==2)
                {
                    button1.Visible = true;
                    button1.Text = "結算";
                    final = 1;
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            counter4--;
            if (counter4 >9)
            {
                pictureBox1.Image = imageList1.Images[counter4];
            }
            else if (counter4 == 9)
            {

                
                counter4 = counter4 - 21;
            }
            else if (counter4 < -14 && counter4 > -18)
            {
                pictureBox1.Image = imageList1.Images[counter4 * (-1)];
            }
            else if (counter4 == -18)
            {
                label1.Visible = true;
                label1.Text = "選擇去哪個嬪妃的宮裡聊天";
                timer4.Enabled = false;
                ka.Visible = true;
                ton.Visible = true;
                
            }

        }

        private void ton_Click(object sender, EventArgs e)
        {
            t = 1;
            ka.Visible = false;
            ton.Visible = false;
            timer5.Enabled = true;
            tonNum++;
        }

        private void finalT_Tick(object sender, EventArgs e)
        {
            string x = "";
            counter7++;
            label3.Text = "你獲得的好感度是:" + loveNum;
            
            if(counter7 == 2)
            {
                if (loveNum<=9)
                {
                    x = "打入冷宮";
                    pictureBox1.Image = imageList1.Images[14];
                    
                }
                else if(loveNum>9&&loveNum<20)
                {
                    x = "常在";
                }
                else if(loveNum > 19 && loveNum < 40)
                {
                    x = "貴人";
                }
                else if (loveNum > 39 && loveNum < 60)
                {
                    x = "嬪";
                }
                else if (loveNum > 59 && loveNum < 80)
                {
                    x = "妃";
                }
                else if (loveNum > 79 && loveNum < 90)
                {
                    x = "貴妃";
                }
                else if (loveNum > 89)
                {
                    x = "皇后";
                }
                label3.Text = "你獲得的好感度是:" + loveNum + "\r\n" + "你最後的位份是:" + x;
                restart.Visible = true;
                finalT.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int k = 0, t = 0;
        private void ka_Click(object sender, EventArgs e)
        {
            k = 1;
            ka.Visible = false;
            ton.Visible = false;
            timer5.Enabled = true;
            kaNum ++;
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            counter5--;
            if (counter5 > 14)
            {
                pictureBox1.Image = imageList1.Images[counter5];
            }
            else if (counter5 == 14)
            {

                label1.Visible = false;
                counter5 = counter5 - 22;
            }
            else if (counter5 < -9 && counter5 > -13)
            {
                pictureBox1.Image = imageList1.Images[counter5 * (-1)];
            }
            else if (counter5 == -13)
            {
                textBox2.Visible = true;
                hint.Visible = true;
                pictureBox2.Visible = true;
                if(tonNum == 1)
                {
                    pictureBox2.Image = imageList1.Images[19];
                }
                else
                {
                    pictureBox2.Image = imageList1.Images[18];
                }
                
                timer5.Enabled = false;
                counter5 = 18;
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            loveNum = 10;
            Reset();
            textBox2.Visible = false;
            hint.Visible = false;
            pictureBox2.Visible = false;
            love.Visible = false;
            love.Text = "好感度 : " + loveNum;
            restart.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            N = 0;
            B5 = 0;
            B4 = 0;
            fail = 0;
            kaNum = 0;
            tonNum = 0;
            T = 0;
            button1.Visible = true;
            pictureBox1.Image = imageList1.Images[0];
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            check1 = "";
            check = "";
            k = 0;
            t = 0;
            final = 0;
            label3.Visible = false;
            label1.Text = "旋風宮鬥冠軍";
            button1.Text = "start!";
            ka.Enabled = true;
            ton.Enabled = true;
            label3.Text = "";




        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            counter3--;
            if (counter3 > 6)
            {
                pictureBox1.Image = imageList1.Images[counter3];
            }
            else if (counter3 == 6)
            {

                label1.Visible = true;
                label1.Text = "面見皇后";
                counter3= counter3 - 13;
            }
            else if (counter3 < -9 && counter3 > -13)
            {
                pictureBox1.Image = imageList1.Images[counter3 * (-1)];
            }
            else if (counter3 == -13)
            {
                timer3.Enabled = false;
                textBox2.Visible = true;
                hint.Visible = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(T==1)
            {
               
                
                textBox2.Visible = true;
                hint.Visible = true;
                textBox2.Text = "躺嬪:皇上已經很久沒有來看我了...你願意在皇上跟前幫我說兩句話嗎?";
                loveNum = loveNum - 10;
                button2.Visible = false;
                button3.Visible = false;
                love.Text = "好感度 : " + loveNum;
                tonNum++;
                T++;
                if (loveNum <= 0)
                {
                    FAIL();
                }

            }
            else if(T==2)
            {
                loveNum = loveNum - 10;
                if (loveNum <= 0)
                {
                    FAIL();
                }
                else
                {
                    textBox2.Visible = true;
                    hint.Visible = true;
                    
                    button2.Visible = false;
                    button3.Visible = false;
                    love.Text = "好感度 : " + loveNum;
                    textBox2.Text = "小亮子:[名字]小主，皇上約了您用晚膳，該出發了。";
                    pictureBox2.Image = imageList1.Images[20];
                    tonNum++;
                    T++;
                }
            }
            else if (T == 3)
            {
                loveNum = loveNum + 10;
                button2.Visible = false;
                button3.Visible = false;
                love.Text = "好感度 : " + loveNum;
                pictureBox2.Visible = false;
                timer6.Enabled = true;
            }
            else
            {
                button2.Visible = false;
                button3.Visible = false;
                pictureBox2.Visible = false;
                loveNum = loveNum + 5;
                love.Text = "好感度 : " + loveNum;
                timer2.Enabled = true;
                T++;
            }
            

        }
    }
}
