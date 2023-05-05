using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.Services.MouseService
{
    public static class MouseService 
    {
        public static async Task<(Point, Point)> MoveWindow(bool mouseDown, Point lastMousePosition, Point mousePosition, Point location)
        {
            if (mouseDown)
            {
                Point currentMousePosition = mousePosition;
                int deltaX = currentMousePosition.X - lastMousePosition.X;
                int deltaY = currentMousePosition.Y - lastMousePosition.Y;
                Point newWindowPosition = new Point(location.X + deltaX, location.Y + deltaY);
                return (newWindowPosition, currentMousePosition);
            }
            return (location, lastMousePosition);
        }
    }
}
