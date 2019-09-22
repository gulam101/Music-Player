using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var ExitBox = MessageBox.Show("Are you sure you want to exit off the application?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (ExitBox == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void quickExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Used for testing purposes

        /***  Used for testing different functions, going to keep this here once done so that other people can understand what I was doing and what functions I was testing. You can call upon them if you want   *****/

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            var TestMenu1 = new SplashScreen();
            TestMenu1.Show();
        }

        //End testing

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            Player.URL = textBox1.Text;
        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
  
        }

        private void cmdPause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void cmdPrevious_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.previous();
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
         Player.Ctlcontrols.next();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.previous();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.previous();
        }
    }
}
