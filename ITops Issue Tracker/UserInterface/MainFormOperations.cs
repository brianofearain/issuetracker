using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker
{
   internal interface IMainFormOperations
   {
      void OnFormLoading();
      void SetAnswer(string answer);
      void Cancel();
   }
}
