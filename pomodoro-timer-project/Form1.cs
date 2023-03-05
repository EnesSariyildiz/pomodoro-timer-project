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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            BtnStart.FlatAppearance.BorderSize = 0;
            BtnStart.BackColor = this.BackColor;
            TmrMinutes.Start();
        }
        int count = 25;
        private void TmrMinutes_Tick(object sender, EventArgs e)
        {
            count--;
            LblMinutes.Text = count.ToString();
        }
    }
}
