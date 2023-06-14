using DeviceCommander.Data;
using DeviceCommander.Data.Models;
using DeviceCommander.Helper_Methods.Files;
using DeviceCommander.Helper_Methods.Socket;
using DeviceCommander.Services.ButtonServices;
using DeviceCommander.Services.DataGridServices;
using DeviceCommander.Services.MouseService;
using ListeningIMEI;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Timer = System.Threading.Timer;
using System.Security.Policy;
using DeviceCommander.Helper_Methods.Data_Methods;

namespace DeviceCommander
{
    public partial class MainWindow : Form
    {
        Writer writer;
        Reader reader;
        private  static List<DeviceCommandModel> writerCommand = new List<DeviceCommandModel>();

        //=====================================================================
        private bool mouseDown;
        private Point lastMousePosition;
        //=====================================================================
        static CancellationTokenSource cts = new CancellationTokenSource();
        //=====================================================================
        public MainWindow()
        {
            InitializeComponent();
            CommandPanel.Width = 0;
            HistoryPanel.Width= 0;
            StopButton.Enabled=false;
            TimerForLoadHistory.Start();
            HelperProperties.Properties.token = cts.Token;
            writer=new Writer();
            reader=new Reader();
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

            TimerCheckConnect.Start();
            ButtonNavigator.SelectBtn((Button)sender, PnlNav);
            StopButton.Enabled = true;
            StartButton.Enabled = false;
        }
        private async void StopButton_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            TimerCheckConnect.Stop();
            await Task.Factory.StartNew(async () => ClearSocketData.CloseConnection(ref DataGrid));
            StartButton.Enabled = true;
            StopButton.Enabled = false;
            ButtonNavigator.SelectBtn((Button)sender, PnlNav);

            cts = new CancellationTokenSource();
            HelperProperties.Properties.token = new CancellationToken();
        }

        private async void DeviceCommander_Click(object sender, EventArgs e)
        {
            ButtonNavigator.SelectBtn((Button)sender, PnlNav);
            Timer.Start();
        }
        private void HistoryButton_Click(object sender, EventArgs e)
        {
            TimerForHistory.Start();
        }
        private async void CloseButton_Click(object sender, EventArgs e)
        {
            await Task.Factory.StartNew(async () => ClearSocketData.CloseConnection(ref DataGrid));
            Close();
        }

