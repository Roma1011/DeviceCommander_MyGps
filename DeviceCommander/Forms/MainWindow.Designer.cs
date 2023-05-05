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
            this.TLPnlMenu = new System.Windows.Forms.TableLayoutPanel();
            this.DeviceCommander = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PnlNav = new System.Windows.Forms.Label();
            this.PnFill = new System.Windows.Forms.Panel();
            this.PnPage = new System.Windows.Forms.Panel();
            this.ElipsePnl = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TLPnl.SuspendLayout();
            this.PNLSearch.SuspendLayout();
            this.TLPnlMenu.SuspendLayout();
            this.PnFill.SuspendLayout();
            this.PnPage.SuspendLayout();
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
            this.TLPnlMenu.Controls.Add(this.DeviceCommander, 0, 2);
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
            // DeviceCommander
            // 
            this.DeviceCommander.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceCommander.FlatAppearance.BorderSize = 0;
            this.DeviceCommander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeviceCommander.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeviceCommander.ForeColor = System.Drawing.Color.Black;
            this.DeviceCommander.Image = ((System.Drawing.Image)(resources.GetObject("DeviceCommander.Image")));
            this.DeviceCommander.Location = new System.Drawing.Point(3, 183);
            this.DeviceCommander.Name = "DeviceCommander";
            this.DeviceCommander.Size = new System.Drawing.Size(86, 464);
            this.DeviceCommander.TabIndex = 2;
            this.DeviceCommander.Text = "Command";
            this.DeviceCommander.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeviceCommander.UseVisualStyleBackColor = true;
            this.DeviceCommander.Click += new System.EventHandler(this.DeviceCommander_Click);
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
            this.PnPage.Controls.Add(this.panel1);
            this.PnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnPage.Location = new System.Drawing.Point(0, 0);
            this.PnPage.Name = "PnPage";
            this.PnPage.Size = new System.Drawing.Size(1275, 630);
            this.PnPage.TabIndex = 0;
            // 
            // ElipsePnl
            // 
            this.ElipsePnl.ElipseRadius = 15;
            this.ElipsePnl.TargetControl = this.PNLSearch;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 630);
            this.panel1.TabIndex = 0;
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
        private Button DeviceCommander;
        private Button StopButton;
        private Label PnlNav;
        private Panel PnFill;
        private Panel PnPage;
        private Bunifu.Framework.UI.BunifuElipse ElipsePnl;
        private Panel panel1;
    }
}