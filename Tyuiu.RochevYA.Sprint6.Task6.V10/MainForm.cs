using Tyuiu.RochevYA.Sprint6.Task6.V10.Lib;
namespace Tyuiu.RochevYA.Sprint6.Task6.V10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Найдите файл InPutFileTask6V10.txt";
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                openFileDialog.FileName = "InPutFileTask6V10.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = openFileDialog.FileName;
                    DataService ds = new DataService();
                    MainLabel.Text = ds.CollectTextFromFile(selectedPath);
                }
            }
        }
    }
}
