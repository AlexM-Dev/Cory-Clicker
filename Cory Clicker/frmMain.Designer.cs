namespace Cory_Clicker {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.picClick = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tmrFollowers = new System.Windows.Forms.Timer(this.components);
            this.picShop = new System.Windows.Forms.PictureBox();
            this.lblShop = new System.Windows.Forms.Label();
            this.btnVpF = new System.Windows.Forms.Button();
            this.lblVpF = new System.Windows.Forms.Label();
            this.lblVpC = new System.Windows.Forms.Label();
            this.btnVpC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShop)).BeginInit();
            this.SuspendLayout();
            // 
            // picClick
            // 
            this.picClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClick.Image = global::Cory_Clicker.Properties.Resources.Whitehouse;
            this.picClick.Location = new System.Drawing.Point(46, 98);
            this.picClick.Name = "picClick";
            this.picClick.Size = new System.Drawing.Size(200, 96);
            this.picClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClick.TabIndex = 0;
            this.picClick.TabStop = false;
            this.picClick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picClick_MouseDown);
            this.picClick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picClick_MouseUp);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(69, 210);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(143, 83);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Votes: 0\r\nFollowers: 0 k\r\nPresident Defeats: 0";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrFollowers
            // 
            this.tmrFollowers.Enabled = true;
            this.tmrFollowers.Interval = 4000;
            this.tmrFollowers.Tick += new System.EventHandler(this.tmrFollowers_Tick);
            // 
            // picShop
            // 
            this.picShop.Location = new System.Drawing.Point(180, 337);
            this.picShop.Name = "picShop";
            this.picShop.Size = new System.Drawing.Size(100, 41);
            this.picShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShop.TabIndex = 2;
            this.picShop.TabStop = false;
            this.picShop.Click += new System.EventHandler(this.picShop_Click);
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShop.Location = new System.Drawing.Point(291, 19);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(94, 45);
            this.lblShop.TabIndex = 3;
            this.lblShop.Text = "Shop";
            // 
            // btnVpF
            // 
            this.btnVpF.Location = new System.Drawing.Point(299, 68);
            this.btnVpF.Name = "btnVpF";
            this.btnVpF.Size = new System.Drawing.Size(295, 33);
            this.btnVpF.TabIndex = 4;
            this.btnVpF.Text = "Upgrade Votes per Follower (20kF)";
            this.btnVpF.UseVisualStyleBackColor = true;
            // 
            // lblVpF
            // 
            this.lblVpF.AutoSize = true;
            this.lblVpF.Location = new System.Drawing.Point(482, 104);
            this.lblVpF.Name = "lblVpF";
            this.lblVpF.Size = new System.Drawing.Size(112, 15);
            this.lblVpF.TabIndex = 5;
            this.lblVpF.Text = "1 Vote per Follower";
            this.lblVpF.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVpC
            // 
            this.lblVpC.AutoSize = true;
            this.lblVpC.Location = new System.Drawing.Point(503, 173);
            this.lblVpC.Name = "lblVpC";
            this.lblVpC.Size = new System.Drawing.Size(91, 15);
            this.lblVpC.TabIndex = 7;
            this.lblVpC.Text = "1 Vote per Click";
            this.lblVpC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnVpC
            // 
            this.btnVpC.Location = new System.Drawing.Point(299, 137);
            this.btnVpC.Name = "btnVpC";
            this.btnVpC.Size = new System.Drawing.Size(295, 33);
            this.btnVpC.TabIndex = 6;
            this.btnVpC.Text = "Upgrade Votes per Click (40kF)";
            this.btnVpC.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(292, 390);
            this.Controls.Add(this.lblVpC);
            this.Controls.Add(this.btnVpC);
            this.Controls.Add(this.lblVpF);
            this.Controls.Add(this.btnVpF);
            this.Controls.Add(this.lblShop);
            this.Controls.Add(this.picShop);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picClick);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Cory Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.picClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClick;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer tmrFollowers;
        private System.Windows.Forms.PictureBox picShop;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.Button btnVpF;
        private System.Windows.Forms.Label lblVpF;
        private System.Windows.Forms.Label lblVpC;
        private System.Windows.Forms.Button btnVpC;
    }
}

