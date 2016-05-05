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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lblDesc.Location = new System.Drawing.Point(71, 289);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(316, 122);
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
            this.lblDescTitle.Location = new System.Drawing.Point(71, 271);
            this.lblDescTitle.Name = "lblDescTitle";
            this.lblDescTitle.Size = new System.Drawing.Size(315, 14);
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
            this.lblCopyright.Location = new System.Drawing.Point(319, 407);
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
            this.richTextBox1.Location = new System.Drawing.Point(-6, 274);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(11, 14);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(398, 411);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkSound);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.checkTop);
            this.Controls.Add(this.lblDescTitle);
            this.Controls.Add(this.lblDesc);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lazy Pomo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

