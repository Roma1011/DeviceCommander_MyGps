namespace DeviceCommander
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TLPnl = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.PNLSearch = new System.Windows.Forms.Panel();
            this.LineSearch = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.AppLabelName = new System.Windows.Forms.Label();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.TLPnlMenu = new System.Windows.Forms.TableLayoutPanel();
            this.DeviceCommanderButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PnlNav = new System.Windows.Forms.Label();
            this.PnFill = new System.Windows.Forms.Panel();
            this.PnPage = new System.Windows.Forms.Panel();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Imei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryPanel = new System.Windows.Forms.Panel();
            this.DeviceCommandGrid = new System.Windows.Forms.DataGridView();
            this.Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommandPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SendButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OnOfPannel = new System.Windows.Forms.Panel();
            this.K3ShiftOf = new System.Windows.Forms.TextBox();
            this.K3ShiftOn = new System.Windows.Forms.TextBox();
            this.K3Label = new System.Windows.Forms.Label();
            this.K2ShiftOf = new System.Windows.Forms.TextBox();
            this.K2ShiftOn = new System.Windows.Forms.TextBox();
            this.K2Label = new System.Windows.Forms.Label();
            this.K1Label = new System.Windows.Forms.Label();
            this.K1ShiftOf = new System.Windows.Forms.TextBox();
            this.K1ShiftOn = new System.Windows.Forms.TextBox();
            this.ManagmantPanel = new System.Windows.Forms.Panel();
            this.ResetShedule = new System.Windows.Forms.RadioButton();
            this.TurnOnRadio = new System.Windows.Forms.RadioButton();
            this.TurnOffRadio = new System.Windows.Forms.RadioButton();
            this.OnOffShiftRadioButton = new System.Windows.Forms.RadioButton();
            this.GraficRadioButton = new System.Windows.Forms.RadioButton();
            this.DeviceManagmentRadio = new System.Windows.Forms.RadioButton();
            this.K_SPanel = new System.Windows.Forms.Panel();
            this.K3Checkbox = new System.Windows.Forms.CheckBox();
            this.K2CheckBox = new System.Windows.Forms.CheckBox();
            this.K1Checkbox = new System.Windows.Forms.CheckBox();
            this.Panel_IP_PORT = new System.Windows.Forms.Panel();
            this.Spare_Port = new System.Windows.Forms.TextBox();
            this.Primary_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Spare = new System.Windows.Forms.TextBox();
            this.Primary = new System.Windows.Forms.TextBox();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.IP_PortRadio = new System.Windows.Forms.RadioButton();
            this.SetIntervalRadio = new System.Windows.Forms.RadioButton();
            this.RestartRadio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PingButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ElipsePnl = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TimerForHistory = new System.Windows.Forms.Timer(this.components);
            this.TimerForLoadHistory = new System.Windows.Forms.Timer(this.components);
            this.TimerCheckConnect = new System.Windows.Forms.Timer(this.components);
            this.TLPnl.SuspendLayout();
            this.PNLSearch.SuspendLayout();
            this.TLPnlMenu.SuspendLayout();
            this.PnFill.SuspendLayout();
            this.PnPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.HistoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceCommandGrid)).BeginInit();
            this.CommandPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.OnOfPannel.SuspendLayout();
            this.ManagmantPanel.SuspendLayout();
            this.K_SPanel.SuspendLayout();
            this.Panel_IP_PORT.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPnl
            // 
            this.TLPnl.ColumnCount = 7;
            this.TLPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TLPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.TLPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TLPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TLPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPnl.Controls.Add(this.CloseButton, 6, 0);
            this.TLPnl.Controls.Add(this.MinimizeButton, 5, 0);
            this.TLPnl.Controls.Add(this.PNLSearch, 3, 0);
            this.TLPnl.Controls.Add(this.AppLabelName, 2, 0);
            this.TLPnl.Controls.Add(this.HistoryButton, 6, 1);
            this.TLPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLPnl.Location = new System.Drawing.Point(0, 0);
            this.TLPnl.Name = "TLPnl";
            this.TLPnl.RowCount = 2;
            this.TLPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.01205F));
            this.TLPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.98795F));
            this.TLPnl.Size = new System.Drawing.Size(1387, 83);
            this.TLPnl.TabIndex = 0;
            this.TLPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TLPnl_MouseDown);
            this.TLPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TLPnl_MouseMove);
            this.TLPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TLPnl_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1351, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 38);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(1314, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(31, 38);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // PNLSearch
            // 
            this.PNLSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.PNLSearch.Controls.Add(this.LineSearch);
            this.PNLSearch.Controls.Add(this.SearchButton);
            this.PNLSearch.Controls.Add(this.SearchBar);
            this.PNLSearch.Location = new System.Drawing.Point(365, 5);
            this.PNLSearch.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.PNLSearch.Name = "PNLSearch";
            this.TLPnl.SetRowSpan(this.PNLSearch, 2);
            this.PNLSearch.Size = new System.Drawing.Size(771, 42);
            this.PNLSearch.TabIndex = 2;
            // 
            // LineSearch
            // 
            this.LineSearch.BackColor = System.Drawing.Color.White;
            this.LineSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LineSearch.Location = new System.Drawing.Point(0, 38);
            this.LineSearch.Name = "LineSearch";
            this.LineSearch.Size = new System.Drawing.Size(771, 10);
            this.LineSearch.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(729, 1);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(42, 39);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.SearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBar.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchBar.Location = new System.Drawing.Point(12, 7);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(708, 30);
            this.SearchBar.TabIndex = 0;
            this.SearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchBar_MouseClick);
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            this.SearchBar.Leave += new System.EventHandler(this.SearchBar_Leave);
            // 
            // AppLabelName
            // 
            this.AppLabelName.ForeColor = System.Drawing.Color.LightGray;
            this.AppLabelName.Location = new System.Drawing.Point(140, 12);
            this.AppLabelName.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.AppLabelName.Name = "AppLabelName";
            this.TLPnl.SetRowSpan(this.AppLabelName, 2);
            this.AppLabelName.Size = new System.Drawing.Size(150, 32);
            this.AppLabelName.TabIndex = 3;
            this.AppLabelName.Text = "DeviceCommander";
            this.AppLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HistoryButton.BackgroundImage")));
            this.HistoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryButton.FlatAppearance.BorderSize = 0;
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryButton.Location = new System.Drawing.Point(1351, 47);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(33, 33);
            this.HistoryButton.TabIndex = 4;
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // TLPnlMenu
            // 
            this.TLPnlMenu.ColumnCount = 1;
            this.TLPnlMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlMenu.Controls.Add(this.DeviceCommanderButton, 0, 2);
            this.TLPnlMenu.Controls.Add(this.StartButton, 0, 0);
            this.TLPnlMenu.Controls.Add(this.StopButton, 0, 1);
            this.TLPnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.TLPnlMenu.Location = new System.Drawing.Point(0, 83);
            this.TLPnlMenu.Name = "TLPnlMenu";
            this.TLPnlMenu.RowCount = 3;
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPnlMenu.Size = new System.Drawing.Size(92, 617);
            this.TLPnlMenu.TabIndex = 1;
            // 
            // DeviceCommanderButton
            // 
            this.DeviceCommanderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceCommanderButton.FlatAppearance.BorderSize = 0;
            this.DeviceCommanderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeviceCommanderButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeviceCommanderButton.ForeColor = System.Drawing.Color.Black;
            this.DeviceCommanderButton.Image = ((System.Drawing.Image)(resources.GetObject("DeviceCommanderButton.Image")));
            this.DeviceCommanderButton.Location = new System.Drawing.Point(3, 183);
            this.DeviceCommanderButton.Name = "DeviceCommanderButton";
            this.DeviceCommanderButton.Size = new System.Drawing.Size(86, 431);
            this.DeviceCommanderButton.TabIndex = 2;
            this.DeviceCommanderButton.Text = "Command";
            this.DeviceCommanderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeviceCommanderButton.UseVisualStyleBackColor = true;
            this.DeviceCommanderButton.Click += new System.EventHandler(this.DeviceCommander_Click);
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.ForeColor = System.Drawing.Color.Black;
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.Location = new System.Drawing.Point(3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(86, 84);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start Listen";
            this.StartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopButton.Image = ((System.Drawing.Image)(resources.GetObject("StopButton.Image")));
            this.StopButton.Location = new System.Drawing.Point(3, 93);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(86, 84);
            this.StopButton.TabIndex = 3;
            this.StopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "close.png");
            this.ImageList1.Images.SetKeyName(1, "minimize (1).png");
            this.ImageList1.Images.SetKeyName(2, "search-interface-symbol.png");
            this.ImageList1.Images.SetKeyName(3, "play.png");
            this.ImageList1.Images.SetKeyName(4, "stop-sign.png");
            this.ImageList1.Images.SetKeyName(5, "list (1).png");
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.White;
            this.PnlNav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlNav.Location = new System.Drawing.Point(13, 89);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(4, 70);
            this.PnlNav.TabIndex = 3;
            // 
            // PnFill
            // 
            this.PnFill.Controls.Add(this.PnPage);
            this.PnFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnFill.Location = new System.Drawing.Point(92, 83);
            this.PnFill.Name = "PnFill";
            this.PnFill.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.PnFill.Size = new System.Drawing.Size(1295, 617);
            this.PnFill.TabIndex = 4;
            // 
            // PnPage
            // 
            this.PnPage.BackColor = System.Drawing.Color.White;
            this.PnPage.Controls.Add(this.DataGrid);
            this.PnPage.Controls.Add(this.HistoryPanel);
            this.PnPage.Controls.Add(this.CommandPanel);
            this.PnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnPage.Location = new System.Drawing.Point(0, 0);
            this.PnPage.Name = "PnPage";
            this.PnPage.Size = new System.Drawing.Size(1295, 597);
            this.PnPage.TabIndex = 0;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imei,
            this.MobileNumber});
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(198, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowTemplate.Height = 25;
            this.DataGrid.Size = new System.Drawing.Size(677, 597);
            this.DataGrid.TabIndex = 2;
            // 
            // Imei
            // 
            this.Imei.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Imei.HeaderText = "Imei";
            this.Imei.Name = "Imei";
            this.Imei.ReadOnly = true;
            // 
            // MobileNumber
            // 
            this.MobileNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MobileNumber.HeaderText = "MobileNumber";
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.ReadOnly = true;
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.Controls.Add(this.DeviceCommandGrid);
            this.HistoryPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.HistoryPanel.Location = new System.Drawing.Point(875, 0);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Size = new System.Drawing.Size(420, 597);
            this.HistoryPanel.TabIndex = 1;
            // 
            // DeviceCommandGrid
            // 
            this.DeviceCommandGrid.AllowUserToAddRows = false;
            this.DeviceCommandGrid.AllowUserToDeleteRows = false;
            this.DeviceCommandGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeviceCommandGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Device,
            this.Command,
            this.Status,
            this.Time});
            this.DeviceCommandGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceCommandGrid.Location = new System.Drawing.Point(0, 0);
            this.DeviceCommandGrid.Name = "DeviceCommandGrid";
            this.DeviceCommandGrid.ReadOnly = true;
            this.DeviceCommandGrid.RowTemplate.Height = 25;
            this.DeviceCommandGrid.Size = new System.Drawing.Size(420, 597);
            this.DeviceCommandGrid.TabIndex = 0;
            // 
            // Device
            // 
            this.Device.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Device.HeaderText = "Device";
            this.Device.Name = "Device";
            this.Device.ReadOnly = true;
            // 
            // Command
            // 
            this.Command.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Command.HeaderText = "Command";
            this.Command.Name = "Command";
            this.Command.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // CommandPanel
            // 
            this.CommandPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CommandPanel.Controls.Add(this.tableLayoutPanel1);
            this.CommandPanel.Controls.Add(this.panel2);
            this.CommandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CommandPanel.Location = new System.Drawing.Point(0, 0);
            this.CommandPanel.Name = "CommandPanel";
            this.CommandPanel.Size = new System.Drawing.Size(198, 597);
            this.CommandPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SendButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(199, 504);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // SendButton
            // 
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Image = ((System.Drawing.Image)(resources.GetObject("SendButton.Image")));
            this.SendButton.Location = new System.Drawing.Point(3, 439);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(193, 62);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OnOfPannel);
            this.panel1.Controls.Add(this.ManagmantPanel);
            this.panel1.Controls.Add(this.OnOffShiftRadioButton);
            this.panel1.Controls.Add(this.GraficRadioButton);
            this.panel1.Controls.Add(this.DeviceManagmentRadio);
            this.panel1.Controls.Add(this.K_SPanel);
            this.panel1.Controls.Add(this.Panel_IP_PORT);
            this.panel1.Controls.Add(this.IntervalTextBox);
            this.panel1.Controls.Add(this.IP_PortRadio);
            this.panel1.Controls.Add(this.SetIntervalRadio);
            this.panel1.Controls.Add(this.RestartRadio);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 430);
            this.panel1.TabIndex = 4;
            // 
            // OnOfPannel
            // 
            this.OnOfPannel.Controls.Add(this.K3ShiftOf);
            this.OnOfPannel.Controls.Add(this.K3ShiftOn);
            this.OnOfPannel.Controls.Add(this.K3Label);
            this.OnOfPannel.Controls.Add(this.K2ShiftOf);
            this.OnOfPannel.Controls.Add(this.K2ShiftOn);
            this.OnOfPannel.Controls.Add(this.K2Label);
            this.OnOfPannel.Controls.Add(this.K1Label);
            this.OnOfPannel.Controls.Add(this.K1ShiftOf);
            this.OnOfPannel.Controls.Add(this.K1ShiftOn);
            this.OnOfPannel.Location = new System.Drawing.Point(4, 160);
            this.OnOfPannel.Name = "OnOfPannel";
            this.OnOfPannel.Size = new System.Drawing.Size(184, 270);
            this.OnOfPannel.TabIndex = 3;
            this.OnOfPannel.Visible = false;
            // 
            // K3ShiftOf
            // 
            this.K3ShiftOf.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.K3ShiftOf.Location = new System.Drawing.Point(16, 212);
            this.K3ShiftOf.Name = "K3ShiftOf";
            this.K3ShiftOf.Size = new System.Drawing.Size(154, 23);
            this.K3ShiftOf.TabIndex = 12;
            // 
            // K3ShiftOn
            // 
            this.K3ShiftOn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.K3ShiftOn.Location = new System.Drawing.Point(16, 186);
            this.K3ShiftOn.Name = "K3ShiftOn";
            this.K3ShiftOn.Size = new System.Drawing.Size(154, 23);
            this.K3ShiftOn.TabIndex = 11;
            // 
            // K3Label
            // 
            this.K3Label.AutoSize = true;
            this.K3Label.Location = new System.Drawing.Point(75, 157);
            this.K3Label.Name = "K3Label";
            this.K3Label.Size = new System.Drawing.Size(30, 23);
            this.K3Label.TabIndex = 10;
            this.K3Label.Text = "K3";
            // 
            // K2ShiftOf
            // 
            this.K2ShiftOf.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.K2ShiftOf.Location = new System.Drawing.Point(16, 128);
            this.K2ShiftOf.Name = "K2ShiftOf";
            this.K2ShiftOf.Size = new System.Drawing.Size(154, 23);
            this.K2ShiftOf.TabIndex = 9;
            // 
            // K2ShiftOn
            // 
            this.K2ShiftOn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.K2ShiftOn.Location = new System.Drawing.Point(16, 102);
            this.K2ShiftOn.Name = "K2ShiftOn";
            this.K2ShiftOn.Size = new System.Drawing.Size(154, 23);
            this.K2ShiftOn.TabIndex = 8;
            // 
            // K2Label
            // 
            this.K2Label.AutoSize = true;
            this.K2Label.Location = new System.Drawing.Point(75, 77);
            this.K2Label.Name = "K2Label";
            this.K2Label.Size = new System.Drawing.Size(30, 23);
            this.K2Label.TabIndex = 7;
            this.K2Label.Text = "K2";
            // 
            // K1Label
            // 
            this.K1Label.AutoSize = true;
            this.K1Label.Location = new System.Drawing.Point(78, 1);
            this.K1Label.Name = "K1Label";
            this.K1Label.Size = new System.Drawing.Size(30, 23);
            this.K1Label.TabIndex = 6;
            this.K1Label.Text = "K1";
            // 
            // K1ShiftOf
            // 
            this.K1ShiftOf.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.K1ShiftOf.Location = new System.Drawing.Point(16, 51);
            this.K1ShiftOf.Name = "K1ShiftOf";
            this.K1ShiftOf.Size = new System.Drawing.Size(154, 23);
            this.K1ShiftOf.TabIndex = 5;
            // 
            // K1ShiftOn
            // 
            this.K1ShiftOn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.K1ShiftOn.Location = new System.Drawing.Point(16, 25);
            this.K1ShiftOn.Name = "K1ShiftOn";
            this.K1ShiftOn.Size = new System.Drawing.Size(154, 23);
            this.K1ShiftOn.TabIndex = 4;
            // 
            // ManagmantPanel
            // 
            this.ManagmantPanel.Controls.Add(this.ResetShedule);
            this.ManagmantPanel.Controls.Add(this.TurnOnRadio);
            this.ManagmantPanel.Controls.Add(this.TurnOffRadio);
            this.ManagmantPanel.Location = new System.Drawing.Point(3, 192);
            this.ManagmantPanel.Name = "ManagmantPanel";
            this.ManagmantPanel.Size = new System.Drawing.Size(186, 132);
            this.ManagmantPanel.TabIndex = 8;
            this.ManagmantPanel.Visible = false;
            // 
            // ResetShedule
            // 
            this.ResetShedule.AutoSize = true;
            this.ResetShedule.Location = new System.Drawing.Point(4, 78);
            this.ResetShedule.Name = "ResetShedule";
            this.ResetShedule.Size = new System.Drawing.Size(158, 27);
            this.ResetShedule.TabIndex = 7;
            this.ResetShedule.TabStop = true;
            this.ResetShedule.Text = "Back on schedule";
            this.ResetShedule.UseVisualStyleBackColor = true;
            // 
            // TurnOnRadio
            // 
            this.TurnOnRadio.AutoSize = true;
            this.TurnOnRadio.Location = new System.Drawing.Point(4, 45);
            this.TurnOnRadio.Name = "TurnOnRadio";
            this.TurnOnRadio.Size = new System.Drawing.Size(86, 27);
            this.TurnOnRadio.TabIndex = 6;
            this.TurnOnRadio.TabStop = true;
            this.TurnOnRadio.Text = "Turn on";
            this.TurnOnRadio.UseVisualStyleBackColor = true;
            // 
            // TurnOffRadio
            // 
            this.TurnOffRadio.AutoSize = true;
            this.TurnOffRadio.Location = new System.Drawing.Point(4, 12);
            this.TurnOffRadio.Name = "TurnOffRadio";
            this.TurnOffRadio.Size = new System.Drawing.Size(94, 27);
            this.TurnOffRadio.TabIndex = 3;
            this.TurnOffRadio.TabStop = true;
            this.TurnOffRadio.Text = "Turn off";
            this.TurnOffRadio.UseVisualStyleBackColor = true;
            // 
            // OnOffShiftRadioButton
            // 
            this.OnOffShiftRadioButton.AutoSize = true;
            this.OnOffShiftRadioButton.Location = new System.Drawing.Point(3, 116);
            this.OnOffShiftRadioButton.Name = "OnOffShiftRadioButton";
            this.OnOffShiftRadioButton.Size = new System.Drawing.Size(132, 27);
            this.OnOffShiftRadioButton.TabIndex = 10;
            this.OnOffShiftRadioButton.TabStop = true;
            this.OnOffShiftRadioButton.Text = "On Off Shift";
            this.OnOffShiftRadioButton.UseVisualStyleBackColor = true;
            this.OnOffShiftRadioButton.CheckedChanged += new System.EventHandler(this.OnOffShiftRadioButton_CheckedChanged);
            // 
            // GraficRadioButton
            // 
            this.GraficRadioButton.AutoSize = true;
            this.GraficRadioButton.Location = new System.Drawing.Point(3, 68);
            this.GraficRadioButton.Name = "GraficRadioButton";
            this.GraficRadioButton.Size = new System.Drawing.Size(76, 27);
            this.GraficRadioButton.TabIndex = 9;
            this.GraficRadioButton.TabStop = true;
            this.GraficRadioButton.Text = "Grafic";
            this.GraficRadioButton.UseVisualStyleBackColor = true;
            this.GraficRadioButton.CheckedChanged += new System.EventHandler(this.GraficRadioButton_CheckedChanged);
            // 
            // DeviceManagmentRadio
            // 
            this.DeviceManagmentRadio.AutoSize = true;
            this.DeviceManagmentRadio.Location = new System.Drawing.Point(3, 92);
            this.DeviceManagmentRadio.Name = "DeviceManagmentRadio";
            this.DeviceManagmentRadio.Size = new System.Drawing.Size(171, 27);
            this.DeviceManagmentRadio.TabIndex = 5;
            this.DeviceManagmentRadio.TabStop = true;
            this.DeviceManagmentRadio.Text = "Device Managment";
            this.DeviceManagmentRadio.UseVisualStyleBackColor = true;
            this.DeviceManagmentRadio.CheckedChanged += new System.EventHandler(this.DeviceManagmentRadio_CheckedChanged);
            // 
            // K_SPanel
            // 
            this.K_SPanel.Controls.Add(this.K3Checkbox);
            this.K_SPanel.Controls.Add(this.K2CheckBox);
            this.K_SPanel.Controls.Add(this.K1Checkbox);
            this.K_SPanel.Location = new System.Drawing.Point(7, 142);
            this.K_SPanel.Name = "K_SPanel";
            this.K_SPanel.Size = new System.Drawing.Size(180, 40);
            this.K_SPanel.TabIndex = 8;
            this.K_SPanel.Visible = false;
            // 
            // K3Checkbox
            // 
            this.K3Checkbox.AutoSize = true;
            this.K3Checkbox.Location = new System.Drawing.Point(129, 6);
            this.K3Checkbox.Name = "K3Checkbox";
            this.K3Checkbox.Size = new System.Drawing.Size(49, 27);
            this.K3Checkbox.TabIndex = 8;
            this.K3Checkbox.Text = "K3";
            this.K3Checkbox.UseVisualStyleBackColor = true;
            // 
            // K2CheckBox
            // 
            this.K2CheckBox.AutoSize = true;
            this.K2CheckBox.Location = new System.Drawing.Point(65, 6);
            this.K2CheckBox.Name = "K2CheckBox";
            this.K2CheckBox.Size = new System.Drawing.Size(49, 27);
            this.K2CheckBox.TabIndex = 7;
            this.K2CheckBox.Text = "K2";
            this.K2CheckBox.UseVisualStyleBackColor = true;
            // 
            // K1Checkbox
            // 
            this.K1Checkbox.AutoSize = true;
            this.K1Checkbox.Location = new System.Drawing.Point(3, 6);
            this.K1Checkbox.Name = "K1Checkbox";
            this.K1Checkbox.Size = new System.Drawing.Size(49, 27);
            this.K1Checkbox.TabIndex = 6;
            this.K1Checkbox.Text = "K1";
            this.K1Checkbox.UseVisualStyleBackColor = true;
            // 
            // Panel_IP_PORT
            // 
            this.Panel_IP_PORT.Controls.Add(this.Spare_Port);
            this.Panel_IP_PORT.Controls.Add(this.Primary_Port);
            this.Panel_IP_PORT.Controls.Add(this.label2);
            this.Panel_IP_PORT.Controls.Add(this.label1);
            this.Panel_IP_PORT.Controls.Add(this.Spare);
            this.Panel_IP_PORT.Controls.Add(this.Primary);
            this.Panel_IP_PORT.Location = new System.Drawing.Point(4, 189);
            this.Panel_IP_PORT.Name = "Panel_IP_PORT";
            this.Panel_IP_PORT.Size = new System.Drawing.Size(186, 132);
            this.Panel_IP_PORT.TabIndex = 4;
            this.Panel_IP_PORT.Visible = false;
            // 
            // Spare_Port
            // 
            this.Spare_Port.Location = new System.Drawing.Point(127, 85);
            this.Spare_Port.Name = "Spare_Port";
            this.Spare_Port.Size = new System.Drawing.Size(56, 30);
            this.Spare_Port.TabIndex = 5;
            this.Spare_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Primary_Port
            // 
            this.Primary_Port.Location = new System.Drawing.Point(127, 26);
            this.Primary_Port.Name = "Primary_Port";
            this.Primary_Port.Size = new System.Drawing.Size(56, 30);
            this.Primary_Port.TabIndex = 4;
            this.Primary_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spare IP/PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primary IP/PORT";
            // 
            // Spare
            // 
            this.Spare.Location = new System.Drawing.Point(3, 85);
            this.Spare.Name = "Spare";
            this.Spare.Size = new System.Drawing.Size(123, 30);
            this.Spare.TabIndex = 1;
            // 
            // Primary
            // 
            this.Primary.Location = new System.Drawing.Point(3, 26);
            this.Primary.Name = "Primary";
            this.Primary.Size = new System.Drawing.Size(123, 30);
            this.Primary.TabIndex = 0;
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IntervalTextBox.Location = new System.Drawing.Point(133, 27);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(60, 23);
            this.IntervalTextBox.TabIndex = 3;
            this.IntervalTextBox.Visible = false;
            // 
            // IP_PortRadio
            // 
            this.IP_PortRadio.AutoSize = true;
            this.IP_PortRadio.Location = new System.Drawing.Point(4, 45);
            this.IP_PortRadio.Name = "IP_PortRadio";
            this.IP_PortRadio.Size = new System.Drawing.Size(97, 27);
            this.IP_PortRadio.TabIndex = 2;
            this.IP_PortRadio.TabStop = true;
            this.IP_PortRadio.Text = "IP/PORT";
            this.IP_PortRadio.UseVisualStyleBackColor = true;
            this.IP_PortRadio.CheckedChanged += new System.EventHandler(this.IP_PortRadio_CheckedChanged);
            // 
            // SetIntervalRadio
            // 
            this.SetIntervalRadio.AutoSize = true;
            this.SetIntervalRadio.Location = new System.Drawing.Point(4, 24);
            this.SetIntervalRadio.Name = "SetIntervalRadio";
            this.SetIntervalRadio.Size = new System.Drawing.Size(126, 27);
            this.SetIntervalRadio.TabIndex = 1;
            this.SetIntervalRadio.TabStop = true;
            this.SetIntervalRadio.Text = "Set Interval";
            this.SetIntervalRadio.UseVisualStyleBackColor = true;
            this.SetIntervalRadio.CheckedChanged += new System.EventHandler(this.SetIntervalRadio_CheckedChanged);
            // 
            // RestartRadio
            // 
            this.RestartRadio.AutoSize = true;
            this.RestartRadio.Location = new System.Drawing.Point(4, 3);
            this.RestartRadio.Name = "RestartRadio";
            this.RestartRadio.Size = new System.Drawing.Size(88, 27);
            this.RestartRadio.TabIndex = 0;
            this.RestartRadio.TabStop = true;
            this.RestartRadio.Text = "Restart";
            this.RestartRadio.UseVisualStyleBackColor = true;
            this.RestartRadio.CheckedChanged += new System.EventHandler(this.RestartRadio_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PingButton);
            this.panel2.Controls.Add(this.DisconnectButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 65);
            this.panel2.TabIndex = 0;
            // 
            // PingButton
            // 
            this.PingButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PingButton.FlatAppearance.BorderSize = 0;
            this.PingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PingButton.Image = ((System.Drawing.Image)(resources.GetObject("PingButton.Image")));
            this.PingButton.Location = new System.Drawing.Point(103, 0);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(103, 65);
            this.PingButton.TabIndex = 2;
            this.PingButton.Text = "Ping";
            this.PingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PingButton.UseVisualStyleBackColor = true;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.DisconnectButton.FlatAppearance.BorderSize = 0;
            this.DisconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisconnectButton.Image = ((System.Drawing.Image)(resources.GetObject("DisconnectButton.Image")));
            this.DisconnectButton.Location = new System.Drawing.Point(0, 0);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(103, 65);
            this.DisconnectButton.TabIndex = 1;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DisconnectButton.UseVisualStyleBackColor = true;
            // 
            // ElipsePnl
            // 
            this.ElipsePnl.ElipseRadius = 15;
            this.ElipsePnl.TargetControl = this.PNLSearch;
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimerForHistory
            // 
            this.TimerForHistory.Interval = 500;
            this.TimerForHistory.Tick += new System.EventHandler(this.TimerForHistory_Tick);
            // 
            // TimerForLoadHistory
            // 
            this.TimerForLoadHistory.Interval = 5000;
            this.TimerForLoadHistory.Tick += new System.EventHandler(this.TimerForLoadHistory_Tick);
            // 
            // TimerCheckConnect
            // 
            this.TimerCheckConnect.Interval = 5000;
            this.TimerCheckConnect.Tick += new System.EventHandler(this.TimerCheckConnect_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1387, 700);
            this.Controls.Add(this.PnFill);
            this.Controls.Add(this.PnlNav);
            this.Controls.Add(this.TLPnlMenu);
            this.Controls.Add(this.TLPnl);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceCommander";
            this.TLPnl.ResumeLayout(false);
            this.PNLSearch.ResumeLayout(false);
            this.PNLSearch.PerformLayout();
            this.TLPnlMenu.ResumeLayout(false);
            this.PnFill.ResumeLayout(false);
            this.PnPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.HistoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeviceCommandGrid)).EndInit();
            this.CommandPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.OnOfPannel.ResumeLayout(false);
            this.OnOfPannel.PerformLayout();
            this.ManagmantPanel.ResumeLayout(false);
            this.ManagmantPanel.PerformLayout();
            this.K_SPanel.ResumeLayout(false);
            this.K_SPanel.PerformLayout();
            this.Panel_IP_PORT.ResumeLayout(false);
            this.Panel_IP_PORT.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPnl;
        private TableLayoutPanel TLPnlMenu;
        private ImageList ImageList1;
        private Button CloseButton;
        private Button MinimizeButton;
        private Panel PNLSearch;
        private Button SearchButton;
        private TextBox SearchBar;
        private Label LineSearch;
        private Label AppLabelName;
        private Button StartButton;
        private Button DeviceCommanderButton;
        private Button StopButton;
        private Label PnlNav;
        private Panel PnFill;
        private Bunifu.Framework.UI.BunifuElipse ElipsePnl;
        private System.Windows.Forms.Timer Timer;
        private Panel PnPage;
        private Panel HistoryPanel;
        private Panel CommandPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button SendButton;
        private Panel panel1;
        private Panel K_SPanel;
        private CheckBox K3Checkbox;
        private CheckBox K2CheckBox;
        private CheckBox K1Checkbox;
        private RadioButton DeviceManagmentRadio;
        private Panel Panel_IP_PORT;
        private TextBox Spare_Port;
        private TextBox Primary_Port;
        private Label label2;
        private Label label1;
        private TextBox Spare;
        private TextBox Primary;
        private TextBox IntervalTextBox;
        private RadioButton IP_PortRadio;
        private RadioButton SetIntervalRadio;
        private RadioButton RestartRadio;
        private Panel panel2;
        private Button PingButton;
        private Button DisconnectButton;
        private DataGridView DataGrid;
        private DataGridViewTextBoxColumn Imei;
        private DataGridViewTextBoxColumn MobileNumber;
        private Button HistoryButton;
        private System.Windows.Forms.Timer TimerForHistory;
        private DataGridView DeviceCommandGrid;
        private DataGridViewTextBoxColumn Device;
        private DataGridViewTextBoxColumn Command;
        private DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Timer TimerForLoadHistory;
        private System.Windows.Forms.Timer TimerCheckConnect;
        private RadioButton GraficRadioButton;
        private RadioButton OnOffShiftRadioButton;
        private Panel ManagmantPanel;
        private RadioButton ResetShedule;
        private RadioButton TurnOnRadio;
        private RadioButton TurnOffRadio;
        private Panel OnOfPannel;
        private TextBox K1ShiftOn;
        private TextBox K1ShiftOf;
        private TextBox K3ShiftOf;
        private TextBox K3ShiftOn;
        private Label K3Label;
        private TextBox K2ShiftOf;
        private TextBox K2ShiftOn;
        private Label K2Label;
        private Label K1Label;
        private DataGridViewTextBoxColumn Time;
    }
}