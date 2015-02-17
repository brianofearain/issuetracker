using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker
{
   internal enum FileTypeforOutput
   {
      TextType,
      Xml
   }

   internal static class QuestionSettings
   {
      public static readonly List<QuestionDeclarations> QuestionsInfo = new List<QuestionDeclarations>()
      {      

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

      public static readonly string OutputFolderPath = null;

      public static readonly string OutputFileBaseName = "Answers";

      public static readonly FileTypeforOutput OutputFileType = FileTypeforOutput.TextType;
   }
}
