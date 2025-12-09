using System.Windows.Forms;
using Tyuiu.RochevYA.Sprint6.Task7.V28.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.RochevYA.Sprint6.Task7.V28
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Найдите файл InPutFileTask7V28.csv";
                openFileDialog.Filter = "(*.csv)|*.csv";
                openFileDialog.FileName = "InPutFileTask7V28.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = openFileDialog.FileName;
                    DataService ds = new DataService();
                    int[,] matrix = ds.GetMatrix(selectedPath);

                    GridTable.Rows.Clear();
                    GridTable.Columns.Clear();

                    
                    int rows = matrix.GetLength(0);
                    int cols = matrix.GetLength(1);

                    for (int j = 0; j < cols; j++)
                    {
                        GridTable.Columns.Add($"Column{j}", $"C{j + 1}");
                        GridTable.Columns[j].Width = 50;
                        GridTable.Columns[j].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    for (int i = 0; i < rows; i++)
                    {
                        int rowIndex = GridTable.Rows.Add();

                        for (int j = 0; j < cols; j++)
                        {
                            GridTable.Rows[rowIndex].Cells[j].Value = matrix[i, j];
                        }

         
                    }

                    GridTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV файлы (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.DefaultExt = "csv";
                saveDialog.Title = "Сохранить данные в CSV";
                saveDialog.OverwritePrompt = true;
                saveDialog.AddExtension = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> lines = new List<string>();

                    foreach (DataGridViewRow row in GridTable.Rows)
                    {
                        if (row.IsNewRow) continue;

                        List<string> values = new List<string>();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            values.Add(cell.Value?.ToString() ?? "");
                        }

                        lines.Add(string.Join(";", values));
                    }

                    File.WriteAllLines(saveDialog.FileName, lines);
                }

            }
        }
    }
}
