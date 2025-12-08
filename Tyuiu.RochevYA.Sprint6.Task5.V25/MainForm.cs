using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.RochevYA.Sprint6.Task5.V25.Lib;
namespace Tyuiu.RochevYA.Sprint6.Task5.V25
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = @"C:\Users\ярослав\source\repos\Files for Sprint6\Sprint6Task5\InPutDataFileTask5V25.txt";
            DataService ds = new DataService();
            double[] resluts = ds.LoadFromDataFile(text);

            for (int i = 0; i < resluts.Length; i++)
            {
                GridTable.Rows.Add(Convert.ToString(resluts[i]));
                Series series = Chart.Series.Add(Convert.ToString(1 + i));
                series.Points.Add(resluts[i]);
            }
        }
    }
}
