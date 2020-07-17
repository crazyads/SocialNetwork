namespace SocialNetworkTools
{
    partial class XtraFormSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormSetting));
            this.groupControlSettingLDPlayer = new DevExpress.XtraEditors.GroupControl();
            this.LPathLDPlayer = new DevExpress.XtraEditors.LabelControl();
            this.LAudio = new DevExpress.XtraEditors.LabelControl();
            this.LFPS = new DevExpress.XtraEditors.LabelControl();
            this.LDeLayTime = new DevExpress.XtraEditors.LabelControl();
            this.txtPathLDPlayer = new DevExpress.XtraEditors.TextEdit();
            this.RadioOn = new System.Windows.Forms.RadioButton();
            this.RadioOff = new System.Windows.Forms.RadioButton();
            this.BSave = new DevExpress.XtraEditors.SimpleButton();
            this.BCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BOpenPath = new DevExpress.XtraEditors.SimpleButton();
            this.SPinFPS = new DevExpress.XtraEditors.SpinEdit();
            this.SpinDelayTime = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSettingLDPlayer)).BeginInit();
            this.groupControlSettingLDPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPathLDPlayer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPinFPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinDelayTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlSettingLDPlayer
            // 
            this.groupControlSettingLDPlayer.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlSettingLDPlayer.AppearanceCaption.Options.UseFont = true;
            this.groupControlSettingLDPlayer.Controls.Add(this.SpinDelayTime);
            this.groupControlSettingLDPlayer.Controls.Add(this.SPinFPS);
            this.groupControlSettingLDPlayer.Controls.Add(this.RadioOff);
            this.groupControlSettingLDPlayer.Controls.Add(this.RadioOn);
            this.groupControlSettingLDPlayer.Controls.Add(this.txtPathLDPlayer);
            this.groupControlSettingLDPlayer.Controls.Add(this.LDeLayTime);
            this.groupControlSettingLDPlayer.Controls.Add(this.LFPS);
            this.groupControlSettingLDPlayer.Controls.Add(this.LAudio);
            this.groupControlSettingLDPlayer.Controls.Add(this.LPathLDPlayer);
            this.groupControlSettingLDPlayer.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControlSettingLDPlayer.Location = new System.Drawing.Point(4, 0);
            this.groupControlSettingLDPlayer.Name = "groupControlSettingLDPlayer";
            this.groupControlSettingLDPlayer.Size = new System.Drawing.Size(341, 132);
            this.groupControlSettingLDPlayer.TabIndex = 0;
            this.groupControlSettingLDPlayer.Text = "Setting LDPlayer";
            // 
            // LPathLDPlayer
            // 
            this.LPathLDPlayer.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPathLDPlayer.Appearance.Options.UseFont = true;
            this.LPathLDPlayer.Location = new System.Drawing.Point(8, 23);
            this.LPathLDPlayer.Name = "LPathLDPlayer";
            this.LPathLDPlayer.Size = new System.Drawing.Size(81, 15);
            this.LPathLDPlayer.TabIndex = 0;
            this.LPathLDPlayer.Text = "Path LDPLayer";
            // 
            // LAudio
            // 
            this.LAudio.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAudio.Appearance.Options.UseFont = true;
            this.LAudio.Location = new System.Drawing.Point(8, 102);
            this.LAudio.Name = "LAudio";
            this.LAudio.Size = new System.Drawing.Size(34, 15);
            this.LAudio.TabIndex = 1;
            this.LAudio.Text = "Audio";
            // 
            // LFPS
            // 
            this.LFPS.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFPS.Appearance.Options.UseFont = true;
            this.LFPS.Location = new System.Drawing.Point(8, 75);
            this.LFPS.Name = "LFPS";
            this.LFPS.Size = new System.Drawing.Size(21, 15);
            this.LFPS.TabIndex = 2;
            this.LFPS.Text = "FPS";
            // 
            // LDeLayTime
            // 
            this.LDeLayTime.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDeLayTime.Appearance.Options.UseFont = true;
            this.LDeLayTime.Location = new System.Drawing.Point(8, 48);
            this.LDeLayTime.Name = "LDeLayTime";
            this.LDeLayTime.Size = new System.Drawing.Size(60, 15);
            this.LDeLayTime.TabIndex = 3;
            this.LDeLayTime.Text = "Delay Time";
            // 
            // txtPathLDPlayer
            // 
            this.txtPathLDPlayer.Location = new System.Drawing.Point(95, 23);
            this.txtPathLDPlayer.Name = "txtPathLDPlayer";
            this.txtPathLDPlayer.Size = new System.Drawing.Size(200, 20);
            this.txtPathLDPlayer.TabIndex = 4;
            // 
            // RadioOn
            // 
            this.RadioOn.AutoSize = true;
            this.RadioOn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioOn.Location = new System.Drawing.Point(95, 102);
            this.RadioOn.Name = "RadioOn";
            this.RadioOn.Size = new System.Drawing.Size(41, 19);
            this.RadioOn.TabIndex = 7;
            this.RadioOn.Text = "On";
            this.RadioOn.UseVisualStyleBackColor = true;
            // 
            // RadioOff
            // 
            this.RadioOff.AutoSize = true;
            this.RadioOff.Checked = true;
            this.RadioOff.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioOff.Location = new System.Drawing.Point(152, 102);
            this.RadioOff.Name = "RadioOff";
            this.RadioOff.Size = new System.Drawing.Size(42, 19);
            this.RadioOff.TabIndex = 8;
            this.RadioOff.TabStop = true;
            this.RadioOff.Text = "Off";
            this.RadioOff.UseVisualStyleBackColor = true;
            // 
            // BSave
            // 
            this.BSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSave.Appearance.Options.UseFont = true;
            this.BSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BSave.Location = new System.Drawing.Point(182, 138);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(80, 30);
            this.BSave.TabIndex = 1;
            this.BSave.Text = "Save";
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BCancel
            // 
            this.BCancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancel.Appearance.Options.UseFont = true;
            this.BCancel.Location = new System.Drawing.Point(265, 138);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(80, 30);
            this.BCancel.TabIndex = 2;
            this.BCancel.Text = "Cancel";
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // BOpenPath
            // 
            this.BOpenPath.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.BOpenPath.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BOpenPath.Location = new System.Drawing.Point(305, 23);
            this.BOpenPath.Name = "BOpenPath";
            this.BOpenPath.Size = new System.Drawing.Size(33, 20);
            this.BOpenPath.TabIndex = 3;
            this.BOpenPath.Click += new System.EventHandler(this.BOpenPath_Click);
            // 
            // SPinFPS
            // 
            this.SPinFPS.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.SPinFPS.Location = new System.Drawing.Point(95, 75);
            this.SPinFPS.Name = "SPinFPS";
            this.SPinFPS.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPinFPS.Properties.Appearance.Options.UseFont = true;
            this.SPinFPS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SPinFPS.Size = new System.Drawing.Size(100, 22);
            this.SPinFPS.TabIndex = 9;
            // 
            // SpinDelayTime
            // 
            this.SpinDelayTime.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SpinDelayTime.Location = new System.Drawing.Point(95, 48);
            this.SpinDelayTime.Name = "SpinDelayTime";
            this.SpinDelayTime.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinDelayTime.Properties.Appearance.Options.UseFont = true;
            this.SpinDelayTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpinDelayTime.Size = new System.Drawing.Size(100, 22);
            this.SpinDelayTime.TabIndex = 10;
            // 
            // XtraFormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 172);
            this.Controls.Add(this.BOpenPath);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.groupControlSettingLDPlayer);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("XtraFormSetting.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "XtraFormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tool Seting";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSettingLDPlayer)).EndInit();
            this.groupControlSettingLDPlayer.ResumeLayout(false);
            this.groupControlSettingLDPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPathLDPlayer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPinFPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinDelayTime.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlSettingLDPlayer;
        private DevExpress.XtraEditors.LabelControl LPathLDPlayer;
        private DevExpress.XtraEditors.LabelControl LDeLayTime;
        private DevExpress.XtraEditors.LabelControl LFPS;
        private DevExpress.XtraEditors.LabelControl LAudio;
        private DevExpress.XtraEditors.TextEdit txtPathLDPlayer;
        private System.Windows.Forms.RadioButton RadioOff;
        private System.Windows.Forms.RadioButton RadioOn;
        private DevExpress.XtraEditors.SimpleButton BSave;
        private DevExpress.XtraEditors.SimpleButton BCancel;
        private DevExpress.XtraEditors.SimpleButton BOpenPath;
        private DevExpress.XtraEditors.SpinEdit SPinFPS;
        private DevExpress.XtraEditors.SpinEdit SpinDelayTime;
    }
}