using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceCommander.Services.DataGridServices
{
    internal class SearchInDataGrid
    {
        public static async Task Search(DataGridView view, TextBox searchText)
        {
            string searchValue = searchText.Text;
            int rowIndex = 0;
            view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = true;
                foreach (DataGridViewRow row in view.Rows)
                {
                    if (row.Cells[rowIndex].Value.ToString().Contains(searchValue))
                    {
                        valueResult = false;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}