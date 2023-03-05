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

namespace pomodoro_timer_project
{
    public partial class FrmPomodoro : Form
    {
        public FrmPomodoro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            TmrMinutes.Start();
            BtnStart.Hide();
            BtnStop.Show();
        }
        int minuteCount = 25;
        int secondsCount = 60;
        private void TmrMinutes_Tick(object sender, EventArgs e)
        {
            secondsCount--;
            LblSecond.Text = secondsCount.ToString();
            if (secondsCount==0)
            {
                
                
            }

            //Minutescount--;
            //LblMinutes.Text = Minutescount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmShortBreak fr = new FrmShortBreak();
            fr.Show();
            this.Hide();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            BtnStop.Hide();
            BtnStart.Show();
            TmrMinutes.Stop();
        }
    }
}
