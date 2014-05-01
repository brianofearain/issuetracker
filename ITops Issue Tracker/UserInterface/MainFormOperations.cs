using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker
{
   /// <summary>
   /// 
   /// </summary>
   internal interface IMainFormOperations
   {
      /// <summary>
      /// 
      /// </summary>
      void OnFormLoading();

      /// <summary>
      /// 
      /// </summary>
      /// 
      /// <param name="answer"></param>
      void SetAnswer(string answer);

      /// <summary>
      /// 
      /// </summary>
      void Cancel();
   }
}