        private async void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private async void SearchBar_TextChanged(object sender, EventArgs e)
        {
            if(SearchBar.Text.Length>3)
                await SearchInDataGrid.Search(DataGrid, SearchBar);
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
           await ShowData.Show(DataGrid);
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
        private void TimerForHistory_Tick(object sender, EventArgs e)
        {
            if(HistoryPanel.Width >= 420)
                for (int i = 0; i < 10; i++)
                HistoryPanel.Width = HistoryPanel.Width - 42;


            else
                for (int i = 0; i < 10; i++)
                    HistoryPanel.Width = HistoryPanel.Width + 42;

            TimerForHistory.Stop();
        }
        private async void TimerCheckConnect_Tick(object sender, EventArgs e)
        {
            await ConnectionCheck.IsConnected(DataGrid);
        }
        private async void TimerForLoadHistory_Tick(object sender, EventArgs e)
        {
            //new Thread(() => reader.ReaderInFile(DeviceCommandGrid)).Start();
             await Task.Factory.StartNew(() => reader.ReaderInFile(DeviceCommandGrid));
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  

        }
        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void RestartRadio_CheckedChanged(object sender, EventArgs e)
        {
            OnOfPannel.Hide();
            IntervalTextBox.Hide();
            Panel_IP_PORT.Hide();
            K_SPanel.Hide();
            ManagmantPanel.Hide();
        }
        private void SetIntervalRadio_CheckedChanged(object sender, EventArgs e)
        {
            OnOfPannel.Hide();
            IntervalTextBox.Show();
            Panel_IP_PORT.Hide();
            ManagmantPanel.Hide();
            K_SPanel.Hide();
        }
        private void IP_PortRadio_CheckedChanged(object sender, EventArgs e)
        {
            OnOfPannel.Hide();
            IntervalTextBox.Hide();
            ManagmantPanel.Hide();
            K_SPanel.Hide();
            Panel_IP_PORT.Show();
        }
        private void DeviceManagmentRadio_CheckedChanged(object sender, EventArgs e)
        {
            OnOfPannel.Hide();
            IntervalTextBox.Hide();
            Panel_IP_PORT.Hide();
            ManagmantPanel.Show();
            K_SPanel.Show();
        }
        private void GraficRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OnOfPannel.Hide();
            IntervalTextBox.Hide();
            Panel_IP_PORT.Hide();
            ManagmantPanel.Hide();
            K_SPanel.Hide();
        }
        private void OnOffShiftRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            IntervalTextBox.Hide();
            Panel_IP_PORT.Hide();
            ManagmantPanel.Hide();
            K_SPanel.Hide();
            OnOfPannel.Show();
        }
        private async void SendButton_Click(object sender, EventArgs e)
        {
            List<string>imeiList=new List<string>();

            DateTime ntp = NtpDateclass.GetNetworkTime();
            var utcTime1 = DateTime.SpecifyKind(ntp, DateTimeKind.Utc);
            DateTimeOffset utcTime2 = utcTime1;
            var unixDate = utcTime2.ToUnixTimeSeconds();
            var dateToHex = unixDate.ToString("X8");
            StringBuilder stringBuilder = new StringBuilder("cmd_");
            stringBuilder.Append(dateToHex);


            if (DataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in DataGrid.SelectedRows)
                {
                    string selectedImei = selectedRow.Cells["Imei"].Value.ToString();
                    imeiList.Add(selectedImei);
                }

                if (RestartRadio.Checked)
                {
                    stringBuilder.Append("_restart");
                    string command = stringBuilder.ToString();
                    bool comandResult = await DeviceCommander(imeiList, command);
                }
                if (SetIntervalRadio.Checked)
                {
                    stringBuilder.Append($"_setspeed {IntervalTextBox.Text}");
                    string command = stringBuilder.ToString();
                    bool comandResult = await DeviceCommander(imeiList, command);
                }
                if (IP_PortRadio.Checked)
                {
                    stringBuilder.Append($"_setipports {Primary.Text}:{Primary_Port.Text}/{Spare.Text}:{Spare_Port.Text}");
                    string command = stringBuilder.ToString();
                    bool comandResult = await DeviceCommander(imeiList, command);
                }

                if (GraficRadioButton.Checked)
                {
                    stringBuilder.Append("_setgrafic>17:49,08:09;17:54,08:09;17:58,08:08;18:06,08:06;18:11,08:03;18:17,07:58;18:26,07:52;18:36,07:47;18:39,07:41;18:45,07:35;18:51,07:27;18:56,07:21;19:02,07:14;19:06,07:07;19:13,06:57;19:19,06:49;19:25,06:39;19:30,06:29;19:37,06:20;19:41,06:14;" +
                                         "19:48,06:04;19:53,05:57;19:59,05:49;20:02,05:41;20:10,05:35;20:15,05:29;20:20,05:23;20:25,05:18;20:29,05:14;20:34,05:11;20:39,05:08;20:43,05:05;20:46,05:05;20:48,05:05;20:48,05:06;20:48,05:07;20:48,05:10;20:47,05:13;20:45,05:16;20:41,05:21;20:37,05:25;20:31,05:31" +
                                         "20:25,05:36;20:19,05:41;20:12,05:46;20:05,05:52;19:57,05:57;19:49,06:02;19:45,06:08;19:31,06:13;19:22,06:19;19:14,06:24;19:05,06:29;18:56,06:34;18:47,06:40;18:39,06:46;18:31,06:52;18:23,06:57;18:16,07:02;18:07,07:10;18:01,07:16;17:55,07:22;17:50,07:29;" +
                                         "17:46,07:35;17:42,07:40;17:40,07:46;17:38,07:50;17:38,07:56;17:38,08:00;17:39,08:03;17:41,08:06;17:44,08:09<");
                    string command = stringBuilder.ToString();
                    bool comandResult = await DeviceCommander(imeiList, command);
                }
                if (OnOffShiftRadioButton.Checked)
                {
                    string date = "0";
                    string k1ShiftOn = ShiftTime.GetFormattedShiftTime(K1ShiftOn.Text, date);
                    string k1ShiftOff = ShiftTime.GetFormattedShiftTime(K1ShiftOf.Text, date);
                    string k2ShiftOn = ShiftTime.GetFormattedShiftTime(K2ShiftOn.Text, date);
                    string k2ShiftOff = ShiftTime.GetFormattedShiftTime(K2ShiftOf.Text, date);
                    string k3ShiftOn = ShiftTime.GetFormattedShiftTime(K3ShiftOn.Text, date);
                    string k3ShiftOff = ShiftTime.GetFormattedShiftTime(K3ShiftOf.Text, date);

                    stringBuilder.Append($"_user_ofsets " +
                                         $"{k1ShiftOn}{k1ShiftOff}/{k2ShiftOn}{k2ShiftOff}/{k3ShiftOn}{k3ShiftOff}/+00-00");

                    string command = stringBuilder.ToString();
                    bool comandResult = await DeviceCommander(imeiList, command);
                }
                if (DeviceManagmentRadio.Checked)
                {
                    bool k1Checked = K1Checkbox.Checked;
                    bool k2Checked = K2CheckBox.Checked;
                    bool k3Checked = K3Checkbox.Checked;

                    if ((k1Checked && !k2Checked && !k3Checked) || (!k1Checked && k2Checked && !k3Checked) || (!k1Checked && !k2Checked && k3Checked) ||
                        (k1Checked && k2Checked && !k3Checked) || (k1Checked && !k2Checked && k3Checked) || (k1Checked && k2Checked && k3Checked))
                    {
                        int[,] checkedResult = ExecuteCode(k1Checked, k2Checked, k3Checked);

                        stringBuilder.Append($"_Kontactors {checkedResult[0, 0]}{checkedResult[1, 0]}{checkedResult[2, 0]}3");
                        string command = stringBuilder.ToString();
                        bool comandResult = await DeviceCommander(imeiList, command);
                    }
                }
            }
            else
            {

            }
        }

        private async Task<bool> DeviceCommander(List<string> identificationImei,string command)
        {
            try
            {
                foreach (var item in identificationImei)
                {
                    var selectedItem = HelperProperties.Properties.IncomingData.FirstOrDefault(x => x.Item2 == item).Item1;
                    if (selectedItem != default)
                    {
                        try
                        {
                            await selectedItem.SendAsync(Encoding.UTF8.GetBytes(command));
                            if (command.Contains("restart"))
                            {
                                selectedItem.Close();
                            };
                        }
                        catch ( Exception ex)
                        {
                            MessageBox.Show("Sending Problem");
                            throw ex;
                        }
                        writerCommand.Add(new DeviceCommandModel { Imei = item, Command = command, Status = "OK" });
                    }
                    else
                        writerCommand.Add(new DeviceCommandModel { Imei = item, Command = command, Status = "Error",DataTime = DateTime.Now.ToString()});
                }
                MessageBox.Show("All Message Sented");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Exception");
                return false;
            }
            Task.Factory.StartNew(() => writer.InFile(writerCommand)).Wait();
            return true;
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