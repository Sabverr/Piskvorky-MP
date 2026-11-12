namespace piskvorky
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            boardPanel = new System.Windows.Forms.Panel();
            backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (System.Byte)238);
            label1.Location = new System.Drawing.Point(290, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(217, 31);
            label1.TabIndex = 0;
            label1.Text = "Na tahu: Hráč 1 (X)";
            // 
            // boardPanel
            // 
            boardPanel.AutoScroll = true;
            boardPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            boardPanel.Location = new System.Drawing.Point(133, 95);
            boardPanel.Name = "boardPanel";
            boardPanel.Size = new System.Drawing.Size(600, 600);
            boardPanel.TabIndex = 1;
            // 
            // backButton
            // 
            backButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            backButton.Location = new System.Drawing.Point(0, 715);
            backButton.Name = "backButton";
            backButton.Size = new System.Drawing.Size(857, 29);
            backButton.TabIndex = 2;
            backButton.Text = "Zpět";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += this.backButton_Click;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 744);
            this.Controls.Add(backButton);
            this.Controls.Add(boardPanel);
            this.Controls.Add(label1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel boardPanel;
        private Button backButton;
    }
}