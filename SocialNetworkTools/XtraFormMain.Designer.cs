using System.Drawing;

namespace SocialNetworkTools
{
    partial class XtraFormMain
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormMain));
            this.colIsRun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameDevices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlIListGroup = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControlGroup = new DevExpress.XtraGrid.GridControl();
            this.gridViewGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNameGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gridControlDevices = new DevExpress.XtraGrid.GridControl();
            this.gridViewDevices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlAccount = new DevExpress.XtraGrid.GridControl();
            this.gridViewAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCookies = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAddDevices = new DevExpress.XtraEditors.SimpleButton();
            this.BAddAccount = new DevExpress.XtraEditors.SimpleButton();
            this.BAddGroup = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlIListAccount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlIListDevices = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControllButtonGroup = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControllButtonDevices = new DevExpress.XtraLayout.LayoutControlItem();
            this.LInfoAccount = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlIButtonAccount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.BarTop = new DevExpress.XtraBars.Bar();
            this.ButtonItem_SettingLDPlayer = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItem_SortLDPlayer = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ButtonItem_EditNameGroup = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItem_DelGroup = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItem_DelDevice = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItem_EditNameDevice = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItem_MoveDevice = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItem_TurnOnDevice = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItem_TurnOffDive = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItem_OnAllDevice = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonItem_OffAllDevice = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlIListGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlIListAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlIListDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControllButtonGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControllButtonDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LInfoAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlIButtonAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            this.SuspendLayout();
            // 
            // colIsRun
            // 
            this.colIsRun.Caption = "IsRun";
            this.colIsRun.DisplayFormat.FormatString = "{0:#;;\"\"}";
            this.colIsRun.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colIsRun.FieldName = "IsRun";
            this.colIsRun.Name = "colIsRun";
            this.colIsRun.OptionsColumn.AllowEdit = false;
            this.colIsRun.OptionsColumn.AllowFocus = false;
            this.colIsRun.OptionsColumn.AllowMove = false;
            this.colIsRun.OptionsColumn.AllowSize = false;
            this.colIsRun.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIsRun.OptionsColumn.ShowCaption = false;
            this.colIsRun.OptionsFilter.AllowAutoFilter = false;
            this.colIsRun.OptionsFilter.AllowFilter = false;
            this.colIsRun.Visible = true;
            this.colIsRun.VisibleIndex = 0;
            this.colIsRun.Width = 24;
            // 
            // colNameDevices
            // 
            this.colNameDevices.Caption = "Name Devices";
            this.colNameDevices.FieldName = "Name";
            this.colNameDevices.Name = "colNameDevices";
            this.colNameDevices.OptionsColumn.AllowEdit = false;
            this.colNameDevices.OptionsColumn.AllowFocus = false;
            this.colNameDevices.OptionsColumn.AllowMove = false;
            this.colNameDevices.Visible = true;
            this.colNameDevices.VisibleIndex = 1;
            this.colNameDevices.Width = 101;
            // 
            // layoutControlIListGroup
            // 
            this.layoutControlIListGroup.Control = this.gridControlGroup;
            this.layoutControlIListGroup.CustomizationFormText = "layoutControlListGroup";
            this.layoutControlIListGroup.Location = new System.Drawing.Point(0, 34);
            this.layoutControlIListGroup.MaxSize = new System.Drawing.Size(130, 0);
            this.layoutControlIListGroup.MinSize = new System.Drawing.Size(118, 24);
            this.layoutControlIListGroup.Name = "layoutControlIListGroup";
            this.layoutControlIListGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 1, 2, 1);
            this.layoutControlIListGroup.Size = new System.Drawing.Size(130, 420);
            this.layoutControlIListGroup.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlIListGroup.Text = "layoutControlListGroup";
            this.layoutControlIListGroup.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlIListGroup.TextVisible = false;
            // 
            // gridControlGroup
            // 
            this.gridControlGroup.DataMember = null;
            this.gridControlGroup.Location = new System.Drawing.Point(2, 36);
            this.gridControlGroup.MainView = this.gridViewGroup;
            this.gridControlGroup.Name = "gridControlGroup";
            this.gridControlGroup.Size = new System.Drawing.Size(127, 417);
            this.gridControlGroup.TabIndex = 10;
            this.gridControlGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGroup});
            // 
            // gridViewGroup
            // 
            this.gridViewGroup.Appearance.FocusedRow.BackColor = System.Drawing.Color.Aqua;
            this.gridViewGroup.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewGroup.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewGroup.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridViewGroup.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewGroup.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewGroup.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewGroup.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewGroup.Appearance.SelectedRow.BackColor = System.Drawing.Color.Aqua;
            this.gridViewGroup.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewGroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNameGroup});
            this.gridViewGroup.GridControl = this.gridControlGroup;
            this.gridViewGroup.Name = "gridViewGroup";
            this.gridViewGroup.OptionsSelection.MultiSelect = true;
            this.gridViewGroup.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewGroup.OptionsView.ColumnAutoWidth = false;
            this.gridViewGroup.OptionsView.ShowGroupPanel = false;
            this.gridViewGroup.OptionsView.ShowIndicator = false;
            this.gridViewGroup.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.GridViewGroup_PopupMenuShowing);
            this.gridViewGroup.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewGroup_FocusedRowChanged);
            // 
            // colNameGroup
            // 
            this.colNameGroup.Caption = "Name Group";
            this.colNameGroup.FieldName = "Name";
            this.colNameGroup.Name = "colNameGroup";
            this.colNameGroup.OptionsColumn.AllowEdit = false;
            this.colNameGroup.OptionsColumn.AllowMove = false;
            this.colNameGroup.OptionsColumn.FixedWidth = true;
            this.colNameGroup.Visible = true;
            this.colNameGroup.VisibleIndex = 0;
            this.colNameGroup.Width = 125;
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.statusStrip1);
            this.layoutControl.Controls.Add(this.gridControlGroup);
            this.layoutControl.Controls.Add(this.gridControlDevices);
            this.layoutControl.Controls.Add(this.gridControlAccount);
            this.layoutControl.Controls.Add(this.BAddDevices);
            this.layoutControl.Controls.Add(this.BAddAccount);
            this.layoutControl.Controls.Add(this.BAddGroup);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControl.Location = new System.Drawing.Point(0, 30);
            this.layoutControl.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(304, 35, 1003, 732);
            this.layoutControl.Root = this.layoutControlGroupMain;
            this.layoutControl.Size = new System.Drawing.Size(1008, 478);
            this.layoutControl.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LStatus});
            this.statusStrip1.Location = new System.Drawing.Point(2, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 21);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LStatus
            // 
            this.LStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStatus.ForeColor = System.Drawing.Color.Green;
            this.LStatus.ImageTransparentColor = System.Drawing.Color.Yellow;
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(79, 16);
            this.LStatus.Text = "about:blank";
            // 
            // gridControlDevices
            // 
            this.gridControlDevices.DataMember = null;
            this.gridControlDevices.Location = new System.Drawing.Point(131, 36);
            this.gridControlDevices.MainView = this.gridViewDevices;
            this.gridControlDevices.Name = "gridControlDevices";
            this.gridControlDevices.Size = new System.Drawing.Size(128, 417);
            this.gridControlDevices.TabIndex = 9;
            this.gridControlDevices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDevices});
            // 
            // gridViewDevices
            // 
            this.gridViewDevices.Appearance.FocusedRow.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.gridViewDevices.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewDevices.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDevices.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridViewDevices.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewDevices.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewDevices.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewDevices.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewDevices.Appearance.SelectedRow.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.gridViewDevices.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewDevices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsRun,
            this.colNameDevices});
            gridFormatRule1.Column = this.colIsRun;
            gridFormatRule1.Name = "Format0";
            formatConditionIconSet1.CategoryName = "Shapes";
            formatConditionIconSetIcon1.PredefinedName = "TrafficLights23_1.png";
            formatConditionIconSetIcon1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "TrafficLights23_2.png";
            formatConditionIconSetIcon2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.PredefinedName = "TrafficLights23_3.png";
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Name = "TrafficLights3Unrimmed";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            this.gridViewDevices.FormatRules.Add(gridFormatRule1);
            this.gridViewDevices.GridControl = this.gridControlDevices;
            this.gridViewDevices.Name = "gridViewDevices";
            this.gridViewDevices.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridViewDevices.OptionsSelection.MultiSelect = true;
            this.gridViewDevices.OptionsView.ColumnAutoWidth = false;
            this.gridViewDevices.OptionsView.ShowGroupPanel = false;
            this.gridViewDevices.OptionsView.ShowIndicator = false;
            this.gridViewDevices.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.GridViewDevices_PopupMenuShowing);
            this.gridViewDevices.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewDevices_FocusedRowChanged);
            // 
            // gridControlAccount
            // 
            this.gridControlAccount.DataMember = null;
            this.gridControlAccount.Location = new System.Drawing.Point(261, 36);
            this.gridControlAccount.MainView = this.gridViewAccount;
            this.gridControlAccount.Name = "gridControlAccount";
            this.gridControlAccount.Size = new System.Drawing.Size(745, 417);
            this.gridControlAccount.TabIndex = 0;
            this.gridControlAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAccount});
            // 
            // gridViewAccount
            // 
            this.gridViewAccount.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAccount.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridViewAccount.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewAccount.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewAccount.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewAccount.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewAccount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colUsername,
            this.colPassword,
            this.colStatus,
            this.colCookies});
            this.gridViewAccount.GridControl = this.gridControlAccount;
            this.gridViewAccount.Name = "gridViewAccount";
            this.gridViewAccount.OptionsView.ColumnAutoWidth = false;
            this.gridViewAccount.OptionsView.ShowGroupPanel = false;
            this.gridViewAccount.OptionsView.ShowIndicator = false;
            // 
            // colNo
            // 
            this.colNo.AppearanceCell.Options.UseTextOptions = true;
            this.colNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNo.Caption = "No";
            this.colNo.FieldName = "No";
            this.colNo.Name = "colNo";
            this.colNo.OptionsColumn.AllowEdit = false;
            this.colNo.OptionsColumn.AllowFocus = false;
            this.colNo.OptionsColumn.AllowMove = false;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            this.colNo.Width = 40;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Username";
            this.colUsername.FieldName = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.OptionsColumn.AllowEdit = false;
            this.colUsername.OptionsColumn.AllowMove = false;
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 1;
            this.colUsername.Width = 200;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Password";
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.OptionsColumn.AllowEdit = false;
            this.colPassword.OptionsColumn.AllowMove = false;
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 2;
            this.colPassword.Width = 200;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.AllowFocus = false;
            this.colStatus.OptionsColumn.AllowMove = false;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 80;
            // 
            // colCookies
            // 
            this.colCookies.Caption = "Cookies";
            this.colCookies.FieldName = "Cookies";
            this.colCookies.Name = "colCookies";
            this.colCookies.OptionsColumn.AllowEdit = false;
            this.colCookies.OptionsColumn.AllowMove = false;
            this.colCookies.Visible = true;
            this.colCookies.VisibleIndex = 4;
            this.colCookies.Width = 220;
            // 
            // BAddDevices
            // 
            this.BAddDevices.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAddDevices.Appearance.Options.UseFont = true;
            this.BAddDevices.Location = new System.Drawing.Point(131, 2);
            this.BAddDevices.MinimumSize = new System.Drawing.Size(0, 30);
            this.BAddDevices.Name = "BAddDevices";
            this.BAddDevices.Size = new System.Drawing.Size(127, 30);
            this.BAddDevices.StyleController = this.layoutControl;
            this.BAddDevices.TabIndex = 0;
            this.BAddDevices.TabStop = false;
            this.BAddDevices.Text = "Add Devices";
            this.BAddDevices.Click += new System.EventHandler(this.BAddDevices_Click);
            // 
            // BAddAccount
            // 
            this.BAddAccount.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAddAccount.Appearance.Options.UseFont = true;
            this.BAddAccount.Location = new System.Drawing.Point(890, 2);
            this.BAddAccount.MinimumSize = new System.Drawing.Size(0, 30);
            this.BAddAccount.Name = "BAddAccount";
            this.BAddAccount.Size = new System.Drawing.Size(116, 30);
            this.BAddAccount.StyleController = this.layoutControl;
            this.BAddAccount.TabIndex = 0;
            this.BAddAccount.TabStop = false;
            this.BAddAccount.Text = "Add Account";
            this.BAddAccount.Click += new System.EventHandler(this.BAddAccount_Click);
            // 
            // BAddGroup
            // 
            this.BAddGroup.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAddGroup.Appearance.Options.UseFont = true;
            this.BAddGroup.Location = new System.Drawing.Point(2, 2);
            this.BAddGroup.Name = "BAddGroup";
            this.BAddGroup.Size = new System.Drawing.Size(127, 30);
            this.BAddGroup.StyleController = this.layoutControl;
            this.BAddGroup.TabIndex = 0;
            this.BAddGroup.TabStop = false;
            this.BAddGroup.Text = "Add Group";
            this.BAddGroup.Click += new System.EventHandler(this.BAddGroup_Click);
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlIListAccount,
            this.layoutControlIListDevices,
            this.layoutControlIListGroup,
            this.layoutControllButtonGroup,
            this.layoutControllButtonDevices,
            this.LInfoAccount,
            this.layoutControlIButtonAccount,
            this.layoutControlLabel});
            this.layoutControlGroupMain.Name = "Root";
            this.layoutControlGroupMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupMain.Size = new System.Drawing.Size(1008, 478);
            // 
            // layoutControlIListAccount
            // 
            this.layoutControlIListAccount.Control = this.gridControlAccount;
            this.layoutControlIListAccount.CustomizationFormText = "layoutControlListAccount";
            this.layoutControlIListAccount.Location = new System.Drawing.Point(260, 34);
            this.layoutControlIListAccount.Name = "layoutControlIListAccount";
            this.layoutControlIListAccount.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 2, 2, 1);
            this.layoutControlIListAccount.Size = new System.Drawing.Size(748, 420);
            this.layoutControlIListAccount.Text = "layoutControlListAccount";
            this.layoutControlIListAccount.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlIListAccount.TextVisible = false;
            // 
            // layoutControlIListDevices
            // 
            this.layoutControlIListDevices.Control = this.gridControlDevices;
            this.layoutControlIListDevices.CustomizationFormText = "layoutControlListDevices";
            this.layoutControlIListDevices.Location = new System.Drawing.Point(130, 34);
            this.layoutControlIListDevices.MaxSize = new System.Drawing.Size(130, 0);
            this.layoutControlIListDevices.MinSize = new System.Drawing.Size(126, 24);
            this.layoutControlIListDevices.Name = "layoutControlIListDevices";
            this.layoutControlIListDevices.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 2, 1);
            this.layoutControlIListDevices.Size = new System.Drawing.Size(130, 420);
            this.layoutControlIListDevices.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlIListDevices.Text = "layoutControlListDevices";
            this.layoutControlIListDevices.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlIListDevices.TextVisible = false;
            // 
            // layoutControllButtonGroup
            // 
            this.layoutControllButtonGroup.AppearanceItemCaption.Options.UseBorderColor = true;
            this.layoutControllButtonGroup.Control = this.BAddGroup;
            this.layoutControllButtonGroup.CustomizationFormText = "layoutControlButtonGroup";
            this.layoutControllButtonGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControllButtonGroup.MaxSize = new System.Drawing.Size(200, 40);
            this.layoutControllButtonGroup.MinSize = new System.Drawing.Size(70, 30);
            this.layoutControllButtonGroup.Name = "layoutControllButtonGroup";
            this.layoutControllButtonGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 1, 2, 2);
            this.layoutControllButtonGroup.Size = new System.Drawing.Size(130, 34);
            this.layoutControllButtonGroup.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControllButtonGroup.Text = "layoutControlButtonGroup";
            this.layoutControllButtonGroup.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControllButtonGroup.TextVisible = false;
            // 
            // layoutControllButtonDevices
            // 
            this.layoutControllButtonDevices.AppearanceItemCaption.Options.UseBorderColor = true;
            this.layoutControllButtonDevices.Control = this.BAddDevices;
            this.layoutControllButtonDevices.CustomizationFormText = "layoutControlButtonDevices";
            this.layoutControllButtonDevices.Location = new System.Drawing.Point(130, 0);
            this.layoutControllButtonDevices.Name = "layoutControllButtonDevices";
            this.layoutControllButtonDevices.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 2, 2, 2);
            this.layoutControllButtonDevices.Size = new System.Drawing.Size(130, 34);
            this.layoutControllButtonDevices.Text = "layoutControlButtonDevices";
            this.layoutControllButtonDevices.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControllButtonDevices.TextVisible = false;
            // 
            // LInfoAccount
            // 
            this.LInfoAccount.AllowHotTrack = false;
            this.LInfoAccount.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInfoAccount.AppearanceItemCaption.Options.UseBorderColor = true;
            this.LInfoAccount.AppearanceItemCaption.Options.UseFont = true;
            this.LInfoAccount.Location = new System.Drawing.Point(260, 0);
            this.LInfoAccount.Name = "LInfoAccount";
            this.LInfoAccount.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInfoAccount.OptionsPrint.AppearanceItem.Options.UseFont = true;
            this.LInfoAccount.OptionsPrint.AppearanceItem.Options.UseTextOptions = true;
            this.LInfoAccount.OptionsPrint.AppearanceItemText.BorderColor = System.Drawing.Color.Red;
            this.LInfoAccount.OptionsPrint.AppearanceItemText.Options.UseBorderColor = true;
            this.LInfoAccount.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 1, 2, 2);
            this.LInfoAccount.Size = new System.Drawing.Size(629, 34);
            this.LInfoAccount.Text = "Infomation Account";
            this.LInfoAccount.TextSize = new System.Drawing.Size(178, 24);
            // 
            // layoutControlIButtonAccount
            // 
            this.layoutControlIButtonAccount.AppearanceItemCaption.Options.UseBorderColor = true;
            this.layoutControlIButtonAccount.Control = this.BAddAccount;
            this.layoutControlIButtonAccount.Location = new System.Drawing.Point(889, 0);
            this.layoutControlIButtonAccount.Name = "layoutControlIButtonAccount";
            this.layoutControlIButtonAccount.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 2, 2, 2);
            this.layoutControlIButtonAccount.Size = new System.Drawing.Size(119, 34);
            this.layoutControlIButtonAccount.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlIButtonAccount.TextVisible = false;
            // 
            // layoutControlLabel
            // 
            this.layoutControlLabel.Control = this.statusStrip1;
            this.layoutControlLabel.Location = new System.Drawing.Point(0, 454);
            this.layoutControlLabel.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlLabel.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlLabel.Name = "layoutControlLabel";
            this.layoutControlLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 1, 2);
            this.layoutControlLabel.Size = new System.Drawing.Size(1008, 24);
            this.layoutControlLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlLabel.Text = "layoutControlStatus";
            this.layoutControlLabel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlLabel.TextVisible = false;
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarTop});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ButtonItem_EditNameGroup,
            this.ButtonItem_DelGroup,
            this.ButtonItem_SettingLDPlayer,
            this.ButtonItem_DelDevice,
            this.ButtonItem_EditNameDevice,
            this.ButtonItem_MoveDevice,
            this.ButtonItem_TurnOnDevice,
            this.ButtonItem_TurnOffDive,
            this.ButtonItem_OnAllDevice,
            this.ButtonItem_OffAllDevice,
            this.ButtonItem_SortLDPlayer});
            this.barManager.MaxItemId = 12;
            // 
            // BarTop
            // 
            this.BarTop.BarName = "Tools";
            this.BarTop.DockCol = 0;
            this.BarTop.DockRow = 0;
            this.BarTop.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.BarTop.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ButtonItem_SettingLDPlayer, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ButtonItem_SortLDPlayer, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.BarTop.OptionsBar.DrawBorder = false;
            this.BarTop.OptionsBar.UseWholeRow = true;
            this.BarTop.Text = "Tools";
            // 
            // ButtonItem_SettingLDPlayer
            // 
            this.ButtonItem_SettingLDPlayer.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.ButtonItem_SettingLDPlayer.Caption = "Setting LDPlayer";
            this.ButtonItem_SettingLDPlayer.Id = 2;
            this.ButtonItem_SettingLDPlayer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_SettingLDPlayer.ImageOptions.Image")));
            this.ButtonItem_SettingLDPlayer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ButtonItem_SettingLDPlayer.ImageOptions.LargeImage")));
            this.ButtonItem_SettingLDPlayer.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonItem_SettingLDPlayer.ItemAppearance.Disabled.Options.UseFont = true;
            this.ButtonItem_SettingLDPlayer.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonItem_SettingLDPlayer.ItemAppearance.Hovered.Options.UseFont = true;
            this.ButtonItem_SettingLDPlayer.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonItem_SettingLDPlayer.ItemAppearance.Normal.Options.UseFont = true;
            this.ButtonItem_SettingLDPlayer.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonItem_SettingLDPlayer.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.ButtonItem_SettingLDPlayer.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonItem_SettingLDPlayer.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.ButtonItem_SettingLDPlayer.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonItem_SettingLDPlayer.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.ButtonItem_SettingLDPlayer.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonItem_SettingLDPlayer.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.ButtonItem_SettingLDPlayer.Name = "ButtonItem_SettingLDPlayer";
            this.ButtonItem_SettingLDPlayer.Size = new System.Drawing.Size(130, 30);
            this.ButtonItem_SettingLDPlayer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonItem_SettingLDPlayer_ItemClick);
            // 
            // ButtonItem_SortLDPlayer
            // 
            this.ButtonItem_SortLDPlayer.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.ButtonItem_SortLDPlayer.Caption = "Sort LDPlayer";
            this.ButtonItem_SortLDPlayer.Id = 11;
            this.ButtonItem_SortLDPlayer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_SortLDPlayer.ImageOptions.Image")));
            this.ButtonItem_SortLDPlayer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ButtonItem_SortLDPlayer.ImageOptions.LargeImage")));
            this.ButtonItem_SortLDPlayer.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonItem_SortLDPlayer.ItemAppearance.Hovered.Options.UseFont = true;
            this.ButtonItem_SortLDPlayer.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonItem_SortLDPlayer.ItemAppearance.Normal.Options.UseFont = true;
            this.ButtonItem_SortLDPlayer.Name = "ButtonItem_SortLDPlayer";
            this.ButtonItem_SortLDPlayer.Size = new System.Drawing.Size(130, 30);
            this.ButtonItem_SortLDPlayer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonItem_SortLDPlayer_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1008, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 508);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1008, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 478);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1008, 30);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 478);
            // 
            // ButtonItem_EditNameGroup
            // 
            this.ButtonItem_EditNameGroup.Caption = "Edit Name";
            this.ButtonItem_EditNameGroup.Id = 0;
            this.ButtonItem_EditNameGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_EditNameGroup.ImageOptions.Image")));
            this.ButtonItem_EditNameGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ButtonItem_EditNameGroup.ImageOptions.LargeImage")));
            this.ButtonItem_EditNameGroup.Name = "ButtonItem_EditNameGroup";
            this.ButtonItem_EditNameGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonItem_EditNameGroup_ItemClick);
            // 
            // ButtonItem_DelGroup
            // 
            this.ButtonItem_DelGroup.Caption = "Del Group";
            this.ButtonItem_DelGroup.Id = 1;
            this.ButtonItem_DelGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_DelGroup.ImageOptions.Image")));
            this.ButtonItem_DelGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ButtonItem_DelGroup.ImageOptions.LargeImage")));
            this.ButtonItem_DelGroup.Name = "ButtonItem_DelGroup";
            this.ButtonItem_DelGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonItem_DelGroup_ItemClick);
            // 
            // ButtonItem_DelDevice
            // 
            this.ButtonItem_DelDevice.Caption = "Del Device";
            this.ButtonItem_DelDevice.Id = 3;
            this.ButtonItem_DelDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_DelDevice.ImageOptions.Image")));
            this.ButtonItem_DelDevice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ButtonItem_DelDevice.ImageOptions.LargeImage")));
            this.ButtonItem_DelDevice.Name = "ButtonItem_DelDevice";
            this.ButtonItem_DelDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonItem_DelDevice_ItemClick);
            // 
            // ButtonItem_EditNameDevice
            // 
            this.ButtonItem_EditNameDevice.Caption = "Edit Device";
            this.ButtonItem_EditNameDevice.Id = 4;
            this.ButtonItem_EditNameDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_EditNameDevice.ImageOptions.Image")));
            this.ButtonItem_EditNameDevice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ButtonItem_EditNameDevice.ImageOptions.LargeImage")));
            this.ButtonItem_EditNameDevice.Name = "ButtonItem_EditNameDevice";
            this.ButtonItem_EditNameDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonItem_EditNameDevice_ItemClick);
            // 
            // ButtonItem_MoveDevice
            // 
            this.ButtonItem_MoveDevice.Caption = "Move Device";
            this.ButtonItem_MoveDevice.Id = 6;
            this.ButtonItem_MoveDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_MoveDevice.ImageOptions.Image")));
            this.ButtonItem_MoveDevice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ButtonItem_MoveDevice.ImageOptions.LargeImage")));
            this.ButtonItem_MoveDevice.Name = "ButtonItem_MoveDevice";
            this.ButtonItem_MoveDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonItem_MoveDevice_ItemClick);
            // 
            // ButtonItem_TurnOnDevice
            // 
            this.ButtonItem_TurnOnDevice.Caption = "Turn On Device";
            this.ButtonItem_TurnOnDevice.Id = 7;
            this.ButtonItem_TurnOnDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_TurnOnDevice.ImageOptions.Image")));
            this.ButtonItem_TurnOnDevice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ButtonItem_TurnOnDevice.ImageOptions.LargeImage")));
            this.ButtonItem_TurnOnDevice.Name = "ButtonItem_TurnOnDevice";
            this.ButtonItem_TurnOnDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonItem_TurnOnDevice_ItemClick);
            // 
            // ButtonItem_TurnOffDive
            // 
            this.ButtonItem_TurnOffDive.Caption = "Turn Off Device";
            this.ButtonItem_TurnOffDive.Id = 8;
            this.ButtonItem_TurnOffDive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_TurnOffDive.ImageOptions.Image")));
            this.ButtonItem_TurnOffDive.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ButtonItem_TurnOffDive.ImageOptions.LargeImage")));
            this.ButtonItem_TurnOffDive.Name = "ButtonItem_TurnOffDive";
            this.ButtonItem_TurnOffDive.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonItem_TurnOffDive_ItemClick);
            // 
            // ButtonItem_OnAllDevice
            // 
            this.ButtonItem_OnAllDevice.Caption = "On All Device";
            this.ButtonItem_OnAllDevice.Id = 9;
            this.ButtonItem_OnAllDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_OnAllDevice.ImageOptions.Image")));
            this.ButtonItem_OnAllDevice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ButtonItem_OnAllDevice.ImageOptions.LargeImage")));
            this.ButtonItem_OnAllDevice.Name = "ButtonItem_OnAllDevice";
            this.ButtonItem_OnAllDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonItem_OnAllDevice_ItemClick);
            // 
            // ButtonItem_OffAllDevice
            // 
            this.ButtonItem_OffAllDevice.Caption = "Off All Device";
            this.ButtonItem_OffAllDevice.Id = 10;
            this.ButtonItem_OffAllDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonItem_OffAllDevice.ImageOptions.Image")));
            this.ButtonItem_OffAllDevice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ButtonItem_OffAllDevice.ImageOptions.LargeImage")));
            this.ButtonItem_OffAllDevice.Name = "ButtonItem_OffAllDevice";
            this.ButtonItem_OffAllDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonItem_OffAllDevice_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItem_OnAllDevice),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItem_OffAllDevice),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItem_EditNameGroup, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItem_DelGroup)});
            this.popupMenu1.Manager = this.barManager;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            // 
            // popupMenu2
            // 
            this.popupMenu2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItem_TurnOnDevice),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItem_TurnOffDive),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItem_MoveDevice, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItem_EditNameDevice),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonItem_DelDevice)});
            this.popupMenu2.Manager = this.barManager;
            this.popupMenu2.Name = "popupMenu2";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // XtraFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 508);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("XtraFormMain.IconOptions.LargeImage")));
            this.Name = "XtraFormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social Network Tools";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlIListGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlIListAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlIListDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControllButtonGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControllButtonDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LInfoAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlIButtonAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraEditors.SimpleButton BAddAccount;
        private DevExpress.XtraGrid.GridControl gridControlGroup;
        private DevExpress.XtraGrid.GridControl gridControlDevices;
        private DevExpress.XtraGrid.GridControl gridControlAccount;
        private DevExpress.XtraEditors.SimpleButton BAddGroup;
        private DevExpress.XtraEditors.SimpleButton BAddDevices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDevices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCookies;
        private DevExpress.XtraGrid.Columns.GridColumn colNameDevices;
        private DevExpress.XtraGrid.Columns.GridColumn colNameGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlIListAccount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlIListDevices;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlIListGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControllButtonGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControllButtonDevices;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlIButtonAccount;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar BarTop;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private DevExpress.XtraBars.BarButtonItem ButtonItem_DelDevice;
        private DevExpress.XtraBars.BarButtonItem ButtonItem_EditNameDevice;
        private DevExpress.XtraBars.BarButtonItem ButtonItem_MoveDevice;
        private DevExpress.XtraBars.BarButtonItem ButtonItem_TurnOnDevice;
        private DevExpress.XtraBars.BarButtonItem ButtonItem_TurnOffDive;
        private DevExpress.XtraBars.BarButtonItem ButtonItem_OnAllDevice;
        private DevExpress.XtraBars.BarButtonItem ButtonItem_OffAllDevice;
        private DevExpress.XtraBars.BarButtonItem ButtonItem_SortLDPlayer;
        private DevExpress.XtraBars.BarButtonItem ButtonItem_EditNameGroup;
        private DevExpress.XtraBars.BarButtonItem ButtonItem_DelGroup;
        private DevExpress.XtraBars.BarButtonItem ButtonItem_SettingLDPlayer;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraLayout.SimpleLabelItem LInfoAccount;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlLabel;
        private DevExpress.XtraGrid.Columns.GridColumn colIsRun;
    }
}