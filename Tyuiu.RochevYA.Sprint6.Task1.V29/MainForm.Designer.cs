namespace Tyuiu.RochevYA.Sprint6.Task1.V29
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
            button1 = new Button();
            numb1 = new TextBox();
            numb2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(311, 370);
            button1.Name = "button1";
            button1.Size = new Size(172, 61);
            button1.TabIndex = 0;
            button1.Text = "press me :0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numb1
            // 
            numb1.Location = new Point(273, 337);
            numb1.Name = "numb1";
            numb1.Size = new Size(121, 27);
            numb1.TabIndex = 1;
            // 
            // numb2
            // 
            numb2.Location = new Point(400, 337);
            numb2.Name = "numb2";
            numb2.Size = new Size(111, 27);
            numb2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(436, 325);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(numb2);
            Controls.Add(numb1);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox numb1;
        private TextBox numb2;
        private Label label1;
    }
}
