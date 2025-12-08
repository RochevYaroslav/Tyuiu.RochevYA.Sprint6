namespace Tyuiu.RochevYA.Sprint6.Task5.V25
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
            Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            GridTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Chart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridTable).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 380);
            button1.Name = "button1";
            button1.Size = new Size(196, 63);
            button1.TabIndex = 0;
            button1.Text = "Press me :}";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Chart
            // 
            chartArea2.Name = "ChartArea1";
            Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            Chart.Legends.Add(legend2);
            Chart.Location = new Point(266, 0);
            Chart.Name = "Chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            Chart.Series.Add(series2);
            Chart.Size = new Size(534, 443);
            Chart.TabIndex = 1;
            Chart.Text = "chart1";
            // 
            // GridTable
            // 
            GridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridTable.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            GridTable.Location = new Point(3, 2);
            GridTable.Name = "GridTable";
            GridTable.RowHeadersWidth = 5;
            GridTable.Size = new Size(257, 372);
            GridTable.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Value";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GridTable);
            Controls.Add(Chart);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Chart).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private DataGridView GridTable;
        private DataGridViewTextBoxColumn Column1;
    }
}
