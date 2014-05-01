using System;
using System.Collections.Generic;
using System.Text;
using System.Security;
using System.Runtime.InteropServices;

namespace IssueTracker
{
   /// <summary>
   /// 
   /// </summary>
   [SuppressUnmanagedCodeSecurity]
   internal class Win32Native
   {
      #region WinUser.h

      public const int GWL_USERDATA = -21;

      public const int WM_APP = 0x8000;

      [DllImport("user32.dll", SetLastError = true)]
      [return: MarshalAs(UnmanagedType.Bool)]
      public extern static bool EnumWindows(
         Delegate lpEnumFunc,
         int lParam);

      [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
      public extern static int GetWindowText(
         IntPtr hWnd,
         StringBuilder lpString,
         int nMaxCount);

      [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
      public extern static int SetWindowLong(
         IntPtr hWnd,
         int nIndex,
         int dwNewLong);

      [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
      public extern static int GetWindowLong(
         IntPtr hWnd,
         int nIndex);

      [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
      public extern static bool PostMessage(
         IntPtr hWnd,
         uint Msg,
         uint wParam,
         int lParam);

      #endregion WinUser.h
   }
}
