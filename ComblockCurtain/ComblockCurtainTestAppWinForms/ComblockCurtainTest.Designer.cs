namespace ComblockCurtainTestAppWinForms
{
    partial class ComblockCurtainTest
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
            this.cmdTestFormBottomButton = new System.Windows.Forms.Button();
            this.udcCurtain = new ComblockCurtainControlWinForms.ComblockCurtain();
            this.SuspendLayout();
            // 
            // cmdTestFormBottomButton
            // 
            this.cmdTestFormBottomButton.BackColor = System.Drawing.Color.Orange;
            this.cmdTestFormBottomButton.Location = new System.Drawing.Point(28, 129);
            this.cmdTestFormBottomButton.Name = "cmdTestFormBottomButton";
            this.cmdTestFormBottomButton.Size = new System.Drawing.Size(212, 220);
            this.cmdTestFormBottomButton.TabIndex = 1;
            this.cmdTestFormBottomButton.Text = "Test form bottom button.";
            this.cmdTestFormBottomButton.UseVisualStyleBackColor = false;
            this.cmdTestFormBottomButton.Click += new System.EventHandler(this.cmdTestFormBottomButton_Click);
            // 
            // udcCurtain
            // 
            this.udcCurtain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.udcCurtain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udcCurtain.CurtainText = "";
            this.udcCurtain.IsDebugMode = false;
            this.udcCurtain.Location = new System.Drawing.Point(12, 12);
            this.udcCurtain.Name = "udcCurtain";
            this.udcCurtain.Size = new System.Drawing.Size(249, 254);
            this.udcCurtain.TabIndex = 0;
            // 
            // ComblockCurtainTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.udcCurtain);
            this.Controls.Add(this.cmdTestFormBottomButton);
            this.Name = "ComblockCurtainTest";
            this.Text = "Comblock curtain control test";
            this.ClientSizeChanged += new System.EventHandler(this.ComblockCurtainTest_ClientSizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private ComblockCurtainControlWinForms.ComblockCurtain udcCurtain;
        private System.Windows.Forms.Button cmdTestFormBottomButton;
    }
}

