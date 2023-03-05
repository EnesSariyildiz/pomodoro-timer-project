namespace pomodoro_timer_project
{
    partial class FrmShortBreak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShortBreak));
            this.BtnLongBreak = new System.Windows.Forms.Button();
            this.BtnShortBreak = new System.Windows.Forms.Button();
            this.BtnPomodoro = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblSecond = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblMinutes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLongBreak
            // 
            this.BtnLongBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BtnLongBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLongBreak.ForeColor = System.Drawing.Color.Black;
            this.BtnLongBreak.Location = new System.Drawing.Point(738, 190);
            this.BtnLongBreak.Name = "BtnLongBreak";
            this.BtnLongBreak.Size = new System.Drawing.Size(201, 45);
            this.BtnLongBreak.TabIndex = 13;
            this.BtnLongBreak.Text = "Long Break";
            this.BtnLongBreak.UseVisualStyleBackColor = false;
            // 
            // BtnShortBreak
            // 
            this.BtnShortBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BtnShortBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShortBreak.ForeColor = System.Drawing.Color.Black;
            this.BtnShortBreak.Location = new System.Drawing.Point(531, 190);
            this.BtnShortBreak.Name = "BtnShortBreak";
            this.BtnShortBreak.Size = new System.Drawing.Size(201, 45);
            this.BtnShortBreak.TabIndex = 12;
            this.BtnShortBreak.Text = "Short Break";
            this.BtnShortBreak.UseVisualStyleBackColor = false;
            // 
            // BtnPomodoro
            // 
            this.BtnPomodoro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BtnPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPomodoro.ForeColor = System.Drawing.Color.Black;
            this.BtnPomodoro.Location = new System.Drawing.Point(324, 190);
            this.BtnPomodoro.Name = "BtnPomodoro";
            this.BtnPomodoro.Size = new System.Drawing.Size(201, 45);
            this.BtnPomodoro.TabIndex = 11;
            this.BtnPomodoro.Text = "Pomodoro";
            this.BtnPomodoro.UseVisualStyleBackColor = false;
            this.BtnPomodoro.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.ForeColor = System.Drawing.Color.Black;
            this.BtnStart.Location = new System.Drawing.Point(531, 439);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(201, 45);
            this.BtnStart.TabIndex = 10;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            // 
            // LblSecond
            // 
            this.LblSecond.AutoSize = true;
            this.LblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSecond.ForeColor = System.Drawing.Color.White;
            this.LblSecond.Location = new System.Drawing.Point(628, 338);
            this.LblSecond.Name = "LblSecond";
            this.LblSecond.Size = new System.Drawing.Size(104, 73);
            this.LblSecond.TabIndex = 9;
            this.LblSecond.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(604, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 73);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // LblMinutes
            // 
            this.LblMinutes.AutoSize = true;
            this.LblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMinutes.ForeColor = System.Drawing.Color.White;
            this.LblMinutes.Location = new System.Drawing.Point(518, 338);
            this.LblMinutes.Name = "LblMinutes";
            this.LblMinutes.Size = new System.Drawing.Size(104, 73);
            this.LblMinutes.TabIndex = 7;
            this.LblMinutes.Text = "25";
            // 
            // FrmShortBreak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1262, 674);
            this.Controls.Add(this.BtnLongBreak);
            this.Controls.Add(this.BtnShortBreak);
            this.Controls.Add(this.BtnPomodoro);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblMinutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmShortBreak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShortBreak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLongBreak;
        private System.Windows.Forms.Button BtnShortBreak;
        private System.Windows.Forms.Button BtnPomodoro;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblMinutes;
    }
}