using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cory_Clicker
{
    public partial class frmMain : Form
    {
        private int Votes = 0;
        private int Followers = 100;
        private int PresidentDefeats = 0;

        private int VotesPerFollower = 1;
        private int VotesPerClick = 1;

        private int VpF_Cost = 20;
        private int VpC_Cost = 40;

        // Votes until a follower is added.
        private int MaxVotes = 50;

        private int Interval = 4000;

        // Private
        private bool isClicked = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void picClick_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isClicked)
            {
                isClicked = true;

                picClick.Width -= 20;
                picClick.Left += 10;
                picClick.Height -= 20;
                picClick.Top += 10;
            }
        }

        Random r = new Random();
        private void picClick_MouseUp(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                isClicked = false;
                picClick.Width += 20;
                picClick.Left -= 10;
                picClick.Height += 20;
                picClick.Top -= 10;

                addFollower();
                Votes += VotesPerClick;
            }
            updateUI();
        }

        private void updateUI()
        {
            lblInfo.Text =
                $"Votes: {Votes}\n" +
                $"Followers: {Followers} k\n" +
                $"President Defeats: {PresidentDefeats}";

            btnVpF.Text = $"Upgrade Votes per Follower ({VpF_Cost}kF)";
            lblVpF.Text = $"{VotesPerFollower} Votes per Follower.";
            btnVpC.Text = $"Upgrade Votes per Click ({VpC_Cost}kF)";
            lblVpC.Text = $"{VotesPerFollower} Votes per Click.";
        }

        private void addFollower()
        {
            while (Votes >= MaxVotes)
            {
                Votes -= MaxVotes;
                Followers++;
            }
        }

        private void tmrFollowers_Tick(object sender, EventArgs e)
        {
            Votes += VotesPerFollower * Followers;

            addFollower();
            updateUI();
        }

        private void picShop_Click(object sender, EventArgs e)
        {
            this.Width = Width == 308 ? 625 : 308;
        }

        private void btnVpF_Click(object sender, EventArgs e)
        {
            if (Followers >= VpF_Cost)
            {
                Followers -= VpF_Cost;
                VotesPerFollower++;

                // Update cost
                VpF_Cost = 10 + VotesPerFollower * 10;
                MaxVotes = (int)(MaxVotes * 1.25);
            }

            updateUI();
        }

        private void btnVpC_Click(object sender, EventArgs e)
        {
            if (Followers >= VpC_Cost)
            {
                Followers -= VpC_Cost;
                VotesPerClick++;

                // Update cost
                VpC_Cost = 20 + VotesPerClick * 20;
                MaxVotes = (int)(MaxVotes * 1.25);
            }

            updateUI();
        }
    }
}
