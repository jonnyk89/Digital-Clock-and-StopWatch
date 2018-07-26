namespace Digital_Clock
{
    partial class frmDigitalClock
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDateOfWeek = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.btnStopwatch = new System.Windows.Forms.Button();
            this.chkbAlwaysFront = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(147, 57);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "14:14";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.ForeColor = System.Drawing.Color.Lime;
            this.lblDate.Location = new System.Drawing.Point(64, 64);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 22);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "date";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Day of Week:";
            // 
            // lblDateOfWeek
            // 
            this.lblDateOfWeek.AutoSize = true;
            this.lblDateOfWeek.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblDateOfWeek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateOfWeek.ForeColor = System.Drawing.Color.Lime;
            this.lblDateOfWeek.Location = new System.Drawing.Point(126, 84);
            this.lblDateOfWeek.Name = "lblDateOfWeek";
            this.lblDateOfWeek.Size = new System.Drawing.Size(96, 22);
            this.lblDateOfWeek.TabIndex = 7;
            this.lblDateOfWeek.Text = "dayofweek";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblSeconds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeconds.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSeconds.Location = new System.Drawing.Point(165, 9);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(69, 22);
            this.lblSeconds.TabIndex = 8;
            this.lblSeconds.Text = "100:100";
            // 
            // btnStopwatch
            // 
            this.btnStopwatch.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnStopwatch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopwatch.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnStopwatch.Location = new System.Drawing.Point(168, 34);
            this.btnStopwatch.Name = "btnStopwatch";
            this.btnStopwatch.Size = new System.Drawing.Size(75, 47);
            this.btnStopwatch.TabIndex = 9;
            this.btnStopwatch.Text = "StopWatch";
            this.btnStopwatch.UseVisualStyleBackColor = false;
            this.btnStopwatch.Click += new System.EventHandler(this.btnStopwatch_Click);
            // 
            // chkbAlwaysFront
            // 
            this.chkbAlwaysFront.AutoSize = true;
            this.chkbAlwaysFront.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkbAlwaysFront.ForeColor = System.Drawing.Color.Black;
            this.chkbAlwaysFront.Location = new System.Drawing.Point(12, 109);
            this.chkbAlwaysFront.Name = "chkbAlwaysFront";
            this.chkbAlwaysFront.Size = new System.Drawing.Size(90, 17);
            this.chkbAlwaysFront.TabIndex = 15;
            this.chkbAlwaysFront.Text = "Always on top";
            this.chkbAlwaysFront.UseVisualStyleBackColor = true;
            this.chkbAlwaysFront.CheckedChanged += new System.EventHandler(this.chkbAlwaysFront_CheckedChanged);
            // 
            // frmDigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(255, 132);
            this.Controls.Add(this.chkbAlwaysFront);
            this.Controls.Add(this.btnStopwatch);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblDateOfWeek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmDigitalClock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDateOfWeek;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Button btnStopwatch;
        private System.Windows.Forms.CheckBox chkbAlwaysFront;
    }
}

