using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test1
{
    public partial class Form1 : Form
    {
        //Name:
        //IDNo:

        //constants for the two scooter types
        const string G3 = "G3";
        const string G25 = "G2.5";
        
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
