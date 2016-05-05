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
using System.IO;

namespace PomoDoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblPomoCount.Text = c.ToString() + " Pomo Sessions";
            lblPomoTime.Text = "Pomo " + mP + ":0" + sP;
            lblPomoTimeAll.Text = "Total Pomo Time " + h + ":0" + m + ":0" + s ;
            lblLazyTime.Text = "Lazy " + mL + ":0" + sL;;
            lblLazyTimeAll.Text = "Total Lazy Time " + h + ":0" + mL_a + ":0" + sL_a;
            this.ClientSize = new System.Drawing.Size(414, 260);
            btnExpand.Text = "Settings";
            timerLazy.Start();

        }

        int s = 0;
        int m = 0;
        int h = 0;
        int c = 0;
        int sP = 0;
        int mP = 25;
        int sL = 0;
        int mL = 0;
        int hL = 0;
        int sL_a = 0;
        int mL_a = 0;
        int hL_a = 0;

        // Pomo Timer counts pomo seconds and minutes, and also overall pomo seconds and minutes. + Some optical highlights.
        private void timerPomo_Tick(object sender, EventArgs e)
        {
            this.lblLazyTime.ForeColor = System.Drawing.Color.Gray;
            this.lblLazyTimeAll.ForeColor = System.Drawing.Color.Gray;
            this.lblPomoTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.lblPomoTimeAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.barPomo.Size = new System.Drawing.Size(390, 23);
            this.barLazy.Size = new System.Drawing.Size(390, 10);
           // Timer starts with 0 and jumps back to 59, for countdown.
            if (sP == -1)
            {
                sP = 59;
                mP = mP - 1;           
            }

            // This ends a Pomo, when mP reaches 0 it resets the counter.
            if (mP == 0 && sP == 0)
            {                             
                c = c + 1;
                sP--;
                if (checkSound.Checked == true)
                {
                    SoundPlayer snd = new SoundPlayer(Properties.Resources.yay);
                    snd.Play();
                }
                else
                {
                    SoundPlayer snd = new SoundPlayer(Properties.Resources.yay);
                    snd.Stop();
                }
                
                MessageBox.Show(this, 
                    "LazyPomo recommends you to be lazy now for 5 minutes.", 
                    " Lazy!", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1,
                    (MessageBoxOptions)0x40000);
                this.timerPomo.Stop();
                mP = 25;
                sP = 00;
                this.barPomo.Value = 0;
                lblPomoCount.Text = c.ToString() + " Pomo Sessions";
                timerLazy.Start();
                btnPomo.Text = "Next Pomo!";
            
            }

            // This summs up the overall time as readable time.
            if (s == 60)
            {
                s = 0;
                m = m + 1;
            }
            if (m == 60)
            {
                m = 0;
                h = h + 1;
            }

            // Checks if 0 has to be displayed on the Pomo Time.
            if (sP < 10)
            {
                lblPomoTime.Text = "Pomo " + mP + ":0" + sP;
            }

            else
            {
                lblPomoTime.Text = "Pomo " + mP + ":" + sP;
            }
            // Checks if 0 has to be displayed on Overall Pomo Time.
            if (s < 10)
            {
                
                if (m < 10)
                {
                    lblPomoTimeAll.Text = "Total Pomo Time " + h + ":0" + m + ":0" + s;
                }
                else
                {
                    lblPomoTimeAll.Text = "Total Pomo Time " + h + ":" + m + ":0" + s;
                }
            }

            else
            {
                if (m < 10)
                {
                    lblPomoTimeAll.Text = "Total Pomo Time " + h + ":0" + m + ":" + s;
                }
                else
                {
                    lblPomoTimeAll.Text = "Total Pomo Time " + h + ":" + m + ":" + s;
                }            
            }

            barPomo.Increment(1);
            s++;
            sP = sP - 1;

        }

        // Pomo Button starts Pomo Timer or pauses it.
        private void btnPomo_Click(object sender, EventArgs e)
        {
            if (btnPomo.Text == "Pomo!" || btnPomo.Text == "Next Pomo!")
            {
                timerPomo.Start();
                timerLazy.Stop();
                btnPomo.Text = "Pause";
                sL = 0;
                mL = 0;
                lblLazyTime.Text = "Lazy " + mL + ":0" + sL;
                barLazy.Value = 0;
                

            }

            else
            {
                timerPomo.Stop();
                timerLazy.Start();
                btnPomo.Text = "Pomo!";
               
            }
            if (btnExpand.Text == "Settings")
            {
                this.ClientSize = new System.Drawing.Size(414, 260);
                btnExpand.Text = "Settings";
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(414, 420);
                btnExpand.Text = "Hide";

            }
        }

        // Lazy Timer. Counts Lazy Time, Overall Lazy Time and does some optical highlighting.
        private void timerLazy_Tick(object sender, EventArgs e)
        {
            this.lblLazyTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.lblLazyTimeAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.lblPomoTime.ForeColor = System.Drawing.Color.Gray;
            this.lblPomoTimeAll.ForeColor = System.Drawing.Color.Gray;
            this.barPomo.Size = new System.Drawing.Size(390, 10);
            this.barLazy.Size = new System.Drawing.Size(390, 23);
            sL_a++;
            lblLazyTimeAll.Text = "Total Lazy Time " + mL_a + ":" + sL_a;

            if (sL_a == 60)
            {
                mL_a = mL_a + 1;
                sL_a = 0;
                
            }
            if (mL_a == 60)
            {
                hL_a = hL_a + 1;
                mL_a = 0;
            }

            if (btnPomo.Text == "Next Pomo!")
            {
                sL++;
                lblLazyTime.Text = "Lazy " + mL + ":" + sL; ; //check if conditions later for 0
                barLazy.Increment(1);

                if (sL == 60)
                {
                    mL = mL + 1;
                    sL = 0;
                }
                if (mL == 5)
                {
                    mL = 0;
                    sL = 0;
                    btnPomo.Text = "Pomo!";
                    lblLazyTime.Text = "Lazy 5:00" ;
                    if (checkSound.Checked == true)
                    {
                        SoundPlayer snd = new SoundPlayer(Properties.Resources._3beeps);
                        snd.Play();
                    }
                    else
                    {
                        SoundPlayer snd = new SoundPlayer(Properties.Resources._3beeps);
                        snd.Stop();
                    }
                    MessageBox.Show("Time for your next Pomo!", 
                        " Let's do it!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk,
                        MessageBoxDefaultButton.Button1,
                        (MessageBoxOptions)0x40000);
                }

            }
            // Checks if 0 has to be displayed on the Lazy Time.
            if (sL < 10)
            {
                lblLazyTime.Text = "Lazy " + mL + ":0" + sL;
            }

            else
            {
                lblLazyTime.Text = "Lazy " + mL + ":" + sL;
            }
            // Checks if 0 has to be displayed on Overall Lazy Time.
            if (sL_a < 10)
            {
                if (mL_a < 10)
                {
                    lblLazyTimeAll.Text = "Total Lazy Time " + hL_a + ":0"+ mL_a + ":0" + sL_a;
                }
                else
                {
                    lblLazyTimeAll.Text = "Total Lazy Time " + hL_a + ":" + mL_a + ":0" + sL_a;
                }
            }

            else
            {
                if (mL_a < 10)
                {
                    lblLazyTimeAll.Text = "Total Lazy Time " + hL_a + ":0" + mL_a + ":" + sL_a;
                }
                else
                {
                    lblLazyTimeAll.Text = "Total Lazy Time " + hL_a + ":" + mL_a + ":" + sL_a;
                }
            }

        }

        // Checkbox to keep the window on top, if checked.
        private void checkTop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTop.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;

              
            }
        }

        // To hide or show the "About" section.
        private void btnExpand_Click(object sender, EventArgs e)
        {
            
            if (btnExpand.Text == "Hide")
            {
                this.ClientSize = new System.Drawing.Size(414, 260);
                btnExpand.Text = "Settings";
                this.btnExpand.BackColor = System.Drawing.SystemColors.AppWorkspace;

            }
            else
            {
                this.ClientSize = new System.Drawing.Size(414, 420);
                btnExpand.Text = "Hide";
                this.btnExpand.BackColor = Color.Silver;
                
                
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = lblPomoCount.Text + "\r\n" + lblPomoTimeAll.Text +"\r\n"+ lblLazyTimeAll.Text;
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(richTextBox1.Text);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }


  
 

      


    }
}
