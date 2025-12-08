using Tyuiu.RochevYA.Sprint6.Task3.V18.Lib;
namespace Tyuiu.RochevYA.Sprint6.Task3.V18
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void resBut_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] motrix = { {-19,-19,1,18,7 }, {5,3,-4,-6,-12 }, {-15,6,2,2,-14 }, {-9,-10,15,-5,-6 }, {-13,-15,-9,7,1 } };

            int[,] matrix = ds.Calculate(motrix);
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Очистка существующих данных
            GridTable.Rows.Clear();

            // Добавление строк и данных
            for (int i = 0; i < rows; i++)
            {
                // Добавляем новую строку
                int rowIndex = GridTable.Rows.Add();

                // Заполняем ячейки строки
                for (int j = 0; j < cols; j++)
                {
                    GridTable.Rows[rowIndex].Cells[j].Value = matrix[i, j];
                }
            }
        }
    }
}
