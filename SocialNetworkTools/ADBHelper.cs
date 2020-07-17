using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

namespace SocialNetworkTools
{
    public class ADBHelper
    {
        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        public string xCaption;
        private static ADBHelper instance;
        public static ADBHelper Instance
        {
            get
            {
                if (instance == null)
                    instance = new ADBHelper();
                return instance;
            }
            set { instance = value; }
        }
        public void TurnOnLDPlayer(string IDDevice)
        {
            try
            {
                string xPathPlayer = string.Empty;
                bool flag;
                if (flag = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                {
                    DTO_SettingTool dTO_SettingTool = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                    xPathPlayer = dTO_SettingTool.LDPlayer.Trim();
                }
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = xPathPlayer + "\\dnconsole.exe",
                        Arguments = "launch --index " + IDDevice,
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true
                    }
                };
                process.Start();
                process.WaitForExit();                
                process.Dispose();                
                Thread.Sleep(TimeSpan.FromSeconds(1));
                SortLDPlayer(10);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        public void TurnOffLDPlayer(string IDDevice)
        {
            try
            {
                string text = string.Empty;
                bool flag;
                if (flag = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                {
                    DTO_SettingTool dTO_SettingTool = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                    text = dTO_SettingTool.LDPlayer.Trim();
                }
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = text + "\\dnconsole.exe",
                        Arguments = "quit --index " + IDDevice,
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true
                    }
                };
                process.Start();
                process.WaitForExit();
                process.Dispose();

            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        public void TurnOffAllLDPlayer()
        {
            try
            {
                string text = string.Empty;
                bool xFlag;
                if (xFlag = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                {
                    DTO_SettingTool dTO_SettingTool = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                    text = dTO_SettingTool.LDPlayer.Trim();
                }
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = text + "\\dnconsole.exe",
                        Arguments = "quitall",
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true
                    }
                };
                process.Start();
                process.WaitForExit();
                process.Dispose();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        public List<int> IsLive()
        {
            checked
            {
                List<int> xResult;
                try
                {
                    List<int> xList = new List<int>();
                    string xPathLDPlayer = string.Empty;
                    bool xFlagPath;
                    if (xFlagPath = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                    {
                        DTO_SettingTool dTO_SettingTool = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                        xPathLDPlayer = dTO_SettingTool.LDPlayer.Trim();
                    }
                    bool xFlagConso;
                    if (xFlagConso = File.Exists(xPathLDPlayer + "\\dnconsole.exe"))
                    {
                        try
                        {
                            Process process01 = new Process
                            {
                                StartInfo = new ProcessStartInfo
                                {
                                    FileName = xPathLDPlayer + "\\dnconsole.exe",
                                    Arguments = "list2",
                                    UseShellExecute = false,
                                    WindowStyle = ProcessWindowStyle.Hidden,
                                    RedirectStandardError = true,
                                    RedirectStandardOutput = true,
                                    CreateNoWindow = true
                                }
                            };
                            process01.Start();
                            process01.WaitForExit();
                            StreamReader standardOutput01 = process01.StandardOutput;
                            string xTextDevice01 = string.Empty;
                            while (true)
                            {
                                xTextDevice01 = standardOutput01.ReadLine();
                                bool xCheckValue;
                                if (!(xCheckValue = (Operators.CompareString(xTextDevice01, null, false) != 0)))
                                {
                                    break;
                                }
                                bool xCheckExist;
                                if (xCheckExist = xTextDevice01.Contains(","))
                                {
                                    string[] xArray01 = xTextDevice01.Split(new char[] { ',' });
                                    bool xCheckID;
                                    if (xCheckID = (Operators.CompareString(xArray01[4].Trim(), "1", false) == 0))
                                    {
                                        xList.Add((int)Convert.ToInt16(xArray01[0]));
                                    }
                                }
                            }
                            process01.Dispose();
                        }
                        catch (Exception ex)
                        {
                            ProjectData.SetProjectError(ex);
                            ProjectData.ClearProjectError();
                        }
                        bool flag6 = true;
                        try
                        {
                            Process process02 = new Process
                            {
                                StartInfo = new ProcessStartInfo
                                {
                                    FileName = xPathLDPlayer + "\\adb.exe",
                                    Arguments = "devices",
                                    UseShellExecute = false,
                                    WindowStyle = ProcessWindowStyle.Hidden,
                                    RedirectStandardError = true,
                                    RedirectStandardOutput = true,
                                    CreateNoWindow = true
                                }
                            };
                            process02.Start();
                            process02.WaitForExit();                            
                            StreamReader standardOutput02 = process02.StandardOutput;
                            string xTextDevice02 = standardOutput02.ReadToEnd();
                            string[] xArray02 = xTextDevice02.Split(new char[] { '\r' });
                            string[] xArray03 = xArray02;
                            int xNum = 0;
                            bool flag7;
                            while (flag7 = (xNum < xArray03.Length))
                            {
                                string xTextDevice03 = xArray03[xNum];
                                bool flag8;
                                bool flag9;
                                if ((flag8 = (Operators.CompareString(xTextDevice03.Trim(), "", false) != 0)) && (flag9 = xTextDevice03.Contains("offline")))
                                {
                                    flag6 = false;
                                }
                                xNum++;
                            }
                            process02.Dispose();
                        }
                        catch (Exception ex)
                        {
                            ProjectData.SetProjectError(ex);
                            ProjectData.ClearProjectError();
                        }
                        bool flag10;
                        if (flag10 = !flag6)
                        {
                            try
                            {
                                Process process03 = new Process
                                {
                                    StartInfo = new ProcessStartInfo
                                    {
                                        FileName = xPathLDPlayer + "\\adb.exe",
                                        Arguments = "kill-server",
                                        UseShellExecute = false,
                                        WindowStyle = ProcessWindowStyle.Hidden,
                                        RedirectStandardError = true,
                                        RedirectStandardOutput = true,
                                        CreateNoWindow = true
                                    }
                                };
                                process03.Start();
                                process03.WaitForExit();
                                process03.Dispose();
                            }
                            catch (Exception ex)
                            {
                                ProjectData.SetProjectError(ex);
                                ProjectData.ClearProjectError();
                            }
                            try
                            {
                                Process process04 = new Process
                                {
                                    StartInfo = new ProcessStartInfo
                                    {
                                        FileName = xPathLDPlayer + "\\adb.exe",
                                        Arguments = "start-server",
                                        UseShellExecute = false,
                                        WindowStyle = ProcessWindowStyle.Hidden,
                                        RedirectStandardError = true,
                                        RedirectStandardOutput = true,
                                        CreateNoWindow = true
                                    }
                                };
                                process04.Start();
                                process04.WaitForExit();
                                process04.Dispose();
                            }
                            catch (Exception ex)
                            {
                                ProjectData.SetProjectError(ex);
                                ProjectData.ClearProjectError();
                            }
                        }
                    }
                    List<int> xListTemp = xList;
                    xResult = xListTemp;
                }
                catch (Exception)
                {
                    throw;
                }
                return xResult;
            }
        }
        public void SortLDPlayer(int deviceinrow)
        {
            try
            {
                List<int> list = new List<int>();
                string xPathLDPlayer = string.Empty;
                bool xFlagPath;
                if (xFlagPath = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                {
                    DTO_SettingTool dTO_SettingTool = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                    xPathLDPlayer = dTO_SettingTool.LDPlayer.Trim();
                }
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = xPathLDPlayer + "\\dnconsole.exe",
                        Arguments = "list2",
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true
                    }
                };
                process.Start();
                StreamReader standardOutput = process.StandardOutput;
                string xListLDPlayer = string.Empty;
                int xNumX = 0;
                int xNumY = 0;
                int xCount = 0;
                bool xFlagCheckWhile;
                do
                {
                    xListLDPlayer = standardOutput.ReadLine();
                    bool xFlagCheckNull;
                    if (xFlagCheckNull = (Operators.CompareString(xListLDPlayer, "", false) != 0))
                    {
                        string[] xArray = xListLDPlayer.Split(new char[] { ',' });
                        bool xFlag;
                        if (xFlag = (Convert.ToInt64(xArray[2]) != 0L))
                        {
                            Rectangle bounds = Screen.PrimaryScreen.Bounds;
                            int xNumWidth = (int)Math.Round((double)bounds.Width / (double)deviceinrow);
                            int xNumHeight = (int)Math.Round(unchecked((double)xNumWidth * 1.7777777777777777 + 34.0));
                            MoveWindow((IntPtr)((long)Convert.ToUInt64(xArray[2])), xNumX, xNumY, xNumWidth, xNumHeight, true);
                            SetForegroundWindow((IntPtr)((long)Convert.ToUInt64(xArray[2])));
                            xNumX += xNumWidth;
                            bool xFlag01;
                            bool xFlag02;
                            if (xFlag01 = (xFlag02 = ((xCount + 1) % deviceinrow == 0)))
                            {
                                xNumX = 0;
                                xNumY += xNumHeight;
                            }
                            xCount++;
                        }
                    }
                }
                while (!(xFlagCheckWhile = (process.HasExited & Operators.CompareString(xListLDPlayer, null, false) == 0)));
                process.WaitForExit();
                process.Dispose();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        public void CheckLDPlayerRun()
        {
            try
            {
                string xTextLDPlayer = string.Empty;
                bool xFlagLDPlayer;
                if (xFlagLDPlayer = File.Exists(Application.StartupPath + "\\data\\setting\\LDPlayer.txt"))
                {
                    xTextLDPlayer = File.ReadAllText(Application.StartupPath + "\\data\\setting\\LDPlayer.txt").Trim();
                }
                bool xFlagSetting;
                if (xFlagSetting = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                {
                    DTO_SettingTool dTO_SettingTool = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                    xTextLDPlayer = dTO_SettingTool.LDPlayer.Trim();
                }
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = xTextLDPlayer + "\\dnconsole.exe",
                        Arguments = "runninglist",
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true
                    }
                };
                process.Start();
                process.WaitForExit();
                StreamReader standardOutput = process.StandardOutput;
                string xReadRunLD = standardOutput.ReadToEnd();
                if (xReadRunLD != "")
                {
                    string[] xTemp = xReadRunLD.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    xCaption = xTemp.Length + " Device Is Running...!";
                }
                else
                {
                    xCaption = "Stopped!";
                }
                process.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
