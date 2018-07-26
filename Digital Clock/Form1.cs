using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class frmDigitalClock : Form
    {
        private frmStopWatch form2;

        public frmDigitalClock()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSeconds.Text = DateTime.Now.ToString("ss:fff");
            lblDate.Text = DateTime.Now.ToString("yyyy:MM:dd");
            lblDateOfWeek.Text = DateTime.Now.ToString("dddd");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnStopwatch_Click(object sender, EventArgs e)
        {
            form2 = new frmStopWatch();
            form2.Show();
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
