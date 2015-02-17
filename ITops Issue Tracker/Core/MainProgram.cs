using System;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using System.Globalization;

namespace IssueTracker
{
   internal static class MainProgram
   {
      private delegate bool EnumWindowsProcedureDelegate(IntPtr hWnd, int lParam);
      
      [STAThread]
      private static void Main()
      {
         try
         {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            bool newMutx;
            msMutx = new Mutex(false, MutexName, out newMutx);
            if (!newMutx)
            {
               // There is another instance already running.
               ShowPreviousInstanceWindow();
               
               return;
            }
            
            Application.ThreadException += Application_ThreadException;

            MainMethods.GetInstance().Initiate();
         }
         catch (Exception exception)
         {
            OnUnhandledException(exception);
         }
      }

      private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
      {
         OnUnhandledException(e.ExceptionObject as Exception);
      }

      private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
      {
         OnUnhandledException(e.Exception);
      }

      private static void OnUnhandledException(Exception exception)
      {
         try
         {
            MessageBox.Show(
               (exception == null) ? "Unhandled exception." : exception.ToString(),
               ClientForm1.MainFormText,
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
         }
         catch
         {
         }
         finally
         {
            Application.Exit();
            Environment.Exit(0);
         }
      }

      private static void ShowPreviousInstanceWindow()
      {
         msPreviousInstanceWindowHandle = IntPtr.Zero;

         EnumWindowsProcedureDelegate enumWindowsProcedureDelegate = EnumWindowsProcedure;
         
         Win32Native.EnumWindows(enumWindowsProcedureDelegate, 0);
         
         if (msPreviousInstanceWindowHandle != IntPtr.Zero)
         {
            Win32Native.PostMessage(
               msPreviousInstanceWindowHandle,
               ClientForm1.WM_SHOWUP,
               0,
               0);
         }
      }

      private static bool EnumWindowsProcedure(IntPtr hWnd, int lParam)
      {
         StringBuilder windowText = new StringBuilder(ClientForm1.MainFormText.Length + 1);
         if (Win32Native.GetWindowText(hWnd, windowText, windowText.Capacity) != 0)
         {
            if (StringsEqual(windowText.ToString(), ClientForm1.MainFormText))
            {
               if (Win32Native.GetWindowLong(hWnd, Win32Native.GWL_USERDATA) == ClientForm1.MainWindowUserData)
               {
                  msPreviousInstanceWindowHandle = hWnd;
               }
            }
         }

         return (msPreviousInstanceWindowHandle == IntPtr.Zero);
      }

      private static bool StringsEqual(string string1, string string2)
      {
         return (string.Compare(string1, string2, false, CultureInfo.InvariantCulture) == 0);
      }


      private const string MutexName = "IssueTracker_{2E920FE1-CC2F-45DA-BCE6-DB8A062CA8E9}";

      private static Mutex msMutx;

      private static IntPtr msPreviousInstanceWindowHandle;
   }
}
