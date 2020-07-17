using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;
using DevExpress.XtraEditors;

namespace SocialNetworkTools
{
    public partial class XtraFormSetting : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormSetting()
        {
            base.Load += new EventHandler(this.XtraFormSetting_Load);
            InitializeComponent();
        }
        private void XtraFormSetting_Load(object sender, EventArgs e)
        {
            try
            {
                bool flag;
                if (flag = File.Exists(Application.StartupPath + "\\data\\setting\\setting.json"))
                {
                    try
                    {
                        DTO_SettingTool dTO_SettingTool = JsonConvert.DeserializeObject<DTO_SettingTool>(File.ReadAllText(Application.StartupPath + "\\data\\setting\\setting.json"));
                        this.txtPathLDPlayer.Text = dTO_SettingTool.LDPlayer;
                        this.SpinDelayTime.Value = new decimal(dTO_SettingTool.StartInter.TotalSeconds);
                        this.SPinFPS.Value = new decimal(dTO_SettingTool.FPS);
                        this.RadioOn.Checked = dTO_SettingTool.Audio;
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        ProjectData.ClearProjectError();
                    }
                }
                else
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\data\\setting");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }
        private void BOpenPath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                bool flag;
                if (flag = (folderBrowserDialog.ShowDialog() == DialogResult.OK))
                {
                    this.txtPathLDPlayer.Text = folderBrowserDialog.SelectedPath;
                }
                folderBrowserDialog.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BSave_Click(object sender, EventArgs e)
        {
            XtraFormMain mainForm = new XtraFormMain();
            try
            {
                bool flag;
                if (!(flag = !File.Exists(txtPathLDPlayer.Text.Trim() + "\\dnconsole.exe")))
                {
                    try
                    {
                        try
                        {
                            this.Cursor = Cursors.WaitCursor;
                            DTO_SettingTool dTO_SettingTool = new DTO_SettingTool
                            {
                                LDPlayer = txtPathLDPlayer.Text.Trim(),
                                StartInter = TimeSpan.FromSeconds(Convert.ToDouble(SpinDelayTime.Value)),
                                FPS = Convert.ToInt32(SPinFPS.Value),
                                Audio = RadioOn.Checked
                            };
                            int num = 1;
                            bool checked2;
                            if (checked2 = RadioOn.Checked)
                            {
                                num = 0;
                            }
                            Process process = new Process
                            {
                                StartInfo = new ProcessStartInfo
                                {
                                    FileName = txtPathLDPlayer.Text + "\\dnconsole.exe",
                                    Arguments = "globalsetting --fps " + Convert.ToString(SPinFPS.Value) + " --audio " + Convert.ToString(num),
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
                            ADSPlugin.WriteText(Application.StartupPath + "\\data\\setting\\setting.json", JsonConvert.SerializeObject(dTO_SettingTool));
                            XtraMessageBox.Show("Save Success!", "Notices!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        catch (Exception ex)
                        {
                            ProjectData.SetProjectError(ex);
                            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            ProjectData.ClearProjectError();
                        }
                        goto IL_2FE;
                    }
                    finally
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.Cursor = Cursors.Default;
                            mainForm.LoadData();
                            this.Close();
                        }));
                    }
                }
                MessageBox.Show("Folder LDPlayer Notfound!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                IL_2FE:;
                mainForm.Dispose();
            }            
            catch (Exception)
            {
                throw;
            }
        }
    }
}