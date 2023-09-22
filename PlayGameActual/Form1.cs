using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PlayGameActual
{
    public partial class ground : Form
    {
        public ground()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            startButton.BackColor = Color.White;

            outputLabel.Text = "3";
            outputLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(500);

           
            outputLabel.Text = "2";
            outputLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(500);

            outputLabel.Text = "1";
            Refresh();
            Thread.Sleep(500);

         outputLabel.Text = "GO";

        }
    }
}
