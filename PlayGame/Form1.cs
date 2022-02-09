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

namespace PlayGame
{
    public partial class Arcade : Form
    {
        public Arcade()
        {
            InitializeComponent();
            GoLabel.Visible = false;
            Start.Visible = false;
            Count3.Visible = false;
        }

        private void PlayGame_Click(object sender, EventArgs e)
        {
            Soundplayer

            Start.Visible = true;
            Count3.Visible = true;
            Start.ForeColor = Color.Green;
            Count3.ForeColor = Color.Green;

            Refresh();
            Thread.Sleep(1000);
            Count3.Text = "2...";

            Refresh();
            Thread.Sleep(1000);

            Count3.Text = "1...";

            Refresh();
            Thread.Sleep(1000);

            GoLabel.Visible = true;
            this.BackColor = Color.Green;
            PlayGame.Visible = false;

        }

        private void beginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
