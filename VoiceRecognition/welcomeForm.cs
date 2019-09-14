using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VoiceRecognition
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {
            //Application.Run(new frmUtama());
            //System.Threading.Thread.Sleep(1500);

            //new welcomeForm().
            //this.Close();
            //Application.Exit();
            //frmUtama frm = new frmUtama();
            //frm.Show();

            
        }
        Timer tmr;

        private void welcomeForm_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 3000;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;

        }

        void tmr_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

            frmUtama mf = new frmUtama();

            mf.Show();

            //hide this form

            this.Hide();

        }
    }
}
