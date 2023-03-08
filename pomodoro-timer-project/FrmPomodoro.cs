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

            TmrSeconds.Start();
            //Start butonuna tıkladığı zaman timer'ı çalıştırıyor.
          
        }
        int minuteCount = 25, secondsCount = 59;
        //Geriye sayılacak olan değişkenlerin tanımlanması.
      
        private void TmrMinutes_Tick(object sender, EventArgs e)
        {
            secondsCount--;
            //Timer başlayınca seconds değişkenini bir bir azaltıyor.
            LblSecond.Text = secondsCount.ToString();
            //Azalan değeri ekrana yazdırıyor.
            if (secondsCount==0)
            {
                minuteCount--;
                //Seconds değişkeni "0" olduğu zaman minute değişkenini bir azaltıyor.
                LblMinutes.Text= minuteCount.ToString();
                //Azalan minute değerini ekrana yazdırıyor.
                secondsCount = 59;
                //0 olan seconds değişkenini tekrardan 59 olarak tanımlıyoruz.
            }
            else if (minuteCount==0)
            {
                
                TmrSeconds.Stop();
                //Minute değişkeni 0 olduğu zaman timer'ı durduruyoruz.
                LblSecond.Text = "00";
                LblMinutes.Text = "00";
                //Seconds ve Minutes label'larına "00" yazdırıyoruz.
                frShortBreak.Show();
                this.Hide();

            }
        }
        FrmShortBreak frShortBreak = new FrmShortBreak();
        //TMR_Minutes kod bloğunda çalışması için FrmShortBreak ekranımı global olarak tanımlıyoruz.
        private void button2_Click(object sender, EventArgs e)
        {
            
            frShortBreak.Show();
            this.Hide();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
           
            TmrSeconds.Stop();
            //Timer'ı durduruyor.
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void LoginImg_Click(object sender, EventArgs e)
        {
            FrmLogin fr = new FrmLogin();
            fr.Show();
        }

        private void BtnLongBreak_Click(object sender, EventArgs e)
        {
            FrmLongBreak fr = new FrmLongBreak();
            fr.Show();
            this.Hide();
        }

        private void FrmPomodoro_Load(object sender, EventArgs e)
        {
            LblTimeToBreak.Visible = false;
            //Sadece zaman dolduğu zaman ekranda gözükmesini istediğim yazıyı, uygulama başladığı zaman görmek istemediğim için
            //Visible özelliğini false yapıyorum.
        }
    }
}
