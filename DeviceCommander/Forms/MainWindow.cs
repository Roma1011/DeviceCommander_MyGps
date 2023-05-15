using DeviceCommander.Helper_Methods.Socket;
using DeviceCommander.Services.ButtonServices;
using DeviceCommander.Services.DataGridServices;
using DeviceCommander.Services.MouseService;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using Timer = System.Threading.Timer;

namespace DeviceCommander
{
    public partial class MainWindow : Form
    {
        private bool mouseDown;
        private Point lastMousePosition;
        //=====================================================================
        ConfirmConnection confirm = new ConfirmConnection();
        ReceiveIncomingSocket recive =new ReceiveIncomingSocket();
        private System.Windows.Forms.Timer timer;
        //=====================================================================
        static CancellationTokenSource cts = new CancellationTokenSource();
        //=====================================================================
        public MainWindow()
        {
            InitializeComponent();
            CommandPanel.Width = 0;
            StopButton.Enabled=false;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50; // set interval to 5 seconds
            timer.Tick += Timer_Tick2;
            HelperProperties.Properties.token = cts.Token;
        }
        void AddForm(Form frm, Button btn)
        {
            switch (btn.Name)
            {
                case "StartButton":

                    break;
                case "StopButton":

                    break;
                case "ConectedDeviceButton":

                    break;
                default:
                    break;
            }

            AddOwnedForm(frm);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }

        private async void TLPnl_MouseMove(object sender, MouseEventArgs e)
        {
            (Point newWindowPosition, Point updatedLastMousePosition) =
                await MouseService.MoveWindow(mouseDown, lastMousePosition, MousePosition, this.Location);
            this.Location = newWindowPosition;
            lastMousePosition = updatedLastMousePosition;
        }

        private void TLPnl_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastMousePosition = MousePosition;
        }

        private void TLPnl_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void SearchBar_MouseClick(object sender, MouseEventArgs e)
        {
            LineSearch.Visible = true;
            SearchBar.BackColor = Color.FromArgb(139, 199, 255);
        }

        private void SearchBar_Leave(object sender, EventArgs e)
        {
            LineSearch.Visible = false;
            SearchBar.BackColor = Color.FromArgb(99, 180, 255);
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(async () => PreparationSocket.CreateListenerSocket(DataGrid));
            ButtonNavigator.SelectBtn((Button)sender, PnlNav);
            StopButton.Enabled = true;
            StartButton.Enabled = false;
        }
        private async void StopButton_Click(object sender, EventArgs e)
        {
            cts.Cancel();

            //timer.Stop();
            ClearSocketData.CloseConnection();

            StartButton.Enabled = true;
            StopButton.Enabled = false;
            ButtonNavigator.SelectBtn((Button)sender, PnlNav);

            //// Create a new cancellation token source to use for the next time the StartButton is clicked
            cts = new CancellationTokenSource();
        }

        private async void DeviceCommander_Click(object sender, EventArgs e)
        {
            ButtonNavigator.SelectBtn((Button)sender, PnlNav);
            Timer.Start();
        }

        private async void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private async void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            if (CommandPanel.Width >= 196)
                for (int i = 0; i < 10; i++)
                    CommandPanel.Width = CommandPanel.Width - 20;


            else
                for (int i = 0; i < 10; i++)
                    CommandPanel.Width = CommandPanel.Width + 20;
            Timer.Stop();
        }
        private async void Timer_Tick2(object sender, EventArgs e)
        {
            //await ConnectionCheck.IsConnected(DataGrid);
        }
        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  

        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }
    }

}