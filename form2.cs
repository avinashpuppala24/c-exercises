using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_quiz
{
    public partial class Form1 : Form
    {
        Random randomiser = new Random();
        int addend1, addend2;
        int minued, subminued;
        int productend1, productend2;
        int div1, div2;

        
        int timeleft = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void startthequiz()
        {
            timelabel_label.BackColor = Color.White;
          
            DIFFERENCE.BackColor = Color.White;
            PRODUCT.BackColor = Color.White;
            QUOTIENT.BackColor = Color.White;
            addend1 = randomiser.Next(50);
            addend2 = randomiser.Next(50);
            PLUSLEFTLABEL_LABEL.Text = addend1.ToString();
            PLUSRIGHTLABEL_LABEL.Text = addend2.ToString();
           SUM.Value =0;
            SUM.BackColor = Color.White;


            minued = randomiser.Next(1, 101);
            subminued = randomiser.Next(1, minued);
            MINUSLEFTLABEL_LABEL.Text = minued.ToString();
            MINUSRIGHTLABEL_LABEL.Text = subminued.ToString();
            DIFFERENCE.Value = 0;
            DIFFERENCE.BackColor = Color.White;

            productend1 = randomiser.Next(15);
            productend2 = randomiser.Next(15);
            TIMESLEFTLABEL_LABEL.Text = productend1.ToString();
            TIMESRIGHTLABEL_LABEL.Text = productend2.ToString();
            PRODUCT.Value = 0;
            PRODUCT.BackColor = Color.White;


            div1 = randomiser.Next(0, 50);
            div2 = randomiser.Next(1, div1);
            DIVIDESLEFTLABEL_LABEL.Text = div1.ToString();
            DIVIDESRIGHTLABEL_LABEL.Text = div2.ToString();
            QUOTIENT.Value = 0;
            QUOTIENT.BackColor = Color.White;



            timeleft = 20;

            timelabel_label.Text = timeleft + " seconds";
            timer1.Start();
        }
        private bool checktheanswer()
        {
            if((addend1+addend2==SUM.Value) && (minued-subminued == DIFFERENCE.Value) && (productend1 *productend2 == PRODUCT.Value) && (div1 / div2 == QUOTIENT.Value))
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(DIFFERENCE.Value==minued-subminued)
            {
                DIFFERENCE.BackColor = Color.GreenYellow;
            }
            else
            {
                DIFFERENCE.BackColor = Color.DarkOrange;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timelabel_label_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PLUSLEFTLABEL_LABEL_Click(object sender, EventArgs e)
        {

        }

        private void SUM_ValueChanged(object sender, EventArgs e)
        {
           

                if (SUM.Value == addend1 + addend2)
                {
                    SUM.BackColor = Color.GreenYellow;
                }
            
            else
            {
                SUM.BackColor = Color.DarkOrange;
            }
        }

        private void PRODUCT_ValueChanged(object sender, EventArgs e)
        {
            if(PRODUCT.Value==productend1*productend2)
            {
                PRODUCT.BackColor = Color.GreenYellow;
            }
            else
            {
                PRODUCT.BackColor = Color.DarkOrange;
            }
        }

        private void QUOTIENT_ValueChanged(object sender, EventArgs e)
        {
            if(QUOTIENT.Value==div1/div2)
            {
                QUOTIENT.BackColor = Color.GreenYellow;
            }
            else
            {
                QUOTIENT.BackColor = Color.DarkOrange;
            }

        }

        private void START_button_Click(object sender, EventArgs e)
        {
            startthequiz();
            START_button.Enabled = false;

          }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checktheanswer())
            {
                

                timer1.Stop();
                MessageBox.Show("u did the correct answers", "congratulations");
                START_button.Enabled = true;

            }

            else if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                timelabel_label.Text = timeleft.ToString();
                if (timeleft < 5)

                {
                    timelabel_label.BackColor = Color.Red;
                }
            }
            else
            {
                timer1.Stop();
                timelabel_label.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");

                SUM.Value = addend1 + addend2;
                DIFFERENCE.Value = minued - subminued;
                PRODUCT.Value = productend1 * productend2;
                QUOTIENT.Value = div1 / div2;
                START_button.Enabled = true;

            }
        }

        private void answer_enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
       
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
