namespace pomodoro_timer_project
{
    partial class FrmLongBreak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLongBreak));
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnLongBreak = new System.Windows.Forms.Button();
            this.BtnShortBreak = new System.Windows.Forms.Button();
            this.BtnPomodoro = new System.Windows.Forms.Button();
            this.LblSeconds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblMinutes = new System.Windows.Forms.Label();
            this.TmrSeconds = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(103)))));
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.ForeColor = System.Drawing.Color.Black;
            this.BtnStop.Location = new System.Drawing.Point(836, 585);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(268, 55);
            this.BtnStop.TabIndex = 23;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.ForeColor = System.Drawing.Color.Black;
            this.BtnStart.Location = new System.Drawing.Point(560, 585);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(268, 55);
            this.BtnStart.TabIndex = 24;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnLongBreak
            // 
            this.BtnLongBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(123)))));
            this.BtnLongBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLongBreak.ForeColor = System.Drawing.Color.Black;
            this.BtnLongBreak.Location = new System.Drawing.Point(977, 203);
            this.BtnLongBreak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLongBreak.Name = "BtnLongBreak";
            this.BtnLongBreak.Size = new System.Drawing.Size(268, 55);
            this.BtnLongBreak.TabIndex = 22;
            this.BtnLongBreak.Text = "Long Break";
            this.BtnLongBreak.UseVisualStyleBackColor = false;
            this.BtnLongBreak.Click += new System.EventHandler(this.BtnLongBreak_Click);
            // 
            // BtnShortBreak
            // 
            this.BtnShortBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.BtnShortBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShortBreak.ForeColor = System.Drawing.Color.Black;
            this.BtnShortBreak.Location = new System.Drawing.Point(701, 203);
            this.BtnShortBreak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnShortBreak.Name = "BtnShortBreak";
            this.BtnShortBreak.Size = new System.Drawing.Size(268, 55);
            this.BtnShortBreak.TabIndex = 21;
            this.BtnShortBreak.Text = "Short Break";
            this.BtnShortBreak.UseVisualStyleBackColor = false;
            this.BtnShortBreak.Click += new System.EventHandler(this.BtnShortBreak_Click);
            // 
            // BtnPomodoro
            // 
            this.BtnPomodoro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.BtnPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPomodoro.ForeColor = System.Drawing.Color.Black;
            this.BtnPomodoro.Location = new System.Drawing.Point(425, 203);
            this.BtnPomodoro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnPomodoro.Name = "BtnPomodoro";
            this.BtnPomodoro.Size = new System.Drawing.Size(268, 55);
            this.BtnPomodoro.TabIndex = 20;
            this.BtnPomodoro.Text = "Pomodoro";
            this.BtnPomodoro.UseVisualStyleBackColor = false;
            this.BtnPomodoro.Click += new System.EventHandler(this.BtnPomodoro_Click);
            // 
            // LblSeconds
            // 
            this.LblSeconds.AutoSize = true;
            this.LblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSeconds.ForeColor = System.Drawing.Color.White;
            this.LblSeconds.Location = new System.Drawing.Point(831, 385);
            this.LblSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSeconds.Name = "LblSeconds";
            this.LblSeconds.Size = new System.Drawing.Size(127, 91);
            this.LblSeconds.TabIndex = 19;
            this.LblSeconds.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(799, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 91);
            this.label2.TabIndex = 18;
            this.label2.Text = ":";
            // 
            // LblMinutes
            // 
            this.LblMinutes.AutoSize = true;
            this.LblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMinutes.ForeColor = System.Drawing.Color.White;
            this.LblMinutes.Location = new System.Drawing.Point(685, 385);
            this.LblMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMinutes.Name = "LblMinutes";
            this.LblMinutes.Size = new System.Drawing.Size(127, 91);
            this.LblMinutes.TabIndex = 17;
            this.LblMinutes.Text = "15";
            // 
            // TmrSeconds
            // 
            this.TmrSeconds.Tick += new System.EventHandler(this.TmrSeconds_Tick);
            // 
            // FrmLongBreak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(180)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1683, 830);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnLongBreak);
            this.Controls.Add(this.BtnShortBreak);
            this.Controls.Add(this.BtnPomodoro);
            this.Controls.Add(this.LblSeconds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblMinutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmLongBreak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Long Break";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnLongBreak;
        private System.Windows.Forms.Button BtnShortBreak;
        private System.Windows.Forms.Button BtnPomodoro;
        private System.Windows.Forms.Label LblSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblMinutes;
        private System.Windows.Forms.Timer TmrSeconds;
    }
}