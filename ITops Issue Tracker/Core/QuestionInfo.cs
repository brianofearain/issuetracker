using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker
{
   /// <summary>
   /// 
   /// </summary>
    internal class QuestionDeclarations
    {
        /// <summary>
        /// 
        /// </summary>
        /// 
        /// <param name="question"></param>
        /// <param name="advice">
        /// Set to null if no advice is associated.
        public QuestionDeclarations(string question, string advice)
        {
            Question = question;
            Advice = advice;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Question;

        /// <summary>
        /// Set to null if no advice is associated.
        /// </summary>
        public string Advice;

        /// <summary>
        /// 
        /// </summary>
        public string Answer;
    }
}

