using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        DateTime start;
        DateTime stop;
        TimeSpan elaspedTime;

        private void btnStart_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            txtStart.Text = start.ToLongTimeString();
            txtStop.Text = "";
            txtElapsedTime.Text = "";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = DateTime.Now;
            txtStop.Text = stop.ToLongTimeString();
            elaspedTime = stop - start;
            txtElapsedTime.Text = elaspedTime.Seconds.ToString(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
