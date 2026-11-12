
using piskvorky.Tridy;

namespace piskvorky
{
    public partial class GameForm : Form
    {
        private readonly Game game;
        private readonly TableLayoutPanel grid;

        public GameForm(int size)
        {
            InitializeComponent();

            game = new Game(size);

            label1.Text = "Na tahu: Hráč 1 (X)";

            grid = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = size,
                ColumnCount = size,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                AutoSize = false,
                Margin = new Padding(0),
                Padding = new Padding(0),
            };

            boardPanel.Controls.Add(grid);

            CreateBoard(size);
        }

        private void CreateBoard(int size)
        {

            grid.ColumnStyles.Clear();
            grid.RowStyles.Clear();
            for (int i = 0; i < size; i++)
            {
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / size));

                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / size));
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Button button = new Button
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(0),
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Segoe UI", 14, FontStyle.Bold),
                        Tag = new Point(col, row),
                        BackColor = Color.White,
                    };

                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.BorderColor = Color.LightGray;
                    button.Click += Cell_Click;

                    grid.Controls.Add(button, col, row);
                }
            }
        }

        private void Cell_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
                return;

            Point position = (Point)button.Tag;

            int row = position.Y;
            int col = position.X;

            Player player = game.CurrentPlayer;

            if (!game.MakeMove(row, col))
                return;

            button.Text = player.Symbol.ToString();

            button.ForeColor = player.Symbol == Symbol.X ? Color.Blue : Color.Red;

            if (game.Winner != null)
            {
                label1.Text = $"Vyhrál {game.Winner.Name}!";

                MessageBox.Show($"{game.Winner.Name} vyhrál!", "Konec hry");
                return;
            }

            if (game.IsDraw)
            {
                label1.Text = "Remíza!";
                MessageBox.Show("Hra skončila remízou.", "Konec hry");
                return;
            }

            label1.Text = $"Na tahu: {game.CurrentPlayer.Name} " + $"({game.CurrentPlayer.Symbol})";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
