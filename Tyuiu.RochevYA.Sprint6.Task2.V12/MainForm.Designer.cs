namespace Tyuiu.RochevYA.Sprint6.Task2.V12
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
            numb1 = new TextBox();
            numb2 = new TextBox();
            button1 = new Button();
            GridTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)GridTable).BeginInit();
            SuspendLayout();
            // 
            // numb1
            // 
            numb1.Location = new Point(192, 334);
            numb1.Name = "numb1";
            numb1.Size = new Size(124, 27);
            numb1.TabIndex = 0;
            // 
            // numb2
            // 
            numb2.Location = new Point(322, 333);
            numb2.Name = "numb2";
            numb2.Size = new Size(133, 27);
            numb2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(191, 367);
            button1.Name = "button1";
            button1.Size = new Size(264, 45);
            button1.TabIndex = 2;
            button1.Text = "press me :^";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GridTable
            // 
            GridTable.AllowUserToAddRows = false;
            GridTable.AllowUserToDeleteRows = false;
            GridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridTable.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            GridTable.Location = new Point(122, 12);
            GridTable.Name = "GridTable";
            GridTable.ReadOnly = true;
            GridTable.RowHeadersWidth = 51;
            GridTable.Size = new Size(378, 319);
            GridTable.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Индекс";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Значение";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GridTable);
            Controls.Add(button1);
            Controls.Add(numb2);
            Controls.Add(numb1);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numb1;
        private TextBox numb2;
        private Button button1;
        private DataGridView GridTable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
