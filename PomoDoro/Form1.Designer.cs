namespace PomoDoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerPomo = new System.Windows.Forms.Timer(this.components);
            this.timerLazy = new System.Windows.Forms.Timer(this.components);
            this.btnPomo = new System.Windows.Forms.Button();
            this.lblPomoCount = new System.Windows.Forms.Label();
            this.lblPomoTimeAll = new System.Windows.Forms.Label();
            this.lblPomoTime = new System.Windows.Forms.Label();
            this.barPomo = new System.Windows.Forms.ProgressBar();
            this.barLazy = new System.Windows.Forms.ProgressBar();
            this.lblLazyTime = new System.Windows.Forms.Label();
            this.lblLazyTimeAll = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblDescTitle = new System.Windows.Forms.Label();
            this.checkTop = new System.Windows.Forms.CheckBox();
            this.btnExpand = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.checkSound = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_save = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditTime = new System.Windows.Forms.Button();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.btnEditAction = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCheatbox = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            this.pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPomo
            // 
            this.timerPomo.Interval = 1000;
            this.timerPomo.Tick += new System.EventHandler(this.timerPomo_Tick);
            // 
            // timerLazy
            // 
            this.timerLazy.Interval = 1000;
            this.timerLazy.Tick += new System.EventHandler(this.timerLazy_Tick);
            // 
            // btnPomo
            // 
            this.btnPomo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPomo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPomo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnPomo.Location = new System.Drawing.Point(12, 186);
            this.btnPomo.Name = "btnPomo";
            this.btnPomo.Size = new System.Drawing.Size(374, 26);
            this.btnPomo.TabIndex = 0;
            this.btnPomo.Text = "Pomo!";
            this.btnPomo.UseVisualStyleBackColor = true;
            this.btnPomo.Click += new System.EventHandler(this.btnPomo_Click);
            // 
            // lblPomoCount
            // 
            this.lblPomoCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPomoCount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPomoCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.lblPomoCount.Location = new System.Drawing.Point(12, 15);
            this.lblPomoCount.Name = "lblPomoCount";
            this.lblPomoCount.Size = new System.Drawing.Size(200, 30);
            this.lblPomoCount.TabIndex = 1;
            this.lblPomoCount.Text = "5 Pomo Sessions";
            this.lblPomoCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPomoTimeAll
            // 
            this.lblPomoTimeAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPomoTimeAll.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPomoTimeAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.lblPomoTimeAll.Location = new System.Drawing.Point(135, 61);
            this.lblPomoTimeAll.Name = "lblPomoTimeAll";
            this.lblPomoTimeAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPomoTimeAll.Size = new System.Drawing.Size(251, 13);
            this.lblPomoTimeAll.TabIndex = 2;
            this.lblPomoTimeAll.Text = "Total Pomo Time 25m:45s";
            this.lblPomoTimeAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPomoTime
            // 
            this.lblPomoTime.AutoSize = true;
            this.lblPomoTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPomoTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.lblPomoTime.Location = new System.Drawing.Point(13, 61);
            this.lblPomoTime.Name = "lblPomoTime";
            this.lblPomoTime.Size = new System.Drawing.Size(81, 13);
            this.lblPomoTime.TabIndex = 3;
            this.lblPomoTime.Text = "Pomo: 24:59";
            this.lblPomoTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // barPomo
            // 
            this.barPomo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barPomo.Location = new System.Drawing.Point(12, 77);
            this.barPomo.Maximum = 1500;
            this.barPomo.Name = "barPomo";
            this.barPomo.Size = new System.Drawing.Size(374, 23);
            this.barPomo.TabIndex = 4;
            // 
            // barLazy
            // 
            this.barLazy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barLazy.Location = new System.Drawing.Point(12, 143);
            this.barLazy.Maximum = 300;
            this.barLazy.Name = "barLazy";
            this.barLazy.Size = new System.Drawing.Size(374, 23);
            this.barLazy.TabIndex = 5;
            // 
            // lblLazyTime
            // 
            this.lblLazyTime.AutoSize = true;
            this.lblLazyTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLazyTime.ForeColor = System.Drawing.Color.Gray;
            this.lblLazyTime.Location = new System.Drawing.Point(13, 127);
            this.lblLazyTime.Name = "lblLazyTime";
            this.lblLazyTime.Size = new System.Drawing.Size(133, 13);
            this.lblLazyTime.TabIndex = 6;
            this.lblLazyTime.Text = "Lazy: 4m:59s/5m:00s";
            this.lblLazyTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLazyTimeAll
            // 
            this.lblLazyTimeAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLazyTimeAll.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLazyTimeAll.ForeColor = System.Drawing.Color.Gray;
            this.lblLazyTimeAll.Location = new System.Drawing.Point(166, 127);
            this.lblLazyTimeAll.Name = "lblLazyTimeAll";
            this.lblLazyTimeAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLazyTimeAll.Size = new System.Drawing.Size(220, 13);
            this.lblLazyTimeAll.TabIndex = 7;
            this.lblLazyTimeAll.Text = "Total Lazy Time: 45m:30s";
            this.lblLazyTimeAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDesc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.lblDesc.Location = new System.Drawing.Point(3, 20);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(318, 120);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = resources.GetString("lblDesc.Text");
            // 
            // lblDescTitle
            // 
            this.lblDescTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescTitle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.lblDescTitle.Location = new System.Drawing.Point(3, 4);
            this.lblDescTitle.Name = "lblDescTitle";
            this.lblDescTitle.Size = new System.Drawing.Size(206, 14);
            this.lblDescTitle.TabIndex = 9;
            this.lblDescTitle.Text = "How does this work?";
            // 
            // checkTop
            // 
            this.checkTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkTop.AutoSize = true;
            this.checkTop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkTop.FlatAppearance.BorderSize = 0;
            this.checkTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.checkTop.Location = new System.Drawing.Point(290, 23);
            this.checkTop.Name = "checkTop";
            this.checkTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkTop.Size = new System.Drawing.Size(96, 17);
            this.checkTop.TabIndex = 10;
            this.checkTop.Text = "Always on Top";
            this.checkTop.UseVisualStyleBackColor = true;
            this.checkTop.CheckedChanged += new System.EventHandler(this.checkTop_CheckedChanged);
            // 
            // btnExpand
            // 
            this.btnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpand.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExpand.FlatAppearance.BorderSize = 0;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.ForeColor = System.Drawing.Color.DimGray;
            this.btnExpand.Location = new System.Drawing.Point(-6, 232);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(411, 28);
            this.btnExpand.TabIndex = 12;
            this.btnExpand.Text = "Hide";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.Silver;
            this.lblCopyright.Location = new System.Drawing.Point(253, 140);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(68, 7);
            this.lblCopyright.TabIndex = 14;
            this.lblCopyright.Text = "© LazyPomo by DK";
            // 
            // checkSound
            // 
            this.checkSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkSound.AutoSize = true;
            this.checkSound.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkSound.Checked = true;
            this.checkSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.checkSound.Location = new System.Drawing.Point(221, 23);
            this.checkSound.Name = "checkSound";
            this.checkSound.Size = new System.Drawing.Size(57, 17);
            this.checkSound.TabIndex = 15;
            this.checkSound.Text = "Sound";
            this.checkSound.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "myPomo";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(-6, 259);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 25);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-6, 258);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(14, 28);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(63, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 165);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditTime
            // 
            this.btnEditTime.Location = new System.Drawing.Point(-6, 309);
            this.btnEditTime.Name = "btnEditTime";
            this.btnEditTime.Size = new System.Drawing.Size(75, 25);
            this.btnEditTime.TabIndex = 21;
            this.btnEditTime.Text = "Edit";
            this.btnEditTime.UseVisualStyleBackColor = true;
            this.btnEditTime.Click += new System.EventHandler(this.btnEditTime_Click);
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(213, 334);
            this.numMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(39, 20);
            this.numMinutes.TabIndex = 22;
            // 
            // btnEditAction
            // 
            this.btnEditAction.Location = new System.Drawing.Point(258, 308);
            this.btnEditAction.Name = "btnEditAction";
            this.btnEditAction.Size = new System.Drawing.Size(90, 46);
            this.btnEditAction.TabIndex = 23;
            this.btnEditAction.Text = "Do it!";
            this.btnEditAction.UseVisualStyleBackColor = true;
            this.btnEditAction.Click += new System.EventHandler(this.btnEditAction_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(-6, 334);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 25);
            this.btnInfo.TabIndex = 24;
            this.btnInfo.Text = "About";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pnlAbout
            // 
            this.pnlAbout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlAbout.Controls.Add(this.lblDesc);
            this.pnlAbout.Controls.Add(this.lblDescTitle);
            this.pnlAbout.Controls.Add(this.lblCopyright);
            this.pnlAbout.Location = new System.Drawing.Point(81, 382);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(324, 152);
            this.pnlAbout.TabIndex = 25;
            this.pnlAbout.Visible = false;
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(213, 308);
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(39, 20);
            this.numHours.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(117, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Change Minutes:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(63, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Edit Pomo Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(126, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Change Hours:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCheatbox
            // 
            this.txtCheatbox.Location = new System.Drawing.Point(120, 363);
            this.txtCheatbox.Name = "txtCheatbox";
            this.txtCheatbox.Size = new System.Drawing.Size(228, 20);
            this.txtCheatbox.TabIndex = 30;
            this.txtCheatbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheatbox_KeyDown);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(-6, 284);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(77, 25);
            this.btnOpen.TabIndex = 31;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "myPomo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(398, 411);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtCheatbox);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numHours);
            this.Controls.Add(this.btnEditAction);
            this.Controls.Add(this.numMinutes);
            this.Controls.Add(this.checkSound);
            this.Controls.Add(this.checkTop);
            this.Controls.Add(this.lblLazyTimeAll);
            this.Controls.Add(this.lblLazyTime);
            this.Controls.Add(this.barLazy);
            this.Controls.Add(this.barPomo);
            this.Controls.Add(this.lblPomoTime);
            this.Controls.Add(this.lblPomoTimeAll);
            this.Controls.Add(this.lblPomoCount);
            this.Controls.Add(this.btnPomo);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btnEditTime);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lazy Pomo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerPomo;
        private System.Windows.Forms.Timer timerLazy;
        private System.Windows.Forms.Button btnPomo;
        private System.Windows.Forms.Label lblPomoCount;
        private System.Windows.Forms.Label lblPomoTimeAll;
        private System.Windows.Forms.Label lblPomoTime;
        private System.Windows.Forms.ProgressBar barPomo;
        private System.Windows.Forms.ProgressBar barLazy;
        private System.Windows.Forms.Label lblLazyTime;
        private System.Windows.Forms.Label lblLazyTimeAll;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblDescTitle;
        private System.Windows.Forms.CheckBox checkTop;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.CheckBox checkSound;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditTime;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.Button btnEditAction;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCheatbox;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

