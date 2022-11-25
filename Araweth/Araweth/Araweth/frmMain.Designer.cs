namespace Araweth
{
    partial class frmMain
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
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnContinueSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.btnPaladin = new System.Windows.Forms.Button();
            this.btnArcher = new System.Windows.Forms.Button();
            this.btnMage = new System.Windows.Forms.Button();
            this.btnKnight = new System.Windows.Forms.Button();
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.btnOptions = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlError = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlHigh = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lvwHigh = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInstructions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlError.SuspendLayout();
            this.pnlHigh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.BackColor = System.Drawing.Color.Black;
            this.lblMainMenu.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.Color.White;
            this.lblMainMenu.Location = new System.Drawing.Point(281, 248);
            this.lblMainMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(243, 61);
            this.lblMainMenu.TabIndex = 11;
            this.lblMainMenu.Text = "Main Menu";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Black;
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewGame.FlatAppearance.BorderSize = 2;
            this.btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNewGame.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(281, 316);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(243, 58);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnContinueSave
            // 
            this.btnContinueSave.BackColor = System.Drawing.Color.Black;
            this.btnContinueSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnContinueSave.FlatAppearance.BorderSize = 2;
            this.btnContinueSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnContinueSave.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueSave.ForeColor = System.Drawing.Color.White;
            this.btnContinueSave.Location = new System.Drawing.Point(281, 383);
            this.btnContinueSave.Name = "btnContinueSave";
            this.btnContinueSave.Size = new System.Drawing.Size(243, 58);
            this.btnContinueSave.TabIndex = 1;
            this.btnContinueSave.Text = "CONTINUE GAME";
            this.btnContinueSave.UseVisualStyleBackColor = false;
            this.btnContinueSave.Click += new System.EventHandler(this.btnContinueSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(281, 584);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(243, 58);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&XIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.BackColor = System.Drawing.Color.Black;
            this.btnHighScores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHighScores.FlatAppearance.BorderSize = 2;
            this.btnHighScores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHighScores.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScores.ForeColor = System.Drawing.Color.White;
            this.btnHighScores.Location = new System.Drawing.Point(281, 450);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(243, 58);
            this.btnHighScores.TabIndex = 2;
            this.btnHighScores.Text = "HIGH SCORES";
            this.btnHighScores.UseVisualStyleBackColor = false;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.Black;
            this.btnReturnMain.BackgroundImage = global::Araweth.Properties.Resources.arawethBack;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReturnMain.FlatAppearance.BorderSize = 2;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReturnMain.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMain.ForeColor = System.Drawing.Color.White;
            this.btnReturnMain.Location = new System.Drawing.Point(281, 587);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(243, 58);
            this.btnReturnMain.TabIndex = 9;
            this.btnReturnMain.Text = "BACK";
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Visible = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // btnPaladin
            // 
            this.btnPaladin.BackColor = System.Drawing.Color.Black;
            this.btnPaladin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPaladin.FlatAppearance.BorderSize = 2;
            this.btnPaladin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPaladin.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaladin.ForeColor = System.Drawing.Color.White;
            this.btnPaladin.Location = new System.Drawing.Point(281, 517);
            this.btnPaladin.Name = "btnPaladin";
            this.btnPaladin.Size = new System.Drawing.Size(243, 58);
            this.btnPaladin.TabIndex = 8;
            this.btnPaladin.Text = "PALADIN";
            this.btnPaladin.UseVisualStyleBackColor = false;
            this.btnPaladin.Visible = false;
            this.btnPaladin.Click += new System.EventHandler(this.btnPaladin_Click);
            // 
            // btnArcher
            // 
            this.btnArcher.BackColor = System.Drawing.Color.Black;
            this.btnArcher.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnArcher.FlatAppearance.BorderSize = 2;
            this.btnArcher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnArcher.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcher.ForeColor = System.Drawing.Color.White;
            this.btnArcher.Location = new System.Drawing.Point(281, 453);
            this.btnArcher.Name = "btnArcher";
            this.btnArcher.Size = new System.Drawing.Size(243, 58);
            this.btnArcher.TabIndex = 7;
            this.btnArcher.Text = "ARCHER";
            this.btnArcher.UseVisualStyleBackColor = false;
            this.btnArcher.Visible = false;
            this.btnArcher.Click += new System.EventHandler(this.btnArcher_Click);
            // 
            // btnMage
            // 
            this.btnMage.BackColor = System.Drawing.Color.Black;
            this.btnMage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMage.FlatAppearance.BorderSize = 2;
            this.btnMage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMage.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMage.ForeColor = System.Drawing.Color.White;
            this.btnMage.Location = new System.Drawing.Point(281, 386);
            this.btnMage.Name = "btnMage";
            this.btnMage.Size = new System.Drawing.Size(243, 58);
            this.btnMage.TabIndex = 6;
            this.btnMage.Text = "MAGE";
            this.btnMage.UseVisualStyleBackColor = false;
            this.btnMage.Visible = false;
            this.btnMage.Click += new System.EventHandler(this.btnMage_Click);
            // 
            // btnKnight
            // 
            this.btnKnight.BackColor = System.Drawing.Color.Black;
            this.btnKnight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKnight.FlatAppearance.BorderSize = 2;
            this.btnKnight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnKnight.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKnight.ForeColor = System.Drawing.Color.White;
            this.btnKnight.Location = new System.Drawing.Point(281, 319);
            this.btnKnight.Name = "btnKnight";
            this.btnKnight.Size = new System.Drawing.Size(243, 58);
            this.btnKnight.TabIndex = 5;
            this.btnKnight.Text = "KNIGHT";
            this.btnKnight.UseVisualStyleBackColor = false;
            this.btnKnight.Visible = false;
            this.btnKnight.Click += new System.EventHandler(this.btnKnight_Click);
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.BackColor = System.Drawing.Color.Black;
            this.lblSelectClass.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectClass.ForeColor = System.Drawing.Color.White;
            this.lblSelectClass.Location = new System.Drawing.Point(247, 248);
            this.lblSelectClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(310, 61);
            this.lblSelectClass.TabIndex = 10;
            this.lblSelectClass.Text = "Select A Class";
            this.lblSelectClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelectClass.Visible = false;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Black;
            this.btnOptions.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Location = new System.Drawing.Point(22, 714);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(134, 46);
            this.btnOptions.TabIndex = 12;
            this.btnOptions.Text = "Options";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Araweth.Properties.Resources.settings;
            this.pictureBox1.Location = new System.Drawing.Point(26, 718);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pnlError
            // 
            this.pnlError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlError.Controls.Add(this.btnOK);
            this.pnlError.Controls.Add(this.lblError);
            this.pnlError.Location = new System.Drawing.Point(263, 248);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(277, 231);
            this.pnlError.TabIndex = 10;
            this.pnlError.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.FlatAppearance.BorderSize = 3;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(70, 167);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 41);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(3, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(271, 166);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "label1";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHigh
            // 
            this.pnlHigh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHigh.Controls.Add(this.lblScore);
            this.pnlHigh.Controls.Add(this.lblUser);
            this.pnlHigh.Controls.Add(this.btnClose);
            this.pnlHigh.Controls.Add(this.lvwHigh);
            this.pnlHigh.Location = new System.Drawing.Point(233, 253);
            this.pnlHigh.Name = "pnlHigh";
            this.pnlHigh.Size = new System.Drawing.Size(336, 394);
            this.pnlHigh.TabIndex = 11;
            this.pnlHigh.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblScore.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(196, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 41);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "SCORE";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(32, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 37);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "USER";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(100, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 45);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvwHigh
            // 
            this.lvwHigh.BackColor = System.Drawing.Color.Black;
            this.lvwHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwHigh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.User,
            this.Score});
            this.lvwHigh.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwHigh.ForeColor = System.Drawing.Color.White;
            this.lvwHigh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwHigh.LabelWrap = false;
            this.lvwHigh.Location = new System.Drawing.Point(-2, 67);
            this.lvwHigh.MultiSelect = false;
            this.lvwHigh.Name = "lvwHigh";
            this.lvwHigh.Scrollable = false;
            this.lvwHigh.Size = new System.Drawing.Size(336, 240);
            this.lvwHigh.TabIndex = 0;
            this.lvwHigh.UseCompatibleStateImageBehavior = false;
            this.lvwHigh.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // User
            // 
            this.User.Text = "USER";
            this.User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.User.Width = 169;
            // 
            // Score
            // 
            this.Score.Text = "SCORE";
            this.Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Score.Width = 165;
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.Black;
            this.btnInstructions.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInstructions.FlatAppearance.BorderSize = 2;
            this.btnInstructions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnInstructions.Font = new System.Drawing.Font("Elementary Gothic Scaled ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.Color.White;
            this.btnInstructions.Location = new System.Drawing.Point(281, 517);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(243, 58);
            this.btnInstructions.TabIndex = 3;
            this.btnInstructions.Text = "HOW TO PLAY";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnContinueSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Araweth.Properties.Resources.arawethBack;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(805, 782);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.pnlHigh);
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnPaladin);
            this.Controls.Add(this.btnArcher);
            this.Controls.Add(this.btnMage);
            this.Controls.Add(this.btnKnight);
            this.Controls.Add(this.lblSelectClass);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnContinueSave);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araweth";
            this.Click += new System.EventHandler(this.btnHighScores_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlError.ResumeLayout(false);
            this.pnlHigh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblMainMenu;
        public System.Windows.Forms.Button btnNewGame;
        public System.Windows.Forms.Button btnContinueSave;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnHighScores;
        public System.Windows.Forms.Button btnReturnMain;
        public System.Windows.Forms.Button btnPaladin;
        public System.Windows.Forms.Button btnArcher;
        public System.Windows.Forms.Button btnMage;
        public System.Windows.Forms.Button btnKnight;
        public System.Windows.Forms.Label lblSelectClass;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlHigh;
        public System.Windows.Forms.ListView lvwHigh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader Score;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.Button btnInstructions;
    }
}
