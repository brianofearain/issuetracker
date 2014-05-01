
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;


namespace IssueTracker
{

   internal class MainMethods : IMainFormOperations
   {
     
      [MethodImpl(MethodImplOptions.Synchronized)]
      public static MainMethods GetInstance()
      {
         if (msMainManager == null)
         {
            msMainManager = new MainMethods();
         }

         return msMainManager;
      }

      /// <summary>
      /// 
      /// </summary>
      public void Initiate()
      {
         if (QuestionSettings.QuestionsInfo.Count == 0)
         {
            return;
         }

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         mMainForm = new ClientForm1(this);

         Application.Run(mMainForm);
      }

      #region IMainFormOperations Implementation

      /// <summary>
      /// 
      /// </summary>
      public void OnFormLoading()
      {
         mCurrentQuestionInfoIndex = 0;
         SetCurrentQuestion();
      }

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <param name="answer"></param>
      public void SetAnswer(string answer)
      {
         if (mMainForm == null)
         {
            return;
         }

         Debug.Assert(mCurrentQuestionInfoIndex >= 0);
         Debug.Assert(mCurrentQuestionInfoIndex < QuestionSettings.QuestionsInfo.Count);

         QuestionSettings.QuestionsInfo[mCurrentQuestionInfoIndex].Answer = answer;

         if (mCurrentQuestionInfoIndex == (QuestionSettings.QuestionsInfo.Count - 1))
         {
            OnFinish();
         }
         else
         {
            mCurrentQuestionInfoIndex++;
            SetCurrentQuestion();
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public void Cancel()
      {
         if (mMainForm == null)
         {
            return;
         }

         DialogResult result = MessageBox.Show(
            mMainForm,
            "Are you sure you want to quit?",
            ClientForm1.MainFormText,
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Exclamation);

         if (result == DialogResult.Yes)
         {
            CloseMainForm();
         }
      }

      #endregion IMainFormOperations Implementation

      // ------------------------------------------------------------------- //
      // ------------------------- Private Section ------------------------- //
      // ------------------------------------------------------------------- //

      /// <summary>
      /// 
      /// </summary>
      private MainMethods()
      {
      }

      /// <summary>
      /// 
      /// </summary>
      private void SetCurrentQuestion()
      {
         Debug.Assert(mMainForm != null);

         Debug.Assert(mCurrentQuestionInfoIndex >= 0);
         Debug.Assert(mCurrentQuestionInfoIndex < QuestionSettings.QuestionsInfo.Count);

         QuestionDeclarations questionInfo = QuestionSettings.QuestionsInfo[mCurrentQuestionInfoIndex];

         mMainForm.SetQuestion(
            mCurrentQuestionInfoIndex + 1,
            QuestionSettings.QuestionsInfo.Count,
            questionInfo.Question,
            questionInfo.Advice);
      }

      /// <summary>
      /// 
      /// </summary>
      private void OnFinish()
      {
         if (SaveAnswers())
         {
            MessageBox.Show(
               mMainForm,
               "The answers were stored successfully.",
               ClientForm1.MainFormText,
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            
            CloseMainForm();
         }
         else
         {
            MessageBox.Show(
               mMainForm,
               "Failed to save the answers.",
               ClientForm1.MainFormText,
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
         }
      }

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <returns></returns>
      private bool SaveAnswers()
      {
         bool succeeded;

         switch (QuestionSettings.OutputFileType)
         {
            case FileTypeforOutput.TextType:
               succeeded = SaveAnswersTextual();
               break;

            default: // FileTypeforOutput.Xml
               succeeded = SaveAnswersXml();
               break;
         }

         return succeeded;
      }

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <returns></returns>
      private bool SaveAnswersTextual()
      {
         string outputFilePath = GetOutputFilePath();

         StringBuilder contents = new StringBuilder();

         foreach (QuestionDeclarations questionInfo in QuestionSettings.QuestionsInfo)
         {
            contents.AppendLine(questionInfo.Question);
            contents.AppendLine(questionInfo.Answer);
            contents.AppendLine();
         }

         bool succeeded = true;

         try
         {
            File.WriteAllText(outputFilePath, contents.ToString());
         }
         catch
         {
            succeeded = false;
         }

         return succeeded;
      }

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <returns></returns>
      private bool SaveAnswersXml()
      {
         string outputFilePath = GetOutputFilePath();

         XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
         xmlWriterSettings.Indent = true;
         xmlWriterSettings.IndentChars = "   ";

         bool succeeded = true;

         try
         {
            using (XmlWriter xmlWriter = XmlWriter.Create(outputFilePath, xmlWriterSettings))
            {
               xmlWriter.WriteStartDocument();

               xmlWriter.WriteStartElement("issuetracker"); // The root element.

               foreach (QuestionDeclarations questionInfo in QuestionSettings.QuestionsInfo)
               {
                  xmlWriter.WriteStartElement("question");

                  xmlWriter.WriteElementString("text", questionInfo.Question);
                  xmlWriter.WriteElementString("answer", questionInfo.Answer);

                  xmlWriter.WriteEndElement(); // question
               }

               xmlWriter.WriteEndElement(); // issuetracker
            }
         }
         catch
         {
            succeeded = false;
         }

         return succeeded;
      }

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <returns></returns>
      private string GetOutputFilePath()
      {
         const string TxtFileExtension = "txt";
         const string XmlFileExtension = "xml";

         string folderPath;

         if (QuestionSettings.OutputFolderPath == null)
         {
            folderPath = Path.GetDirectoryName(Application.ExecutablePath);
         }
         else
         {
            folderPath = QuestionSettings.OutputFolderPath;

            if (!Directory.Exists(folderPath))
            {
               try
               {
                  Directory.CreateDirectory(folderPath);
               }
               catch
               {
               }
            }
         }

         string extension;

         switch (QuestionSettings.OutputFileType)
         {
            case FileTypeforOutput.TextType:
               extension = TxtFileExtension;
               break;

            default: // FileTypeforOutput.Xml:
               extension = XmlFileExtension;
               break;
         }

         return Path.Combine(
            folderPath,
            string.Format("{0}.{1}", QuestionSettings.OutputFileBaseName, extension));
      }

      /// <summary>
      /// 
      /// </summary>
      private void CloseMainForm()
      {
         ClientForm1 mainForm = mMainForm;

         mMainForm = null;

         mainForm.Close();
      }

      /// <summary>
      /// 
      /// </summary>
      private static MainMethods msMainManager = null;

      /// <summary>
      /// 
      /// </summary>
      private ClientForm1 mMainForm;

      /// <summary>
      /// 
      /// </summary>
      private int mCurrentQuestionInfoIndex;
   }
}
