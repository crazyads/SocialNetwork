using System;
using System.IO;
using System.Windows.Forms;

namespace SocialNetworkTools
{
    public class ADSPlugin
    {
        public static void WriteText(string path, string str)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(path);
                fileInfo.Delete();
                StreamWriter streamWriter = new StreamWriter(path, true);
                streamWriter.WriteLine(str);
                streamWriter.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void WriteLog(string form, string mess)
        {
            try
            {
                using (FileStream fileStream = new FileStream(Application.StartupPath + "\\data\\log.txt", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        TextWriter arg_57_0 = streamWriter;
                        string[] expr_25 = new string[5];
                        int arg_39_1 = 0;
                        DateTime now = DateTime.Now;
                        expr_25[arg_39_1] = now.ToString("dd/MM/yyyy HH:mm:ss");
                        expr_25[1] = "  ";
                        expr_25[2] = form;
                        expr_25[3] = ": ";
                        expr_25[4] = mess;
                        arg_57_0.WriteLine(string.Concat(expr_25));
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
