using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceCommander.Services.DataGridServices
{
    public class ReflectionGridData
    {

        public object padlock = new object();


        public static async Task AddData(DataGridView dataGrid, string[] item)
        {
            bool found = false;

            dataGrid.Invoke(new Action(() =>
            {
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    bool match = true;
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (row.Cells[i].Value == null || row.Cells[i].Value.ToString() != item[i])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    dataGrid.Rows.Add(item);
            }));
        }
    }
}