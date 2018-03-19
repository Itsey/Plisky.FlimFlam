namespace MexInternals {

    using Plisky.Plumbing;
    //using Plisky.Plumbing.Legacy;
    //using Plisky.Plumbing.Listeners;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Security;
    using System.Security.Permissions;
    using System.Windows.Forms;

    /// <summary>
    /// Summary description for MexOptionsScreen.
    /// </summary>
    internal partial class frmMexOptionsScreen : System.Windows.Forms.Form {
        private Button btnOK;
        private Button btnCancel;
        private TabControl tabOptionsContainer;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabAdvancedOptions;
        private GroupBox groupBox4;
        private TextBox txtNormalisationMS;
        private CheckBox chkNormaliseRefresh;
        private Button btnSetODSAcl;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown nudPushbackLimitCount;
        private GroupBox grpUserMessageNotificationOptions;
        private RadioButton rdoShowUserNotificationsInLog;
        private RadioButton rdoShowUserNotificationsInStatusBar;
        private RadioButton rdoShowUserNotificationsasMessages;
        private RadioButton rdoDontProcessUserNotifications;
        private GroupBox groupBox2;
        private CheckBox chkMatchingNamePurgeAlsoClearsPartials;
        private CheckBox chkBeautifyOutput;
        private CheckBox chkWotTimedViewToo;
        private CheckBox chkDisplayGlobalIndexInMainView;
        private CheckBox chkSelectingProcessSelectsProcessView;
        private CheckBox chkAutoScroll;
        private CheckBox chkAutoRefresh;
        private CheckBox chkAllowCancelOperations;
        private CheckBox chkLeaveMatchingPidsInNonTracedToo;
        private CheckBox chkImportMatchingPIDODSIntoEvents;
        private CheckBox chkAutoSelectProcessIfNoneSelected;
        private CheckBox chkRespectFilter;
        private CheckBox chkRecycleProcessWhenNameMatches;
        private GroupBox groupBox5;
        private Label label8;
        private Label label7;
        private TextBox txtPortBinding;
        private TextBox txtIPBinding;
        private GroupBox groupBox1;
        private CheckBox chkXRefCheckAssertions;
        private CheckBox chkXRefResourceMessages;
        private CheckBox chkXRefVerbLogs;
        private CheckBox chkXRefMiniLogs;
        private CheckBox chkXRefLogs;
        private CheckBox chkXRefExceptions;
        private CheckBox chkXRefErrors;
        private Label label3;
        private CheckBox chkXRefWarnings;
        private CheckBox chkXRefAppInitialises;
        private TabPage tabPage4;
        private Label label1;
        private TextBox txtFilterAndHighlightDir;
        private Button btnBrowseForFilterDir;
        private CheckBox chkRelocateOnChange;
        private CheckBox chkHighlightCrossProcesses;
        private CheckBox chkTimingsViewIgnoresThreads;
        private GroupBox grpThreadDisplayOptions;
        private RadioButton rdoThreadShowFullInfo;
        private RadioButton rdoThreadShowNetId;
        private RadioButton rdoThreadShowOSId;
        private RadioButton rdoThreadShowDefault;
        private CheckBox chkAllowInternalMessageDisplays;
        private Label label2;
        private TextBox txtUIRefreshFrequency;
        private Label label10;
        private TextBox txtLongRunningOps;
        private Label label9;
        private TextBox txtUserLogSize;
        private TabPage tabTexSettings;
        private CheckBox chkExpandAssertions;
        private Button btnReadEnvironment;
        private Button btnSetEnvironment;
        private CheckBox chkUseHighPerf;
        private GroupBox groupBox7;
        private CheckBox chkMakeTcpInteractive;
        private CheckBox chkRemoveAll;
        private TextBox txtIPInit;
        private TextBox txtPortInit;
        private CheckBox chkAddTexListener;
        private GroupBox grpTraceLevel;
        private RadioButton rdoWarningLevel;
        private RadioButton rdoVerboseLevel;
        private RadioButton rdoErrorLevel;
        private RadioButton rdoTraceInfo;
        private RadioButton rdoTraceOff;
        private TextBox txtGeneratedString;
        private Label lblHelp;
        private CheckBox chkEnableEnhancements;
        private GroupBox groupBox9;
        private Label label14;
        private Label label13;
        private ListBox lbxNameMappings;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnAddMapping;
        private Button btnDeleteMapping;
        private CheckBox chkEnableBacktrace;
        private CheckBox chkAddStackInfo;
        private Button btnAddNewListener;
        private Button btnRemoveSelected;
        private ListBox lbxAddTCPListeners;
        private Label lblErrorMsg;
        private Label label11;
        private Label label12;
        private Button btnReleaseDefaults;
        private Button btnDevelopmentDefaults;
        private Label lblRefreshWarning;
        private CheckBox chkUseRenderNameNotPID;
        private CheckBox chkRemoveDupes;
        private CheckBox chkRemoveDupesOnDisplay;
        private CheckBox chkFilterDefaultIncludesClasses;
        private CheckBox chkFilterDefaultIncludeModules;
        private CheckBox chkFilterDefaultIncludesThreads;
        private CheckBox chkFilterDefaultIncludesLocations;
        private LinkLabel llbRelatedContent;
        private GroupBox groupBox3;
        private CheckBox chkActivateImportLogging;
        private CheckBox chkIncludeFileContents;
        private CheckBox chkInlucdeTCPContents;
        private CheckBox chkImportLoggingInlcudedsODS;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        internal frmMexOptionsScreen() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            // Look up the list of filters so that we can enable the dropdown of filters.
            RefreshTexTabFromEnvironmentVariable();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMexOptionsScreen));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabOptionsContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblRefreshWarning = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLongRunningOps = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserLogSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUIRefreshFrequency = new System.Windows.Forms.TextBox();
            this.grpUserMessageNotificationOptions = new System.Windows.Forms.GroupBox();
            this.rdoShowUserNotificationsInLog = new System.Windows.Forms.RadioButton();
            this.rdoShowUserNotificationsInStatusBar = new System.Windows.Forms.RadioButton();
            this.rdoShowUserNotificationsasMessages = new System.Windows.Forms.RadioButton();
            this.rdoDontProcessUserNotifications = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpThreadDisplayOptions = new System.Windows.Forms.GroupBox();
            this.rdoThreadShowDefault = new System.Windows.Forms.RadioButton();
            this.rdoThreadShowFullInfo = new System.Windows.Forms.RadioButton();
            this.rdoThreadShowNetId = new System.Windows.Forms.RadioButton();
            this.rdoThreadShowOSId = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUseRenderNameNotPID = new System.Windows.Forms.CheckBox();
            this.chkEnableBacktrace = new System.Windows.Forms.CheckBox();
            this.chkHighlightCrossProcesses = new System.Windows.Forms.CheckBox();
            this.chkMatchingNamePurgeAlsoClearsPartials = new System.Windows.Forms.CheckBox();
            this.chkBeautifyOutput = new System.Windows.Forms.CheckBox();
            this.chkWotTimedViewToo = new System.Windows.Forms.CheckBox();
            this.chkDisplayGlobalIndexInMainView = new System.Windows.Forms.CheckBox();
            this.chkSelectingProcessSelectsProcessView = new System.Windows.Forms.CheckBox();
            this.chkAutoScroll = new System.Windows.Forms.CheckBox();
            this.chkAutoRefresh = new System.Windows.Forms.CheckBox();
            this.chkAllowCancelOperations = new System.Windows.Forms.CheckBox();
            this.chkLeaveMatchingPidsInNonTracedToo = new System.Windows.Forms.CheckBox();
            this.chkImportMatchingPIDODSIntoEvents = new System.Windows.Forms.CheckBox();
            this.chkAutoSelectProcessIfNoneSelected = new System.Windows.Forms.CheckBox();
            this.chkRespectFilter = new System.Windows.Forms.CheckBox();
            this.chkRecycleProcessWhenNameMatches = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkRemoveDupesOnDisplay = new System.Windows.Forms.CheckBox();
            this.chkRemoveDupes = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPortBinding = new System.Windows.Forms.TextBox();
            this.txtIPBinding = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkXRefCheckAssertions = new System.Windows.Forms.CheckBox();
            this.chkXRefResourceMessages = new System.Windows.Forms.CheckBox();
            this.chkXRefVerbLogs = new System.Windows.Forms.CheckBox();
            this.chkXRefMiniLogs = new System.Windows.Forms.CheckBox();
            this.chkXRefLogs = new System.Windows.Forms.CheckBox();
            this.chkXRefExceptions = new System.Windows.Forms.CheckBox();
            this.chkXRefErrors = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkXRefWarnings = new System.Windows.Forms.CheckBox();
            this.chkXRefAppInitialises = new System.Windows.Forms.CheckBox();
            this.tabAdvancedOptions = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnDeleteMapping = new System.Windows.Forms.Button();
            this.btnAddMapping = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbxNameMappings = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkTimingsViewIgnoresThreads = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNormalisationMS = new System.Windows.Forms.TextBox();
            this.chkNormaliseRefresh = new System.Windows.Forms.CheckBox();
            this.btnSetODSAcl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPushbackLimitCount = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chkFilterDefaultIncludesClasses = new System.Windows.Forms.CheckBox();
            this.chkFilterDefaultIncludeModules = new System.Windows.Forms.CheckBox();
            this.chkFilterDefaultIncludesThreads = new System.Windows.Forms.CheckBox();
            this.chkFilterDefaultIncludesLocations = new System.Windows.Forms.CheckBox();
            this.chkAllowInternalMessageDisplays = new System.Windows.Forms.CheckBox();
            this.chkRelocateOnChange = new System.Windows.Forms.CheckBox();
            this.btnBrowseForFilterDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterAndHighlightDir = new System.Windows.Forms.TextBox();
            this.tabTexSettings = new System.Windows.Forms.TabPage();
            this.btnReleaseDefaults = new System.Windows.Forms.Button();
            this.btnDevelopmentDefaults = new System.Windows.Forms.Button();
            this.chkAddStackInfo = new System.Windows.Forms.CheckBox();
            this.chkEnableEnhancements = new System.Windows.Forms.CheckBox();
            this.chkExpandAssertions = new System.Windows.Forms.CheckBox();
            this.btnReadEnvironment = new System.Windows.Forms.Button();
            this.btnSetEnvironment = new System.Windows.Forms.Button();
            this.chkUseHighPerf = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.btnAddNewListener = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.lbxAddTCPListeners = new System.Windows.Forms.ListBox();
            this.chkMakeTcpInteractive = new System.Windows.Forms.CheckBox();
            this.chkRemoveAll = new System.Windows.Forms.CheckBox();
            this.txtIPInit = new System.Windows.Forms.TextBox();
            this.txtPortInit = new System.Windows.Forms.TextBox();
            this.chkAddTexListener = new System.Windows.Forms.CheckBox();
            this.grpTraceLevel = new System.Windows.Forms.GroupBox();
            this.rdoWarningLevel = new System.Windows.Forms.RadioButton();
            this.rdoVerboseLevel = new System.Windows.Forms.RadioButton();
            this.rdoErrorLevel = new System.Windows.Forms.RadioButton();
            this.rdoTraceInfo = new System.Windows.Forms.RadioButton();
            this.rdoTraceOff = new System.Windows.Forms.RadioButton();
            this.txtGeneratedString = new System.Windows.Forms.TextBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.llbRelatedContent = new System.Windows.Forms.LinkLabel();
            this.chkActivateImportLogging = new System.Windows.Forms.CheckBox();
            this.chkImportLoggingInlcudedsODS = new System.Windows.Forms.CheckBox();
            this.chkInlucdeTCPContents = new System.Windows.Forms.CheckBox();
            this.chkIncludeFileContents = new System.Windows.Forms.CheckBox();
            this.tabOptionsContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpUserMessageNotificationOptions.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpThreadDisplayOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAdvancedOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPushbackLimitCount)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabTexSettings.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.grpTraceLevel.SuspendLayout();
            this.SuspendLayout();
            //
            // btnOK
            //
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(655, 446);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            //
            // btnCancel
            //
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(574, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // tabOptionsContainer
            //
            this.tabOptionsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOptionsContainer.Controls.Add(this.tabPage1);
            this.tabOptionsContainer.Controls.Add(this.tabPage2);
            this.tabOptionsContainer.Controls.Add(this.tabPage3);
            this.tabOptionsContainer.Controls.Add(this.tabAdvancedOptions);
            this.tabOptionsContainer.Controls.Add(this.tabPage4);
            this.tabOptionsContainer.Controls.Add(this.tabTexSettings);
            this.tabOptionsContainer.Location = new System.Drawing.Point(2, 3);
            this.tabOptionsContainer.Name = "tabOptionsContainer";
            this.tabOptionsContainer.SelectedIndex = 0;
            this.tabOptionsContainer.Size = new System.Drawing.Size(731, 375);
            this.tabOptionsContainer.TabIndex = 17;
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.lblRefreshWarning);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtLongRunningOps);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtUserLogSize);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtUIRefreshFrequency);
            this.tabPage1.Controls.Add(this.grpUserMessageNotificationOptions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Preferences";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // lblRefreshWarning
            //
            this.lblRefreshWarning.AutoSize = true;
            this.lblRefreshWarning.Location = new System.Drawing.Point(6, 97);
            this.lblRefreshWarning.Name = "lblRefreshWarning";
            this.lblRefreshWarning.Size = new System.Drawing.Size(48, 13);
            this.lblRefreshWarning.TabIndex = 20;
            this.lblRefreshWarning.Text = "label15";
            this.lblRefreshWarning.Visible = false;
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "No seconds for long running";
            //
            // txtLongRunningOps
            //
            this.txtLongRunningOps.Location = new System.Drawing.Point(444, 59);
            this.txtLongRunningOps.Name = "txtLongRunningOps";
            this.txtLongRunningOps.Size = new System.Drawing.Size(51, 21);
            this.txtLongRunningOps.TabIndex = 18;
            this.txtLongRunningOps.Text = "45";
            this.txtLongRunningOps.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "User Log Size";
            //
            // txtUserLogSize
            //
            this.txtUserLogSize.Location = new System.Drawing.Point(271, 59);
            this.txtUserLogSize.Name = "txtUserLogSize";
            this.txtUserLogSize.Size = new System.Drawing.Size(59, 21);
            this.txtUserLogSize.TabIndex = 16;
            this.txtUserLogSize.Text = "150";
            this.txtUserLogSize.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Frequency of UI Refresh";
            //
            // txtUIRefreshFrequency
            //
            this.txtUIRefreshFrequency.Location = new System.Drawing.Point(10, 59);
            this.txtUIRefreshFrequency.Name = "txtUIRefreshFrequency";
            this.txtUIRefreshFrequency.Size = new System.Drawing.Size(51, 21);
            this.txtUIRefreshFrequency.TabIndex = 13;
            this.txtUIRefreshFrequency.Text = "1";
            this.txtUIRefreshFrequency.TextChanged += new System.EventHandler(this.txtUIRefreshFrequency_TextChanged);
            this.txtUIRefreshFrequency.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // grpUserMessageNotificationOptions
            //
            this.grpUserMessageNotificationOptions.Controls.Add(this.rdoShowUserNotificationsInLog);
            this.grpUserMessageNotificationOptions.Controls.Add(this.rdoShowUserNotificationsInStatusBar);
            this.grpUserMessageNotificationOptions.Controls.Add(this.rdoShowUserNotificationsasMessages);
            this.grpUserMessageNotificationOptions.Controls.Add(this.rdoDontProcessUserNotifications);
            this.grpUserMessageNotificationOptions.Enabled = false;
            this.grpUserMessageNotificationOptions.Location = new System.Drawing.Point(9, 6);
            this.grpUserMessageNotificationOptions.Name = "grpUserMessageNotificationOptions";
            this.grpUserMessageNotificationOptions.Size = new System.Drawing.Size(702, 47);
            this.grpUserMessageNotificationOptions.TabIndex = 12;
            this.grpUserMessageNotificationOptions.TabStop = false;
            this.grpUserMessageNotificationOptions.Text = "Recieve User Messages";
            this.grpUserMessageNotificationOptions.Visible = false;
            this.grpUserMessageNotificationOptions.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // rdoShowUserNotificationsInLog
            //
            this.rdoShowUserNotificationsInLog.AutoSize = true;
            this.rdoShowUserNotificationsInLog.Location = new System.Drawing.Point(454, 19);
            this.rdoShowUserNotificationsInLog.Name = "rdoShowUserNotificationsInLog";
            this.rdoShowUserNotificationsInLog.Size = new System.Drawing.Size(108, 17);
            this.rdoShowUserNotificationsInLog.TabIndex = 5;
            this.rdoShowUserNotificationsInLog.Text = "In the log only";
            this.rdoShowUserNotificationsInLog.UseVisualStyleBackColor = true;
            //
            // rdoShowUserNotificationsInStatusBar
            //
            this.rdoShowUserNotificationsInStatusBar.AutoSize = true;
            this.rdoShowUserNotificationsInStatusBar.Location = new System.Drawing.Point(301, 20);
            this.rdoShowUserNotificationsInStatusBar.Name = "rdoShowUserNotificationsInStatusBar";
            this.rdoShowUserNotificationsInStatusBar.Size = new System.Drawing.Size(120, 17);
            this.rdoShowUserNotificationsInStatusBar.TabIndex = 2;
            this.rdoShowUserNotificationsInStatusBar.Text = "In the status bar";
            this.rdoShowUserNotificationsInStatusBar.UseVisualStyleBackColor = true;
            //
            // rdoShowUserNotificationsasMessages
            //
            this.rdoShowUserNotificationsasMessages.AutoSize = true;
            this.rdoShowUserNotificationsasMessages.Checked = true;
            this.rdoShowUserNotificationsasMessages.Location = new System.Drawing.Point(128, 20);
            this.rdoShowUserNotificationsasMessages.Name = "rdoShowUserNotificationsasMessages";
            this.rdoShowUserNotificationsasMessages.Size = new System.Drawing.Size(90, 17);
            this.rdoShowUserNotificationsasMessages.TabIndex = 1;
            this.rdoShowUserNotificationsasMessages.TabStop = true;
            this.rdoShowUserNotificationsasMessages.Text = "Interactivly";
            this.rdoShowUserNotificationsasMessages.UseVisualStyleBackColor = true;
            //
            // rdoDontProcessUserNotifications
            //
            this.rdoDontProcessUserNotifications.AutoSize = true;
            this.rdoDontProcessUserNotifications.Location = new System.Drawing.Point(7, 19);
            this.rdoDontProcessUserNotifications.Name = "rdoDontProcessUserNotifications";
            this.rdoDontProcessUserNotifications.Size = new System.Drawing.Size(54, 17);
            this.rdoDontProcessUserNotifications.TabIndex = 0;
            this.rdoDontProcessUserNotifications.Text = "None";
            this.rdoDontProcessUserNotifications.UseVisualStyleBackColor = true;
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.grpThreadDisplayOptions);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mex Behaviour";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // grpThreadDisplayOptions
            //
            this.grpThreadDisplayOptions.Controls.Add(this.rdoThreadShowDefault);
            this.grpThreadDisplayOptions.Controls.Add(this.rdoThreadShowFullInfo);
            this.grpThreadDisplayOptions.Controls.Add(this.rdoThreadShowNetId);
            this.grpThreadDisplayOptions.Controls.Add(this.rdoThreadShowOSId);
            this.grpThreadDisplayOptions.Location = new System.Drawing.Point(7, 269);
            this.grpThreadDisplayOptions.Name = "grpThreadDisplayOptions";
            this.grpThreadDisplayOptions.Size = new System.Drawing.Size(710, 74);
            this.grpThreadDisplayOptions.TabIndex = 21;
            this.grpThreadDisplayOptions.TabStop = false;
            this.grpThreadDisplayOptions.Text = "Thread Display";
            this.grpThreadDisplayOptions.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // rdoThreadShowDefault
            //
            this.rdoThreadShowDefault.AutoSize = true;
            this.rdoThreadShowDefault.Location = new System.Drawing.Point(15, 20);
            this.rdoThreadShowDefault.Name = "rdoThreadShowDefault";
            this.rdoThreadShowDefault.Size = new System.Drawing.Size(347, 17);
            this.rdoThreadShowDefault.TabIndex = 4;
            this.rdoThreadShowDefault.TabStop = true;
            this.rdoThreadShowDefault.Text = "Default display - net threadname and OS thread identity";
            this.rdoThreadShowDefault.UseVisualStyleBackColor = true;
            //
            // rdoThreadShowFullInfo
            //
            this.rdoThreadShowFullInfo.AutoSize = true;
            this.rdoThreadShowFullInfo.Location = new System.Drawing.Point(279, 51);
            this.rdoThreadShowFullInfo.Name = "rdoThreadShowFullInfo";
            this.rdoThreadShowFullInfo.Size = new System.Drawing.Size(144, 17);
            this.rdoThreadShowFullInfo.TabIndex = 3;
            this.rdoThreadShowFullInfo.TabStop = true;
            this.rdoThreadShowFullInfo.Text = "show full information";
            this.rdoThreadShowFullInfo.UseVisualStyleBackColor = true;
            //
            // rdoThreadShowNetId
            //
            this.rdoThreadShowNetId.AutoSize = true;
            this.rdoThreadShowNetId.Location = new System.Drawing.Point(134, 51);
            this.rdoThreadShowNetId.Name = "rdoThreadShowNetId";
            this.rdoThreadShowNetId.Size = new System.Drawing.Size(102, 17);
            this.rdoThreadShowNetId.TabIndex = 1;
            this.rdoThreadShowNetId.TabStop = true;
            this.rdoThreadShowNetId.Text = ".net thread id";
            this.rdoThreadShowNetId.UseVisualStyleBackColor = true;
            //
            // rdoThreadShowOSId
            //
            this.rdoThreadShowOSId.AutoSize = true;
            this.rdoThreadShowOSId.Location = new System.Drawing.Point(16, 51);
            this.rdoThreadShowOSId.Name = "rdoThreadShowOSId";
            this.rdoThreadShowOSId.Size = new System.Drawing.Size(102, 17);
            this.rdoThreadShowOSId.TabIndex = 0;
            this.rdoThreadShowOSId.TabStop = true;
            this.rdoThreadShowOSId.Text = "OS Thread Id";
            this.rdoThreadShowOSId.UseVisualStyleBackColor = true;
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.chkUseRenderNameNotPID);
            this.groupBox2.Controls.Add(this.chkEnableBacktrace);
            this.groupBox2.Controls.Add(this.chkHighlightCrossProcesses);
            this.groupBox2.Controls.Add(this.chkMatchingNamePurgeAlsoClearsPartials);
            this.groupBox2.Controls.Add(this.chkBeautifyOutput);
            this.groupBox2.Controls.Add(this.chkWotTimedViewToo);
            this.groupBox2.Controls.Add(this.chkDisplayGlobalIndexInMainView);
            this.groupBox2.Controls.Add(this.chkSelectingProcessSelectsProcessView);
            this.groupBox2.Controls.Add(this.chkAutoScroll);
            this.groupBox2.Controls.Add(this.chkAutoRefresh);
            this.groupBox2.Controls.Add(this.chkAllowCancelOperations);
            this.groupBox2.Controls.Add(this.chkLeaveMatchingPidsInNonTracedToo);
            this.groupBox2.Controls.Add(this.chkImportMatchingPIDODSIntoEvents);
            this.groupBox2.Controls.Add(this.chkAutoSelectProcessIfNoneSelected);
            this.groupBox2.Controls.Add(this.chkRespectFilter);
            this.groupBox2.Controls.Add(this.chkRecycleProcessWhenNameMatches);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 257);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Mex Behaviour ";
            //
            // chkUseRenderNameNotPID
            //
            this.chkUseRenderNameNotPID.AutoSize = true;
            this.chkUseRenderNameNotPID.Location = new System.Drawing.Point(412, 223);
            this.chkUseRenderNameNotPID.Name = "chkUseRenderNameNotPID";
            this.chkUseRenderNameNotPID.Size = new System.Drawing.Size(212, 17);
            this.chkUseRenderNameNotPID.TabIndex = 20;
            this.chkUseRenderNameNotPID.Text = "Prefer to use a processes name.";
            this.chkUseRenderNameNotPID.UseVisualStyleBackColor = true;
            this.chkUseRenderNameNotPID.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkEnableBacktrace
            //
            this.chkEnableBacktrace.AutoSize = true;
            this.chkEnableBacktrace.Location = new System.Drawing.Point(15, 143);
            this.chkEnableBacktrace.Name = "chkEnableBacktrace";
            this.chkEnableBacktrace.Size = new System.Drawing.Size(214, 17);
            this.chkEnableBacktrace.TabIndex = 19;
            this.chkEnableBacktrace.Text = "Backtrace Extended Details View";
            this.chkEnableBacktrace.UseVisualStyleBackColor = true;
            this.chkEnableBacktrace.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkHighlightCrossProcesses
            //
            this.chkHighlightCrossProcesses.AutoSize = true;
            this.chkHighlightCrossProcesses.Location = new System.Drawing.Point(16, 74);
            this.chkHighlightCrossProcesses.Name = "chkHighlightCrossProcesses";
            this.chkHighlightCrossProcesses.Size = new System.Drawing.Size(191, 17);
            this.chkHighlightCrossProcesses.TabIndex = 18;
            this.chkHighlightCrossProcesses.Text = "Cross Process View Highlight";
            this.chkHighlightCrossProcesses.UseVisualStyleBackColor = true;
            this.chkHighlightCrossProcesses.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkMatchingNamePurgeAlsoClearsPartials
            //
            this.chkMatchingNamePurgeAlsoClearsPartials.AutoSize = true;
            this.chkMatchingNamePurgeAlsoClearsPartials.Location = new System.Drawing.Point(16, 53);
            this.chkMatchingNamePurgeAlsoClearsPartials.Name = "chkMatchingNamePurgeAlsoClearsPartials";
            this.chkMatchingNamePurgeAlsoClearsPartials.Size = new System.Drawing.Size(259, 17);
            this.chkMatchingNamePurgeAlsoClearsPartials.TabIndex = 15;
            this.chkMatchingNamePurgeAlsoClearsPartials.Text = "Partial Purge Elimiates Partial Copies too";
            this.chkMatchingNamePurgeAlsoClearsPartials.UseVisualStyleBackColor = true;
            this.chkMatchingNamePurgeAlsoClearsPartials.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkBeautifyOutput
            //
            this.chkBeautifyOutput.AutoSize = true;
            this.chkBeautifyOutput.Location = new System.Drawing.Point(412, 96);
            this.chkBeautifyOutput.Name = "chkBeautifyOutput";
            this.chkBeautifyOutput.Size = new System.Drawing.Size(176, 17);
            this.chkBeautifyOutput.TabIndex = 14;
            this.chkBeautifyOutput.Text = "Beautify Output Of Strings";
            this.chkBeautifyOutput.UseVisualStyleBackColor = true;
            this.chkBeautifyOutput.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkWotTimedViewToo
            //
            this.chkWotTimedViewToo.AutoSize = true;
            this.chkWotTimedViewToo.Location = new System.Drawing.Point(175, 97);
            this.chkWotTimedViewToo.Name = "chkWotTimedViewToo";
            this.chkWotTimedViewToo.Size = new System.Drawing.Size(134, 17);
            this.chkWotTimedViewToo.TabIndex = 12;
            this.chkWotTimedViewToo.Text = "Even in timed view";
            this.chkWotTimedViewToo.UseVisualStyleBackColor = true;
            this.chkWotTimedViewToo.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkDisplayGlobalIndexInMainView
            //
            this.chkDisplayGlobalIndexInMainView.AutoSize = true;
            this.chkDisplayGlobalIndexInMainView.Location = new System.Drawing.Point(412, 200);
            this.chkDisplayGlobalIndexInMainView.Name = "chkDisplayGlobalIndexInMainView";
            this.chkDisplayGlobalIndexInMainView.Size = new System.Drawing.Size(229, 17);
            this.chkDisplayGlobalIndexInMainView.TabIndex = 11;
            this.chkDisplayGlobalIndexInMainView.Text = "Show Global Index In Process View";
            this.chkDisplayGlobalIndexInMainView.UseVisualStyleBackColor = true;
            this.chkDisplayGlobalIndexInMainView.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkSelectingProcessSelectsProcessView
            //
            this.chkSelectingProcessSelectsProcessView.AutoSize = true;
            this.chkSelectingProcessSelectsProcessView.Location = new System.Drawing.Point(15, 187);
            this.chkSelectingProcessSelectsProcessView.Name = "chkSelectingProcessSelectsProcessView";
            this.chkSelectingProcessSelectsProcessView.Size = new System.Drawing.Size(370, 17);
            this.chkSelectingProcessSelectsProcessView.TabIndex = 9;
            this.chkSelectingProcessSelectsProcessView.Text = "When selecting a new process change view to process view.";
            this.chkSelectingProcessSelectsProcessView.UseVisualStyleBackColor = true;
            this.chkSelectingProcessSelectsProcessView.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkAutoScroll
            //
            this.chkAutoScroll.AutoSize = true;
            this.chkAutoScroll.Location = new System.Drawing.Point(412, 146);
            this.chkAutoScroll.Name = "chkAutoScroll";
            this.chkAutoScroll.Size = new System.Drawing.Size(139, 17);
            this.chkAutoScroll.TabIndex = 8;
            this.chkAutoScroll.Text = "Automatically Scroll";
            this.chkAutoScroll.UseVisualStyleBackColor = true;
            this.chkAutoScroll.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkAutoRefresh
            //
            this.chkAutoRefresh.AutoSize = true;
            this.chkAutoRefresh.Location = new System.Drawing.Point(412, 123);
            this.chkAutoRefresh.Name = "chkAutoRefresh";
            this.chkAutoRefresh.Size = new System.Drawing.Size(148, 17);
            this.chkAutoRefresh.TabIndex = 7;
            this.chkAutoRefresh.Text = "Automatically refresh";
            this.chkAutoRefresh.UseVisualStyleBackColor = true;
            this.chkAutoRefresh.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkAllowCancelOperations
            //
            this.chkAllowCancelOperations.AutoSize = true;
            this.chkAllowCancelOperations.Enabled = false;
            this.chkAllowCancelOperations.Location = new System.Drawing.Point(15, 120);
            this.chkAllowCancelOperations.Name = "chkAllowCancelOperations";
            this.chkAllowCancelOperations.Size = new System.Drawing.Size(193, 17);
            this.chkAllowCancelOperations.TabIndex = 5;
            this.chkAllowCancelOperations.Text = "Support Refresh Cancellation";
            this.chkAllowCancelOperations.UseVisualStyleBackColor = true;
            this.chkAllowCancelOperations.Visible = false;
            this.chkAllowCancelOperations.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkLeaveMatchingPidsInNonTracedToo
            //
            this.chkLeaveMatchingPidsInNonTracedToo.AutoSize = true;
            this.chkLeaveMatchingPidsInNonTracedToo.Location = new System.Drawing.Point(440, 51);
            this.chkLeaveMatchingPidsInNonTracedToo.Name = "chkLeaveMatchingPidsInNonTracedToo";
            this.chkLeaveMatchingPidsInNonTracedToo.Size = new System.Drawing.Size(214, 17);
            this.chkLeaveMatchingPidsInNonTracedToo.TabIndex = 4;
            this.chkLeaveMatchingPidsInNonTracedToo.Text = "When this occurs, copy the entry";
            this.chkLeaveMatchingPidsInNonTracedToo.UseVisualStyleBackColor = true;
            this.chkLeaveMatchingPidsInNonTracedToo.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkImportMatchingPIDODSIntoEvents
            //
            this.chkImportMatchingPIDODSIntoEvents.AutoSize = true;
            this.chkImportMatchingPIDODSIntoEvents.Location = new System.Drawing.Point(412, 28);
            this.chkImportMatchingPIDODSIntoEvents.Name = "chkImportMatchingPIDODSIntoEvents";
            this.chkImportMatchingPIDODSIntoEvents.Size = new System.Drawing.Size(281, 17);
            this.chkImportMatchingPIDODSIntoEvents.TabIndex = 3;
            this.chkImportMatchingPIDODSIntoEvents.Text = "Messages from same PID join Tex Messages";
            this.chkImportMatchingPIDODSIntoEvents.UseVisualStyleBackColor = true;
            this.chkImportMatchingPIDODSIntoEvents.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkAutoSelectProcessIfNoneSelected
            //
            this.chkAutoSelectProcessIfNoneSelected.AutoSize = true;
            this.chkAutoSelectProcessIfNoneSelected.Location = new System.Drawing.Point(15, 210);
            this.chkAutoSelectProcessIfNoneSelected.Name = "chkAutoSelectProcessIfNoneSelected";
            this.chkAutoSelectProcessIfNoneSelected.Size = new System.Drawing.Size(268, 17);
            this.chkAutoSelectProcessIfNoneSelected.TabIndex = 2;
            this.chkAutoSelectProcessIfNoneSelected.Text = "Auto Select Process View For First Process";
            this.chkAutoSelectProcessIfNoneSelected.UseVisualStyleBackColor = true;
            this.chkAutoSelectProcessIfNoneSelected.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkRespectFilter
            //
            this.chkRespectFilter.AutoSize = true;
            this.chkRespectFilter.Location = new System.Drawing.Point(16, 97);
            this.chkRespectFilter.Name = "chkRespectFilter";
            this.chkRespectFilter.Size = new System.Drawing.Size(153, 17);
            this.chkRespectFilter.TabIndex = 1;
            this.chkRespectFilter.Text = "Respect Filter Settings";
            this.chkRespectFilter.UseVisualStyleBackColor = true;
            this.chkRespectFilter.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkRecycleProcessWhenNameMatches
            //
            this.chkRecycleProcessWhenNameMatches.AutoSize = true;
            this.chkRecycleProcessWhenNameMatches.Location = new System.Drawing.Point(16, 30);
            this.chkRecycleProcessWhenNameMatches.Name = "chkRecycleProcessWhenNameMatches";
            this.chkRecycleProcessWhenNameMatches.Size = new System.Drawing.Size(283, 17);
            this.chkRecycleProcessWhenNameMatches.TabIndex = 0;
            this.chkRecycleProcessWhenNameMatches.Text = "On initialise partially purge matching process";
            this.chkRecycleProcessWhenNameMatches.UseVisualStyleBackColor = true;
            this.chkRecycleProcessWhenNameMatches.MouseEnter += new System.EventHandler(this.chkRecycleProcessWhenNameMatches_MouseEnter);
            this.chkRecycleProcessWhenNameMatches.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // tabPage3
            //
            this.tabPage3.Controls.Add(this.chkRemoveDupesOnDisplay);
            this.tabPage3.Controls.Add(this.chkRemoveDupes);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(723, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Importer Behaviour";
            this.tabPage3.UseVisualStyleBackColor = true;
            //
            // chkRemoveDupesOnDisplay
            //
            this.chkRemoveDupesOnDisplay.AutoSize = true;
            this.chkRemoveDupesOnDisplay.Location = new System.Drawing.Point(6, 252);
            this.chkRemoveDupesOnDisplay.Name = "chkRemoveDupesOnDisplay";
            this.chkRemoveDupesOnDisplay.Size = new System.Drawing.Size(212, 17);
            this.chkRemoveDupesOnDisplay.TabIndex = 19;
            this.chkRemoveDupesOnDisplay.Text = "Re-apply the filtering on display.";
            this.chkRemoveDupesOnDisplay.UseVisualStyleBackColor = true;
            this.chkRemoveDupesOnDisplay.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkRemoveDupes
            //
            this.chkRemoveDupes.AutoSize = true;
            this.chkRemoveDupes.Location = new System.Drawing.Point(6, 229);
            this.chkRemoveDupes.Name = "chkRemoveDupes";
            this.chkRemoveDupes.Size = new System.Drawing.Size(297, 17);
            this.chkRemoveDupes.TabIndex = 18;
            this.chkRemoveDupes.Text = "Detect and remove duplicate entries on import.";
            this.chkRemoveDupes.UseVisualStyleBackColor = true;
            this.chkRemoveDupes.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // groupBox5
            //
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtPortBinding);
            this.groupBox5.Controls.Add(this.txtIPBinding);
            this.groupBox5.Location = new System.Drawing.Point(6, 147);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(542, 57);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Listener Config.";
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = ":";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "IP Address:";
            //
            // txtPortBinding
            //
            this.txtPortBinding.Location = new System.Drawing.Point(241, 24);
            this.txtPortBinding.Name = "txtPortBinding";
            this.txtPortBinding.Size = new System.Drawing.Size(39, 21);
            this.txtPortBinding.TabIndex = 1;
            this.txtPortBinding.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // txtIPBinding
            //
            this.txtIPBinding.Location = new System.Drawing.Point(104, 24);
            this.txtIPBinding.Name = "txtIPBinding";
            this.txtIPBinding.Size = new System.Drawing.Size(100, 21);
            this.txtIPBinding.TabIndex = 0;
            this.txtIPBinding.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.chkXRefCheckAssertions);
            this.groupBox1.Controls.Add(this.chkXRefResourceMessages);
            this.groupBox1.Controls.Add(this.chkXRefVerbLogs);
            this.groupBox1.Controls.Add(this.chkXRefMiniLogs);
            this.groupBox1.Controls.Add(this.chkXRefLogs);
            this.groupBox1.Controls.Add(this.chkXRefExceptions);
            this.groupBox1.Controls.Add(this.chkXRefErrors);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkXRefWarnings);
            this.groupBox1.Controls.Add(this.chkXRefAppInitialises);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 135);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Cross Reference Options";
            //
            // chkXRefCheckAssertions
            //
            this.chkXRefCheckAssertions.AutoSize = true;
            this.chkXRefCheckAssertions.Location = new System.Drawing.Point(337, 61);
            this.chkXRefCheckAssertions.Name = "chkXRefCheckAssertions";
            this.chkXRefCheckAssertions.Size = new System.Drawing.Size(105, 17);
            this.chkXRefCheckAssertions.TabIndex = 11;
            this.chkXRefCheckAssertions.Text = "XR Assertions";
            this.chkXRefCheckAssertions.UseVisualStyleBackColor = true;
            this.chkXRefCheckAssertions.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkXRefResourceMessages
            //
            this.chkXRefResourceMessages.AutoSize = true;
            this.chkXRefResourceMessages.Location = new System.Drawing.Point(337, 41);
            this.chkXRefResourceMessages.Name = "chkXRefResourceMessages";
            this.chkXRefResourceMessages.Size = new System.Drawing.Size(158, 17);
            this.chkXRefResourceMessages.TabIndex = 10;
            this.chkXRefResourceMessages.Text = "XR Resource Messages";
            this.chkXRefResourceMessages.UseVisualStyleBackColor = true;
            this.chkXRefResourceMessages.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkXRefVerbLogs
            //
            this.chkXRefVerbLogs.AutoSize = true;
            this.chkXRefVerbLogs.Location = new System.Drawing.Point(337, 20);
            this.chkXRefVerbLogs.Name = "chkXRefVerbLogs";
            this.chkXRefVerbLogs.Size = new System.Drawing.Size(103, 17);
            this.chkXRefVerbLogs.TabIndex = 9;
            this.chkXRefVerbLogs.Text = "XR Verb Logs";
            this.chkXRefVerbLogs.UseVisualStyleBackColor = true;
            this.chkXRefVerbLogs.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkXRefMiniLogs
            //
            this.chkXRefMiniLogs.AutoSize = true;
            this.chkXRefMiniLogs.Location = new System.Drawing.Point(182, 60);
            this.chkXRefMiniLogs.Name = "chkXRefMiniLogs";
            this.chkXRefMiniLogs.Size = new System.Drawing.Size(98, 17);
            this.chkXRefMiniLogs.TabIndex = 8;
            this.chkXRefMiniLogs.Text = "XR Mini Logs";
            this.chkXRefMiniLogs.UseVisualStyleBackColor = true;
            this.chkXRefMiniLogs.Visible = false;
            this.chkXRefMiniLogs.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkXRefLogs
            //
            this.chkXRefLogs.AutoSize = true;
            this.chkXRefLogs.Location = new System.Drawing.Point(182, 40);
            this.chkXRefLogs.Name = "chkXRefLogs";
            this.chkXRefLogs.Size = new System.Drawing.Size(72, 17);
            this.chkXRefLogs.TabIndex = 7;
            this.chkXRefLogs.Text = "XR Logs";
            this.chkXRefLogs.UseVisualStyleBackColor = true;
            this.chkXRefLogs.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkXRefExceptions
            //
            this.chkXRefExceptions.AutoSize = true;
            this.chkXRefExceptions.Location = new System.Drawing.Point(182, 19);
            this.chkXRefExceptions.Name = "chkXRefExceptions";
            this.chkXRefExceptions.Size = new System.Drawing.Size(107, 17);
            this.chkXRefExceptions.TabIndex = 6;
            this.chkXRefExceptions.Text = "XR Exceptions";
            this.chkXRefExceptions.UseVisualStyleBackColor = true;
            this.chkXRefExceptions.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkXRefErrors
            //
            this.chkXRefErrors.AutoSize = true;
            this.chkXRefErrors.Location = new System.Drawing.Point(9, 60);
            this.chkXRefErrors.Name = "chkXRefErrors";
            this.chkXRefErrors.Size = new System.Drawing.Size(81, 17);
            this.chkXRefErrors.TabIndex = 5;
            this.chkXRefErrors.Text = "XR Errors";
            this.chkXRefErrors.UseVisualStyleBackColor = true;
            this.chkXRefErrors.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // label3
            //
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enabling these options will cause certain events to be cross referenced into the " +
                "main view.  Turning all of these on simultaniously will turn the main view into " +
                "a viewer showing all data.";
            //
            // chkXRefWarnings
            //
            this.chkXRefWarnings.AutoSize = true;
            this.chkXRefWarnings.Location = new System.Drawing.Point(9, 40);
            this.chkXRefWarnings.Name = "chkXRefWarnings";
            this.chkXRefWarnings.Size = new System.Drawing.Size(99, 17);
            this.chkXRefWarnings.TabIndex = 1;
            this.chkXRefWarnings.Text = "XR Warnings";
            this.chkXRefWarnings.UseVisualStyleBackColor = true;
            this.chkXRefWarnings.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkXRefAppInitialises
            //
            this.chkXRefAppInitialises.AutoSize = true;
            this.chkXRefAppInitialises.Location = new System.Drawing.Point(9, 19);
            this.chkXRefAppInitialises.Name = "chkXRefAppInitialises";
            this.chkXRefAppInitialises.Size = new System.Drawing.Size(120, 17);
            this.chkXRefAppInitialises.TabIndex = 0;
            this.chkXRefAppInitialises.Text = "XR App Initialise";
            this.chkXRefAppInitialises.UseVisualStyleBackColor = true;
            this.chkXRefAppInitialises.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // tabAdvancedOptions
            //
            this.tabAdvancedOptions.Controls.Add(this.groupBox3);
            this.tabAdvancedOptions.Controls.Add(this.groupBox9);
            this.tabAdvancedOptions.Controls.Add(this.chkTimingsViewIgnoresThreads);
            this.tabAdvancedOptions.Controls.Add(this.groupBox4);
            this.tabAdvancedOptions.Location = new System.Drawing.Point(4, 22);
            this.tabAdvancedOptions.Name = "tabAdvancedOptions";
            this.tabAdvancedOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvancedOptions.Size = new System.Drawing.Size(723, 349);
            this.tabAdvancedOptions.TabIndex = 3;
            this.tabAdvancedOptions.Text = "Advanced Options";
            this.tabAdvancedOptions.UseVisualStyleBackColor = true;
            //
            // groupBox3
            //
            this.groupBox3.Controls.Add(this.chkIncludeFileContents);
            this.groupBox3.Controls.Add(this.chkInlucdeTCPContents);
            this.groupBox3.Controls.Add(this.chkImportLoggingInlcudedsODS);
            this.groupBox3.Controls.Add(this.chkActivateImportLogging);
            this.groupBox3.Location = new System.Drawing.Point(18, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 121);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Logging. ";
            //
            // groupBox9
            //
            this.groupBox9.Controls.Add(this.btnDeleteMapping);
            this.groupBox9.Controls.Add(this.btnAddMapping);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.lbxNameMappings);
            this.groupBox9.Controls.Add(this.textBox2);
            this.groupBox9.Controls.Add(this.textBox1);
            this.groupBox9.Location = new System.Drawing.Point(474, 131);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(243, 160);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Workstation Name Mappings";
            this.groupBox9.Visible = false;
            //
            // btnDeleteMapping
            //
            this.btnDeleteMapping.Location = new System.Drawing.Point(11, 110);
            this.btnDeleteMapping.Name = "btnDeleteMapping";
            this.btnDeleteMapping.Size = new System.Drawing.Size(123, 23);
            this.btnDeleteMapping.TabIndex = 6;
            this.btnDeleteMapping.Text = "Delete Mapping";
            this.btnDeleteMapping.UseVisualStyleBackColor = true;
            //
            // btnAddMapping
            //
            this.btnAddMapping.Location = new System.Drawing.Point(6, 131);
            this.btnAddMapping.Name = "btnAddMapping";
            this.btnAddMapping.Size = new System.Drawing.Size(103, 23);
            this.btnAddMapping.TabIndex = 5;
            this.btnAddMapping.Text = "Add Mapping";
            this.btnAddMapping.UseVisualStyleBackColor = true;
            //
            // label14
            //
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Shall from henceforth be known as:";
            //
            // label13
            //
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "The box formerly know as:";
            //
            // lbxNameMappings
            //
            this.lbxNameMappings.FormattingEnabled = true;
            this.lbxNameMappings.Location = new System.Drawing.Point(11, 20);
            this.lbxNameMappings.Name = "lbxNameMappings";
            this.lbxNameMappings.Size = new System.Drawing.Size(113, 30);
            this.lbxNameMappings.TabIndex = 2;
            //
            // textBox2
            //
            this.textBox2.Location = new System.Drawing.Point(11, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 21);
            this.textBox2.TabIndex = 1;
            //
            // textBox1
            //
            this.textBox1.Location = new System.Drawing.Point(11, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 21);
            this.textBox1.TabIndex = 0;
            //
            // chkTimingsViewIgnoresThreads
            //
            this.chkTimingsViewIgnoresThreads.AutoSize = true;
            this.chkTimingsViewIgnoresThreads.Location = new System.Drawing.Point(18, 19);
            this.chkTimingsViewIgnoresThreads.Name = "chkTimingsViewIgnoresThreads";
            this.chkTimingsViewIgnoresThreads.Size = new System.Drawing.Size(197, 17);
            this.chkTimingsViewIgnoresThreads.TabIndex = 13;
            this.chkTimingsViewIgnoresThreads.Text = "Timings view ignores threads.";
            this.chkTimingsViewIgnoresThreads.UseVisualStyleBackColor = true;
            this.chkTimingsViewIgnoresThreads.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // groupBox4
            //
            this.groupBox4.Controls.Add(this.txtNormalisationMS);
            this.groupBox4.Controls.Add(this.chkNormaliseRefresh);
            this.groupBox4.Controls.Add(this.btnSetODSAcl);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.nudPushbackLimitCount);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(491, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 94);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Advanced Options";
            this.groupBox4.Visible = false;
            //
            // txtNormalisationMS
            //
            this.txtNormalisationMS.Location = new System.Drawing.Point(9, 67);
            this.txtNormalisationMS.Name = "txtNormalisationMS";
            this.txtNormalisationMS.Size = new System.Drawing.Size(67, 21);
            this.txtNormalisationMS.TabIndex = 7;
            //
            // chkNormaliseRefresh
            //
            this.chkNormaliseRefresh.AutoSize = true;
            this.chkNormaliseRefresh.Location = new System.Drawing.Point(9, 45);
            this.chkNormaliseRefresh.Name = "chkNormaliseRefresh";
            this.chkNormaliseRefresh.Size = new System.Drawing.Size(131, 17);
            this.chkNormaliseRefresh.TabIndex = 6;
            this.chkNormaliseRefresh.Text = "Normalise Refresh";
            this.chkNormaliseRefresh.UseVisualStyleBackColor = true;
            //
            // btnSetODSAcl
            //
            this.btnSetODSAcl.Location = new System.Drawing.Point(9, 19);
            this.btnSetODSAcl.Name = "btnSetODSAcl";
            this.btnSetODSAcl.Size = new System.Drawing.Size(67, 20);
            this.btnSetODSAcl.TabIndex = 5;
            this.btnSetODSAcl.Text = "Set ODS ACL";
            this.btnSetODSAcl.UseVisualStyleBackColor = true;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Seconds";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Delays or";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pushback Limiting:";
            //
            // nudPushbackLimitCount
            //
            this.nudPushbackLimitCount.Location = new System.Drawing.Point(146, 41);
            this.nudPushbackLimitCount.Name = "nudPushbackLimitCount";
            this.nudPushbackLimitCount.Size = new System.Drawing.Size(38, 21);
            this.nudPushbackLimitCount.TabIndex = 0;
            this.nudPushbackLimitCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            //
            // tabPage4
            //
            this.tabPage4.Controls.Add(this.chkFilterDefaultIncludesClasses);
            this.tabPage4.Controls.Add(this.chkFilterDefaultIncludeModules);
            this.tabPage4.Controls.Add(this.chkFilterDefaultIncludesThreads);
            this.tabPage4.Controls.Add(this.chkFilterDefaultIncludesLocations);
            this.tabPage4.Controls.Add(this.chkAllowInternalMessageDisplays);
            this.tabPage4.Controls.Add(this.chkRelocateOnChange);
            this.tabPage4.Controls.Add(this.btnBrowseForFilterDir);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.txtFilterAndHighlightDir);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(723, 349);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Filter Behaviour";
            this.tabPage4.UseVisualStyleBackColor = true;
            //
            // chkFilterDefaultIncludesClasses
            //
            this.chkFilterDefaultIncludesClasses.AutoSize = true;
            this.chkFilterDefaultIncludesClasses.Location = new System.Drawing.Point(79, 185);
            this.chkFilterDefaultIncludesClasses.Name = "chkFilterDefaultIncludesClasses";
            this.chkFilterDefaultIncludesClasses.Size = new System.Drawing.Size(213, 17);
            this.chkFilterDefaultIncludesClasses.TabIndex = 27;
            this.chkFilterDefaultIncludesClasses.Text = "By default filters include classes.";
            this.chkFilterDefaultIncludesClasses.UseVisualStyleBackColor = true;
            this.chkFilterDefaultIncludesClasses.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkFilterDefaultIncludeModules
            //
            this.chkFilterDefaultIncludeModules.AutoSize = true;
            this.chkFilterDefaultIncludeModules.Location = new System.Drawing.Point(79, 162);
            this.chkFilterDefaultIncludeModules.Name = "chkFilterDefaultIncludeModules";
            this.chkFilterDefaultIncludeModules.Size = new System.Drawing.Size(220, 17);
            this.chkFilterDefaultIncludeModules.TabIndex = 26;
            this.chkFilterDefaultIncludeModules.Text = "By default filters include modules.";
            this.chkFilterDefaultIncludeModules.UseVisualStyleBackColor = true;
            this.chkFilterDefaultIncludeModules.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkFilterDefaultIncludesThreads
            //
            this.chkFilterDefaultIncludesThreads.AutoSize = true;
            this.chkFilterDefaultIncludesThreads.Location = new System.Drawing.Point(79, 139);
            this.chkFilterDefaultIncludesThreads.Name = "chkFilterDefaultIncludesThreads";
            this.chkFilterDefaultIncludesThreads.Size = new System.Drawing.Size(215, 17);
            this.chkFilterDefaultIncludesThreads.TabIndex = 25;
            this.chkFilterDefaultIncludesThreads.Text = "By default filters include threads.";
            this.chkFilterDefaultIncludesThreads.UseVisualStyleBackColor = true;
            this.chkFilterDefaultIncludesThreads.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkFilterDefaultIncludesLocations
            //
            this.chkFilterDefaultIncludesLocations.AutoSize = true;
            this.chkFilterDefaultIncludesLocations.Location = new System.Drawing.Point(79, 116);
            this.chkFilterDefaultIncludesLocations.Name = "chkFilterDefaultIncludesLocations";
            this.chkFilterDefaultIncludesLocations.Size = new System.Drawing.Size(222, 17);
            this.chkFilterDefaultIncludesLocations.TabIndex = 24;
            this.chkFilterDefaultIncludesLocations.Text = "By default filters include locations.";
            this.chkFilterDefaultIncludesLocations.UseVisualStyleBackColor = true;
            this.chkFilterDefaultIncludesLocations.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkAllowInternalMessageDisplays
            //
            this.chkAllowInternalMessageDisplays.AutoSize = true;
            this.chkAllowInternalMessageDisplays.Location = new System.Drawing.Point(79, 69);
            this.chkAllowInternalMessageDisplays.Name = "chkAllowInternalMessageDisplays";
            this.chkAllowInternalMessageDisplays.Size = new System.Drawing.Size(255, 17);
            this.chkAllowInternalMessageDisplays.TabIndex = 23;
            this.chkAllowInternalMessageDisplays.Text = "Allow internal messages to be displayed";
            this.chkAllowInternalMessageDisplays.UseVisualStyleBackColor = true;
            this.chkAllowInternalMessageDisplays.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkRelocateOnChange
            //
            this.chkRelocateOnChange.AutoSize = true;
            this.chkRelocateOnChange.Checked = true;
            this.chkRelocateOnChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRelocateOnChange.Location = new System.Drawing.Point(79, 46);
            this.chkRelocateOnChange.Name = "chkRelocateOnChange";
            this.chkRelocateOnChange.Size = new System.Drawing.Size(281, 17);
            this.chkRelocateOnChange.TabIndex = 22;
            this.chkRelocateOnChange.Text = "Relocate existing filters on directory change.";
            this.chkRelocateOnChange.UseVisualStyleBackColor = true;
            this.chkRelocateOnChange.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // btnBrowseForFilterDir
            //
            this.btnBrowseForFilterDir.Location = new System.Drawing.Point(641, 33);
            this.btnBrowseForFilterDir.Name = "btnBrowseForFilterDir";
            this.btnBrowseForFilterDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseForFilterDir.TabIndex = 21;
            this.btnBrowseForFilterDir.Text = "...";
            this.btnBrowseForFilterDir.UseVisualStyleBackColor = true;
            this.btnBrowseForFilterDir.Click += new System.EventHandler(this.btnBrowseForFilterDir_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Filter Dir:";
            //
            // txtFilterAndHighlightDir
            //
            this.txtFilterAndHighlightDir.Location = new System.Drawing.Point(79, 10);
            this.txtFilterAndHighlightDir.Name = "txtFilterAndHighlightDir";
            this.txtFilterAndHighlightDir.ReadOnly = true;
            this.txtFilterAndHighlightDir.Size = new System.Drawing.Size(638, 21);
            this.txtFilterAndHighlightDir.TabIndex = 15;
            //
            // tabTexSettings
            //
            this.tabTexSettings.Controls.Add(this.btnReleaseDefaults);
            this.tabTexSettings.Controls.Add(this.btnDevelopmentDefaults);
            this.tabTexSettings.Controls.Add(this.chkAddStackInfo);
            this.tabTexSettings.Controls.Add(this.chkEnableEnhancements);
            this.tabTexSettings.Controls.Add(this.chkExpandAssertions);
            this.tabTexSettings.Controls.Add(this.btnReadEnvironment);
            this.tabTexSettings.Controls.Add(this.btnSetEnvironment);
            this.tabTexSettings.Controls.Add(this.chkUseHighPerf);
            this.tabTexSettings.Controls.Add(this.groupBox7);
            this.tabTexSettings.Controls.Add(this.grpTraceLevel);
            this.tabTexSettings.Controls.Add(this.txtGeneratedString);
            this.tabTexSettings.Location = new System.Drawing.Point(4, 22);
            this.tabTexSettings.Name = "tabTexSettings";
            this.tabTexSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabTexSettings.Size = new System.Drawing.Size(723, 349);
            this.tabTexSettings.TabIndex = 5;
            this.tabTexSettings.Text = "Tex Behaviour";
            this.tabTexSettings.UseVisualStyleBackColor = true;
            //
            // btnReleaseDefaults
            //
            this.btnReleaseDefaults.Location = new System.Drawing.Point(555, 174);
            this.btnReleaseDefaults.Name = "btnReleaseDefaults";
            this.btnReleaseDefaults.Size = new System.Drawing.Size(151, 23);
            this.btnReleaseDefaults.TabIndex = 31;
            this.btnReleaseDefaults.Text = "Rel. Defaults";
            this.btnReleaseDefaults.UseVisualStyleBackColor = true;
            this.btnReleaseDefaults.Click += new System.EventHandler(this.btnReleaseDefaults_Click);
            this.btnReleaseDefaults.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // btnDevelopmentDefaults
            //
            this.btnDevelopmentDefaults.Location = new System.Drawing.Point(555, 145);
            this.btnDevelopmentDefaults.Name = "btnDevelopmentDefaults";
            this.btnDevelopmentDefaults.Size = new System.Drawing.Size(151, 23);
            this.btnDevelopmentDefaults.TabIndex = 30;
            this.btnDevelopmentDefaults.Text = "Dev. Defaults";
            this.btnDevelopmentDefaults.UseVisualStyleBackColor = true;
            this.btnDevelopmentDefaults.Click += new System.EventHandler(this.btnDevelopmentDefaults_Click);
            this.btnDevelopmentDefaults.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkAddStackInfo
            //
            this.chkAddStackInfo.AutoSize = true;
            this.chkAddStackInfo.Location = new System.Drawing.Point(555, 108);
            this.chkAddStackInfo.Name = "chkAddStackInfo";
            this.chkAddStackInfo.Size = new System.Drawing.Size(155, 17);
            this.chkAddStackInfo.TabIndex = 29;
            this.chkAddStackInfo.Text = "Add Stack Information";
            this.chkAddStackInfo.UseVisualStyleBackColor = true;
            this.chkAddStackInfo.CheckedChanged += new System.EventHandler(this.chkTexOptionsScreen_CheckedChanged);
            this.chkAddStackInfo.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkEnableEnhancements
            //
            this.chkEnableEnhancements.AutoSize = true;
            this.chkEnableEnhancements.Location = new System.Drawing.Point(555, 16);
            this.chkEnableEnhancements.Name = "chkEnableEnhancements";
            this.chkEnableEnhancements.Size = new System.Drawing.Size(151, 17);
            this.chkEnableEnhancements.TabIndex = 28;
            this.chkEnableEnhancements.Text = "Enable Enhancements";
            this.chkEnableEnhancements.UseVisualStyleBackColor = true;
            this.chkEnableEnhancements.CheckedChanged += new System.EventHandler(this.chkTexOptionsScreen_CheckedChanged);
            this.chkEnableEnhancements.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkExpandAssertions
            //
            this.chkExpandAssertions.AutoSize = true;
            this.chkExpandAssertions.Location = new System.Drawing.Point(555, 39);
            this.chkExpandAssertions.Name = "chkExpandAssertions";
            this.chkExpandAssertions.Size = new System.Drawing.Size(131, 17);
            this.chkExpandAssertions.TabIndex = 27;
            this.chkExpandAssertions.Text = "Expand Assertions";
            this.chkExpandAssertions.UseVisualStyleBackColor = true;
            this.chkExpandAssertions.CheckedChanged += new System.EventHandler(this.chkTexOptionsScreen_CheckedChanged);
            this.chkExpandAssertions.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // btnReadEnvironment
            //
            this.btnReadEnvironment.Location = new System.Drawing.Point(307, 310);
            this.btnReadEnvironment.Name = "btnReadEnvironment";
            this.btnReadEnvironment.Size = new System.Drawing.Size(195, 23);
            this.btnReadEnvironment.TabIndex = 21;
            this.btnReadEnvironment.Text = "Get Environment Variable";
            this.btnReadEnvironment.UseVisualStyleBackColor = true;
            this.btnReadEnvironment.Click += new System.EventHandler(this.btnReadEnvironment_Click);
            this.btnReadEnvironment.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // btnSetEnvironment
            //
            this.btnSetEnvironment.Location = new System.Drawing.Point(523, 310);
            this.btnSetEnvironment.Name = "btnSetEnvironment";
            this.btnSetEnvironment.Size = new System.Drawing.Size(193, 23);
            this.btnSetEnvironment.TabIndex = 20;
            this.btnSetEnvironment.Text = "Set Environment (Machine)";
            this.btnSetEnvironment.UseVisualStyleBackColor = true;
            this.btnSetEnvironment.Click += new System.EventHandler(this.btnSetEnvironment_Click);
            this.btnSetEnvironment.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkUseHighPerf
            //
            this.chkUseHighPerf.AutoSize = true;
            this.chkUseHighPerf.Location = new System.Drawing.Point(555, 85);
            this.chkUseHighPerf.Name = "chkUseHighPerf";
            this.chkUseHighPerf.Size = new System.Drawing.Size(125, 17);
            this.chkUseHighPerf.TabIndex = 18;
            this.chkUseHighPerf.Text = "High Perf support";
            this.chkUseHighPerf.UseVisualStyleBackColor = true;
            this.chkUseHighPerf.CheckedChanged += new System.EventHandler(this.chkTexOptionsScreen_CheckedChanged);
            this.chkUseHighPerf.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // groupBox7
            //
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.lblErrorMsg);
            this.groupBox7.Controls.Add(this.btnAddNewListener);
            this.groupBox7.Controls.Add(this.btnRemoveSelected);
            this.groupBox7.Controls.Add(this.lbxAddTCPListeners);
            this.groupBox7.Controls.Add(this.chkMakeTcpInteractive);
            this.groupBox7.Controls.Add(this.chkRemoveAll);
            this.groupBox7.Controls.Add(this.txtIPInit);
            this.groupBox7.Controls.Add(this.txtPortInit);
            this.groupBox7.Controls.Add(this.chkAddTexListener);
            this.groupBox7.Location = new System.Drawing.Point(137, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(375, 271);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Listeners";
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Port:";
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Hostname:";
            //
            // lblErrorMsg
            //
            this.lblErrorMsg.Location = new System.Drawing.Point(10, 217);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(355, 51);
            this.lblErrorMsg.TabIndex = 11;
            //
            // btnAddNewListener
            //
            this.btnAddNewListener.Enabled = false;
            this.btnAddNewListener.Location = new System.Drawing.Point(263, 119);
            this.btnAddNewListener.Name = "btnAddNewListener";
            this.btnAddNewListener.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewListener.TabIndex = 6;
            this.btnAddNewListener.Text = "Add";
            this.btnAddNewListener.UseVisualStyleBackColor = true;
            this.btnAddNewListener.Click += new System.EventHandler(this.btnAddNewListener_Click);
            //
            // btnRemoveSelected
            //
            this.btnRemoveSelected.Enabled = false;
            this.btnRemoveSelected.Location = new System.Drawing.Point(263, 148);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSelected.TabIndex = 7;
            this.btnRemoveSelected.Text = "Remove";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            //
            // lbxAddTCPListeners
            //
            this.lbxAddTCPListeners.FormattingEnabled = true;
            this.lbxAddTCPListeners.Location = new System.Drawing.Point(21, 119);
            this.lbxAddTCPListeners.Name = "lbxAddTCPListeners";
            this.lbxAddTCPListeners.Size = new System.Drawing.Size(236, 95);
            this.lbxAddTCPListeners.TabIndex = 5;
            this.lbxAddTCPListeners.MouseHover += new System.EventHandler(this.generic_MouseHover);
            this.lbxAddTCPListeners.SelectedIndexChanged += new System.EventHandler(this.lbxAddTCPListeners_SelectedIndexChanged);
            //
            // chkMakeTcpInteractive
            //
            this.chkMakeTcpInteractive.AutoSize = true;
            this.chkMakeTcpInteractive.Checked = true;
            this.chkMakeTcpInteractive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMakeTcpInteractive.Location = new System.Drawing.Point(244, 94);
            this.chkMakeTcpInteractive.Name = "chkMakeTcpInteractive";
            this.chkMakeTcpInteractive.Size = new System.Drawing.Size(88, 17);
            this.chkMakeTcpInteractive.TabIndex = 4;
            this.chkMakeTcpInteractive.Text = "Interactive";
            this.chkMakeTcpInteractive.UseVisualStyleBackColor = true;
            this.chkMakeTcpInteractive.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkRemoveAll
            //
            this.chkRemoveAll.AutoSize = true;
            this.chkRemoveAll.Location = new System.Drawing.Point(21, 25);
            this.chkRemoveAll.Name = "chkRemoveAll";
            this.chkRemoveAll.Size = new System.Drawing.Size(253, 17);
            this.chkRemoveAll.TabIndex = 0;
            this.chkRemoveAll.Text = "Remove All Listeners before adding......";
            this.chkRemoveAll.UseVisualStyleBackColor = true;
            this.chkRemoveAll.CheckedChanged += new System.EventHandler(this.chkTexOptionsScreen_CheckedChanged);
            this.chkRemoveAll.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // txtIPInit
            //
            this.txtIPInit.Location = new System.Drawing.Point(20, 92);
            this.txtIPInit.MaxLength = 255;
            this.txtIPInit.Name = "txtIPInit";
            this.txtIPInit.Size = new System.Drawing.Size(121, 21);
            this.txtIPInit.TabIndex = 2;
            this.txtIPInit.TextChanged += new System.EventHandler(this.txtIPInit_TextChanged);
            this.txtIPInit.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // txtPortInit
            //
            this.txtPortInit.Location = new System.Drawing.Point(147, 92);
            this.txtPortInit.MaxLength = 8;
            this.txtPortInit.Name = "txtPortInit";
            this.txtPortInit.Size = new System.Drawing.Size(64, 21);
            this.txtPortInit.TabIndex = 3;
            this.txtPortInit.TextChanged += new System.EventHandler(this.txtIPInit_TextChanged);
            this.txtPortInit.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // chkAddTexListener
            //
            this.chkAddTexListener.AutoSize = true;
            this.chkAddTexListener.Location = new System.Drawing.Point(21, 48);
            this.chkAddTexListener.Name = "chkAddTexListener";
            this.chkAddTexListener.Size = new System.Drawing.Size(96, 17);
            this.chkAddTexListener.TabIndex = 1;
            this.chkAddTexListener.Text = "Tex Listener";
            this.chkAddTexListener.UseVisualStyleBackColor = true;
            this.chkAddTexListener.CheckedChanged += new System.EventHandler(this.chkTexOptionsScreen_CheckedChanged);
            this.chkAddTexListener.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // grpTraceLevel
            //
            this.grpTraceLevel.Controls.Add(this.rdoWarningLevel);
            this.grpTraceLevel.Controls.Add(this.rdoVerboseLevel);
            this.grpTraceLevel.Controls.Add(this.rdoErrorLevel);
            this.grpTraceLevel.Controls.Add(this.rdoTraceInfo);
            this.grpTraceLevel.Controls.Add(this.rdoTraceOff);
            this.grpTraceLevel.Location = new System.Drawing.Point(6, 6);
            this.grpTraceLevel.Name = "grpTraceLevel";
            this.grpTraceLevel.Size = new System.Drawing.Size(125, 150);
            this.grpTraceLevel.TabIndex = 1;
            this.grpTraceLevel.TabStop = false;
            this.grpTraceLevel.Text = "Trace Level";
            this.grpTraceLevel.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // rdoWarningLevel
            //
            this.rdoWarningLevel.AutoSize = true;
            this.rdoWarningLevel.Location = new System.Drawing.Point(15, 119);
            this.rdoWarningLevel.Name = "rdoWarningLevel";
            this.rdoWarningLevel.Size = new System.Drawing.Size(72, 17);
            this.rdoWarningLevel.TabIndex = 4;
            this.rdoWarningLevel.TabStop = true;
            this.rdoWarningLevel.Text = "Warning";
            this.rdoWarningLevel.UseVisualStyleBackColor = true;
            this.rdoWarningLevel.CheckedChanged += new System.EventHandler(this.chkTexOptionsScreen_CheckedChanged);
            this.rdoWarningLevel.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // rdoVerboseLevel
            //
            this.rdoVerboseLevel.AutoSize = true;
            this.rdoVerboseLevel.Location = new System.Drawing.Point(15, 96);
            this.rdoVerboseLevel.Name = "rdoVerboseLevel";
            this.rdoVerboseLevel.Size = new System.Drawing.Size(72, 17);
            this.rdoVerboseLevel.TabIndex = 3;
            this.rdoVerboseLevel.TabStop = true;
            this.rdoVerboseLevel.Text = "Verbose";
            this.rdoVerboseLevel.UseVisualStyleBackColor = true;
            this.rdoVerboseLevel.CheckedChanged += new System.EventHandler(this.chkTexOptionsScreen_CheckedChanged);
            this.rdoVerboseLevel.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // rdoErrorLevel
            //
            this.rdoErrorLevel.AutoSize = true;
            this.rdoErrorLevel.Location = new System.Drawing.Point(15, 72);
            this.rdoErrorLevel.Name = "rdoErrorLevel";
            this.rdoErrorLevel.Size = new System.Drawing.Size(54, 17);
            this.rdoErrorLevel.TabIndex = 2;
            this.rdoErrorLevel.TabStop = true;
            this.rdoErrorLevel.Text = "Error";
            this.rdoErrorLevel.UseVisualStyleBackColor = true;
            this.rdoErrorLevel.CheckedChanged += new System.EventHandler(this.chkTexOptionsScreen_CheckedChanged);
            this.rdoErrorLevel.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // rdoTraceInfo
            //
            this.rdoTraceInfo.AutoSize = true;
            this.rdoTraceInfo.Location = new System.Drawing.Point(15, 48);
            this.rdoTraceInfo.Name = "rdoTraceInfo";
            this.rdoTraceInfo.Size = new System.Drawing.Size(48, 17);
            this.rdoTraceInfo.TabIndex = 1;
            this.rdoTraceInfo.TabStop = true;
            this.rdoTraceInfo.Text = "Info";
            this.rdoTraceInfo.UseVisualStyleBackColor = true;
            this.rdoTraceInfo.CheckedChanged += new System.EventHandler(this.chkTexOptionsScreen_CheckedChanged);
            this.rdoTraceInfo.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // rdoTraceOff
            //
            this.rdoTraceOff.AutoSize = true;
            this.rdoTraceOff.Location = new System.Drawing.Point(15, 24);
            this.rdoTraceOff.Name = "rdoTraceOff";
            this.rdoTraceOff.Size = new System.Drawing.Size(42, 17);
            this.rdoTraceOff.TabIndex = 0;
            this.rdoTraceOff.TabStop = true;
            this.rdoTraceOff.Text = "Off";
            this.rdoTraceOff.UseVisualStyleBackColor = true;
            this.rdoTraceOff.CheckedChanged += new System.EventHandler(this.chkTexOptionsScreen_CheckedChanged);
            this.rdoTraceOff.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // txtGeneratedString
            //
            this.txtGeneratedString.Location = new System.Drawing.Point(15, 283);
            this.txtGeneratedString.Name = "txtGeneratedString";
            this.txtGeneratedString.ReadOnly = true;
            this.txtGeneratedString.Size = new System.Drawing.Size(701, 21);
            this.txtGeneratedString.TabIndex = 15;
            this.txtGeneratedString.MouseHover += new System.EventHandler(this.generic_MouseHover);
            //
            // lblHelp
            //
            this.lblHelp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHelp.Location = new System.Drawing.Point(4, 383);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(726, 57);
            this.lblHelp.TabIndex = 27;
            this.lblHelp.Text = "Hover the mouse over a setting for information....";
            //
            // llbRelatedContent
            //
            this.llbRelatedContent.AutoSize = true;
            this.llbRelatedContent.Location = new System.Drawing.Point(4, 446);
            this.llbRelatedContent.Name = "llbRelatedContent";
            this.llbRelatedContent.Size = new System.Drawing.Size(162, 13);
            this.llbRelatedContent.TabIndex = 28;
            this.llbRelatedContent.TabStop = true;
            this.llbRelatedContent.Text = "Click Here for related help.";
            this.llbRelatedContent.Visible = false;
            //
            // chkActivateImportLogging
            //
            this.chkActivateImportLogging.AutoSize = true;
            this.chkActivateImportLogging.Location = new System.Drawing.Point(10, 23);
            this.chkActivateImportLogging.Name = "chkActivateImportLogging";
            this.chkActivateImportLogging.Size = new System.Drawing.Size(167, 17);
            this.chkActivateImportLogging.TabIndex = 0;
            this.chkActivateImportLogging.Text = "Activate Import Logging.";
            this.chkActivateImportLogging.UseVisualStyleBackColor = true;
            //
            // chkImportLoggingInlcudedsODS
            //
            this.chkImportLoggingInlcudedsODS.AutoSize = true;
            this.chkImportLoggingInlcudedsODS.Location = new System.Drawing.Point(31, 45);
            this.chkImportLoggingInlcudedsODS.Name = "chkImportLoggingInlcudedsODS";
            this.chkImportLoggingInlcudedsODS.Size = new System.Drawing.Size(246, 17);
            this.chkImportLoggingInlcudedsODS.TabIndex = 1;
            this.chkImportLoggingInlcudedsODS.Text = "Include OutputDebugString messages.";
            this.chkImportLoggingInlcudedsODS.UseVisualStyleBackColor = true;
            //
            // chkInlucdeTCPContents
            //
            this.chkInlucdeTCPContents.AutoSize = true;
            this.chkInlucdeTCPContents.Location = new System.Drawing.Point(31, 68);
            this.chkInlucdeTCPContents.Name = "chkInlucdeTCPContents";
            this.chkInlucdeTCPContents.Size = new System.Drawing.Size(160, 17);
            this.chkInlucdeTCPContents.TabIndex = 2;
            this.chkInlucdeTCPContents.Text = "Include TCP messages.";
            this.chkInlucdeTCPContents.UseVisualStyleBackColor = true;
            //
            // chkIncludeFileContents
            //
            this.chkIncludeFileContents.AutoSize = true;
            this.chkIncludeFileContents.Location = new System.Drawing.Point(31, 88);
            this.chkIncludeFileContents.Name = "chkIncludeFileContents";
            this.chkIncludeFileContents.Size = new System.Drawing.Size(213, 17);
            this.chkIncludeFileContents.TabIndex = 3;
            this.chkIncludeFileContents.Text = "Include Imported File messages.";
            this.chkIncludeFileContents.UseVisualStyleBackColor = true;
            //
            // frmMexOptionsScreen
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(734, 488);
            this.Controls.Add(this.llbRelatedContent);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.tabOptionsContainer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(742, 515);
            this.MinimumSize = new System.Drawing.Size(742, 515);
            this.Name = "frmMexOptionsScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MexOptionsScreen";
            this.Load += new System.EventHandler(this.frmMexOptionsScreen_Load);
            this.tabOptionsContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpUserMessageNotificationOptions.ResumeLayout(false);
            this.grpUserMessageNotificationOptions.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpThreadDisplayOptions.ResumeLayout(false);
            this.grpThreadDisplayOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabAdvancedOptions.ResumeLayout(false);
            this.tabAdvancedOptions.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPushbackLimitCount)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabTexSettings.ResumeLayout(false);
            this.tabTexSettings.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.grpTraceLevel.ResumeLayout(false);
            this.grpTraceLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        internal void PopulateOptionsScreenFromOptions(MexOptions mo) {
            txtFilterAndHighlightDir.Text = mo.FilterAndHighlightStoreDirectory;
            m_filterDirInitialiseValue = mo.FilterAndHighlightStoreDirectory;  // This is used so we know if its changed

            chkRecycleProcessWhenNameMatches.Checked = mo.AutoPurgeApplicationOnMatchingName;
            chkAutoRefresh.Checked = mo.AutoRefresh;
            chkAutoScroll.Checked = mo.AutoScroll;
            chkNormaliseRefresh.Checked = mo.NormaliseRefreshActive;
            chkSelectingProcessSelectsProcessView.Checked = mo.SelectingProcessSelectsProcessView;
            chkAutoSelectProcessIfNoneSelected.Checked = mo.AutoSelectFirstProcess;

            if (mo.NormaliseRefreshActive) {
                txtNormalisationMS.Text = mo.NormalisationLimitMilliseconds.ToString();
            } else {
                txtNormalisationMS.Text = "0";
            }

            nudPushbackLimitCount.Value = mo.PushbackCountDelayLimitForInteractiveJobs;

            chkRespectFilter.Checked = mo.RespectFilter;
            chkDisplayGlobalIndexInMainView.Checked = mo.ShowGlobalIndexInView;
            chkAllowCancelOperations.Checked = mo.SupportCancellationOfRefresh;
            chkWotTimedViewToo.Checked = mo.TimedViewRespectsFilter;

            chkLeaveMatchingPidsInNonTracedToo.Checked = mo.XRefReverseCopyEnabled;
            chkImportMatchingPIDODSIntoEvents.Checked = mo.XRefMatchingProcessIdsIntoEventEntries;

            chkXRefAppInitialises.Checked = mo.XRefAppInitialiseToMain;
            chkXRefCheckAssertions.Checked = mo.XRefAssertionsToMain;
            chkXRefErrors.Checked = mo.XRefErrorsToMain;
            chkXRefExceptions.Checked = mo.XRefExceptionsToMain;
            chkXRefLogs.Checked = mo.XRefLogsToMain;
            chkXRefMiniLogs.Checked = mo.XRefMiniLogsToMain;
            chkXRefResourceMessages.Checked = mo.XRefResourceMessagesToMain;
            chkXRefVerbLogs.Checked = mo.XRefVerbLogsToMain;
            chkXRefWarnings.Checked = mo.XRefWarningsToMain;
            chkBeautifyOutput.Checked = mo.BeautifyDisplayedStrings;
            chkRemoveDupes.Checked = mo.RemoveDuplicatesOnImport;
            chkRemoveDupesOnDisplay.Checked = mo.RemoveDuplicatesOnView;

            txtIPBinding.Text = mo.IPAddressToBind;
            txtPortBinding.Text = mo.PortAddressToBind.ToString();

            chkMatchingNamePurgeAlsoClearsPartials.Checked = mo.MatchingNamePurgeAlsoClearsPartials;

            chkTimingsViewIgnoresThreads.Checked = mo.TimingsViewIgnoresThreads;

            switch (mo.ThreadDisplayOption) {
                case ThreadDisplayMode.UseDotNetThread:
                    rdoThreadShowNetId.Checked = true;
                    break;

                case ThreadDisplayMode.UseOSThread:
                    rdoThreadShowOSId.Checked = true;
                    break;

                case ThreadDisplayMode.DefaultUseThreadNameAndOS:
                    rdoThreadShowDefault.Checked = true;
                    break;

                case ThreadDisplayMode.ShowFullInformation:
                    rdoThreadShowFullInfo.Checked = true;
                    break;

                default:
                    throw new InvalidOperationException("Should not be able to have another possibility in thread display options enum");
            }

            txtUIRefreshFrequency.Text = mo.NoSecondsForUIUpdate.ToString();
            txtUserLogSize.Text = mo.NoUserNotificationsToStoreInLog.ToString();
            txtLongRunningOps.Text = mo.NoSecondsForRefreshOnImport.ToString();
            chkAllowInternalMessageDisplays.Checked = mo.DisplayInternalMessages;
            chkEnableBacktrace.Checked = mo.EnableBackTrace;
            chkHighlightCrossProcesses.Checked = mo.CrossProcessViewHighlight;
            chkUseRenderNameNotPID.Checked = mo.UsePreferredNameInsteadOfProcessId;

            chkFilterDefaultIncludesClasses.Checked = mo.FilterDefaultSaveClassLocation;
            chkFilterDefaultIncludesThreads.Checked = mo.FilterDefaultSaveThreads;
            chkFilterDefaultIncludesLocations.Checked = mo.FilterDefaultSaveLocations;
            chkFilterDefaultIncludeModules.Checked = mo.FilterDefaultSaveModules;
        }

        internal MexOptions GetOptionsFromDialog() {
            MexOptions mo = new MexOptions();
            mo.FilterAndHighlightStoreDirectory = txtFilterAndHighlightDir.Text;

            mo.AutoPurgeApplicationOnMatchingName = chkRecycleProcessWhenNameMatches.Checked;
            mo.AutoRefresh = chkAutoRefresh.Checked;
            mo.AutoScroll = chkAutoScroll.Checked;
            mo.SelectingProcessSelectsProcessView = chkSelectingProcessSelectsProcessView.Checked;
            mo.AutoSelectFirstProcess = chkAutoSelectProcessIfNoneSelected.Checked;
            mo.RemoveDuplicatesOnImport = chkRemoveDupes.Checked;
            mo.RemoveDuplicatesOnView = chkRemoveDupesOnDisplay.Checked;

            mo.NormaliseRefreshActive = chkNormaliseRefresh.Checked;
            if (mo.NormaliseRefreshActive) {
                mo.NormalisationLimitMilliseconds = int.Parse(txtNormalisationMS.Text);
            } else {
                mo.NormalisationLimitMilliseconds = 0;
            }

            mo.PushbackCountDelayLimitForInteractiveJobs = (int)nudPushbackLimitCount.Value;
            mo.RespectFilter = chkRespectFilter.Checked;
            mo.ShowGlobalIndexInView = chkDisplayGlobalIndexInMainView.Checked;

            mo.SupportCancellationOfRefresh = chkAllowCancelOperations.Checked;
            mo.TimedViewRespectsFilter = chkWotTimedViewToo.Checked;

            mo.XRefReverseCopyEnabled = chkLeaveMatchingPidsInNonTracedToo.Checked;
            mo.XRefMatchingProcessIdsIntoEventEntries = chkImportMatchingPIDODSIntoEvents.Checked;

            mo.XRefAppInitialiseToMain = chkXRefAppInitialises.Checked;
            mo.XRefAssertionsToMain = chkXRefCheckAssertions.Checked;
            mo.XRefErrorsToMain = chkXRefErrors.Checked;
            mo.XRefExceptionsToMain = chkXRefExceptions.Checked;
            mo.XRefLogsToMain = chkXRefLogs.Checked;
            mo.XRefMiniLogsToMain = chkXRefMiniLogs.Checked;
            mo.XRefResourceMessagesToMain = chkXRefResourceMessages.Checked;
            mo.XRefVerbLogsToMain = chkXRefVerbLogs.Checked;
            mo.XRefWarningsToMain = chkXRefWarnings.Checked;
            mo.BeautifyDisplayedStrings = chkBeautifyOutput.Checked;

            mo.IPAddressToBind = txtIPBinding.Text;
            mo.PortAddressToBind = int.Parse(txtPortBinding.Text);

            mo.MatchingNamePurgeAlsoClearsPartials = chkMatchingNamePurgeAlsoClearsPartials.Checked;

            mo.CrossProcessViewHighlight = chkHighlightCrossProcesses.Checked;
            mo.EnableBackTrace = chkEnableBacktrace.Checked;

            mo.TimingsViewIgnoresThreads = chkTimingsViewIgnoresThreads.Checked;

            if (rdoThreadShowDefault.Checked) {
                mo.ThreadDisplayOption = ThreadDisplayMode.DefaultUseThreadNameAndOS;
            } else if (rdoThreadShowNetId.Checked) {
                mo.ThreadDisplayOption = ThreadDisplayMode.UseDotNetThread;
            } else if (rdoThreadShowOSId.Checked) {
                mo.ThreadDisplayOption = ThreadDisplayMode.UseOSThread;
            } else if (rdoThreadShowFullInfo.Checked) {
                mo.ThreadDisplayOption = ThreadDisplayMode.ShowFullInformation;
            }

            mo.NoSecondsForUIUpdate = int.Parse(txtUIRefreshFrequency.Text);
            mo.NoUserNotificationsToStoreInLog = int.Parse(txtUserLogSize.Text);
            mo.NoSecondsForRefreshOnImport = int.Parse(txtLongRunningOps.Text);
            mo.UsePreferredNameInsteadOfProcessId = chkUseRenderNameNotPID.Checked;
            mo.DisplayInternalMessages = chkAllowInternalMessageDisplays.Checked;

            mo.FilterDefaultSaveClassLocation = chkFilterDefaultIncludesClasses.Checked; ;
            mo.FilterDefaultSaveThreads = chkFilterDefaultIncludesThreads.Checked;
            mo.FilterDefaultSaveLocations = chkFilterDefaultIncludesLocations.Checked;
            mo.FilterDefaultSaveModules = chkFilterDefaultIncludeModules.Checked;

            return mo;
        }

