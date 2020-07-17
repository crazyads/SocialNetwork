using System;
using System.Windows.Forms;

namespace SocialNetworkTools
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
      //  public static XtraFormMain Form;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Form = new XtraFormMain();
            Application.Run(new XtraFormMain());
        }
    }
}
