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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int ran1, ans, j;

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true; button3.Visible = true;
            label1.Enabled = true; label1.Visible = true;
            label2.Enabled = true; label2.Visible = true;
            label3.Enabled = true; label3.Visible = true;
            label4.Enabled = true; label4.Visible = true;
            textBox1.Enabled = true; textBox1.Visible = true;

            int[] rann = new int[2];
            Random rnd1 = new Random();
            for (int k = 0; k <= 0; k++)
            {
                ran1 = rnd1.Next(0, 100);
                rann[k] = ran1;
            }
            label1.Text = rann[0].ToString();
            label3.Text = rann[1].ToString();
            ans = rann[0] + rann[1];
            if (j == 5)
            {



                IsToForm1 = true;
                this.Close(); //強制關閉Form2




                j = 0;

            }
        }
        bool IsToForm1 = false; //紀錄是否要回到Form1

        private void button3_Click(object sender, EventArgs e)
        {
            j++;
            if (j == 5)
            {
                button3.Enabled = false; button3.Visible = false;
                label1.Enabled = false; label1.Visible = false;
                label2.Enabled = false; label2.Visible = false;
                label3.Enabled = false; label3.Visible = false;
                label4.Enabled = false; label4.Visible = false;
                textBox1.Enabled = false; textBox1.Visible = false;
                button1.Text = "End of the questioning. Quietly return to your own quarters.";
            }
            int nn;
            try
            {
                
                nn = int.Parse(textBox1.Text);
                if (!(nn == ans))
                {
                    DialogResult False;
                    False = MessageBox.Show("You answered incorrectly! The Emperor is watching you.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                textBox1.Text = "";
                int[] rann2 = new int[8];
                Random rnd1 = new Random();
                for (int i = 0; i <= 1; i++)
                {
                    ran1 = rnd1.Next(0, 100);
                    rann2[i] = ran1;
                }
                label1.Text = rann2[0].ToString();
                label3.Text = rann2[1].ToString();
                ans = rann2[0] + rann2[1];
            }
            catch(FormatException ex)
            {
                DialogResult False;
                False = MessageBox.Show("Please enter an integer.", "Incorrect format.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox1.Text = "";
                int[] rann2 = new int[8];
                Random rnd1 = new Random();
                for (int i = 0; i <= 1; i++)
                {
                    ran1 = rnd1.Next(0, 100);
                    rann2[i] = ran1;
                }
                label1.Text = rann2[0].ToString();
                label3.Text = rann2[1].ToString();
                ans = rann2[0] + rann2[1];
            }
        


            

        }

        protected override void OnClosing(CancelEventArgs e) //在視窗關閉時觸發
        {
            base.OnClosing(e);
            if (IsToForm1) //判斷是否要回到Form1
            {
                this.DialogResult = DialogResult.Yes; //利用DialogResult傳遞訊息
                Core_Form form1 = (Core_Form)this.Owner; //取得父視窗的參考

            }
            else
            {
                this.DialogResult = DialogResult.No;
            }

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            button3.Enabled = false; button3.Visible = false;
            label1.Enabled = false; label1.Visible = false;
            label2.Enabled = false; label2.Visible = false;
            label3.Enabled = false; label3.Visible = false;
            label4.Enabled = false; label4.Visible = false;
            textBox1.Enabled = false; textBox1.Visible = false;
            pictureBox1.Image = imageList1.Images[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
