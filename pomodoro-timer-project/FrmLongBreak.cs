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
        

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TmrSeconds.Start();
            //Timer'ı başlatıyor.
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TmrSeconds.Stop();
            //Timer'ı durduruyor.
        }

        int secondsCount = 59, minuteCount = 2;
        //İki adet geriye sayılacak olan değişkenleri tanımlıyoruz.
        private void TmrSeconds_Tick(object sender, EventArgs e)
        {
            secondsCount--;
            //Timer başlayınca yukarıda tanımladığım değişkeni bir bir eksiltiyor.
            LblSeconds.Text = secondsCount.ToString();
            //Eksiltilen değer ekranda yazdırılıyor.
            if (secondsCount==0)
            {              
                minuteCount--;
                //Seconds değişkeni "0" olduğu zaman minute değişkenini bir azaltıyor.
                LblMinutes.Text = minuteCount.ToString();
                secondsCount = 59;
                //Seconds değişkeni"0" olduğu zaman tekrardan 59' değerinden başlatılıyor. 
            }
            else if (minuteCount==0)
            {
                TmrSeconds.Stop();
                LblSeconds.Text = "00";
            }


        }
    }
}
