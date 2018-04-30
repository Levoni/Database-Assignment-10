using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
   class Oracle
   {
      //The Enumeration Data Type for user response 
      public enum ResponseType { OK, Cancel };

      internal static string UserName;
      internal static string PassWd;
      internal static string Server;
      internal static ResponseType Result;

      public static void LogInAtRunTime()
      {

      }

      public static void Main()
      {
         bool connected = false;
         FormClassLogin login = new FormClassLogin();
         while (!connected)
         {
            login.ShowDialog();
            if (login.DialogResult == System.Windows.Forms.DialogResult.Cancel)
               connected = true;
         }
      }

   }
   /*
   The pseudo code of Sub Main could be as follows:
      Set Connected to False
      While Not Connected
         Show Form Login as a dialogue
         If Response is Cancel
            Exit while
         Else
            Try
               Call LogInAtRunTime
               Set Connected to true and exit while
            Catch an exception
               Display a message box
      End While

      If Connected
         Run application with FormClassBooking
   }
   */
}
