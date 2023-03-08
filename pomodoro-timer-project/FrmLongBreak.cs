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
    public partial class FrmLongBreak : Form
    {
        public FrmLongBreak()
        {
            InitializeComponent();
        }

        private void BtnPomodoro_Click(object sender, EventArgs e)
        {
            FrmPomodoro fr = new FrmPomodoro();
            fr.Show();
            this.Hide();
        }

        private void BtnShortBreak_Click(object sender, EventArgs e)
        {
            FrmShortBreak fr = new FrmShortBreak();
            fr.Show();
            this.Hide();
        }

        private void BtnLongBreak_Click(object sender, EventArgs e)
        {
            FrmLongBreak fr = new FrmLongBreak();
            fr.Show();
            this.Hide();
        }
        int secondsCount=59,minuteCount=15;
        // iki adet geriye sayılacak olan değişkenleri tanımlıyoruz.

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TmrSeconds.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TmrSeconds.Stop();
            //Timer'ı durduruyor.
        }

        private void TmrSeconds_Tick(object sender, EventArgs e)
        {
            secondsCount--;
            LblSeconds.Text = secondsCount.ToString();
            if (secondsCount==0)
            {
                minuteCount--;
                secondsCount= 59;
            }

        }
    }
}
