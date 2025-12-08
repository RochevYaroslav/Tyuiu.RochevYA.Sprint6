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
            string text = "-17\r\n0\r\n12\r\n-14,32\r\n5\r\n-7,84\r\n12,89\r\n-1,57\r\n-3,64\r\n-13,26\r\n-8,91\r\n-17,77\r\n35\r\n-9\r\n13,83\r\n12,76\r\n8,86\r\n0\r\n-1,49\r\n-7\r\n";
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
