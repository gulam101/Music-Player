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

namespace Music_Player_Project
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            //To fix the splash screen, make sure this loads up first...
            InitializeComponent();
            Thread Load = new Thread(new ThreadStart(Main));
            Load.Start();
            Thread.Sleep(5000); //Waits for 5 seconds
            Load.Abort();
        }

        public void Main()
        {
            Application.Run(new SplashScreen());
        }

        private void ExitMainCmd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
