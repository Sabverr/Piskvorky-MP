namespace piskvorky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            using (SizeForm sizeForm = new SizeForm())
            {
                if (sizeForm.ShowDialog(this) == DialogResult.OK)
                {
                    int size = sizeForm.SelectedSize;

                    using (GameForm gameForm = new GameForm(size))
                    {
                        Hide();

                        try
                        {
                            gameForm.ShowDialog();
                        }
                        finally
                        {
                            Show();
                        }
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
