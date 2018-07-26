using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Digital_Clock
{
    public partial class frmStopWatch : Form
    {
        private Stopwatch _stopwatch;

        public frmStopWatch()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnPause.Text = "4";
            _stopwatch = new Stopwatch();
            timer1.Stop();
            lblTime.Text = _stopwatch.Elapsed.ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == ";") // ON to OFF
            {
                timer1.Stop();
                _stopwatch.Stop();
                btnPause.Text = "4";
            }
            else if (btnPause.Text == "4") // OFF to ON
            {
                timer1.Start();
                _stopwatch.Start();
                btnPause.Text = ";";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            _stopwatch.Stop();
            _stopwatch.Reset();
            btnPause.Text = "4";

            lblTime.Text = _stopwatch.Elapsed.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = _stopwatch.Elapsed.ToString();
        }

        private void chkbAlwaysFront_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbAlwaysFront.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
    }
}
