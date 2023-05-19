using DeviceCommander.Helper_Methods.Socket;
using DeviceCommander.Services.ButtonServices;
using DeviceCommander.Services.MouseService;
using ListeningIMEI;
using System.Text;
using Timer = System.Threading.Timer;

namespace DeviceCommander
{
    public partial class MainWindow : Form
    {
        private bool mouseDown;
        private Point lastMousePosition;
        //=====================================================================
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
            timer.Interval = 5000; // set interval to 5 seconds
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
            timer.Start();
            ButtonNavigator.SelectBtn((Button)sender, PnlNav);
            StopButton.Enabled = true;
            StartButton.Enabled = false;
        }
        private async void StopButton_Click(object sender, EventArgs e)
        {
            cts.Cancel();

            timer.Stop();
            ClearSocketData.CloseConnection();

            StartButton.Enabled = true;
            StopButton.Enabled = false;
            ButtonNavigator.SelectBtn((Button)sender, PnlNav);

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
            await ConnectionCheck.IsConnected(DataGrid);
        }
        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  

        }
        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void RestartRadio_CheckedChanged(object sender, EventArgs e)
        {
            IntervalTextBox.Hide();
            Panel_IP_PORT.Hide();
            K_SPanel.Hide();
            PanelManagment.Hide();
        }
        private void SetIntervalRadio_CheckedChanged(object sender, EventArgs e)
        {
            IntervalTextBox.Show();
            Panel_IP_PORT.Hide();
            PanelManagment.Hide();
            K_SPanel.Hide();
        }
        private void IP_PortRadio_CheckedChanged(object sender, EventArgs e)
        {
            IntervalTextBox.Hide();
            PanelManagment.Hide();
            K_SPanel.Hide();
            Panel_IP_PORT.Show();
        }
        private void DeviceManagmentRadio_CheckedChanged(object sender, EventArgs e)
        {
            IntervalTextBox.Hide();
            Panel_IP_PORT.Hide();
            PanelManagment.Show();
            K_SPanel.Show();
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            DateTime ntp = NtpDateclass.GetNetworkTime();
            var utcTime1 = DateTime.SpecifyKind(ntp, DateTimeKind.Utc);
            DateTimeOffset utcTime2 = utcTime1;
            var unixDate = utcTime2.ToUnixTimeSeconds();
            var dateToHex = unixDate.ToString("X8");
            StringBuilder stringBuilder = new StringBuilder("cmd_");
            stringBuilder.Append(dateToHex);

            if (DataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGrid.SelectedRows[0];
                string selectedImei = selectedRow.Cells["Imei"].Value.ToString();
                if (RestartRadio.Checked)
                {
                    stringBuilder.Append("_restart");
                    string command = stringBuilder.ToString();
                    bool comandResult=await DeviceCommander(selectedImei, command);
                }
                if (SetIntervalRadio.Checked)
                {
                    stringBuilder.Append($"_setspeed {IntervalTextBox.Text}");
                    string command = stringBuilder.ToString();
                    bool comandResult = await DeviceCommander(selectedImei, command);
                }
                if (IP_PortRadio.Checked)
                {
                    stringBuilder.Append($"_setipports {Primary.Text}:{Primary_Port.Text}/{Spare.Text}:{Spare_Port.Text}");
                    string command = stringBuilder.ToString();
                    bool comandResult = await DeviceCommander(selectedImei, command);
                }
                if (DeviceManagmentRadio.Checked)
                {
                    bool k1Checked = K1Checkbox.Checked;
                    bool k2Checked = K2CheckBox.Checked;
                    bool k3Checked = K3Checkbox.Checked;

                    if ((k1Checked && !k2Checked && !k3Checked) || (!k1Checked && k2Checked && !k3Checked) || (!k1Checked && !k2Checked && k3Checked) ||
                        (k1Checked && k2Checked && !k3Checked) || (k1Checked && !k2Checked && k3Checked) || (k1Checked && k2Checked && k3Checked))
                    {
                        int[,]checkedResult=ExecuteCode(k1Checked, k2Checked, k3Checked);

                        stringBuilder.Append($"_Kontactors {checkedResult[0, 0]}{checkedResult[1, 0]}{checkedResult[2, 0]}3");
                        string command = stringBuilder.ToString();
                        bool comandResult = await DeviceCommander(selectedImei, command);
                    }
                }

            }
            else
            {

            }
        }

        private async Task<bool> DeviceCommander(string identificationImei,string command)
        {
            var selectedItem = HelperProperties.Properties.IncomingData.FirstOrDefault(item => item.Item2 == identificationImei).Item1;
            if (selectedItem != default)
            {
                selectedItem.Send(Encoding.UTF8.GetBytes(command));
                return true;
            }
            return false;
        }
        int[,] ExecuteCode(bool k1, bool k2, bool k3)
        {
            int[,] whichK_IsChecked= new int[3,4];
            if (TurnOffRadio.Checked)
            {
                whichK_IsChecked[0, 0] = k1 ? 0 : 3;
                whichK_IsChecked[1, 0]= k2 ? 0 : 3;
                whichK_IsChecked[2, 0] = k3 ? 0 : 3;
            }
            if (TurnOnRadio.Checked)
            {
                whichK_IsChecked[0, 0] = k1 ? 1 : 3;
                whichK_IsChecked[1, 0] = k2 ? 1 : 3;
                whichK_IsChecked[2, 0] = k3 ? 1 : 3;
            }
            if (ResetShedule.Checked)
            {
                whichK_IsChecked[0, 0] = k1 ? 2 : 3;
                whichK_IsChecked[1, 0] = k2 ? 2 : 3;
                whichK_IsChecked[2, 0] = k3 ? 2 : 3;
            }
            return whichK_IsChecked;
        }
    }

}