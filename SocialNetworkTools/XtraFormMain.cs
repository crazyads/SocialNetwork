using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using SmartAssembly.SmartExceptionsCore;

namespace SocialNetworkTools
{
    public partial class XtraFormMain : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SetDeviceX(int i, int value);
        public delegate void SetAccountX(string IDDevice, string IDAccount, int i, string status, string message, int icon);
        public DTO_SettingTool ToolSetting;
        public DTO_Group dTOGroup;
        public string _IDGroup;
        public XtraFormMain()
        {
            try
            {
                base.Load += new EventHandler(this.XtraFormMain_Load);
                base.Closing += delegate (object a0, CancelEventArgs a1)
                {
                    try
                    {
                        this.XtraForm_FormClosing(RuntimeHelpers.GetObjectValue(a0), (FormClosingEventArgs)a1);
                    }
                    catch (Exception arg_17_0)
                    {
                        StackFrameHelper.CreateException3(arg_17_0, this, a0, a1);
                        throw;
                    }
                };
                this.InitializeComponent();
            }
            catch (Exception arg_48_0)
            {
                StackFrameHelper.CreateException1(arg_48_0, this);
                throw;
            }
        }
        private void XtraFormMain_Load(object sender, EventArgs e)
        {
            try
            {
                bool xFlag;
                if (xFlag = !Directory.Exists(Application.StartupPath + "\\data\\account"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\data\\account");
                }
                this.BackgroundWorker.RunWorkerAsync();
                DB_SQLite.Instance.UpdateDevice();
                this.LoadData();
                LStatus.Text = "about:blank";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error!");
            }
        }
        private void XtraForm_FormClosing(object v, FormClosingEventArgs e)
        {
            try
            {
                bool xFlag;
                if (xFlag = (XtraMessageBox.Show(new Form { TopMost = true }, "Are You Sure Exit Tool!", "Notices!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                {
                    e.Cancel = true;
                }
                else
                {
                    ADBHelper.Instance.TurnOffAllLDPlayer();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        private void BAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                string text = XtraInputBox.Show("Enter a name!", "New Group", "");
                bool flag;
                if (flag = (Operators.CompareString(text, "", false) != 0))
                {
                    DB_SQLite.Instance.CreateGroup(text);
                }
                this.LoadGroups();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void BAddDevices_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = this.gridViewGroup.GetFocusedDataSourceRowIndex();
            _IDGroup = Convert.ToString(gridViewGroup.GetRowCellValue(focusedRowHandle, "IDGroup"));
            int xNum = Convert.ToInt32(XtraInputBox.Show("Enter Number LDPlayer Create!", "Add Devices!", 1));
            int i = 1;
            while (i <= xNum)
            {
                string xNameLDPlayer = "newld";
                try
                {
                    Process process = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = this.ToolSetting.LDPlayer + "\\dnconsole.exe",
                            Arguments = "add --name " + xNameLDPlayer,
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
                try
                {
                    Process process2 = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = this.ToolSetting.LDPlayer + "\\dnconsole.exe",
                            Arguments = string.Format("restore --name " + xNameLDPlayer + " --file " + Application.StartupPath + "\\data\\LDPlayer.ldbk"),
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true,
                            RedirectStandardError = true,
                            RedirectStandardOutput = true,
                        }
                    };
                    process2.Start();
                    process2.WaitForExit();
                    process2.Dispose();
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                }
                try
                {
                    Process process3 = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = this.ToolSetting.LDPlayer + "\\dnconsole.exe",
                            Arguments = "modify --name " + xNameLDPlayer + " --resolution 540,960,240 --cpu 1 --memory 768 --imei auto",
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true,
                            RedirectStandardError = true,
                            RedirectStandardOutput = true
                        }
                    };
                    process3.Start();
                    process3.WaitForExit();
                    process3.Dispose();
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                }
                DB_SQLite.Instance.CopyDevice(_IDGroup);
                LoadDevices(_IDGroup);
                i++;
                continue;
            }
            SetLabelStatus();
        }
        private void BAddAccount_Click(object sender, EventArgs e)
        {
            gridViewAccount.SetRowCellValue(0, "No", 1);
            gridControlAccount.RefreshDataSource();
        }
        private void SetLabelStatus()
        {
            this.Invoke(new Action(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                ADBHelper.Instance.CheckLDPlayerRun();
                LStatus.Text = ADBHelper.Instance.xCaption;
            }));
        }
        private void LoadGroups()
        {
            List<DTO_Group> list = new List<DTO_Group>();
            try
            {
                string connection = "Data Source=data\\data.sqlite;Version=3;New=False;Compress=True;";
                SQLiteConnection sqlite_conn = new SQLiteConnection(connection);
                sqlite_conn.Open();
                using (SQLiteConnection sQLiteConnection2 = sqlite_conn)
                {
                    using (SQLiteCommand sQLiteCommand = sQLiteConnection2.CreateCommand())
                    {
                        string stringQuery = "SELECT IDGroup, Name From [Group]";
                        sQLiteCommand.CommandText = stringQuery;
                        SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
                        bool xFlag;
                        while (xFlag = sQLiteDataReader.Read())
                        {
                            DTO_Group dTO_Group = new DTO_Group
                            {
                                IDGroup = Convert.ToInt32(sQLiteDataReader["IDGroup"]),
                                Name = Convert.ToString(sQLiteDataReader["Name"]),
                                IsRun = 0
                            };
                            list.Add(dTO_Group);
                        }
                    }
                }
                sqlite_conn.Dispose();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                gridControlGroup.DataSource = list;
                gridViewGroup.RefreshData();
                gridViewGroup.UpdateCurrentRow();
            }
        }
        public void SetDevice(int i, int value)
        {
            try
            {
                SetDeviceX setDeviceX = SetDeviceXX;
                setDeviceX.Invoke(i, value);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        public void SetDeviceXX(int i, int value)
        {
            try
            {
                this.Invoke(new Action(() =>{
                    this.gridViewDevices.UpdateCurrentRow();
                    this.gridViewDevices.SetRowCellValue(i, "IsRun", value);
                    this.gridViewDevices.RefreshData();
                }));                
            }
            catch (Exception ex)
            {
                StackFrameHelper.CreateException3(ex, this, i, value);
                throw;
            }
        }
        public void LoadData()
        {
            try
            {
                LoadForm();
                Thread thread = new Thread(() =>
                {
                    try
                    {
                        DB_SQLite.Instance.DeleteStatusDevice();
                        if (IsHandleCreated)
                        {
                            this.Invoke(new Action(() =>
                            {
                                LoadGroups();
                            }));
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error!");
                    }
                })
                { IsBackground = true };
                thread.Start();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error!");
            }
        }
        public void LoadForm()
        {
            try
            {
                bool xFlag;
                if (xFlag = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                {
                    this.ToolSetting = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                    //try
                    //{
                    //    bool showName;
                    //    if (showName = this.ToolSetting.ShowName)
                    //    {
                    //        this.GridView2.get_Columns().get_Item("NameAccount").set_Visible(true);
                    //        this.GridView2.get_Columns().get_Item("ShowRunning").set_VisibleIndex(0);
                    //        this.GridView2.get_Columns().get_Item("UID").set_VisibleIndex(1);
                    //        this.GridView2.get_Columns().get_Item("Password").set_VisibleIndex(2);
                    //        this.GridView2.get_Columns().get_Item("PrivateKey").set_VisibleIndex(3);
                    //        this.GridView2.get_Columns().get_Item("Action").set_VisibleIndex(4);
                    //        bool isDcom;
                    //        if (!(isDcom = this.ToolSetting.isDcom))
                    //        {
                    //            this.GridView2.get_Columns().get_Item("Proxy").set_VisibleIndex(5);
                    //        }
                    //        else
                    //        {
                    //            this.GridView2.get_Columns().get_Item("Proxy").set_Visible(false);
                    //        }
                    //        this.GridView2.get_Columns().get_Item("NameAccount").set_VisibleIndex(6);
                    //        this.GridView2.get_Columns().get_Item("Note").set_VisibleIndex(7);
                    //        this.GridView2.get_Columns().get_Item("Status").set_VisibleIndex(8);
                    //    }
                    //    else
                    //    {
                    //        this.GridView2.get_Columns().get_Item("NameAccount").set_Visible(false);
                    //        this.GridView2.get_Columns().get_Item("ShowRunning").set_VisibleIndex(0);
                    //        this.GridView2.get_Columns().get_Item("UID").set_VisibleIndex(1);
                    //        this.GridView2.get_Columns().get_Item("Password").set_VisibleIndex(2);
                    //        this.GridView2.get_Columns().get_Item("PrivateKey").set_VisibleIndex(3);
                    //        this.GridView2.get_Columns().get_Item("Action").set_VisibleIndex(4);
                    //        bool isDcom2;
                    //        if (isDcom2 = this.ToolSetting.isDcom)
                    //        {
                    //            this.GridView2.get_Columns().get_Item("Proxy").set_Visible(false);
                    //        }
                    //        else
                    //        {
                    //            this.GridView2.get_Columns().get_Item("Proxy").set_VisibleIndex(5);
                    //        }
                    //        this.GridView2.get_Columns().get_Item("Note").set_VisibleIndex(6);
                    //        this.GridView2.get_Columns().get_Item("Status").set_VisibleIndex(7);
                    //    }
                    //}
                    //catch (Exception arg_322_0)
                    //{
                    //    ProjectData.SetProjectError(arg_322_0);
                    //    ProjectData.ClearProjectError();
                    //}
                    //try
                    //{
                    //    bool isDcom3;
                    //    if (isDcom3 = this.ToolSetting.isDcom)
                    //    {
                    //        this.BarSubItem4.set_Visibility(0);
                    //    }
                    //    else
                    //    {
                    //        this.BarSubItem4.set_Visibility(1);
                    //    }
                    //}
                    //catch (Exception expr_35B)
                    //{
                    //    ProjectData.SetProjectError(expr_35B);
                    //    Exception o = expr_35B;
                    //    ProjectData.ClearProjectError();
                    //}
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void LoadAction()
        {
            //checked
            //{
            //    try
            //    {
            //        this.cmbAction.get_Items().Clear();
            //        DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath + "\\data\\timeline");
            //        string[] array = directoryInfo.GetFiles().OrderByDescending((frm_Main._Closure$__.$I9 - 0 == null) ? (frm_Main._Closure$__.$I9 - 0 = new Func<FileInfo, DateTime>(frm_Main._Closure$__.$I._Lambda$__9 - 0)) : frm_Main._Closure$__.$I9 - 0).Select((frm_Main._Closure$__.$I9 - 1 == null) ? (frm_Main._Closure$__.$I9 - 1 = new Func<FileInfo, string>(frm_Main._Closure$__.$I._Lambda$__9 - 1)) : frm_Main._Closure$__.$I9 - 1).Take(40).ToArray<string>();
            //        string[] array2 = array;
            //        int num = 0;
            //        bool flag;
            //        while (flag = (num < array2.Length))
            //        {
            //            string text = array2[num];
            //            this.cmbAction.get_Items().Add(Path.GetFileNameWithoutExtension(text));
            //            num++;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        throw;
            //    }
            //}
        }
        private void LoadDevices(string IDGroup)
        {
            BindingList<DTO_Devices> xList = new BindingList<DTO_Devices>();
            try
            {
                string xPathSQL = "Data Source=data\\data.sqlite;Version=3;";
                using (SQLiteConnection sql_con = new SQLiteConnection(xPathSQL))
                {
                    sql_con.Open();
                    using (SQLiteCommand sql_cmd = sql_con.CreateCommand())
                    {
                        string xQuery = "SELECT IDDevice, Name, IsStop From [Device] Where IDGroup = " + IDGroup;
                        sql_cmd.CommandText = xQuery;
                        using (SQLiteDataReader sql_rd = sql_cmd.ExecuteReader())
                        {
                            bool flag;
                            while (flag = sql_rd.Read())
                            {
                                DTO_Devices dTO_Devices = new DTO_Devices
                                {
                                    IDDevice = Convert.ToString(sql_rd["IDDevice"]),
                                    IsStop = Convert.ToString(sql_rd["IsStop"]),
                                    Name = Convert.ToString(sql_rd["Name"]),
                                    IsRun = 0
                                };
                                xList.Add(dTO_Devices);
                            }
                        }
                        sql_cmd.Dispose();
                    }
                    sql_con.Dispose();
                }
            }
            finally
            {
                this.Invoke(new Action(() =>
                {
                    try
                    {
                        this.gridControlDevices.DataSource = xList;
                        this.gridViewDevices.RefreshData();
                        this.LoadAccount(Convert.ToString(this.gridViewGroup.GetRowCellValue(this.gridViewGroup.FocusedRowHandle, "IDGroup")), Convert.ToString(this.gridViewDevices.GetRowCellValue(this.gridViewDevices.FocusedRowHandle, "IDDevice")));
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }));
            }
        }
        public void LoadAccount(string IDGroup, string IDDevice)
        {
            BindingList<DTO_Account> xListAccount = new BindingList<DTO_Account>();
            try
            {
                string connection = "Data Source=data\\data.sqlite;Version=3;New=False;Compress=True;";
                SQLiteConnection sqlite_conn = new SQLiteConnection(connection);
                sqlite_conn.Open();
                using (SQLiteConnection sQLiteConnection2 = sqlite_conn)
                {
                    using (SQLiteCommand sQLiteCommand = sQLiteConnection2.CreateCommand())
                    {
                        string stringQuery = string.Concat(new string[]
                        {
                                "SELECT * From [Account] Where [IDGroup] = '",
                                IDGroup,
                                "' and [IDDevice] = '",
                                IDDevice,
                                "' ORDER BY [IDAccount]"
                        });
                        sQLiteCommand.CommandText = stringQuery;
                        SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
                        bool flag;
                        while (flag = sQLiteDataReader.Read())
                        {
                            string text = string.Empty;
                            string text2 = string.Empty;
                            string text3 = string.Empty;
                            try
                            {
                                text = Convert.ToString(sQLiteDataReader["Token"]);
                            }
                            catch (Exception arg_B5_0)
                            {
                                ProjectData.SetProjectError(arg_B5_0);
                                ProjectData.ClearProjectError();
                            }
                            try
                            {
                                text2 = Conversions.ToString(sQLiteDataReader["Cookie"]);
                            }
                            catch (Exception arg_D9_0)
                            {
                                ProjectData.SetProjectError(arg_D9_0);
                                ProjectData.ClearProjectError();
                            }
                            try
                            {
                                text3 = Conversions.ToString(sQLiteDataReader["NameAccount"]);
                            }
                            catch (Exception arg_FB_0)
                            {
                                ProjectData.SetProjectError(arg_FB_0);
                                ProjectData.ClearProjectError();
                            }
                            DTO_Account dTO_Account = new DTO_Account
                            {
                                IDGroup = Convert.ToInt32(IDGroup),
                                NameAccount = text3,
                                IDDevice = Convert.ToInt32(IDDevice),
                                Proxy = Convert.ToString(sQLiteDataReader["Proxy"]),
                                IDAccount = Convert.ToInt32(sQLiteDataReader["IDAccount"]),
                                UID = Convert.ToString(sQLiteDataReader["UID"]),
                                Password = Convert.ToString(sQLiteDataReader["Password"]),
                                Action = Convert.ToString(sQLiteDataReader["Timeline"]),
                                Logged = Convert.ToString(sQLiteDataReader["Logged"]),
                                IsStop = Convert.ToString(sQLiteDataReader["IsStop"]),
                                Status = Convert.ToString(sQLiteDataReader["Status"]),
                                Running = Convert.ToInt32(RuntimeHelpers.GetObjectValue(sQLiteDataReader["Icon"])),
                                PrivateKey = Convert.ToString(sQLiteDataReader["Key2FA"]),
                                Note = Convert.ToString(sQLiteDataReader["KeyKP"]),
                                Token = text,
                                Cookie = text2
                            };
                            DTO_Account dTO_Account2 = dTO_Account;
                            xListAccount.Add(dTO_Account2);
                            continue;
                        }
                    }
                }
            }
            catch (Exception arg_286_0)
            {
                ProjectData.SetProjectError(arg_286_0);
                ProjectData.ClearProjectError();
            }
            finally
            {
                base.Invoke(new Action(() =>
                {
                    try
                    {
                        this.gridControlAccount.DataSource = xListAccount;
                        this.gridViewAccount.RefreshData();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }));
            }
        }
        private void GridViewGroup_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            try
            {
                bool inRowCell;
                if (inRowCell = e.HitInfo.InRowCell)
                {
                    Point mousePosition = Control.MousePosition;
                    this.popupMenu1.ShowPopup(mousePosition);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error!");
            }
        }
        private void GridViewGroup_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.gridViewGroup.UpdateCurrentRow();
                int focusedRowHandle = this.gridViewGroup.FocusedRowHandle;
                string text = Conversions.ToString(this.gridViewGroup.GetRowCellValue(focusedRowHandle, "IDGroup"));
                this.LoadDevices(text);
            }
            catch (Exception expr_39)
            {
                ProjectData.SetProjectError(expr_39);
                Exception ex = expr_39;
                ADSPlugin.WriteLog("Main", ex.Message);
                ProjectData.ClearProjectError();
            }
        }
        private void GridViewDevices_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            try
            {
                bool inRowCell;
                if (inRowCell = e.HitInfo.InRowCell)
                {
                    Point mousePosition = Control.MousePosition;
                    this.popupMenu2.ShowPopup(mousePosition);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error!");
            }
        }
        private void GridViewDevices_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.gridViewDevices.UpdateCurrentRow();
                this.gridViewDevices.UpdateCurrentRow();
                this.Cursor = Cursors.WaitCursor;
                Thread thread = new Thread(() =>
                {

                    try
                    {
                        this.LoadAccount(Convert.ToString(this.gridViewGroup.GetRowCellValue(this.gridViewGroup.FocusedRowHandle, "IDGroup")), Convert.ToString(this.gridViewDevices.GetRowCellValue(this.gridViewDevices.FocusedRowHandle, "IDDevice")));
                    }
                    catch (Exception arg_49_0)
                    {
                        ProjectData.SetProjectError(arg_49_0);
                        ProjectData.ClearProjectError();
                    }
                    finally
                    {
                        base.BeginInvoke(new MethodInvoker(delegate
                        {
                            try
                            {
                                this.LoadAction();
                                this.Cursor = Cursors.Default;
                            }
                            catch (Exception arg_14_0)
                            {
                                StackFrameHelper.CreateException1(arg_14_0, this);
                                throw;
                            }
                        }));
                    }
                })
                { IsBackground = true };
                thread.Start();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void ButtonItem_SettingLDPlayer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormSetting formSetting = new XtraFormSetting();
            string text = string.Empty;
            try
            {
                bool flag;
                if (flag = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                {
                    DTO_SettingTool dTO_SettingTool = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                    text = dTO_SettingTool.LDPlayer.Trim();
                }
            }
            catch (Exception arg_46_0)
            {
                ProjectData.SetProjectError(arg_46_0);
                ProjectData.ClearProjectError();
            }
            if (formSetting.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    LoadForm();
                    bool flag3;
                    if (flag3 = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                    {
                        DTO_SettingTool dTO_SettingTool2 = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                        bool flag4;
                        if (flag4 = (Operators.CompareString(dTO_SettingTool2.LDPlayer, text, false) != 0))
                        {
                            DB_SQLite.Instance.DeleteAllDevice();
                            DB_SQLite.Instance.UpdateDevice();
                            this.LoadDevices(Conversions.ToString(0));
                        }
                    }
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    ProjectData.ClearProjectError();
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
            formSetting.Dispose();
        }
        private void ButtonItem_SortLDPlayer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int xNum = Convert.ToInt32(XtraInputBox.Show("Enter Number Row!", "Sort LDPlayer", Convert.ToString(5)));
                ADBHelper.Instance.SortLDPlayer(xNum);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }
        private void ButtonItem_EditNameGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridControlGroup.Cursor = Cursors.WaitCursor;
                this.gridViewGroup.UpdateCurrentRow();
                int focusedRowHandle = this.gridViewGroup.GetFocusedDataSourceRowIndex();
                string xID = Conversions.ToString(this.gridViewGroup.GetRowCellValue(focusedRowHandle, "IDGroup"));
                bool xFlagID;
                if (xFlagID = (Convert.ToInt16(xID) == 0))
                {
                    XtraMessageBox.Show("Canot Edit Default!", "Noties!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    string xName = XtraInputBox.Show("Enter a new name!", "Change Name", Convert.ToString(gridViewGroup.GetRowCellValue(focusedRowHandle, "Name")));
                    bool xFlagName;
                    if (xFlagName = (Operators.CompareString(xName, "", false) != 0))
                    {
                        DB_SQLite.Instance.RenameGroup(xID, xName);
                    }
                    this.LoadGroups();
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
            finally
            {
                this.gridControlGroup.Cursor = Cursors.Default;
            }
        }
        private void ButtonItem_DelGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool xFlag;
                if (xFlag = (XtraMessageBox.Show("Are you sure to del?", "Noties!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
                {
                    this.gridViewGroup.UpdateCurrentRow();
                    int[] selectedRows = this.gridViewGroup.GetSelectedRows();
                    int xNum = 0;
                    bool xFlag2;
                    while (xFlag2 = (xNum < selectedRows.Length))
                    {
                        int xNum2 = selectedRows[xNum];
                        string xIDGroup = Convert.ToString(this.gridViewGroup.GetRowCellValue(xNum2, "IDGroup"));
                        bool xFlag3;
                        if (xFlag3 = (Convert.ToInt32(xIDGroup) == 0))
                        {
                            XtraMessageBox.Show("Cannot Del Default!", "Notices!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            string xPathSQL = "Data Source=data\\data.sqlite;Version=3;";
                            using (SQLiteConnection sql_conn = new SQLiteConnection(xPathSQL))
                            {
                                sql_conn.Open();
                                using (SQLiteCommand sql_cmd = sql_conn.CreateCommand())
                                {
                                    string xQuery = "SELECT IDDevice FROM [Device] where [IDGroup] = " + xIDGroup;
                                    sql_cmd.CommandText = xQuery;
                                    sql_cmd.ExecuteNonQuery();
                                    using (SQLiteDataReader sql_rd = sql_cmd.ExecuteReader())
                                    {
                                        try
                                        {
                                            while (sql_rd.Read())
                                            {
                                                Process process = new Process()
                                                {
                                                    StartInfo = new ProcessStartInfo
                                                    {
                                                        FileName = ToolSetting.LDPlayer + "\\dnconsole.exe",
                                                        Arguments = "remove --index " + Convert.ToString(sql_rd["IDDevice"]),
                                                        UseShellExecute = false,
                                                        WindowStyle = ProcessWindowStyle.Hidden,
                                                        CreateNoWindow = true,
                                                        RedirectStandardError = true,
                                                        RedirectStandardOutput = true,
                                                    }
                                                };
                                                process.Start();
                                                process.WaitForExit();
                                                process.Dispose();
                                            }
                                        }
                                        finally
                                        {
                                            sql_rd.Close();
                                            sql_conn.Dispose();
                                        }
                                    }
                                }
                            }
                            DB_SQLite.Instance.DeleteGroup(xIDGroup);
                        }
                        xNum++;
                    }
                    this.LoadGroups();
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
        }
        private void ButtonItem_TurnOnDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    this.gridViewDevices.UpdateCurrentRow();
                    int focusedRowHandle = this.gridViewDevices.FocusedRowHandle;
                    string xIDDevice = Convert.ToString(this.gridViewDevices.GetRowCellValue(focusedRowHandle, "IDDevice"));
                    ADBHelper.Instance.TurnOnLDPlayer(xIDDevice);
                    SetLabelStatus();
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    ADSPlugin.WriteLog("Main", ex.Message);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    ProjectData.ClearProjectError();
                }
            })
            { IsBackground = true }.Start();
        }
        private void ButtonItem_TurnOffDive_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.gridViewDevices.UpdateCurrentRow();
                int focusedRowHandle = this.gridViewDevices.FocusedRowHandle;
                string xIDDevice = Convert.ToString(this.gridViewDevices.GetRowCellValue(focusedRowHandle, "IDDevice"));
                DB_SQLite.Instance.StopDevice(xIDDevice);
                ADBHelper.Instance.TurnOffLDPlayer(xIDDevice);
                SetLabelStatus();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ADSPlugin.WriteLog("Main", ex.Message);
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
        }
        private void ButtonItem_MoveDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SetLabelStatus();
                string xPathSQL = "Data Source=data\\data.sqlite;Version=3;";
                LayoutControl layoutControl = new LayoutControl
                {
                    Width = 50
                };
                TextEdit textEdit = new TextEdit();
                textEdit.Dispose();
                ComboBoxEdit comboBoxEdit = new ComboBoxEdit();
                comboBoxEdit.Properties.DropDownItemHeight = 20;
                comboBoxEdit.Properties.DropDownRows = 10;
                comboBoxEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
                using (SQLiteConnection sql_con = new SQLiteConnection(xPathSQL))
                {
                    sql_con.Open();
                    using (SQLiteCommand sql_cmd = sql_con.CreateCommand())
                    {
                        string xQuery = string.Format("SELECT IDGroup, Name FROM [Group]");
                        sql_cmd.CommandText = xQuery;
                        sql_cmd.ExecuteNonQuery();
                        using (SQLiteDataReader sql_rd = sql_cmd.ExecuteReader())
                        {
                            bool flag;
                            while (flag = sql_rd.Read())
                            {
                                comboBoxEdit.Properties.Items.Add(Operators.ConcatenateObject(Operators.ConcatenateObject(sql_rd["IDGroup"], " - "), sql_rd["Name"]));
                            }
                        }
                    }
                    comboBoxEdit.SelectedIndex = 0;
                    LabelControl labelControl = new LabelControl
                    {
                        Text = "Choose Group Move!",
                        Size = new Size(85, 16),
                        Font = new Font("Tahoma", 10F, FontStyle.Bold)
                    };
                    SeparatorControl separatorControl = new SeparatorControl();
                    separatorControl.Dispose();
                    layoutControl.Width = 50;
                    layoutControl.AddItem("	", labelControl);
                    layoutControl.AddItem("Group", comboBoxEdit);
                    bool flag2;
                    if (flag2 = (XtraDialog.Show(layoutControl, "Move To Group!", MessageBoxButtons.OKCancel) == DialogResult.OK))
                    {
                        this.gridViewDevices.UpdateCurrentRow();
                        int[] selectedRows = this.gridViewDevices.GetSelectedRows();
                        int xNum01 = 0;
                        bool flag3;
                        while (flag3 = (xNum01 < selectedRows.Length))
                        {
                            int xNum02 = selectedRows[xNum01];
                            string xIDDevice = Convert.ToString(this.gridViewDevices.GetRowCellValue(xNum02, "IDDevice"));
                            string xQueryDevice = string.Format("UPDATE Device set [IDGroup]='" + comboBoxEdit.SelectedItem.ToString().Split(new char[] { '-' })[0].Trim() + "'where IDDevice='" + xIDDevice + "'");
                            using (SQLiteCommand sql_cmd02 = sql_con.CreateCommand())
                            {
                                sql_cmd02.CommandText = xQueryDevice;
                                sql_cmd02.ExecuteNonQuery();
                            }
                            string xQueryAccount = string.Format("UPDATE Account set [IDGroup]='" + comboBoxEdit.SelectedItem.ToString().Split(new char[] { '-' })[0].Trim() + "' where IDDevice='" + xIDDevice + "'");
                            using (SQLiteCommand sql_cmd03 = sql_con.CreateCommand())
                            {
                                sql_cmd03.CommandText = xQueryAccount;
                                sql_cmd03.ExecuteNonQuery();
                            }
                            xNum01++;
                        }
                    }
                    sql_con.Dispose();
                    DB_SQLite.Instance.UpdateDevice();
                    this.gridViewGroup.UpdateCurrentRow();
                    this.gridViewDevices.UpdateCurrentRow();
                    this.LoadDevices(Convert.ToString(this.gridViewGroup.GetRowCellValue(this.gridViewGroup.FocusedRowHandle, "IDGroup")));
                    this.LoadAccount(Convert.ToString(this.gridViewGroup.GetRowCellValue(this.gridViewGroup.FocusedRowHandle, "IDGroup")), Convert.ToString(this.gridViewDevices.GetRowCellValue(this.gridViewDevices.FocusedRowHandle, "IDDevice")));
                    SetLabelStatus();
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
        }
        private void ButtonItem_EditNameDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridControlDevices.Cursor = Cursors.WaitCursor;
                this.gridViewDevices.UpdateCurrentRow();
                string o = Convert.ToString(this.gridViewDevices.GetRowCellValue(this.gridViewDevices.FocusedRowHandle, "IDDevice"));
                string text = XtraInputBox.Show("Enter a new name device!", "Rename Device!", Convert.ToString(this.gridViewDevices.GetRowCellValue(this.gridViewDevices.FocusedRowHandle, "Name")));
                bool flag;
                if (flag = (Operators.CompareString(text, "", false) != 0))
                {
                    text = text.Replace(" ", "-");
                    Process process = new Process
                    {
                        StartInfo = new ProcessStartInfo()
                        {
                            FileName = ToolSetting.LDPlayer + "\\dnconsole.exe",
                            Arguments = Convert.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("rename --index ", this.gridViewDevices.GetRowCellValue(this.gridViewDevices.FocusedRowHandle, "IDDevice")), " --title "), text)),
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
                    DB_SQLite.Instance.UpdateNameDevice();
                    this.gridViewDevices.SetRowCellValue(this.gridViewDevices.FocusedRowHandle, "Name", text);
                    XtraMessageBox.Show("Rename Success!", "Notices!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
            finally
            {
                this.gridControlDevices.Cursor = Cursors.Default;
            }
        }
        private void ButtonItem_DelDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var result = XtraMessageBox.Show("Are You Del!", "Notices!", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    this.gridViewDevices.UpdateCurrentRow();
                    string xPathSQL = "Data Source=data\\data.sqlite;Version=3;";
                    int[] selectedRows = this.gridViewDevices.GetSelectedRows();
                    int xNum01 = 0;
                    bool xFlag;
                    using (SQLiteConnection sql_con = new SQLiteConnection(xPathSQL))
                    {
                        sql_con.Open();
                        while (xFlag = (xNum01 < selectedRows.Length))
                        {
                            int xNum02 = selectedRows[xNum01];
                            string xIDDevice = Convert.ToString(this.gridViewDevices.GetRowCellValue(xNum02, "IDDevice"));
                            bool xCheckDel;
                            if (xCheckDel = (gridViewDevices.RowCount == 1) && (gridViewGroup.RowCount == 1))
                            {
                                XtraMessageBox.Show("Cannot Del Device!", "Notices!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            else
                            {
                                var xDelDevice = string.Format("DELETE FROM [Device] where [IDDevice]='{0}'", xIDDevice);
                                using (SQLiteCommand sql_cmd = sql_con.CreateCommand())
                                {
                                    sql_cmd.CommandText = xDelDevice;
                                    sql_cmd.ExecuteNonQuery();
                                }
                                string xUpdateAccount = string.Format("UPDATE [Account] SET [IDGroup]='10000', [IDDevice]='10000' WHERE IDDevice='{0}'", xIDDevice);
                                using (SQLiteCommand sql_cmd01 = sql_con.CreateCommand())
                                {
                                    sql_cmd01.CommandText = xUpdateAccount;
                                    sql_cmd01.ExecuteNonQuery();
                                }
                                Process process = new Process
                                {
                                    StartInfo = new ProcessStartInfo
                                    {
                                        FileName = this.ToolSetting.LDPlayer + "\\dnconsole.exe",
                                        Arguments = "remove --index " + xIDDevice,
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
                            xNum01++;
                        }
                        sql_con.Dispose();
                    }
                    SetLabelStatus();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    DB_SQLite.Instance.UpdateDevice();
                    this.LoadDevices(Convert.ToString(this.gridViewGroup.GetRowCellValue(this.gridViewGroup.FocusedRowHandle, "IDGroup")));
                    gridViewDevices.UpdateCurrentRow();
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                XtraMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void ButtonItem_OnAllDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Cursor = Cursors.WaitCursor;
                    }));
                    this.gridViewGroup.UpdateCurrentRow();
                    int focusedRowHandle = this.gridViewGroup.FocusedRowHandle;
                    string xIDGroup = Conversions.ToString(this.gridViewGroup.GetRowCellValue(focusedRowHandle, "IDGroup"));
                    int xDelay = 0;
                    bool xFlagSetting;
                    if (xFlagSetting = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                    {
                        DTO_SettingTool dTO_SettingTool = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                        xDelay = (int)Math.Round(dTO_SettingTool.StartInter.TotalSeconds);
                    }
                    string xPathSQL = "Data Source=data\\data.sqlite;Version=3;";
                    using (SQLiteConnection sql_con = new SQLiteConnection(xPathSQL))
                    {
                        sql_con.Open();
                        using (SQLiteCommand sql_cmd = sql_con.CreateCommand())
                        {
                            string xQuery = "SELECT IDDevice FROM [Device] where [IDGroup] = '" + xIDGroup + "'";
                            sql_cmd.CommandText = xQuery;
                            sql_cmd.ExecuteNonQuery();
                            using (SQLiteDataReader sql_rd = sql_cmd.ExecuteReader())
                            {
                                bool xFlagRD;
                                while (xFlagRD = sql_rd.Read())
                                {
                                    ADBHelper.Instance.TurnOnLDPlayer(Convert.ToString(sql_rd["IDDevice"]));
                                    SetLabelStatus();
                                    Thread.Sleep(TimeSpan.FromSeconds(xDelay));
                                }
                            }
                            sql_cmd.Dispose();
                        }
                        sql_con.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    ADSPlugin.WriteLog("Main", ex.Message);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    ProjectData.ClearProjectError();
                }
                finally
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Cursor = Cursors.WaitCursor;
                    }));
                }
            })
            { IsBackground = true }.Start();
        }
        private void ButtonItem_OffAllDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.gridViewGroup.UpdateCurrentRow();
                int focusedRowHandle = this.gridViewGroup.FocusedRowHandle;
                string xIDGroup = Conversions.ToString(this.gridViewGroup.GetRowCellValue(focusedRowHandle, "IDGroup"));
                DB_SQLite.Instance.StopGroup(xIDGroup);
                string xPathSQL = "Data Source=data\\data.sqlite;Version=3;";
                using (SQLiteConnection sql_con = new SQLiteConnection(xPathSQL))
                {
                    sql_con.Open();
                    using (SQLiteCommand sql_cmd = sql_con.CreateCommand())
                    {
                        string xQuery = "SELECT IDDevice FROM [Device] where [IDGroup] = '" + xIDGroup + "'";
                        sql_cmd.CommandText = xQuery;
                        sql_cmd.ExecuteNonQuery();
                        using (SQLiteDataReader sql_rd = sql_cmd.ExecuteReader())
                        {
                            bool xFlagRd;
                            while (xFlagRd = sql_rd.Read())
                            {
                                ADBHelper.Instance.TurnOffLDPlayer(Convert.ToString(sql_rd["IDDevice"]));
                            }
                            SetLabelStatus();
                        }
                        sql_cmd.Dispose();
                    }
                    sql_con.Dispose();
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ADSPlugin.WriteLog("Main", ex.Message);
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    List<int> xList = ADBHelper.Instance.IsLive();
                    int num = this.gridViewDevices.RowCount - 1;
                    for (int i = 0; i <= num; i++)
                    {
                        string xIDDevice = Convert.ToString(this.gridViewDevices.GetRowCellValue(i, "IDDevice"));
                        bool flag;
                        if (!(flag = xList.Contains(Convert.ToInt32(xIDDevice))))
                            SetDevice(i, 0);
                        else
                            SetDevice(i, 2);
                    }
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                }
                Thread.Sleep(1000);
            }
        }
    }
}