﻿namespace DeviceCommander
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
            this.TLPnlMenu = new System.Windows.Forms.TableLayoutPanel();
            this.DeviceCommanderButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PnlNav = new System.Windows.Forms.Label();
            this.PnFill = new System.Windows.Forms.Panel();
            this.PnPage = new System.Windows.Forms.Panel();
            this.CommandPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SendButton = new System.Windows.Forms.Button();
            this.DeviceNameInfo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PingButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ElipsePnl = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TLPnl.SuspendLayout();
            this.PNLSearch.SuspendLayout();
            this.TLPnlMenu.SuspendLayout();
            this.PnFill.SuspendLayout();
            this.PnPage.SuspendLayout();
            this.CommandPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.TLPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TLPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPnl.Controls.Add(this.CloseButton, 6, 0);
            this.TLPnl.Controls.Add(this.MinimizeButton, 5, 0);
            this.TLPnl.Controls.Add(this.PNLSearch, 3, 0);
            this.TLPnl.Controls.Add(this.AppLabelName, 2, 0);
            this.TLPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLPnl.Location = new System.Drawing.Point(0, 0);
            this.TLPnl.Name = "TLPnl";
            this.TLPnl.RowCount = 2;
            this.TLPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TLPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLPnl.Size = new System.Drawing.Size(1387, 50);
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
            this.CloseButton.Location = new System.Drawing.Point(1339, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 29);
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
            this.MinimizeButton.Location = new System.Drawing.Point(1289, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(44, 29);
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
            // TLPnlMenu
            // 
            this.TLPnlMenu.ColumnCount = 1;
            this.TLPnlMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPnlMenu.Controls.Add(this.DeviceCommanderButton, 0, 2);
            this.TLPnlMenu.Controls.Add(this.StartButton, 0, 0);
            this.TLPnlMenu.Controls.Add(this.StopButton, 0, 1);
            this.TLPnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.TLPnlMenu.Location = new System.Drawing.Point(0, 50);
            this.TLPnlMenu.Name = "TLPnlMenu";
            this.TLPnlMenu.RowCount = 3;
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPnlMenu.Size = new System.Drawing.Size(92, 650);
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
            this.DeviceCommanderButton.Size = new System.Drawing.Size(86, 464);
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
            this.PnlNav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlNav.Location = new System.Drawing.Point(13, 57);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(4, 70);
            this.PnlNav.TabIndex = 3;
            // 
            // PnFill
            // 
            this.PnFill.Controls.Add(this.PnPage);
            this.PnFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnFill.Location = new System.Drawing.Point(92, 50);
            this.PnFill.Name = "PnFill";
            this.PnFill.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.PnFill.Size = new System.Drawing.Size(1295, 650);
            this.PnFill.TabIndex = 4;
            // 
            // PnPage
            // 
            this.PnPage.BackColor = System.Drawing.Color.White;
            this.PnPage.Controls.Add(this.CommandPanel);
            this.PnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnPage.Location = new System.Drawing.Point(0, 0);
            this.PnPage.Name = "PnPage";
            this.PnPage.Size = new System.Drawing.Size(1275, 630);
            this.PnPage.TabIndex = 0;
            // 
            // CommandPanel
            // 
            this.CommandPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(248)))));
            this.CommandPanel.Controls.Add(this.tableLayoutPanel1);
            this.CommandPanel.Controls.Add(this.panel2);
            this.CommandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CommandPanel.Location = new System.Drawing.Point(0, 0);
            this.CommandPanel.Name = "CommandPanel";
            this.CommandPanel.Size = new System.Drawing.Size(198, 630);
            this.CommandPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SendButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.DeviceNameInfo, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.85431F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.1457F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 463);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // SendButton
            // 
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Image = ((System.Drawing.Image)(resources.GetObject("SendButton.Image")));
            this.SendButton.Location = new System.Drawing.Point(3, 397);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(194, 63);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // DeviceNameInfo
            // 
            this.DeviceNameInfo.BackColor = System.Drawing.Color.White;
            this.DeviceNameInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeviceNameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceNameInfo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeviceNameInfo.Location = new System.Drawing.Point(3, 3);
            this.DeviceNameInfo.Name = "DeviceNameInfo";
            this.DeviceNameInfo.ReadOnly = true;
            this.DeviceNameInfo.Size = new System.Drawing.Size(194, 27);
            this.DeviceNameInfo.TabIndex = 0;
            this.DeviceNameInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.CommandPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private Panel PnPage;
        private Bunifu.Framework.UI.BunifuElipse ElipsePnl;
        private Panel CommandPanel;
        private Panel panel2;
        private Button DisconnectButton;
        private Button PingButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox DeviceNameInfo;
        private Button SendButton;
        private System.Windows.Forms.Timer Timer;
    }
}