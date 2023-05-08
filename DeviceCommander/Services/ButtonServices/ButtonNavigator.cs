using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.Services.ButtonServices
{
    public class ButtonNavigator
    {
        public static async void SelectBtn(Button btn, Label navPanel)
        {
            switch (btn.Name)
            {
                case "StartButton":
                    navPanel.Location = new Point(navPanel.Location.X, btn.Location.Y + navPanel.Height - 16);
                    break;
                case "StopButton":
                    navPanel.Location = new Point(navPanel.Location.X, btn.Location.Y + navPanel.Height - 16);
                    break;
                case "DeviceCommanderButton":
                    navPanel.Location = new Point(navPanel.Location.X, btn.Location.Y + navPanel.Height * 2 + 10);
                    break;
                default:
                    break;
            }
        }
    }
}
