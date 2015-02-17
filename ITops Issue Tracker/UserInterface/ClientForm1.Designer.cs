namespace IssueTracker
{
   partial class ClientForm1
   {
      private System.ComponentModel.IContainer components = null;

      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      private void InitializeComponent()
      {
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm1));
          this.mLogoPictureBox = new System.Windows.Forms.PictureBox();
          this.mHeadpanel1 = new System.Windows.Forms.Panel();
          this.mHeadSeparlabel1 = new System.Windows.Forms.Label();
          this.mQuestionNumberlabel1 = new System.Windows.Forms.Label();
          this.mFooterSeparatorLabel = new System.Windows.Forms.Label();
          this.mLeftSidePictureBox1 = new System.Windows.Forms.PictureBox();
          this.mFooterPanel = new System.Windows.Forms.Panel();
          this.mNextFinishButton = new System.Windows.Forms.Button();
          this.mCancelButton = new System.Windows.Forms.Button();
          this.mSidebarPanel = new System.Windows.Forms.Panel();
          this.leftSidebarSepratorlabel1 = new System.Windows.Forms.Label();
          this.MQuestionBox1 = new System.Windows.Forms.TextBox();
          this.mAnswerLabel = new System.Windows.Forms.Label();
          this.mAnswertextBox1 = new System.Windows.Forms.TextBox();
          this.mAdviceButton = new System.Windows.Forms.Button();
          this.mAdviceTextBox = new System.Windows.Forms.TextBox();
          this.mAdvicePanel = new System.Windows.Forms.Panel();
          ((System.ComponentModel.ISupportInitialize)(this.mLogoPictureBox)).BeginInit();
          this.mHeadpanel1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.mLeftSidePictureBox1)).BeginInit();
          this.mFooterPanel.SuspendLayout();
          this.mSidebarPanel.SuspendLayout();
          this.mAdvicePanel.SuspendLayout();
          this.SuspendLayout();
          // 
          // mLogoPictureBox
          // 
          this.mLogoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.mLogoPictureBox.BackColor = System.Drawing.Color.Transparent;
          this.mLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mLogoPictureBox.Image")));
          this.mLogoPictureBox.Location = new System.Drawing.Point(456, 1);
          this.mLogoPictureBox.Name = "mLogoPictureBox";
          this.mLogoPictureBox.Size = new System.Drawing.Size(76, 77);
          this.mLogoPictureBox.TabIndex = 1;
          this.mLogoPictureBox.TabStop = false;
          this.mLogoPictureBox.WaitOnLoad = true;
          // 
          // mHeadpanel1
          // 
          this.mHeadpanel1.BackColor = System.Drawing.Color.White;
          this.mHeadpanel1.Controls.Add(this.mHeadSeparlabel1);
          this.mHeadpanel1.Controls.Add(this.mQuestionNumberlabel1);
          this.mHeadpanel1.Controls.Add(this.mLogoPictureBox);
          this.mHeadpanel1.Dock = System.Windows.Forms.DockStyle.Top;
          this.mHeadpanel1.Location = new System.Drawing.Point(0, 0);
          this.mHeadpanel1.Name = "mHeadpanel1";
          this.mHeadpanel1.Size = new System.Drawing.Size(532, 80);
          this.mHeadpanel1.TabIndex = 0;
          // 
          // mHeadSeparlabel1
          // 
          this.mHeadSeparlabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.mHeadSeparlabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
          this.mHeadSeparlabel1.Location = new System.Drawing.Point(0, 78);
          this.mHeadSeparlabel1.Name = "mHeadSeparlabel1";
          this.mHeadSeparlabel1.Size = new System.Drawing.Size(532, 2);
          this.mHeadSeparlabel1.TabIndex = 1;
          // 
          // mQuestionNumberlabel1
          // 
          this.mQuestionNumberlabel1.AutoSize = true;
          this.mQuestionNumberlabel1.BackColor = System.Drawing.Color.Transparent;
          this.mQuestionNumberlabel1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.mQuestionNumberlabel1.Location = new System.Drawing.Point(22, 25);
          this.mQuestionNumberlabel1.Name = "mQuestionNumberlabel1";
          this.mQuestionNumberlabel1.Size = new System.Drawing.Size(155, 25);
          this.mQuestionNumberlabel1.TabIndex = 0;
          this.mQuestionNumberlabel1.Text = "Question 1 of 3";
          // 
          // mFooterSeparatorLabel
          // 
          this.mFooterSeparatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.mFooterSeparatorLabel.Dock = System.Windows.Forms.DockStyle.Top;
          this.mFooterSeparatorLabel.Location = new System.Drawing.Point(0, 0);
          this.mFooterSeparatorLabel.Name = "mFooterSeparatorLabel";
          this.mFooterSeparatorLabel.Size = new System.Drawing.Size(532, 2);
          this.mFooterSeparatorLabel.TabIndex = 2;
          // 
          // mLeftSidePictureBox1
          // 
          this.mLeftSidePictureBox1.BackColor = System.Drawing.Color.Transparent;
          this.mLeftSidePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.mLeftSidePictureBox1.Location = new System.Drawing.Point(0, 0);
          this.mLeftSidePictureBox1.Name = "mLeftSidePictureBox1";
          this.mLeftSidePictureBox1.Size = new System.Drawing.Size(117, 291);
          this.mLeftSidePictureBox1.TabIndex = 3;
          this.mLeftSidePictureBox1.TabStop = false;
          this.mLeftSidePictureBox1.WaitOnLoad = true;
          this.mLeftSidePictureBox1.Click += new System.EventHandler(this.mLeftSidePictureBox1_Click);
          // 
          // mFooterPanel
          // 
          this.mFooterPanel.Controls.Add(this.mNextFinishButton);
          this.mFooterPanel.Controls.Add(this.mCancelButton);
          this.mFooterPanel.Controls.Add(this.mFooterSeparatorLabel);
          this.mFooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
          this.mFooterPanel.Location = new System.Drawing.Point(0, 371);
          this.mFooterPanel.Name = "mFooterPanel";
          this.mFooterPanel.Size = new System.Drawing.Size(532, 50);
          this.mFooterPanel.TabIndex = 7;
          // 
          // mNextFinishButton
          // 
          this.mNextFinishButton.DialogResult = System.Windows.Forms.DialogResult.OK;
          this.mNextFinishButton.Location = new System.Drawing.Point(357, 15);
          this.mNextFinishButton.Name = "mNextFinishButton";
          this.mNextFinishButton.Size = new System.Drawing.Size(75, 23);
          this.mNextFinishButton.TabIndex = 0;
          this.mNextFinishButton.Text = "&Next >>";
          this.mNextFinishButton.UseVisualStyleBackColor = true;
          this.mNextFinishButton.Click += new System.EventHandler(this.NextFinishButton_Click);
          // 
          // mCancelButton
          // 
          this.mCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          this.mCancelButton.Location = new System.Drawing.Point(445, 15);
          this.mCancelButton.Name = "mCancelButton";
          this.mCancelButton.Size = new System.Drawing.Size(75, 23);
          this.mCancelButton.TabIndex = 1;
          this.mCancelButton.Text = "Cancel";
          this.mCancelButton.UseVisualStyleBackColor = true;
          this.mCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
          // 
          // mSidebarPanel
          // 
          this.mSidebarPanel.BackColor = System.Drawing.Color.White;
          this.mSidebarPanel.Controls.Add(this.leftSidebarSepratorlabel1);
          this.mSidebarPanel.Controls.Add(this.mLeftSidePictureBox1);
          this.mSidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
          this.mSidebarPanel.Location = new System.Drawing.Point(0, 80);
          this.mSidebarPanel.Name = "mSidebarPanel";
          this.mSidebarPanel.Size = new System.Drawing.Size(117, 291);
          this.mSidebarPanel.TabIndex = 1;
          // 
          // leftSidebarSepratorlabel1
          // 
          this.leftSidebarSepratorlabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.leftSidebarSepratorlabel1.Dock = System.Windows.Forms.DockStyle.Right;
          this.leftSidebarSepratorlabel1.Location = new System.Drawing.Point(115, 0);
          this.leftSidebarSepratorlabel1.Name = "leftSidebarSepratorlabel1";
          this.leftSidebarSepratorlabel1.Size = new System.Drawing.Size(2, 291);
          this.leftSidebarSepratorlabel1.TabIndex = 0;
          // 
          // MQuestionBox1
          // 
          this.MQuestionBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.MQuestionBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
          this.MQuestionBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.MQuestionBox1.Location = new System.Drawing.Point(130, 93);
          this.MQuestionBox1.Multiline = true;
          this.MQuestionBox1.Name = "MQuestionBox1";
          this.MQuestionBox1.ReadOnly = true;
          this.MQuestionBox1.Size = new System.Drawing.Size(390, 63);
          this.MQuestionBox1.TabIndex = 2;
          this.MQuestionBox1.Text = "What\'s your name?";
          // 
          // mAnswerLabel
          // 
          this.mAnswerLabel.AutoSize = true;
          this.mAnswerLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.mAnswerLabel.Location = new System.Drawing.Point(130, 165);
          this.mAnswerLabel.Name = "mAnswerLabel";
          this.mAnswerLabel.Size = new System.Drawing.Size(56, 16);
          this.mAnswerLabel.TabIndex = 3;
          this.mAnswerLabel.Text = "&Answer:";
          // 
          // mAnswertextBox1
          // 
          this.mAnswertextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.mAnswertextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.mAnswertextBox1.Location = new System.Drawing.Point(130, 184);
          this.mAnswertextBox1.Multiline = true;
          this.mAnswertextBox1.Name = "mAnswertextBox1";
          this.mAnswertextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
          this.mAnswertextBox1.Size = new System.Drawing.Size(390, 66);
          this.mAnswertextBox1.TabIndex = 4;
          // 
          // mAdviceButton
          // 
          this.mAdviceButton.Location = new System.Drawing.Point(130, 263);
          this.mAdviceButton.Name = "mAdviceButton";
          this.mAdviceButton.Size = new System.Drawing.Size(75, 23);
          this.mAdviceButton.TabIndex = 5;
          this.mAdviceButton.Text = "A&dvice <-";
          this.mAdviceButton.UseVisualStyleBackColor = true;
          this.mAdviceButton.Click += new System.EventHandler(this.AdviceButton_Click);
          // 
          // mAdviceTextBox
          // 
          this.mAdviceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
          this.mAdviceTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
          this.mAdviceTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.mAdviceTextBox.Location = new System.Drawing.Point(0, 6);
          this.mAdviceTextBox.Multiline = true;
          this.mAdviceTextBox.Name = "mAdviceTextBox";
          this.mAdviceTextBox.ReadOnly = true;
          this.mAdviceTextBox.Size = new System.Drawing.Size(390, 66);
          this.mAdviceTextBox.TabIndex = 0;
          // 
          // mAdvicePanel
          // 
          this.mAdvicePanel.Controls.Add(this.mAdviceTextBox);
          this.mAdvicePanel.Location = new System.Drawing.Point(130, 287);
          this.mAdvicePanel.Name = "mAdvicePanel";
          this.mAdvicePanel.Size = new System.Drawing.Size(390, 72);
          this.mAdvicePanel.TabIndex = 6;
          // 
          // ClientForm1
          // 
          this.AcceptButton = this.mNextFinishButton;
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.CancelButton = this.mCancelButton;
          this.ClientSize = new System.Drawing.Size(532, 421);
          this.Controls.Add(this.mAdvicePanel);
          this.Controls.Add(this.mAdviceButton);
          this.Controls.Add(this.mAnswertextBox1);
          this.Controls.Add(this.mAnswerLabel);
          this.Controls.Add(this.MQuestionBox1);
          this.Controls.Add(this.mSidebarPanel);
          this.Controls.Add(this.mFooterPanel);
          this.Controls.Add(this.mHeadpanel1);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.MaximizeBox = false;
          this.Name = "ClientForm1";
          this.Text = "IssueTracker";
          this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
          this.Load += new System.EventHandler(this.MainForm_Load);
          this.Shown += new System.EventHandler(this.MainForm_Shown);
          ((System.ComponentModel.ISupportInitialize)(this.mLogoPictureBox)).EndInit();
          this.mHeadpanel1.ResumeLayout(false);
          this.mHeadpanel1.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.mLeftSidePictureBox1)).EndInit();
          this.mFooterPanel.ResumeLayout(false);
          this.mSidebarPanel.ResumeLayout(false);
          this.mAdvicePanel.ResumeLayout(false);
          this.mAdvicePanel.PerformLayout();
          this.ResumeLayout(false);
          this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox mLogoPictureBox;
      private System.Windows.Forms.Panel mHeadpanel1;
      private System.Windows.Forms.Label mQuestionNumberlabel1;
      private System.Windows.Forms.Label mHeadSeparlabel1;
      private System.Windows.Forms.Label mFooterSeparatorLabel;
      private System.Windows.Forms.PictureBox mLeftSidePictureBox1;
      private System.Windows.Forms.Panel mFooterPanel;
      private System.Windows.Forms.Panel mSidebarPanel;
      private System.Windows.Forms.Label leftSidebarSepratorlabel1;
      private System.Windows.Forms.TextBox MQuestionBox1;
      private System.Windows.Forms.Label mAnswerLabel;
      private System.Windows.Forms.TextBox mAnswertextBox1;
      private System.Windows.Forms.Button mAdviceButton;
      private System.Windows.Forms.TextBox mAdviceTextBox;
      private System.Windows.Forms.Panel mAdvicePanel;
      private System.Windows.Forms.Button mNextFinishButton;
      private System.Windows.Forms.Button mCancelButton;
   }
}

