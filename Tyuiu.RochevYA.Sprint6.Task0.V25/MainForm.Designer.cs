namespace Tyuiu.RochevYA.Sprint6.Task0.V25
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            resButton = new Button();
            pictureBox1 = new PictureBox();
            getNumber = new TextBox();
            resLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // resButton
            // 
            resButton.Location = new Point(267, 313);
            resButton.Name = "resButton";
            resButton.Size = new Size(246, 58);
            resButton.TabIndex = 0;
            resButton.Text = "press me :)";
            resButton.UseVisualStyleBackColor = true;
            resButton.Click += resButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(233, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // getNumber
            // 
            getNumber.Location = new Point(302, 280);
            getNumber.Name = "getNumber";
            getNumber.Size = new Size(171, 27);
            getNumber.TabIndex = 2;
            getNumber.TextChanged += getNumber_TextChanged;
            // 
            // resLabel
            // 
            resLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            resLabel.Location = new Point(302, 233);
            resLabel.Name = "resLabel";
            resLabel.Size = new Size(171, 35);
            resLabel.TabIndex = 3;
            resLabel.Text = "Hello world";
            resLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resLabel);
            Controls.Add(getNumber);
            Controls.Add(pictureBox1);
            Controls.Add(resButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resButton;
        private PictureBox pictureBox1;
        private TextBox getNumber;
        private Label resLabel;
    }
}
