using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

namespace SocialNetworkTools
{
    public class DB_SQLite
    {
        SQLiteConnection sql_con;
        SQLiteCommand sql_cmd;
        
        private static DB_SQLite instance;
        public static DB_SQLite Instance
        {
            get
            {
                if (instance == null)
                    instance = new DB_SQLite();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=data\\data.sqlite;Version=3;New=False;Compress=True;");
            sql_con.Open();
        }
        public void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        public void CreateGroup(string Name)
        {
            SetConnection();
            string stringQuery = "INSERT INTO [Group] ('Name', 'Phone') VALUES ('" + Name + "', '0')";//insert the studyinfo into Db
            ExecuteQuery(stringQuery);
        }
        public void RenameGroup(string IDGroup, string NewName)
        {
            try
            {
                string text = string.Concat(new string[]
                {
                        "UPDATE [Group] set [Name]='", NewName, "' where IDGroup='", IDGroup, "'"
                });
                SetConnection();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = text;
                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        public void DeleteGroup(string IDGroup)
        {
            try
            {
                SetConnection();
                string text = string.Format(string.Concat(new string[]
                {
                        "DELETE FROM [Group] WHERE [IDGroup]='",
                        IDGroup,
                        "'; DELETE FROM [Device] WHERE [IDGroup]='",
                        IDGroup,
                        "'; DELETE FROM [Account] WHERE [IDGroup]='",
                        IDGroup,
                        "'"
                }), new object[0]);
                ExecuteQuery(text);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
        }
        public void UpdateDevice()
        {
            try
            {
                string xPathSQL = "Data Source=data\\data.sqlite;Version=3;";
                List<string> xListSQL = new List<string>();
                List<string> xListLDPlayer = new List<string>();
                string xPathLDPlayer = string.Empty;
                bool xFlag01;
                if (xFlag01 = File.Exists(Application.StartupPath + "\\data\\setting\\LDPlayer.txt"))
                    xPathLDPlayer = File.ReadAllText(Application.StartupPath + "\\data\\setting\\LDPlayer.txt").Trim();
                bool xFlag02;
                if (xFlag02 = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                {
                    DTO_SettingTool dTO_SettingTool = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                    xPathLDPlayer = dTO_SettingTool.LDPlayer.Trim();
                }
                using (SQLiteConnection sql_con = new SQLiteConnection(xPathSQL))
                {
                    sql_con.Open();
                    using (SQLiteCommand sql_cmd = sql_con.CreateCommand())
                    {
                        string xQuery = "SELECT IDDevice FROM [Device]";
                        sql_cmd.CommandText = xQuery;
                        sql_cmd.ExecuteNonQuery();
                        using (SQLiteDataReader sql_rd = sql_cmd.ExecuteReader())
                        {
                            bool xFlagID;
                            while (xFlagID = sql_rd.Read())
                            {
                                xListSQL.Add(Convert.ToString(sql_rd["IDDevice"]));
                            }
                            sql_rd.Close();
                        }
                        sql_cmd.Dispose();
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
                            RedirectStandardOutput = true,
                        }
                    };
                    process.Start();
                    string xLDPlayer = string.Empty;
                    StreamReader standardOutput = process.StandardOutput;
                    process.WaitForExit();
                    process.Dispose();
                    int xCount = 0;
                    try
                    {
                        xLDPlayer = standardOutput.ReadToEnd();
                        if (xLDPlayer != null)
                        {
                            string[] xTempValue = xLDPlayer.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (var xItem in xTempValue)
                            {
                                xListLDPlayer.Add(xItem[0].ToString());
                            }
                            if (xListLDPlayer.Count < xListSQL.Count)
                            {
                                xCount = xListSQL.Count;
                                using (SQLiteCommand sql_cmd = sql_con.CreateCommand())
                                {
                                    for (int i = 0; i <= xListSQL.Count; i++)
                                    {
                                        string xQuery = "DELETE FROM Device WHERE IDDevice = " + xListSQL[xCount - 1];
                                        sql_cmd.CommandText = xQuery;
                                        sql_cmd.ExecuteNonQuery();
                                        xCount--;
                                        xListSQL.RemoveAt(xCount);
                                        if (xListLDPlayer.Count == xCount)
                                            return;
                                    }
                                    sql_cmd.Dispose();
                                }
                            }
                            else if (xListLDPlayer.Count > xListSQL.Count)
                            {
                                xCount = xListSQL.Count;
                                using (SQLiteCommand sql_cmd = sql_con.CreateCommand())
                                {
                                    for (int i = xListSQL.Count; i < xListLDPlayer.Count; i++)
                                    {
                                        string[] xTemp01 = xTempValue[i].Split(',');
                                        string xQuery = "INSERT INTO Device(IDGroup,IDDevice,Name,IMEI,PhoneNumber,MacAddress,DeviceID,IsStop) VALUES ('0','" + xTemp01[0] + "','" + xTemp01[1] + "','','','','','True')";
                                        sql_cmd.CommandText = xQuery;
                                        sql_cmd.ExecuteNonQuery();
                                        xCount++;
                                        xListSQL.Add(xListSQL.Count.ToString());
                                        if (xListLDPlayer.Count == xCount)
                                            return;
                                    }
                                    sql_cmd.Dispose();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        ProjectData.ClearProjectError();
                    }
                    sql_con.Dispose();
                }
                #region Don't Use
                /*  try
                  {
                      string xData = "ALTER TABLE Account ADD Token TEXT; ALTER TABLE Account ADD Cookie TEXT";
                      ExecuteQuery(xData);
                  }
                  catch (Exception ex)
                  {
                      ProjectData.SetProjectError(ex);
                      ProjectData.ClearProjectError();
                  }
                  try
                  {
                      string xData = "ALTER TABLE Account ADD NameAccount TEXT";
                      ExecuteQuery(xData);
                  }
                  catch (Exception ex)
                  {
                      ProjectData.SetProjectError(ex);
                      ProjectData.ClearProjectError();
                  }
                  try
                  {
                      string xData = "ALTER TABLE Account ADD Friends TEXT";
                      ExecuteQuery(xData);
                  }
                  catch (Exception ex)
                  {
                      ProjectData.SetProjectError(ex);
                      ProjectData.ClearProjectError();
                  }
                  try
                  {
                      string xData = "ALTER TABLE Account ADD Groups TEXT";
                      ExecuteQuery(xData);
                  }
                  catch (Exception ex)
                  {
                      ProjectData.SetProjectError(ex);
                      ProjectData.ClearProjectError();
                  }*/
                #endregion
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        public void UpdateNameDevice()
        {
            try
            {
                SetConnection();
                string text = string.Empty;
                bool flag;
                if (flag = File.Exists(Application.StartupPath + "\\data\\setting\\LDPlayer.txt"))
                {
                    text = File.ReadAllText(Application.StartupPath + "\\data\\setting\\LDPlayer.txt").Trim();
                }
                bool flag2;
                if (flag2 = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                {
                    DTO_SettingTool dTO_SettingTool = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                    text = dTO_SettingTool.LDPlayer.Trim();
                }
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = text + "\\dnconsole.exe",
                        Arguments = "list2",
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
                string text2 = string.Empty;
                bool flag3;
                do
                {
                    try
                    {
                        text2 = standardOutput.ReadLine();
                        string[] array = text2.Split(new char[] { ',' });
                        string xQuery = "Update [Device] set [Name]='" + array[1] + "' WHERE [IDDevice]='" + array[0] + "'";
                        ExecuteQuery(xQuery);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        ProjectData.ClearProjectError();
                    }
                }
                while (!(flag3 = (process.HasExited & (Operators.CompareString(text2, null, false) == 0 | Operators.CompareString(text2, "", false) == 0))));
                process.Dispose();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        public void DeleteStatusDevice()
        {
            try
            {
                SetConnection();
                string xText = string.Format("UPDATE [Device] set [IsStop]='True'; UPDATE [Account] set [Icon]='0'", new object[0]);
                ExecuteQuery(xText);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        public void DeleteAllDevice()
        {
            try
            {
                SetConnection();
                string text = "DELETE FROM Device";
                ExecuteQuery(text);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        public void CopyDevice(string IDGroup)
        {
            try
            {
                string xPathData = @"Data Source=data\\data.sqlite;Version=3;New=False;Compress=True;";
                using (SQLiteConnection sql_con = new SQLiteConnection(xPathData))
                {
                    sql_con.Open();
                    List<string> list = new List<string>();
                    using (SQLiteCommand sql_cmd = sql_con.CreateCommand())
                    {
                        sql_cmd.CommandText = "SELECT IDDevice FROM [Device]";
                        sql_cmd.ExecuteNonQuery();
                        SQLiteDataReader sQLiteDataReader = sql_cmd.ExecuteReader();
                        bool xFlagID;
                        while (xFlagID = sQLiteDataReader.Read())
                        {
                            list.Add(Convert.ToString(sQLiteDataReader["IDDevice"]));
                        }
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
                                Arguments = "list2",
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
                        string text2 = string.Empty;
                        bool flag5;
                        do
                        {
                            try
                            {
                                text2 = standardOutput.ReadLine();
                                string[] array = text2.Split(new char[] { ',' });
                                bool flag4;
                                if (flag4 = !list.Contains(array[0]))
                                {
                                    using (SQLiteConnection sql_con1 = new SQLiteConnection(xPathData))
                                    {
                                        sql_con1.Open();
                                        using (SQLiteCommand sql_cmd1 = sql_con.CreateCommand())
                                        {
                                            string xTemp = "INSERT INTO Device(IDGroup,IDDevice,Name,IMEI,PhoneNumber,MacAddress,DeviceID,IsStop) VALUES ('" + IDGroup + "','" + array[0] + "','" + array[1] + "','','','','','True')";
                                            sql_cmd1.CommandText = xTemp;
                                            sql_cmd1.ExecuteNonQuery();
                                            sql_con1.Dispose();
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                ProjectData.SetProjectError(ex);
                                ProjectData.ClearProjectError();
                            }
                        }
                        while (!(flag5 = (process.HasExited & (Operators.CompareString(text2, null, false) == 0 | Operators.CompareString(text2, "", false) == 0))));
                        sql_con.Dispose();
                        process.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        public void StopDevice(string IDDevice)
        {
            try
            {
                string xPathData = @"Data Source=data\\data.sqlite;Version=3;New=False;Compress=True;";
                using (SQLiteConnection sqlile_con = new SQLiteConnection(xPathData))
                {
                    sql_con.Open();
                    using (SQLiteCommand sql_cmd = sqlile_con.CreateCommand())
                    {
                        string xQuery = string.Format("UPDATE [Device] set [IsStop]='True' WHERE [IDDevice]='" + IDDevice + "'; UPDATE [Account] set [IsStop]='True' WHERE [IDDevice]='" + IDDevice + "'");
                        sql_cmd.CommandText = xQuery;
                        sql_cmd.ExecuteNonQuery();
                    }
                }
                sql_con.Dispose();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        public void StopGroup(string IDGroup)
        {
            try
            {
                string xPathSQL = "Data Source=data\\data.sqlite;Version=3;";
                string xQuery = string.Format(string.Concat(new string[]
                {
                    "UPDATE [Device] set [IsStop]='True' WHERE [IDGroup]='",IDGroup,
                    "'; UPDATE [Account] set [IsStop]='True' WHERE [IDGroup]='", IDGroup,"'"
                }), new object[0]);
                using (SQLiteConnection sql_con = new SQLiteConnection(xPathSQL))
                {
                    sql_con.Open();
                    using (SQLiteCommand sql_cmd = sql_con.CreateCommand())
                    {
                        sql_cmd.CommandText = xQuery;
                        sql_cmd.ExecuteNonQuery();
                    }
                    sql_cmd.Dispose();
                }
                sql_con.Dispose();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
    }
}
