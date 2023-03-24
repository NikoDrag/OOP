namespace WindowsForms1
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
            this.panelBonus = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.panelField = new System.Windows.Forms.Panel();
            this.labelplayer = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxBRGresaka = new System.Windows.Forms.TextBox();
            this.textBoxBRKoraka = new System.Windows.Forms.TextBox();
            this.textBoxBRGR = new System.Windows.Forms.TextBox();
            this.textBoxBRK = new System.Windows.Forms.TextBox();
            this.panelBonus.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelField.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBonus
            // 
            this.panelBonus.AllowDrop = true;
            this.panelBonus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBonus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBonus.Controls.Add(this.textBoxBRK);
            this.panelBonus.Controls.Add(this.textBoxBRGR);
            this.panelBonus.Controls.Add(this.textBoxBRGresaka);
            this.panelBonus.Controls.Add(this.textBoxBRKoraka);
            this.panelBonus.Controls.Add(this.textBoxY);
            this.panelBonus.Controls.Add(this.textBoxX);
            this.panelBonus.Location = new System.Drawing.Point(638, 0);
            this.panelBonus.Name = "panelBonus";
            this.panelBonus.Size = new System.Drawing.Size(166, 453);
            this.panelBonus.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelControl.Controls.Add(this.buttonDown);
            this.panelControl.Controls.Add(this.buttonUp);
            this.panelControl.Controls.Add(this.buttonLeft);
            this.panelControl.Controls.Add(this.buttonRight);
            this.panelControl.Location = new System.Drawing.Point(-1, 347);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(640, 106);
            this.panelControl.TabIndex = 1;
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(291, 53);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(89, 38);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(291, 9);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(89, 38);
            this.buttonUp.TabIndex = 4;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(196, 53);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(89, 38);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.CausesValidation = false;
            this.buttonRight.Location = new System.Drawing.Point(386, 53);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(89, 38);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // panelField
            // 
            this.panelField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelField.BackColor = System.Drawing.Color.Gray;
            this.panelField.Controls.Add(this.labelplayer);
            this.panelField.Location = new System.Drawing.Point(0, 0);
            this.panelField.Name = "panelField";
            this.panelField.Size = new System.Drawing.Size(639, 350);
            this.panelField.TabIndex = 2;
            this.panelField.Resize += new System.EventHandler(this.ReSize);
            // 
            // labelplayer
            // 
            this.labelplayer.AutoSize = true;
            this.labelplayer.Location = new System.Drawing.Point(0, 0);
            this.labelplayer.Name = "labelplayer";
            this.labelplayer.Size = new System.Drawing.Size(49, 13);
            this.labelplayer.TabIndex = 0;
            this.labelplayer.Text = "PLAYER";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(25, 18);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(48, 20);
            this.textBoxX.TabIndex = 0;
            this.textBoxX.Text = "x: 0";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(83, 18);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(48, 20);
            this.textBoxY.TabIndex = 1;
            this.textBoxY.Text = "y: 0";
            // 
            // textBoxBRGresaka
            // 
            this.textBoxBRGresaka.Location = new System.Drawing.Point(25, 100);
            this.textBoxBRGresaka.Name = "textBoxBRGresaka";
            this.textBoxBRGresaka.Size = new System.Drawing.Size(73, 20);
            this.textBoxBRGresaka.TabIndex = 2;
            this.textBoxBRGresaka.Text = "Broj Gresaka:";
            // 
            // textBoxBRKoraka
            // 
            this.textBoxBRKoraka.Location = new System.Drawing.Point(25, 58);
            this.textBoxBRKoraka.Name = "textBoxBRKoraka";
            this.textBoxBRKoraka.Size = new System.Drawing.Size(73, 20);
            this.textBoxBRKoraka.TabIndex = 3;
            this.textBoxBRKoraka.Text = "Broj Koraka:";
            // 
            // textBoxBRGR
            // 
            this.textBoxBRGR.Location = new System.Drawing.Point(104, 100);
            this.textBoxBRGR.Name = "textBoxBRGR";
            this.textBoxBRGR.Size = new System.Drawing.Size(27, 20);
            this.textBoxBRGR.TabIndex = 4;
            this.textBoxBRGR.Text = "0";
            // 
            // textBoxBRK
            // 
            this.textBoxBRK.Location = new System.Drawing.Point(104, 58);
            this.textBoxBRK.Name = "textBoxBRK";
            this.textBoxBRK.Size = new System.Drawing.Size(27, 20);
            this.textBoxBRK.TabIndex = 5;
            this.textBoxBRK.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelField);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelBonus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panelBonus.ResumeLayout(false);
            this.panelBonus.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelField.ResumeLayout(false);
            this.panelField.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBonus;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Panel panelField;
        public System.Windows.Forms.Label labelplayer;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxBRGresaka;
        private System.Windows.Forms.TextBox textBoxBRKoraka;
        private System.Windows.Forms.TextBox textBoxBRK;
        private System.Windows.Forms.TextBox textBoxBRGR;
    }
}

