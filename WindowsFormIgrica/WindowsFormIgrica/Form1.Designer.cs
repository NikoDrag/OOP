namespace WindowsFormIgrica
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.pnlEField = new System.Windows.Forms.Panel();
            this.lblenemy = new System.Windows.Forms.Label();
            this.pnlBetween = new System.Windows.Forms.Panel();
            this.pnlPField = new System.Windows.Forms.Panel();
            this.lbltank = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.textBoxShots = new System.Windows.Forms.TextBox();
            this.textBoxPoeni = new System.Windows.Forms.TextBox();
            this.textBoxVreme = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerWait = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.pnlEField.SuspendLayout();
            this.pnlPField.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.pnlStats);
            this.splitContainer1.Size = new System.Drawing.Size(809, 389);
            this.splitContainer1.SplitterDistance = 627;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pnlControl);
            this.splitContainer2.Size = new System.Drawing.Size(627, 389);
            this.splitContainer2.SplitterDistance = 328;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pnlPField);
            this.splitContainer3.Size = new System.Drawing.Size(627, 328);
            this.splitContainer3.SplitterDistance = 252;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.pnlEField);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.pnlBetween);
            this.splitContainer4.Size = new System.Drawing.Size(627, 252);
            this.splitContainer4.SplitterDistance = 87;
            this.splitContainer4.TabIndex = 0;
            // 
            // pnlEField
            // 
            this.pnlEField.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlEField.Controls.Add(this.lblenemy);
            this.pnlEField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEField.Location = new System.Drawing.Point(0, 0);
            this.pnlEField.Name = "pnlEField";
            this.pnlEField.Size = new System.Drawing.Size(627, 87);
            this.pnlEField.TabIndex = 0;
            // 
            // lblenemy
            // 
            this.lblenemy.AutoSize = true;
            this.lblenemy.Image = global::WindowsFormIgrica.Properties.Resources.tank_png;
            this.lblenemy.Location = new System.Drawing.Point(307, 31);
            this.lblenemy.Name = "lblenemy";
            this.lblenemy.Size = new System.Drawing.Size(39, 13);
            this.lblenemy.TabIndex = 0;
            this.lblenemy.Text = "Enemy";
            // 
            // pnlBetween
            // 
            this.pnlBetween.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlBetween.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBetween.Location = new System.Drawing.Point(0, 0);
            this.pnlBetween.Name = "pnlBetween";
            this.pnlBetween.Size = new System.Drawing.Size(627, 161);
            this.pnlBetween.TabIndex = 0;
            // 
            // pnlPField
            // 
            this.pnlPField.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlPField.Controls.Add(this.lbltank);
            this.pnlPField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPField.Location = new System.Drawing.Point(0, 0);
            this.pnlPField.Name = "pnlPField";
            this.pnlPField.Size = new System.Drawing.Size(627, 72);
            this.pnlPField.TabIndex = 0;
            this.pnlPField.Resize += new System.EventHandler(this.Resize);
            // 
            // lbltank
            // 
            this.lbltank.AutoSize = true;
            this.lbltank.Image = global::WindowsFormIgrica.Properties.Resources.tank_png;
            this.lbltank.Location = new System.Drawing.Point(304, 30);
            this.lbltank.Name = "lbltank";
            this.lbltank.Size = new System.Drawing.Size(32, 13);
            this.lbltank.TabIndex = 0;
            this.lbltank.Text = "Tank";
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlControl.Controls.Add(this.btnReset);
            this.pnlControl.Controls.Add(this.btnRight);
            this.pnlControl.Controls.Add(this.btnShoot);
            this.pnlControl.Controls.Add(this.btnLeft);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(627, 57);
            this.pnlControl.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(25, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 31);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(363, 13);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(86, 32);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "--->";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(271, 13);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(86, 32);
            this.btnShoot.TabIndex = 1;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(179, 13);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(86, 32);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "<---";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlStats.Controls.Add(this.textBoxShots);
            this.pnlStats.Controls.Add(this.textBoxPoeni);
            this.pnlStats.Controls.Add(this.textBoxVreme);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStats.Location = new System.Drawing.Point(0, 0);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(178, 389);
            this.pnlStats.TabIndex = 0;
            // 
            // textBoxShots
            // 
            this.textBoxShots.Location = new System.Drawing.Point(19, 76);
            this.textBoxShots.Name = "textBoxShots";
            this.textBoxShots.Size = new System.Drawing.Size(69, 20);
            this.textBoxShots.TabIndex = 2;
            this.textBoxShots.Text = "Shots: ";
            // 
            // textBoxPoeni
            // 
            this.textBoxPoeni.Location = new System.Drawing.Point(19, 50);
            this.textBoxPoeni.Name = "textBoxPoeni";
            this.textBoxPoeni.Size = new System.Drawing.Size(69, 20);
            this.textBoxPoeni.TabIndex = 1;
            this.textBoxPoeni.Text = "Points: ";
            // 
            // textBoxVreme
            // 
            this.textBoxVreme.Location = new System.Drawing.Point(19, 24);
            this.textBoxVreme.Name = "textBoxVreme";
            this.textBoxVreme.Size = new System.Drawing.Size(70, 20);
            this.textBoxVreme.TabIndex = 0;
            this.textBoxVreme.Text = "Vreme:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerWait
            // 
            this.timerWait.Interval = 500;
            this.timerWait.Tick += new System.EventHandler(this.timerWait_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 413);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.pnlEField.ResumeLayout(false);
            this.pnlEField.PerformLayout();
            this.pnlPField.ResumeLayout(false);
            this.pnlPField.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Panel pnlBetween;
        private System.Windows.Forms.Panel pnlPField;
        private System.Windows.Forms.Panel pnlEField;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnLeft;
        public System.Windows.Forms.Label lbltank;
        private System.Windows.Forms.Label lblenemy;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox textBoxVreme;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerWait;
        private System.Windows.Forms.TextBox textBoxShots;
        private System.Windows.Forms.TextBox textBoxPoeni;
    }
}

