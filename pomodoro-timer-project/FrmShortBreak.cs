using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodoro_timer_project
{
    public partial class FrmShortBreak : Form
    {
        public FrmShortBreak()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPomodoro fr = new FrmPomodoro();
            fr.Show();
            this.Hide();
        }

        int minuteCount = 5, secondsCount = 59;

        private void TmrSeconds_Tick(object sender, EventArgs e)
        {
            secondsCount--;
            LblSeconds.Text = secondsCount.ToString();
            if (secondsCount==0)
            {
                minuteCount--;
                LblMinutes.Text=minuteCount.ToString();
                secondsCount = 59;
            }
            else if (minuteCount==0)
            {
                TmrSeconds.Stop();
                LblTimeToFocus.Visible= true;
                
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TmrSeconds.Stop();
        }

        private void FrmShortBreak_Load(object sender, EventArgs e)
        {
            LblTimeToFocus.Visible= false;
        }

        private void BtnLongBreak_Click(object sender, EventArgs e)
        {

            FrmLongBreak fr = new FrmLongBreak();
            fr.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TmrSeconds.Start();
        }
    }
}
