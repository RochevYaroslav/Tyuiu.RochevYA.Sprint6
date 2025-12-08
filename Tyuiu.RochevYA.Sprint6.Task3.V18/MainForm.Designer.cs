namespace Tyuiu.RochevYA.Sprint6.Task3.V18
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
            GridTable = new DataGridView();
            nm1 = new DataGridViewTextBoxColumn();
            nm2 = new DataGridViewTextBoxColumn();
            nm3 = new DataGridViewTextBoxColumn();
            nm4 = new DataGridViewTextBoxColumn();
            nm5 = new DataGridViewTextBoxColumn();
            resBut = new Button();
            ((System.ComponentModel.ISupportInitialize)GridTable).BeginInit();
            SuspendLayout();
            // 
            // GridTable
            // 
            GridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridTable.Columns.AddRange(new DataGridViewColumn[] { nm1, nm2, nm3, nm4, nm5 });
            GridTable.Location = new Point(225, 12);
            GridTable.Name = "GridTable";
            GridTable.RowHeadersWidth = 4;
            GridTable.Size = new Size(382, 342);
            GridTable.TabIndex = 0;
            // 
            // nm1
            // 
            nm1.FillWeight = 50F;
            nm1.HeaderText = "1";
            nm1.MinimumWidth = 6;
            nm1.Name = "nm1";
            nm1.Width = 75;
            // 
            // nm2
            // 
            nm2.HeaderText = "2";
            nm2.MinimumWidth = 6;
            nm2.Name = "nm2";
            nm2.Width = 75;
            // 
            // nm3
            // 
            nm3.HeaderText = "3";
            nm3.MinimumWidth = 6;
            nm3.Name = "nm3";
            nm3.Width = 75;
            // 
            // nm4
            // 
            nm4.HeaderText = "4";
            nm4.MinimumWidth = 6;
            nm4.Name = "nm4";
            nm4.Width = 75;
            // 
            // nm5
            // 
            nm5.HeaderText = "5";
            nm5.MinimumWidth = 6;
            nm5.Name = "nm5";
            nm5.Width = 75;
            // 
            // resBut
            // 
            resBut.Location = new Point(286, 381);
            resBut.Name = "resBut";
            resBut.Size = new Size(252, 45);
            resBut.TabIndex = 1;
            resBut.Text = "Press me :_";
            resBut.UseVisualStyleBackColor = true;
            resBut.Click += resBut_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resBut);
            Controls.Add(GridTable);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridTable;
        private Button resBut;
        private DataGridViewTextBoxColumn nm1;
        private DataGridViewTextBoxColumn nm2;
        private DataGridViewTextBoxColumn nm3;
        private DataGridViewTextBoxColumn nm4;
        private DataGridViewTextBoxColumn nm5;
    }
}
