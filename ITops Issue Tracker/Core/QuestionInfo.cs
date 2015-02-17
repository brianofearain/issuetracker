using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker
{
    internal class QuestionDeclarations
    {
        public QuestionDeclarations(string question, string advice)
        {
            Question = question;
            Advice = advice;
        }

        public string Question;

        public string Advice;

        public string Answer;
    }
}

