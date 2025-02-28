namespace ComblockCurtainControlWinForms
{
    partial class ComblockCurtain
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpKeypad = new System.Windows.Forms.TableLayoutPanel();
            this.lblEarningInProgress = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlUnlockedBanner = new System.Windows.Forms.Panel();
            this.cmdDigit1 = new ComblockCurtainControlWinForms.TransparentButton();
            this.cmdDigit0 = new ComblockCurtainControlWinForms.TransparentButton();
            this.cmdDigit2 = new ComblockCurtainControlWinForms.TransparentButton();
            this.cmdDigit3 = new ComblockCurtainControlWinForms.TransparentButton();
            this.cmdDigit4 = new ComblockCurtainControlWinForms.TransparentButton();
            this.cmdDigit5 = new ComblockCurtainControlWinForms.TransparentButton();
            this.cmdDigit6 = new ComblockCurtainControlWinForms.TransparentButton();
            this.cmdDigit7 = new ComblockCurtainControlWinForms.TransparentButton();
            this.cmdDigit8 = new ComblockCurtainControlWinForms.TransparentButton();
            this.cmdDigit9 = new ComblockCurtainControlWinForms.TransparentButton();
            this.tlpKeypad.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpKeypad
            // 
            this.tlpKeypad.ColumnCount = 3;
            this.tlpKeypad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpKeypad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpKeypad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpKeypad.Controls.Add(this.cmdDigit1, 0, 0);
            this.tlpKeypad.Controls.Add(this.cmdDigit0, 1, 3);
            this.tlpKeypad.Controls.Add(this.cmdDigit2, 1, 0);
            this.tlpKeypad.Controls.Add(this.cmdDigit3, 2, 0);
            this.tlpKeypad.Controls.Add(this.cmdDigit4, 0, 1);
            this.tlpKeypad.Controls.Add(this.cmdDigit5, 1, 1);
            this.tlpKeypad.Controls.Add(this.cmdDigit6, 2, 1);
            this.tlpKeypad.Controls.Add(this.cmdDigit7, 0, 2);
            this.tlpKeypad.Controls.Add(this.cmdDigit8, 1, 2);
            this.tlpKeypad.Controls.Add(this.cmdDigit9, 2, 2);
            this.tlpKeypad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKeypad.Location = new System.Drawing.Point(0, 0);
            this.tlpKeypad.Name = "tlpKeypad";
            this.tlpKeypad.RowCount = 4;
            this.tlpKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKeypad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKeypad.Size = new System.Drawing.Size(300, 400);
            this.tlpKeypad.TabIndex = 0;
            // 
            // lblEarningInProgress
            // 
            this.lblEarningInProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEarningInProgress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEarningInProgress.Location = new System.Drawing.Point(0, 185);
            this.lblEarningInProgress.Name = "lblEarningInProgress";
            this.lblEarningInProgress.Size = new System.Drawing.Size(300, 24);
            this.lblEarningInProgress.TabIndex = 0;
            this.lblEarningInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblEarningInProgress);
            this.pnlMain.Controls.Add(this.tlpKeypad);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(300, 400);
            this.pnlMain.TabIndex = 11;
            // 
            // pnlUnlockedBanner
            // 
            this.pnlUnlockedBanner.BackColor = System.Drawing.Color.Yellow;
            this.pnlUnlockedBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUnlockedBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlUnlockedBanner.Name = "pnlUnlockedBanner";
            this.pnlUnlockedBanner.Size = new System.Drawing.Size(300, 400);
            this.pnlUnlockedBanner.TabIndex = 11;
            this.pnlUnlockedBanner.Visible = false;
            // 
            // cmdDigit1
            // 
            this.cmdDigit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDigit1.BackColor = System.Drawing.Color.Transparent;
            this.cmdDigit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDigit1.Location = new System.Drawing.Point(1, 1);
            this.cmdDigit1.Margin = new System.Windows.Forms.Padding(1);
            this.cmdDigit1.Name = "cmdDigit1";
            this.cmdDigit1.Size = new System.Drawing.Size(97, 98);
            this.cmdDigit1.TabIndex = 1;
            this.cmdDigit1.TabStop = false;
            this.cmdDigit1.Text = "1";
            this.cmdDigit1.Click += new System.EventHandler(this.cmdDigit1_Click);
            // 
            // cmdDigit0
            // 
            this.cmdDigit0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDigit0.BackColor = System.Drawing.Color.Transparent;
            this.cmdDigit0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDigit0.Location = new System.Drawing.Point(100, 301);
            this.cmdDigit0.Margin = new System.Windows.Forms.Padding(1);
            this.cmdDigit0.Name = "cmdDigit0";
            this.cmdDigit0.Size = new System.Drawing.Size(97, 98);
            this.cmdDigit0.TabIndex = 10;
            this.cmdDigit0.TabStop = false;
            this.cmdDigit0.Text = "0";
            this.cmdDigit0.Click += new System.EventHandler(this.cmdDigit0_Click);
            // 
            // cmdDigit2
            // 
            this.cmdDigit2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDigit2.BackColor = System.Drawing.Color.Transparent;
            this.cmdDigit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDigit2.Location = new System.Drawing.Point(100, 1);
            this.cmdDigit2.Margin = new System.Windows.Forms.Padding(1);
            this.cmdDigit2.Name = "cmdDigit2";
            this.cmdDigit2.Size = new System.Drawing.Size(97, 98);
            this.cmdDigit2.TabIndex = 2;
            this.cmdDigit2.TabStop = false;
            this.cmdDigit2.Text = "2";
            this.cmdDigit2.Click += new System.EventHandler(this.cmdDigit2_Click);
            // 
            // cmdDigit3
            // 
            this.cmdDigit3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDigit3.BackColor = System.Drawing.Color.Transparent;
            this.cmdDigit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDigit3.Location = new System.Drawing.Point(199, 1);
            this.cmdDigit3.Margin = new System.Windows.Forms.Padding(1);
            this.cmdDigit3.Name = "cmdDigit3";
            this.cmdDigit3.Size = new System.Drawing.Size(100, 98);
            this.cmdDigit3.TabIndex = 3;
            this.cmdDigit3.TabStop = false;
            this.cmdDigit3.Text = "3";
            this.cmdDigit3.Click += new System.EventHandler(this.cmdDigit3_Click);
            // 
            // cmdDigit4
            // 
            this.cmdDigit4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDigit4.BackColor = System.Drawing.Color.Transparent;
            this.cmdDigit4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDigit4.Location = new System.Drawing.Point(1, 101);
            this.cmdDigit4.Margin = new System.Windows.Forms.Padding(1);
            this.cmdDigit4.Name = "cmdDigit4";
            this.cmdDigit4.Size = new System.Drawing.Size(97, 98);
            this.cmdDigit4.TabIndex = 4;
            this.cmdDigit4.TabStop = false;
            this.cmdDigit4.Text = "4";
            this.cmdDigit4.Click += new System.EventHandler(this.cmdDigit4_Click);
            // 
            // cmdDigit5
            // 
            this.cmdDigit5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDigit5.BackColor = System.Drawing.Color.Transparent;
            this.cmdDigit5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDigit5.Location = new System.Drawing.Point(100, 101);
            this.cmdDigit5.Margin = new System.Windows.Forms.Padding(1);
            this.cmdDigit5.Name = "cmdDigit5";
            this.cmdDigit5.Size = new System.Drawing.Size(97, 98);
            this.cmdDigit5.TabIndex = 5;
            this.cmdDigit5.TabStop = false;
            this.cmdDigit5.Text = "5";
            this.cmdDigit5.Click += new System.EventHandler(this.cmdDigit5_Click);
            // 
            // cmdDigit6
            // 
            this.cmdDigit6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDigit6.BackColor = System.Drawing.Color.Transparent;
            this.cmdDigit6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDigit6.Location = new System.Drawing.Point(199, 101);
            this.cmdDigit6.Margin = new System.Windows.Forms.Padding(1);
            this.cmdDigit6.Name = "cmdDigit6";
            this.cmdDigit6.Size = new System.Drawing.Size(100, 98);
            this.cmdDigit6.TabIndex = 6;
            this.cmdDigit6.TabStop = false;
            this.cmdDigit6.Text = "6";
            this.cmdDigit6.Click += new System.EventHandler(this.cmdDigit6_Click);
            // 
            // cmdDigit7
            // 
            this.cmdDigit7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDigit7.BackColor = System.Drawing.Color.Transparent;
            this.cmdDigit7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDigit7.Location = new System.Drawing.Point(1, 201);
            this.cmdDigit7.Margin = new System.Windows.Forms.Padding(1);
            this.cmdDigit7.Name = "cmdDigit7";
            this.cmdDigit7.Size = new System.Drawing.Size(97, 98);
            this.cmdDigit7.TabIndex = 7;
            this.cmdDigit7.TabStop = false;
            this.cmdDigit7.Text = "7";
            this.cmdDigit7.Click += new System.EventHandler(this.cmdDigit7_Click);
            // 
            // cmdDigit8
            // 
            this.cmdDigit8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDigit8.BackColor = System.Drawing.Color.Transparent;
            this.cmdDigit8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDigit8.Location = new System.Drawing.Point(100, 201);
            this.cmdDigit8.Margin = new System.Windows.Forms.Padding(1);
            this.cmdDigit8.Name = "cmdDigit8";
            this.cmdDigit8.Size = new System.Drawing.Size(97, 98);
            this.cmdDigit8.TabIndex = 8;
            this.cmdDigit8.TabStop = false;
            this.cmdDigit8.Text = "8";
            this.cmdDigit8.Click += new System.EventHandler(this.cmdDigit8_Click);
            // 
            // cmdDigit9
            // 
            this.cmdDigit9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDigit9.BackColor = System.Drawing.Color.Transparent;
            this.cmdDigit9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDigit9.Location = new System.Drawing.Point(199, 201);
            this.cmdDigit9.Margin = new System.Windows.Forms.Padding(1);
            this.cmdDigit9.Name = "cmdDigit9";
            this.cmdDigit9.Size = new System.Drawing.Size(100, 98);
            this.cmdDigit9.TabIndex = 9;
            this.cmdDigit9.TabStop = false;
            this.cmdDigit9.Text = "9";
            this.cmdDigit9.Click += new System.EventHandler(this.cmdDigit9_Click);
            // 
            // ComblockCurtain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlUnlockedBanner);
            this.Name = "ComblockCurtain";
            this.Size = new System.Drawing.Size(300, 400);
            this.Load += new System.EventHandler(this.ComblockCurtain_Load);
            this.ClientSizeChanged += new System.EventHandler(this.ComblockCurtain_ClientSizeChanged);
            this.tlpKeypad.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentButton cmdDigit1;
        private TransparentButton cmdDigit2;
        private TransparentButton cmdDigit3;
        private TransparentButton cmdDigit4;
        private TransparentButton cmdDigit5;
        private TransparentButton cmdDigit6;
        private TransparentButton cmdDigit7;
        private TransparentButton cmdDigit8;
        private TransparentButton cmdDigit9;
        private TransparentButton cmdDigit0;
        private System.Windows.Forms.Label lblEarningInProgress;
        private System.Windows.Forms.TableLayoutPanel tlpKeypad;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlUnlockedBanner;
    }
}
