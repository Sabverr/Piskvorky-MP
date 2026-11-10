namespace piskvorky
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
            playButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.Font = new Font("Segoe UI", 13F);
            playButton.Location = new Point(273, 110);
            playButton.Name = "playButton";
            playButton.Size = new Size(226, 62);
            playButton.TabIndex = 0;
            playButton.Text = "Hrát";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 13F);
            exitButton.Location = new Point(273, 226);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(226, 62);
            exitButton.TabIndex = 1;
            exitButton.Text = "Ukončit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(playButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button playButton;
        private Button exitButton;
    }
}
