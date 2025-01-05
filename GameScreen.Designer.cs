
namespace SnakeGame
{
    partial class GameScreen
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
            components = new System.ComponentModel.Container();
            pbCanvas = new PictureBox();
            labelScore = new Label();
            labelCurrentScore = new Label();
            labelGameOver = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbCanvas).BeginInit();
            SuspendLayout();
            // 
            // pbCanvas
            // 
            pbCanvas.BackColor = Color.Yellow;
            pbCanvas.Location = new Point(13, 13);
            pbCanvas.Name = "pbCanvas";
            pbCanvas.Size = new Size(541, 560);
            pbCanvas.TabIndex = 0;
            pbCanvas.TabStop = false;
            pbCanvas.Click += pictureBox1_Click;
            pbCanvas.Paint += updateGraphics;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelScore.Location = new Point(614, 55);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(97, 38);
            labelScore.TabIndex = 1;
            labelScore.Text = "Score:";
            labelScore.Click += label1_Click;
            // 
            // labelCurrentScore
            // 
            labelCurrentScore.AutoSize = true;
            labelCurrentScore.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCurrentScore.Location = new Point(717, 55);
            labelCurrentScore.Name = "labelCurrentScore";
            labelCurrentScore.Size = new Size(49, 38);
            labelCurrentScore.TabIndex = 2;
            labelCurrentScore.Text = "00";
            // 
            // labelGameOver
            // 
            labelGameOver.AutoSize = true;
            labelGameOver.BackColor = SystemColors.ControlText;
            labelGameOver.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelGameOver.ForeColor = Color.Yellow;
            labelGameOver.Location = new Point(215, 256);
            labelGameOver.Name = "labelGameOver";
            labelGameOver.Size = new Size(128, 38);
            labelGameOver.TabIndex = 3;
            labelGameOver.Text = "End Text";
            labelGameOver.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(903, 614);
            Controls.Add(labelGameOver);
            Controls.Add(labelCurrentScore);
            Controls.Add(labelScore);
            Controls.Add(pbCanvas);
            Name = "Form1";
            Text = "Snake Game";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)pbCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private PictureBox pbCanvas;
        private Label labelScore;
        private Label labelCurrentScore;
        private Label labelGameOver;
        private System.Windows.Forms.Timer gameTimer;
    }
}
