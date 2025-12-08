namespace Tyuiu.RochevYA.Sprint6.Task4.V10
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            button1 = new Button();
            button2 = new Button();
            GridTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)GridTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Chart).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 369);
            button1.Name = "button1";
            button1.Size = new Size(149, 51);
            button1.TabIndex = 0;
            button1.Text = "Click on me";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(167, 369);
            button2.Name = "button2";
            button2.Size = new Size(103, 51);
            button2.TabIndex = 1;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GridTable
            // 
            GridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridTable.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            GridTable.Location = new Point(12, 9);
            GridTable.Name = "GridTable";
            GridTable.RowHeadersWidth = 5;
            GridTable.Size = new Size(258, 339);
            GridTable.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "N";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Value";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Chart
            // 
            chartArea2.Name = "ChartArea1";
            Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            Chart.Legends.Add(legend2);
            Chart.Location = new Point(288, 9);
            Chart.Name = "Chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            Chart.Series.Add(series2);
            Chart.Size = new Size(550, 429);
            Chart.TabIndex = 5;
            Chart.Text = "chart1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 450);
            Controls.Add(Chart);
            Controls.Add(GridTable);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)Chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView GridTable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
    }
}
