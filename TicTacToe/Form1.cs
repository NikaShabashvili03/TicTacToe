namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadOptions(object sender, EventArgs e)
        {
            OptionsScreen optionsWindow = new OptionsScreen();
            optionsWindow.Show();
            this.Hide();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();
            gameWindow.Show();
            this.Hide();

        }

        private void MenuScreenClose(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
