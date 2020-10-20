using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using matching_game.Properties;

namespace matching_game
{
    public partial class Form1 : Form
    {
       

        Random random = new Random();
        Label firstclicked = null;
        Label secondclicked = null;
        int timeleft = 0;

        List<string> icons = new List<string>()
        {
           "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
        };


        public Form1()
        {
            InitializeComponent();
            assigntosquares();
          
        }
        private void assigntosquares()
        {
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                Label iconlabel = ctrl as Label;
                if (iconlabel != null)
                {
                    int randomnumber = random.Next(icons.Count);
                    iconlabel.Text = icons[randomnumber];
                    icons.RemoveAt(randomnumber);
                    iconlabel.ForeColor = iconlabel.BackColor;

                }
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                return;
            }
            if (secondclicked != null)
            {
                return;
            }
            Label clickedlabel = sender as Label;
            if (clickedlabel != null)
            {
                if (clickedlabel.ForeColor == Color.Black)
                {
                    return;

                }

            }

            if (firstclicked == null)
            {
                // if (secondclicked == null)
                //{
                firstclicked = clickedlabel;
                firstclicked.ForeColor = Color.Black;
                //  secondclicked.ForeColor = Color.Black;
                return;
                //  }
            }
            timer2.Start();

            secondclicked = clickedlabel;
            secondclicked.ForeColor = Color.Black;
            checktheanswers();

            if (firstclicked.Text == secondclicked.Text)
            {
               

                firstclicked = null;
                secondclicked = null;
                SoundPlayer s = new SoundPlayer(Properties.Resources.Alarm_Fast_A1_www_fesliyanstudios_com__online_audio_converter_com_);
                s.PlaySync();
                return;
            }
           

            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstclicked.ForeColor = firstclicked.BackColor;
            secondclicked.ForeColor = secondclicked.BackColor;
            firstclicked = null;
            secondclicked = null;
        }
        private void checktheanswers()
        {
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                Label iconlabel = ctrl as Label;
                if (iconlabel != null)
                {
                    if (iconlabel.ForeColor == iconlabel.BackColor)
                    {
                        
                        return;
                    }
                }
            }

            MessageBox.Show("you matched all the icons", "congratulations");

            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            
               
                timelabel1_label.BackColor = Color.White;

                timeleft = timeleft + 1;
                timelabel1_label.Text = timeleft.ToString();

            


            


        }

    }
}
    
    

