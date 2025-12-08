using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.RochevYA.Sprint6.Task4.V10.Lib;
namespace Tyuiu.RochevYA.Sprint6.Task4.V10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            double[] values = ds.GetMassFunction(-5, 5);

            for (int i = 0; i < values.Length; i++)
            {
                GridTable.Rows.Add(Convert.ToString(-5 + i), Convert.ToString(values[i]));
                Series series = Chart.Series.Add(Convert.ToString(-5 + i));
                series.Points.Add(values[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            double[] values = ds.GetMassFunction(-5, 5);

            string result = string.Join("\n", values);
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask4V10.txt");
            File.WriteAllText(outputPath, result);
        }
    }
}
