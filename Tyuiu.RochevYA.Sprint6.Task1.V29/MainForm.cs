using Tyuiu.RochevYA.Sprint6.Task1.V29.Lib;
namespace Tyuiu.RochevYA.Sprint6.Task1.V29
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
            label1.Text = string.Join("\n", ds.GetMassFunction(num1, num2).Select(x => x.ToString()));
        }
    }
}
