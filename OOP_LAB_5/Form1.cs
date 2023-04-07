using System.Runtime.InteropServices;

namespace OOP_LAB_5
{
    public partial class Form1 : Form
    {
        private List<Airport> _airports;

        public Form1()
        {
            InitializeComponent();
            _airports = new List<Airport>();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text,
                    String caption, uint type);

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateObjectBtn_Click(object sender, EventArgs e)
        {
            IAirportBuilder airportBuilder;
            if (MilitaryRadioBtn.Checked)
            {
                airportBuilder = new MilitaryAirportBuilder();
            }
            else
            {
                airportBuilder = new CommercialAirportBuilder();
            }
            Airport airport = airportBuilder.BuildAirport(NameInput.Text, CodeIATAInput.Text)
                .BuildEmployees((int)EmployeeNumberInput.Value)
                .BuildPlanes((int)PlanesNumberInput.Value)
                .BuildMaintenancePrice((decimal)MaintananceCostInput.Value)
                .GetResult();
            _airports.Add(airport);
        }

        private void ClearOutputBtn_Click(object sender, EventArgs e)
        {
            OutputWindow.Clear();
        }

        private void PrintObjectsBtn_Click(object sender, EventArgs e)
        {
            foreach (var airport in _airports)
            {
                string str = airport.ToString() + "\r" + "\n";
                OutputWindow.Text += str;
            }
        }

        private void ClearObjectsListBtn_Click(object sender, EventArgs e)
        {
            _airports.Clear();
        }
    }
}