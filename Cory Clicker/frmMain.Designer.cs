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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.picShop.TabIndex = 2;
            this.picShop.TabStop = false;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Upgrade Votes per Follower";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "1 Vote per Follower";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(608, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblShop);
            this.Controls.Add(this.picShop);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picClick);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

