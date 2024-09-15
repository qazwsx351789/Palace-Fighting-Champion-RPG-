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
            love.Text = "Favorability: " + loveNum;
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
                    MessageBox.Show("Please ensure that your name is not left blank.！", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                textBox2.Text = "Nanny : " + name + "Greetings, Young Master I am your instructing nanny. Today is your first day in the palace. \r\n"
                + "This is the Storage Chrysanthemum Hall, which will be your residence from now on. If you have any questions, please ask Xiao Liangzi.";
                N++;
            }

            if (N == 4)
            {
                textBox2.Text = "";
                textBox2.Visible = false;
                hint.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button2.Text = "Give a reward to the nanny, and have Xiao Liangzi escort her back.";
                button3.Text = "Nodding in acknowledgment, he quietly walked inside.";
                N++;
            }
            if (N == 6)
            {
                textBox2.Text = "Narrator: The Emperor has summoned you to his chamber. How would you like to dress?";
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
                textBox2.Text = "You have safely passed your first night.";
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
                textBox2.Text = "You have safely passed your first night.";
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
                textBox2.Text = "Narrator: On the morning after spending the night in the Emperor's chamber, you are to formally pay your respects to the Empress as per the rules.";
                pictureBox2.Visible = true;
                pictureBox2.Image = imageList1.Images[13];
                N++;
            }
            if(N==14)
            {
                textBox2.Text = name + ": Greetings, Empress. Wishing you longevity and peace.";
                N++;
            }
            if(N==16)
            {
                textBox2.Text = "The Empress wishes to test her skills against you.";
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
                            textBox2.Text = "The Empress finds you formidable and is hesitant to challenge you.";
                            loveNum = loveNum + 20;
                            love.Text = "Favorability: " + loveNum;

                        }
                        else if(check == "NO")
                        {
                            textBox2.Text = "The Empress perceives you as easily bullied and has dispatched someone to frame you and send you to the Cold Palace.";
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
                            textBox2.Text = "Concubine Ka is upset that you did not yield to her and has ordered you to leave.";
                            loveNum = loveNum - 10;
                            love.Text = "Favorability: " + loveNum;
                            kaNum = kaNum - 2;


                        }
                        else if (check1 == "NO")
                        {
                            textBox2.Text = "Concubine Ka invites you to join her faction.";
                            loveNum = loveNum + 20;
                            love.Text = "Favorability: " + loveNum;
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
                textBox2.Text = "Concubine Ka: Sister, come here! Sit down quickly and join me in a game of guessing numbers.";
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
                button2.Text = name + ": Thank you for the reminder, Your Highness. I will follow your guidance from now on.";
                button3.Text = name + ": Thank you for the reminder, Your Highness. I will take care of it.";
                tonNum = 0;

                N = 22;
            }

            if (tonNum == 4)
            {
                textBox2.Text = "Tom Concubine: (whispering)Sister, have you heard about Concubine Ka's involvement in political intrigues? You should be cautious about which side you choose.";
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
                button2.Text = name + " : Of course, the Emperor still likes you very much, Sister.";
                button3.Text = name + " : There must be a reason why the Emperor hasn’t come to see you, Sister. Please be patient and wait a little longer.";
                
            }


            if(tonNum == 2)
            {
                textBox2.Text = "";
                hint.Visible = false;
                textBox2.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button2.Text = name + ": Thanks to your blessings, everything is going well.";
                button3.Text = name + ": The Emperor is very kind to me~ He has given me so many gifts!";
                
            }
            if(tonNum == 1)
            {
                textBox2.Text = "Tom Concubine: Good morning, Sister. Are you adjusting well to life in the palace?";
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
            label1.Text = "Palace Fighting Champion";
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
                love.Text = "Favorability: " + loveNum;
                textBox2.Text = "Tom Concubine: The Emperor hasn't visited me for a long time... Would you be willing to speak on my behalf when you're in his presence?";
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
                love.Text = "Favorability: " + loveNum;
                textBox2.Text = "Xiao Liangzi:" + name + ", the Emperor has requested your presence for dinner. It’s time to head out.";
                pictureBox2.Image = imageList1.Images[20];
                T++;
                tonNum++;
            }
            else if(T==3)
            {
                
                loveNum = loveNum - 10;

                button2.Visible = false;
                button3.Visible = false;
                love.Text = "Favorability: " + loveNum;
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
                love.Text = "Favorability: " + loveNum;
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
                label1.Text = "First night";
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
            love.Text = "Favorability: " + loveNum;
            button4.Visible = false;
            button5.Visible = false;
            textBox2.Visible = true;
            hint.Visible = true;
            textBox2.Text = "Narrator: The Emperor, seeing your elegant attire and keen intellect, has decided to challenge you with a riddle.";
            B4++;

        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            loveNum = loveNum - 10;
            love.Text = "Favorability: " + loveNum;
            hint.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            textBox2.Visible = true;
            textBox2.Text = "Narrator: The Emperor dislikes flamboyant attire and has punished you by requiring you to solve five math problems before you can return.";
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
                label1.Text = "Choose which concubine's quarters you would like to visit.";
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
                    button1.Text = "Settlement";
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
                label1.Text = "Choose which concubine's quarters you would like to visit.";
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
            label3.Text = "The affection you have earned is:" + loveNum;
            
            if(counter7 == 2)
            {
                if (loveNum<=9)
                {
                    x = "Sent to the Cold Palace";
                    pictureBox1.Image = imageList1.Images[14];
                    
                }
                else if(loveNum>9&&loveNum<20)
                {
                    x = "First Class Female Attendant";
                }
                else if(loveNum > 19 && loveNum < 40)
                {
                    x = "Noble Ladies";
                }
                else if (loveNum > 39 && loveNum < 60)
                {
                    x = "Imperial Concubines";
                }
                else if (loveNum > 59 && loveNum < 80)
                {
                    x = "Consorts";
                }
                else if (loveNum > 79 && loveNum < 90)
                {
                    x = " Noble Consorts";
                }
                else if (loveNum > 89)
                {
                    x = "Imperial Noble Consort";
                }
                label3.Text = "The affection you have earned is:" + loveNum + "\r\n" + "Your final position is:" + x;
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
            love.Text = "Favorability   : " + loveNum;
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
            label1.Text = "Palace Fighting Champion";
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
                label1.Text = "Audience with the Empress";
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
                textBox2.Text = "Tom Concubine: The Emperor hasn’t visited me for a long time... Would you be willing to speak on my behalf when you are in his presence?";
                loveNum = loveNum - 10;
                button2.Visible = false;
                button3.Visible = false;
                love.Text = "Favorability: " + loveNum;
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
                    love.Text = "Favorability: " + loveNum;
                    textBox2.Text = "Xiao Liangzi:" + name + ", the Emperor has requested your presence for dinner. It’s time to head out.";
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
                love.Text = "Favorability: " + loveNum;
                pictureBox2.Visible = false;
                timer6.Enabled = true;
            }
            else
            {
                button2.Visible = false;
                button3.Visible = false;
                pictureBox2.Visible = false;
                loveNum = loveNum + 5;
                love.Text = "Favorability: " + loveNum;
                timer2.Enabled = true;
                T++;
            }
            

        }
    }
}
