using Tyuiu.RochevYA.Sprint6.Task0.V25.Lib;

namespace Tyuiu.RochevYA.Sprint6.Task0.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void resButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(getNumber.Text.Trim());
            DataService ds = new DataService();
            resLabel.Text = ds.Calculate(number).ToString();
        }
    }
}
