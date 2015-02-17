using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;

namespace IssueTracker
{
   internal partial class ClientForm1 : Form
   {
      public ClientForm1(IMainFormOperations operations)
      {
         Debug.Assert(operations != null);

         mOperations = operations;

         InitializeComponent();

         SetStyle(ControlStyles.EnableNotifyMessage, true);

         Text = MainFormText;

         mNextFinishButton.Text = NextFinishButtonText_Next;
      }

      public void SetQuestion(
         int questionNumber,
         int questionsCount,
         string question,
         string elaboration)
      {
         Debug.Assert(!InvokeRequired);

         const string QuestionNumberFormatString = "Question {0} of {1}";

         mQuestionNumberlabel1.Text = string.Format(
            NumberFormatInfo.InvariantInfo,
            QuestionNumberFormatString,
            questionNumber,
            questionsCount);

         MQuestionBox1.Text = question;

         mAnswertextBox1.Text = "";
         mAnswertextBox1.Focus();
         
         SetAdviceStatus(false);
         mAdviceButton.Enabled = (elaboration != null);
         mAdviceTextBox.Text = elaboration;

         if (questionNumber == questionsCount)
         {
            mNextFinishButton.Text = NextFinishButtonText_Finish;
         }
         else
         {
            mNextFinishButton.Text = NextFinishButtonText_Next;
         }
      }

      public new void Close()
      {
         mClosing = true;
         base.Close();
      }

      public const string MainFormText = "IssueTracker";

      public const int MainWindowUserData = 31597;

      public const int WM_SHOWUP = Win32Native.WM_APP + 1;

      protected override void OnNotifyMessage(Message m)
      {
         switch (m.Msg)
         {
            case WM_SHOWUP:
               ShowUp();
               break;
         }

         base.OnNotifyMessage(m);
      }

      private void ShowUp()
      {
         if (InvokeRequired)
         {
            BeginInvoke(new MethodInvoker(ShowUp));
            return;
         }
         
         WindowState = FormWindowState.Normal;
         Activate();
      }

      private void SetAdviceStatus(bool shown)
      {
         const string AdviceButtonText_Shown = "A&dvice <-";
         const string AdviceButtonText_Hidden = "A&dvice ->";

         string adviceButtonText = shown ? AdviceButtonText_Shown : AdviceButtonText_Hidden;

         int formHeightIncrement = 0;
         if (mAdvicePanel.Visible ^ shown)
         {
            formHeightIncrement = mAdvicePanel.Visible ? -mAdvicePanel.Height : mAdvicePanel.Height;
         }

         mAdviceButton.Text = adviceButtonText;
         mAdvicePanel.Visible = shown;
         Height += formHeightIncrement;
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         Win32Native.SetWindowLong(Handle, Win32Native.GWL_USERDATA, MainWindowUserData);

         mOperations.OnFormLoading();
      }

      private void MainForm_Shown(object sender, EventArgs e)
      {
         mAnswertextBox1.Focus();
      }

      private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (!mClosing)
         {
            if (e.CloseReason == CloseReason.UserClosing)
            {
               e.Cancel = true;
               CancelButton_Click(null, EventArgs.Empty);
            }
         }
      }

      private void AdviceButton_Click(object sender, EventArgs e)
      {
         SetAdviceStatus(!mAdvicePanel.Visible);
      }

      private void NextFinishButton_Click(object sender, EventArgs e)
      {
         mOperations.SetAnswer(mAnswertextBox1.Text.Trim());
      }

      private void CancelButton_Click(object sender, EventArgs e)
      {
         mOperations.Cancel();
      }

      private const string NextFinishButtonText_Next = "&Next >>";
      private const string NextFinishButtonText_Finish = "&Finish";

      private IMainFormOperations mOperations;

      private bool mClosing = false;

      private void mLeftSidePictureBox1_Click(object sender, EventArgs e)
      {

      }
   }
}
