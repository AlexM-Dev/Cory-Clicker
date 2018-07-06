using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cory_Clicker {
    public partial class frmMain : Form {
        private int Votes = 0;
        private int Followers = 0;
        private int PresidentDefeats = 0;

        private int VotesPerFollower = 1;
        private int VotesPerClick = 1;

        // Votes until a follower is added.
        private int MaxVotes = 50;

        private int Interval = 4000;

        // Private
        private bool isClicked = false;
        public frmMain() {
            InitializeComponent();
        }

        private void picClick_MouseDown(object sender, MouseEventArgs e) {
            if (!isClicked) {
                isClicked = true;

                picClick.Width -= 20;
                picClick.Left += 10;
                picClick.Height -= 20;
                picClick.Top += 10;
            }
        }

        private void picClick_MouseUp(object sender, MouseEventArgs e) {
            if (isClicked) {
                isClicked = false;
                picClick.Width += 20;
                picClick.Left -= 10;
                picClick.Height += 20;
                picClick.Top -= 10;

                addFollower();
                Votes++;
            }
            updateUI();
        }

        private void updateUI() {
            lblInfo.Text =
                $"Votes: {Votes}\n" +
                $"Followers: {Followers} k\n" +
                $"President Defeats: {PresidentDefeats}";
        }

        private void addFollower() {
            while (Votes >= MaxVotes) {
                Votes -= MaxVotes;
                Followers++;
            }
        }

        private void tmrFollowers_Tick(object sender, EventArgs e) {
            Votes += VotesPerFollower * Followers;

            addFollower();
            updateUI();
        }
    }
}
