using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Крестики_нолики
{
    public partial class Form1 : Form
    {
        int count = 0;
        int s1, s2, s3, s4, s5, s6, s7, s8, s9;
        bool winner;
        int c;
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            if (backgroundWorker1.IsBusy != true)
            {
                
               backgroundWorker1.RunWorkerAsync();
            }
            
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //Logic of game
        private void Chek()
        {

            if (s1 == s2 && s2 == s3 && s1 != 0)
            {
                winner = true;
                pictureBox1.Image = (pictureBox1.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox2.Image = (pictureBox2.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox3.Image = (pictureBox3.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
            }
            if (s4 == s5 && s5 == s6 && s4 != 0)
            {
                winner = true;
                pictureBox4.Image = (pictureBox4.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox5.Image = (pictureBox5.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox6.Image = (pictureBox6.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
            }
            if (s7 == s8 && s8 == s9 && s7 != 0)
            {
                winner = true;
                pictureBox7.Image = (pictureBox7.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox8.Image = (pictureBox8.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox9.Image = (pictureBox9.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
            }
            if (s1 == s4 && s4 == s7 && s1 != 0)
            {
                winner = true;
                pictureBox1.Image = (pictureBox1.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox4.Image = (pictureBox4.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox7.Image = (pictureBox7.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
            }
            if (s2 == s5 && s5 == s8 && s2 != 0)
            {
                winner = true;
                pictureBox2.Image = (pictureBox2.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox5.Image = (pictureBox5.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox8.Image = (pictureBox8.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
            }
            if (s3 == s6 && s6 == s9 && s3 != 0)
            {
                winner = true;
                pictureBox3.Image = (pictureBox3.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox6.Image = (pictureBox6.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox9.Image = (pictureBox9.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
            }
            if (s1 == s5 && s5 == s9 && s1 != 0)
            {
                winner = true;
                pictureBox1.Image = (pictureBox1.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox5.Image = (pictureBox5.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox9.Image = (pictureBox9.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
            }
            if (s7 == s5 && s5 == s3 && s7 != 0)
            {
                winner = true;
                pictureBox4.Image = (pictureBox4.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox5.Image = (pictureBox5.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
                pictureBox6.Image = (pictureBox6.Image == Properties.Resources.x_black) ? Properties.Resources.x_red : Properties.Resources.o_red;
            }
            if (winner == true)
            {
                MessageBox.Show("You win!");
                count = 0;
                pictureBox1.Image = Properties.Resources.NullField;
                pictureBox2.Image = Properties.Resources.NullField;
                pictureBox3.Image = Properties.Resources.NullField;
                pictureBox4.Image = Properties.Resources.NullField;
                pictureBox5.Image = Properties.Resources.NullField;
                pictureBox6.Image = Properties.Resources.NullField;
                pictureBox7.Image = Properties.Resources.NullField;
                pictureBox8.Image = Properties.Resources.NullField;
                pictureBox9.Image = Properties.Resources.NullField;
                s1 = 0;
                s2 = 0;
                s3 = 0;
                s4 = 0;
                s5 = 0;
                s6 = 0;
                s7 = 0;
                s8 = 0;
                s9 = 0;
                winner = false;

            }
            if (count == 9)
            {
                MessageBox.Show("Draw!");
            }



        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                this.pictureBox7.Image = Properties.Resources.o_black;
                 s7 = 1;
            }
            else
            {
                this.pictureBox7.Image = Properties.Resources.x_black;
              s7 = 2;
            }
            Chek();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                this.pictureBox2.Image = Properties.Resources.o_black;
                s2 = 1;
            }
            else
            {
                this.pictureBox2.Image = Properties.Resources.x_black;
                s2 = 2;
            }
            Chek();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                this.pictureBox3.Image = Properties.Resources.o_black;
                s3 = 1;
            }
            else
            {
                this.pictureBox3.Image = Properties.Resources.x_black;
                s3 = 2;
            }
            Chek();
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {

                this.pictureBox6.Image = Properties.Resources.o_black;
                s6 = 1;
            }
            else
            {
                this.pictureBox6.Image = Properties.Resources.x_black;
                s6 = 2;
            }
            Chek();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                this.pictureBox1.Image = Properties.Resources.o_black;
                s1 = 1;
            }
            else
            {
                this.pictureBox1.Image = Properties.Resources.x_black;
                s1 = 2;
            }
            Chek();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                s4 = 1;
                this.pictureBox4.Image = Properties.Resources.o_black;
            }
            else
            {
                this.pictureBox4.Image = Properties.Resources.x_black;
                s4 = 2;
            }
            Chek();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                this.pictureBox8.Image = Properties.Resources.o_black;
                s8 = 1;
            }
            else
            {
                this.pictureBox8.Image = Properties.Resources.x_black;
                s8 = 2;
            }
            Chek();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                this.pictureBox5.Image = Properties.Resources.o_black;
                s5 = 1;
            }
            else
            {
                this.pictureBox5.Image = Properties.Resources.x_black;
                s5 = 2;
            }
            Chek();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                s9 = 1;
                this.pictureBox9.Image = Properties.Resources.o_black;
            }
            else
            {
                s9 = 2;
                this.pictureBox9.Image = Properties.Resources.x_black;
            }
            Chek();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            
            count = 0;
            pictureBox1.Image = Properties.Resources.NullField;
            pictureBox2.Image = Properties.Resources.NullField;
            pictureBox3.Image = Properties.Resources.NullField;
            pictureBox4.Image = Properties.Resources.NullField;
            pictureBox5.Image = Properties.Resources.NullField;
            pictureBox6.Image = Properties.Resources.NullField;
            pictureBox7.Image = Properties.Resources.NullField;
            pictureBox8.Image = Properties.Resources.NullField;
            pictureBox9.Image = Properties.Resources.NullField;
            s1 = 0;
            s2 = 0;
            s3 = 0;
            s4 = 0;
            s5 = 0;
            s6 = 0;
            s7 = 0;
            s8 = 0;
            s9 = 0;

        }

       
       private void OneSecond()
       {
           Thread.Sleep(1000);
       }
        

       private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
       {
           BackgroundWorker worker = sender as BackgroundWorker;

           for (int i = 0; i < 3600; i++)
           {
          

               OneSecond();
               worker.ReportProgress(i);
                
                   
           }

       }

       private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
       {
           label1.Text = (c++).ToString()+ " seconds";
           
       }
       private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
       {
           
       }
      
        

        
    }
}
