using DeviceCommander.Services.ButtonServices;
using DeviceCommander.Services.MouseService;

namespace DeviceCommander
{
    public partial class MainWindow : Form
    {
        private bool mouseDown;
        private Point lastMousePosition;

        public MainWindow()
        {
            InitializeComponent();
            CommandPanel.Width = 0;
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

        private void StartButton_Click(object sender, EventArgs e)
        {
            ButtonNavigator.SelectBtn((Button)sender, PnlNav);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ButtonNavigator.SelectBtn((Button)sender, PnlNav);
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
    }

}