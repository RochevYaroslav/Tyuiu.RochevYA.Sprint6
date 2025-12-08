using Tyuiu.RochevYA.Sprint6.Task2.V12.Lib;
namespace Tyuiu.RochevYA.Sprint6.Task2.V12
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(numb1.Text.Trim());
            int num2 = Convert.ToInt32(numb2.Text.Trim());
            DataService ds = new DataService();
            double[] values = ds.GetMassFunction(num1, num2);

            for (int i = 0; i < values.Length; i++)
            {
                GridTable.Rows.Add(Convert.ToString(num1+i), Convert.ToString(values[i]));
            }
        }
    }
}
