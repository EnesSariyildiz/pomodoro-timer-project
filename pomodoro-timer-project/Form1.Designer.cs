namespace pomodoro_timer_project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblMinutes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSecond = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.TmrMinutes = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblMinutes
            // 
            this.LblMinutes.AutoSize = true;
            this.LblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMinutes.ForeColor = System.Drawing.Color.White;
            this.LblMinutes.Location = new System.Drawing.Point(480, 251);
            this.LblMinutes.Name = "LblMinutes";
            this.LblMinutes.Size = new System.Drawing.Size(104, 73);
            this.LblMinutes.TabIndex = 0;
            this.LblMinutes.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(566, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 73);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblSecond
            // 
            this.LblSecond.AutoSize = true;
            this.LblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSecond.ForeColor = System.Drawing.Color.White;
            this.LblSecond.Location = new System.Drawing.Point(590, 251);
            this.LblSecond.Name = "LblSecond";
            this.LblSecond.Size = new System.Drawing.Size(104, 73);
            this.LblSecond.TabIndex = 2;
            this.LblSecond.Text = "00";
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.ForeColor = System.Drawing.Color.Black;
            this.BtnStart.Location = new System.Drawing.Point(493, 352);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(201, 45);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // TmrMinutes
            // 
            this.TmrMinutes.Tick += new System.EventHandler(this.TmrMinutes_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(194)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1262, 674);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblMinutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSecond;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer TmrMinutes;
    }
}