#if DEBUG

        private void DebugBtn_Click(object sender, EventArgs e) {
            /*TCPListener tcpl = new TCPListener("127.0.0.1", 8989, true);
            Debug.Listeners.Clear();
            Debug.Listeners.Add(tcpl);*/
           //Bilge.QueueMessages = true;
           //Bilge.AddStackInformation = true;
           //Bilge.CurrentTraceLevel = TraceLevel.Verbose;
        }

        private void frmMexOptionsScreen_Load(object sender, EventArgs e) {
            Button b = new Button();
            b.Text = "DBG:  Stream Output To Mex 8989";
            b.Left = btnCancel.Left - 350;
            b.Top = btnCancel.Top;
            b.Width = 300;
            this.Controls.Add(b);
            b.Click += new EventHandler(DebugBtn_Click);
        }

#else
    private void frmMexOptionsScreen_Load(object sender, EventArgs e) {
    }

#endif

        private void chkRecycleProcessWhenNameMatches_MouseEnter(object sender, EventArgs e) {
        }

        private void btnBrowseForFilterDir_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog()) {
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.OK) {
                    txtFilterAndHighlightDir.Text = fbd.SelectedPath;
                }
            }
        }

        private string m_filterDirInitialiseValue;

        private void btnOK_Click(object sender, EventArgs e) {
            // Relocate the filters if the directory has changed.
           //Bilge.E();
            try {
                string error = string.Empty;

               //Bilge.Assert(m_filterDirInitialiseValue != null, "The filter initialise value can not be null, this causes an error");

                if ((txtFilterAndHighlightDir.Text != m_filterDirInitialiseValue) && (chkRelocateOnChange.Checked)) {
                    string[] filenames = Directory.GetFiles(m_filterDirInitialiseValue, "*" + MexCore.TheCore.Options.FilterExtension);
                    foreach (string s in filenames) {
                        try {
                            // Try to relocate this file to the new directory that has been chosen by the all knowing user.
                            File.Move(Path.Combine(m_filterDirInitialiseValue, s), Path.Combine(txtFilterAndHighlightDir.Text, s));

                            // And then check for one of the zillion errors that could occur. Before i knew you were supposed to do it properly
                            // code like this was much faster to write, now it tages ages.
                        } catch (FileNotFoundException fnfx) {
                           //Bilge.Dump(fnfx, "Exception trying to relocate filters, trying to continue");
                            error += "File " + s + " could not be relocated." + Environment.NewLine;
                        } catch (UnauthorizedAccessException uaxx) {
                           //Bilge.Dump(uaxx, "Exception trying to relocate filters, trying to continue");
                            error += "File " + s + " could not be relocated." + Environment.NewLine;
                            break;
                        } catch (DirectoryNotFoundException dnfx) {
                           //Bilge.Dump(dnfx, "Exception trying to relocate filters, aborting operation");
                            error += "File " + s + " could not be relocated." + Environment.NewLine;
                            break;
                        } catch (NotSupportedException nsx) {
                           //Bilge.Dump(nsx, "Exception trying to relocate filters, aborting operation");
                            error += "File " + s + " could not be relocated." + Environment.NewLine;
                            break;
                        } catch (PathTooLongException ptlx) {
                           //Bilge.Dump(ptlx, "Exception trying to relocate filters, aborting operation");
                            error += "File " + s + " could not be relocated." + Environment.NewLine;
                            break;
                        } catch (IOException iox) {
                           //Bilge.Dump(iox, "Exception trying to relocate filters, attempting to continue");
                            error += "File " + s + " could not be relocated." + Environment.NewLine;
                        }
                    } // End for each of the fitlers that are to be relocated
                } // IF the directorys did not match and the option to copy is ticked
            } finally {
               //Bilge.X();
            }
        }

        private Settings m_formInitSettings = new Settings();

        private bool m_thisFormBeingUpdated;  // Default false

        private void btnReadEnvironment_Click(object sender, EventArgs e) {
            RefreshTexTabFromEnvironmentVariable();
        }

        private void RefreshTexTabFromEnvironmentVariable() {
            try {
                lblErrorMsg.Text = string.Empty;
                new EnvironmentPermission(EnvironmentPermissionAccess.Read, Settings.EnvironmentVariableName).Demand();

                string envVar = Environment.GetEnvironmentVariable(Settings.EnvironmentVariableName, EnvironmentVariableTarget.Machine);
                if (envVar != null) {
                    m_formInitSettings.PopulateFromString(envVar);
                    RefreshOptionsScreenFromSettings();
                } else {
                   //Bilge.Log("The environment variable could not be read, not altering screen information");
                    MexCore.TheCore.ViewManager.AddUserNotificationMessageByIndex(ViewSupportManager.UserMessages.OptionsConfiguraitonError, ViewSupportManager.UserMessageType.WarningMessage, "Unable to retrieve the Tex Environment Variable, it does not appear to be set for this machine");
                }
            } catch (SecurityException sx) {
               //Bilge.Dump(sx, "Security Exception retrieving the environment name");
                lblErrorMsg.Text = "Security Exception, could not read environment";
                MexCore.TheCore.ViewManager.AddUserNotificationMessageByIndex(ViewSupportManager.UserMessages.OptionsConfiguraitonError, ViewSupportManager.UserMessageType.ErrorMessage, "Security Exception reading Tex Environment Variable >>" + sx.Message);
            } catch (ArgumentException ax) {
               //Bilge.Dump(ax, "Argument Exception retrieving the environment value");
                lblErrorMsg.Text = "Argument Exception, the environment variable was in the wrong format";
                MexCore.TheCore.ViewManager.AddUserNotificationMessageByIndex(ViewSupportManager.UserMessages.OptionsConfiguraitonError, ViewSupportManager.UserMessageType.ErrorMessage, "Argument Exception reading Tex Environment Variable >>" + ax.Message);
            }
        }

        /// <summary>
        /// Applys a changed structure setting to the form that is used to display the information.  This method first disables
        /// events that apply when the settings are being updated and then makes the screen display the settings according to
        /// the newly applied settings.
        /// </summary>
        private void RefreshOptionsScreenFromSettings() {
            this.m_thisFormBeingUpdated = true;
            try {

                #region apply the trace level to the radio group

                switch (this.m_formInitSettings.CurrentTraceLevel) {
                    case TraceLevel.Error:
                        this.rdoErrorLevel.Checked = true;
                        break;

                    case TraceLevel.Warning:
                        this.rdoWarningLevel.Checked = true;
                        break;

                    case TraceLevel.Info:
                        this.rdoTraceInfo.Checked = true;
                        break;

                    case TraceLevel.Verbose:
                        this.rdoVerboseLevel.Checked = true;
                        break;

                    default:
                        this.rdoTraceOff.Checked = true;
                        break;
                }

                #endregion

                lbxAddTCPListeners.Items.Clear();

                foreach (string s in this.m_formInitSettings.ListenersToAdd) {
                    if (s.StartsWith("TEX")) {
                        this.chkAddTexListener.Checked = true;
                    }
                    if (s.StartsWith("TCP")) {
                        lbxAddTCPListeners.Items.Add(s);
                    }
                }
                this.chkAddStackInfo.Checked = this.m_formInitSettings.AddStackInformation;
                this.chkUseHighPerf.Checked = this.m_formInitSettings.QueueMessages;
                this.chkRemoveAll.Checked = this.m_formInitSettings.ClearListenersOnStartup;
                this.chkEnableEnhancements.Checked = this.m_formInitSettings.EnableEnhancements;
                this.txtGeneratedString.Text = this.m_formInitSettings.ToString();
            } finally {
                this.m_thisFormBeingUpdated = false;
            }
        }

        /// <summary>
        /// Repopulates the internal TexInitSettings class using all of the currently selected values on the form,
        /// this should be called after every form change to ensure that the m_formsSettings strucutre has the
        /// correct values for the form.
        /// </summary>
        private void RefreshStructureFromForm() {
            if (m_thisFormBeingUpdated) { return; }  // In the middle of an update from a set

            #region entry code

           //Bilge.Assert(m_formInitSettings != null, "The internal texInitSettings class should never be null");
           //Bilge.Assert(m_formInitSettings.ListenersToAdd != null, "The texInitSettings listeners collection should never be null");

            #endregion

           //Bilge.Log("Refreshing internal texinitsettings from the form settings");

            txtGeneratedString.Text = m_formInitSettings.ToString();

            if (rdoErrorLevel.Checked) { m_formInitSettings.CurrentTraceLevel = TraceLevel.Error; }
            if (rdoTraceInfo.Checked) { m_formInitSettings.CurrentTraceLevel = TraceLevel.Info; }
            if (rdoVerboseLevel.Checked) { m_formInitSettings.CurrentTraceLevel = TraceLevel.Verbose; }
            if (rdoWarningLevel.Checked) { m_formInitSettings.CurrentTraceLevel = TraceLevel.Warning; }
            if (rdoTraceOff.Checked) { m_formInitSettings.CurrentTraceLevel = TraceLevel.Off; }

            m_formInitSettings.ClearAddedListeners();
            foreach (string s in lbxAddTCPListeners.Items) {
                m_formInitSettings.AddListener(s);
            }

            if (chkAddTexListener.Checked) {
                m_formInitSettings.AddListener("TEX;");
            }

            m_formInitSettings.QueueMessages = chkUseHighPerf.Checked;
            m_formInitSettings.AddStackInformation = chkAddStackInfo.Checked;
            m_formInitSettings.EnableEnhancements = chkEnableEnhancements.Checked;
            m_formInitSettings.ClearListenersOnStartup = chkRemoveAll.Checked;

            // Make sure the correct string is displayed.
            txtGeneratedString.Text = m_formInitSettings.ToString();
        }

        private void btnSetEnvironment_Click(object sender, EventArgs e) {
            Cursor curr = Cursor.Current; ;
            try {
                Cursor.Current = Cursors.WaitCursor;

                RefreshStructureFromForm();

                txtGeneratedString.Text = m_formInitSettings.ToString();
                Environment.SetEnvironmentVariable(Settings.EnvironmentVariableName, txtGeneratedString.Text, EnvironmentVariableTarget.Machine);
                string expandAssertions = chkExpandAssertions.Checked ? "True" : "False";
                Environment.SetEnvironmentVariable("TEXASSERTEXPAND", expandAssertions, EnvironmentVariableTarget.Machine);
                Cursor.Current = curr;
            } catch (SecurityException ax) {
               //Bilge.Warning("This user does not have sufficient rights to update the environment.");
               //Bilge.Dump(ax, "Failed to update the environment variable");
                MessageBox.Show("Environment variable could not be set.  You do not have sufficient access rights.");
                return;
            } finally {
                Cursor.Current = curr;
            }
            MessageBox.Show("Environment variable stored.");
        }

        private void btnAddNewListener_Click(object sender, EventArgs e) {
            txtIPInit.Text = txtIPInit.Text.Trim();
            txtPortInit.Text = txtPortInit.Text.Trim();

            if ((this.txtIPInit.Text.Length == 0) && (MessageBox.Show("The IP address appears to be invalid when the TCP listener is set.  This will cause no trace to be stored- contine?", "Invalid Settings", MessageBoxButtons.YesNo) == DialogResult.No)) {
                return;
            }
            if ((this.txtPortInit.Text.Length == 0) && (MessageBox.Show("The port value appears to be invalid when the TCP listener is set.  This will cause no trace to be stored- contine?", "Invalid Settings", MessageBoxButtons.YesNo) == DialogResult.No)) {
                return;
            }

            string tcpListenerText = "TCP;" + txtIPInit.Text + "," + txtPortInit.Text;
            if (chkMakeTcpInteractive.Checked) { tcpListenerText += ",INTERACTIVE"; };
            lbxAddTCPListeners.Items.Add(tcpListenerText);

            RefreshStructureFromForm();
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e) {
            if (lbxAddTCPListeners.SelectedIndex >= 0) {
                lbxAddTCPListeners.Items.RemoveAt(lbxAddTCPListeners.SelectedIndex);
            }
            RefreshStructureFromForm();
        }

        private void chkTexOptionsScreen_CheckedChanged(object sender, EventArgs e) {
            //Common handler for the tickboxes on the Tex options part of the options screen.
            RefreshStructureFromForm();
        }

        private void btnDevelopmentDefaults_Click(object sender, EventArgs e) {
            rdoVerboseLevel.Checked = true;
            chkRemoveAll.Checked = true;
            lbxAddTCPListeners.Items.Clear();
            chkAddTexListener.Checked = true;
            txtIPInit.Text = txtPortInit.Text = string.Empty;
            chkEnableEnhancements.Checked = true;
            chkExpandAssertions.Checked = true;
            chkUseHighPerf.Checked = true;
            chkAddStackInfo.Checked = true;
        }

        private void btnReleaseDefaults_Click(object sender, EventArgs e) {
            rdoTraceOff.Checked = true;
            chkRemoveAll.Checked = true;
            chkAddTexListener.Checked = false;
            lbxAddTCPListeners.Items.Clear();
            txtIPInit.Text = txtPortInit.Text = string.Empty;
            chkEnableEnhancements.Checked = false;
            chkExpandAssertions.Checked = false;
            chkUseHighPerf.Checked = false;
            chkAddStackInfo.Checked = false;
        }

        private void txtIPInit_TextChanged(object sender, EventArgs e) {
            btnAddNewListener.Enabled = ((txtIPInit.Text.Trim().Length > 0) && (txtPortInit.Text.Trim().Length > 0));
        }

        private void lbxAddTCPListeners_SelectedIndexChanged(object sender, EventArgs e) {
            btnRemoveSelected.Enabled = lbxAddTCPListeners.SelectedIndex >= 0;
        }

        #region support for the environment setting and unsetting part of the options

        /*
        private void btnSetEnvironment_Click(object sender, EventArgs e) {
        }

        private void InitialiseTexSettingTab() {
           //Bilge.Log("Initialising Tex Settings Tab.");

            m_formsSettings = new TexInitSettings();

            // This is required so that we do not supply the name of this tool as the default application name.
            m_formsSettings.ResetForConfigurationTool();

           //Bilge.Log("Reading configuration inforamtion from the environment");
            m_formsSettings.PopulateFromEnvironmentVariable();

           //Bilge.Log("Environment configuration now set to" + m_formsSettings.ToString());
            // Put the initial values on the form.
            RefreshFormFromStructure();
        }
*/

        #endregion

        /// <summary>
        /// This method is essentially a massive switch statement to provide the help for hovering over the controls that are on the options
        /// screen. It uses the sender to identify which message is to be displayed and while this is a little crude it seemed over complex
        /// to bounce it through a enum.
        /// </summary>
        /// <remarks>This method is designed to be hooked up to the mouse hover for all of the controls</remarks>
        /// <param name="sender">The control which has triggered the hover event</param>
        /// <param name="e">The arguments provided with the mouse hover</param>
        private void generic_MouseHover(object sender, EventArgs e) {
            string helpText;

            AppHelpProvider ahp = new AppHelpProvider(new ResourceAccessor());
            string identifer = ((Control)sender).Name;
            helpText = ahp.GetHelpDescription(identifer);
            if (string.IsNullOrEmpty(helpText)) {
               //Bilge.Warning("Missing help text for " + identifer);
                helpText = "No help available, raise a bug for the control which you are expecting help for. (" + identifer + ")";
            }
            lblHelp.Text = helpText;
        }

        private void txtUIRefreshFrequency_TextChanged(object sender, EventArgs e) {
            try {
                lblRefreshWarning.Visible = false;

                string s = txtUIRefreshFrequency.Text;
                int i = int.Parse(s);
                if (i > 5) {
                    lblRefreshWarning.Text = "N.B. If your UI refresh is set too high you will not recieve real time notification of trace messages.";
                    lblRefreshWarning.Visible = true;
                }
            } catch (FormatException) {
            }
        }
    }
}