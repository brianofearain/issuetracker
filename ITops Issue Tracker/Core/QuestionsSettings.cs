using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker
{
   /// <summary>
   /// 
   /// </summary>
   internal enum FileTypeforOutput
   {
      TextType,
      Xml
   }

   /// <summary>
   /// 
   /// </summary>
   internal static class QuestionSettings
   {
      public static readonly List<QuestionDeclarations> QuestionsInfo = new List<QuestionDeclarations>()
      {      

          /* This is a sample:

         new QuestionInfo(
            "Do you want a tissue?", // The question
            "Here you go."),                // The advice (null if none)

          */

         new QuestionDeclarations(
            "Which Product is this issue occuring with?", "give the name"),

         new QuestionDeclarations(
            "Please give a description of the issue",
            "be precise"),

         new QuestionDeclarations(
            "Please give a description of the troubleshooting steps you have already tried" , "be precise"),
     
new QuestionDeclarations("please give a description of the environment you are working in. For example operating system, software platform and/or hardware specifications, include as appropriate for the issue", "be precise" ),
      
      new QuestionDeclarations(
            "Please describe the business impact of the issue", "be precise"), 
           
      
      
      };

      /// <summary>
      /// The folder in which the output file will be stored.
      /// </summary>
      /// 
      /// <remarks>
      /// If this is not a null reference, it must be valid as a folder path;
      /// the application will create the folder if it doesn't exist. If this
      /// is a null reference, the folder in which the executable resides will
      /// be the output folder.
      /// </remarks>
      public static readonly string OutputFolderPath = null;

      /// <summary>
      /// The base name of the output file.
      /// </summary>
      /// 
      /// <remarks>
      /// The application assumes that this is valid as a base file name.
      /// </remarks>
      public static readonly string OutputFileBaseName = "Answers";

      /// <summary>
      /// The type of the output file.
      /// </summary>
      public static readonly FileTypeforOutput OutputFileType = FileTypeforOutput.TextType;
   }
}
