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
      // ------------------------------------------------------------------- //
      // ------------------------- Public Section -------------------------- //
      // ------------------------------------------------------------------- //

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <param name="operations"></param>
      public ClientForm1(IMainFormOperations operations)
      {
         Debug.Assert(operations != null);

         mOperations = operations;

         InitializeComponent();

         SetStyle(ControlStyles.EnableNotifyMessage, true);

         Text = MainFormText;

         mNextFinishButton.Text = NextFinishButtonText_Next;
      }

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <param name="questionNumber"></param>
      /// <param name="questionsCount"></param>
      /// <param name="question"></param>
      /// <param name="elaboration">
      /// Set to a null reference if no elaboration is associated.
      /// </param>
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

      /// <summary>
      /// 
      /// </summary>
      public new void Close()
      {
         mClosing = true;
         base.Close();
      }

      /// <summary>
      /// 
      /// </summary>
      public const string MainFormText = "IssueTracker";

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <remarks>
      /// When we search for the main window of the previous instance, we
      /// check, in addition to the title of the window, the user data
      /// associated with the window. This is an arbitrary number.
      /// </remarks>
      public const int MainWindowUserData = 31597;

      /// <summary>
      /// 
      /// </summary>
      public const int WM_SHOWUP = Win32Native.WM_APP + 1;

      // ------------------------------------------------------------------- //
      // ------------------------ Protected Section ------------------------ //
      // ------------------------------------------------------------------- //

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <param name="m"></param>
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

      // ------------------------------------------------------------------- //
      // ------------------------- Private Section ------------------------- //
      // ------------------------------------------------------------------- //

      /// <summary>
      /// 
      /// </summary>
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

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <param name="shown"></param>
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

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void MainForm_Load(object sender, EventArgs e)
      {
         Win32Native.SetWindowLong(Handle, Win32Native.GWL_USERDATA, MainWindowUserData);

         mOperations.OnFormLoading();
      }

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void MainForm_Shown(object sender, EventArgs e)
      {
         mAnswertextBox1.Focus();
      }

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <param name="sender"></param>
      /// <param name="e"></param>
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

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void AdviceButton_Click(object sender, EventArgs e)
      {
         SetAdviceStatus(!mAdvicePanel.Visible);
      }

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void NextFinishButton_Click(object sender, EventArgs e)
      {
         mOperations.SetAnswer(mAnswertextBox1.Text.Trim());
      }

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void CancelButton_Click(object sender, EventArgs e)
      {
         mOperations.Cancel();
      }

      private const string NextFinishButtonText_Next = "&Next >>";
      private const string NextFinishButtonText_Finish = "&Finish";

      /// <summary>
      /// 
      /// </summary>
      private IMainFormOperations mOperations;

      /// <summary>
      /// 
      /// </summary>
      private bool mClosing = false;

      private void mLeftSidePictureBox1_Click(object sender, EventArgs e)
      {

      }
   }
}
