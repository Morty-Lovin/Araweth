namespace Araweth
{
    partial class frmComingSoon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblComingSoon = new System.Windows.Forms.Label();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.lblItem3 = new System.Windows.Forms.Label();
            this.lblItem5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblComingSoon
            // 
            this.lblComingSoon.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComingSoon.Location = new System.Drawing.Point(30, 9);
            this.lblComingSoon.Name = "lblComingSoon";
            this.lblComingSoon.Size = new System.Drawing.Size(339, 59);
            this.lblComingSoon.TabIndex = 0;
            this.lblComingSoon.Text = "COMING SOON";
            this.lblComingSoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItem1
            // 
            this.lblItem1.Location = new System.Drawing.Point(30, 68);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(339, 47);
            this.lblItem1.TabIndex = 1;
            this.lblItem1.Text = "Options for Music!";
            this.lblItem1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItem2
            // 
            this.lblItem2.Location = new System.Drawing.Point(30, 115);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Size = new System.Drawing.Size(339, 47);
            this.lblItem2.TabIndex = 2;
            this.lblItem2.Text = "Dungeons for more loot!";
            this.lblItem2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItem3
            // 
            this.lblItem3.Location = new System.Drawing.Point(30, 162);
            this.lblItem3.Name = "lblItem3";
            this.lblItem3.Size = new System.Drawing.Size(339, 94);
            this.lblItem3.TabIndex = 3;
            this.lblItem3.Text = "Uusable weapons to help get further!";
            this.lblItem3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItem5
            // 
            this.lblItem5.Location = new System.Drawing.Point(30, 256);
            this.lblItem5.Name = "lblItem5";
            this.lblItem5.Size = new System.Drawing.Size(339, 47);
            this.lblItem5.TabIndex = 7;
            this.lblItem5.Text = "Idle Adventures!";
            this.lblItem5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(113, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(162, 54);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "BACK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Black;
            this.btnStop.BackgroundImage = global::Araweth.Properties.Resources.play;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Location = new System.Drawing.Point(12, 362);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(31, 31);
            this.btnStop.TabIndex = 18;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Black;
            this.btnPlay.BackgroundImage = global::Araweth.Properties.Resources.mute;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Location = new System.Drawing.Point(353, 362);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(31, 31);
            this.btnPlay.TabIndex = 17;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmComingSoon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Araweth.Properties.Resources.battleBack1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(396, 405);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblItem5);
            this.Controls.Add(this.lblItem3);
            this.Controls.Add(this.lblItem2);
            this.Controls.Add(this.lblItem1);
            this.Controls.Add(this.lblComingSoon);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComingSoon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComingSoon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblComingSoon;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.Label lblItem2;
        private System.Windows.Forms.Label lblItem3;
        private System.Windows.Forms.Label lblItem5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
    }
}