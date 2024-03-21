using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace TicTacToe
{
    public partial class GameScreen : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public GameScreen()
        {
            InitializeComponent();
        }

        public static int tableSize = 3;
        public double setTableSize(double size)
        {
            tableSize = (Int32)Math.Sqrt(size);
            buttons = new Button[tableSize, tableSize];
            return 0;
        }


        private bool playerXTurn = true;
        private int movesCount = 0;

        private Button[,] buttons = new Button[tableSize, tableSize];

        private Button resetGameBtn = new Button();

        private Label PlayerXStats = new Label();
        private Label PlayerOStats = new Label();
        private Label DrawStats = new Label();


        private Panel panel = new Panel();
        private Panel moveIndicator = new Panel();

        private void ResetGame()
        {
            movesCount = 0;
            playerXTurn = true;
            PlayerXStats.Text = "0";
            PlayerOStats.Text = "0";
            DrawStats.Text = "0";
            moveIndicator.Left = 25;
        }

        private void ResetButtons()
        {
            movesCount = 0;
            for (int i = 0; i < tableSize; i++)
            {
                for (int j = 0; j < tableSize; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }
        }
        private void initialPlayerXStats(Panel panel)
        {
            // Player X Panel
            Panel PPlayerX = new Panel();
            PPlayerX.Left = 25;
            PPlayerX.Top = 25;
            PPlayerX.Width = 100;
            PPlayerX.Height = 100;
            PPlayerX.BackColor = Color.FromArgb(72, 210, 254);
            PPlayerX.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PPlayerX.Width, PPlayerX.Height, 10, 10));
            panel.Controls.Add(PPlayerX);
            // Player X Label 1
            Label PlayerXTitle = new Label();
            PlayerXTitle.Text = "PLAYER X";
            PlayerXTitle.Left = (PPlayerX.Width - PlayerXTitle.Text.Length) / 4;
            PlayerXTitle.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerXTitle.Top = 30;
            PPlayerX.Controls.Add(PlayerXTitle);

            // Player X Label 2

            PlayerXStats.Text = "0";
            PlayerXStats.Left = ((PPlayerX.Width - PlayerXTitle.Text.Length) / 2) - 4;
            PlayerXStats.Top = 50;
            PlayerXStats.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PPlayerX.Controls.Add(PlayerXStats);
        }
        private void initialPlayerOStats(Panel panel)
        {
            // Player O Panel
            Panel PPlayerO = new Panel();
            PPlayerO.Left = (panel.Width - 100) - 25;
            PPlayerO.Top = 25;
            PPlayerO.Width = 100;
            PPlayerO.Height = 100;
            PPlayerO.BackColor = Color.FromArgb(226, 190, 0);
            PPlayerO.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PPlayerO.Width, PPlayerO.Height, 10, 10));
            panel.Controls.Add(PPlayerO);
            // Player O Label 1
            Label PlayerOTitle = new Label();
            PlayerOTitle.Text = "PLAYER O";
            PlayerOTitle.Left = (PPlayerO.Width - PlayerOTitle.Text.Length) / 4;
            PlayerOTitle.Top = 30;
            PlayerOTitle.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PPlayerO.Controls.Add(PlayerOTitle);

            // Player O Label 2

            PlayerOStats.Text = "0";
            PlayerOStats.Left = ((PPlayerO.Width - PlayerOTitle.Text.Length) / 2) - 4;
            PlayerOStats.Top = 50;
            PlayerOStats.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PPlayerO.Controls.Add(PlayerOStats);

        }
        private void initialDrawStats(Panel panel)
        {
            // Draw Panel
            Panel PDraw = new Panel();
            PDraw.Left = (panel.Width / 2) - 50;
            PDraw.Top = 25;
            PDraw.Width = 100;
            PDraw.Height = 100;
            PDraw.BackColor = Color.FromArgb(188, 219, 249);
            PDraw.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PDraw.Width, PDraw.Height, 10, 10));
            PDraw.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(PDraw);

            // Draw Label 1
            Label DrawTitle = new Label();
            DrawTitle.Text = "DRAW";
            DrawTitle.Left = (PDraw.Width - DrawTitle.Text.Length) / 3;
            DrawTitle.Top = 30;

            PDraw.Controls.Add(DrawTitle);

            // Draw Label 2
            DrawStats.Text = "0";
            DrawStats.Left = ((PDraw.Width - DrawTitle.Text.Length) / 2) - 10;
            DrawStats.Top = 50;
            DrawStats.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PDraw.Controls.Add(DrawStats);
        }

        private void initialLogo()
        {
            PictureBox tictactoe = new PictureBox();
            tictactoe.BackgroundImage = Properties.Resources.tic__tac_toe_;
            tictactoe.BackgroundImageLayout = ImageLayout.Stretch;
            tictactoe.Left = 0;
            tictactoe.Top = this.Height - 320;
            tictactoe.Name = "TicTacToeLogo";
            tictactoe.Size = new Size(282, 282);
            tictactoe.TabIndex = 1;
            tictactoe.TabStop = false;
            Controls.Add(tictactoe);
        }

        private void CreatorClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/NikaShabashvili03",
                UseShellExecute = true
            });
        }
        private void initialCreator()
        {
            Button creator = new Button();
            creator.Width = 100;
            creator.Height = 25;
            creator.Text = "Created by Nika";
            creator.Left = this.Width - 100 - 50;
            creator.Top = this.Height - 40 - 50;
            creator.FlatAppearance.BorderSize = 0;
            creator.BackColor = Color.FromArgb(151, 95, 177);
            creator.ForeColor = Color.FromArgb(43, 0, 64);
            creator.FlatStyle = FlatStyle.Flat;
            creator.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, creator.Width, creator.Height, 10, 10));
            creator.Click += CreatorClick;
            creator.Font = new Font("Impact", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creator.Cursor = Cursors.Hand;

            Controls.Add(creator);
        }

        private void initialButtons()
        {
            // Initial Buttons
            for (int i = 0; i < tableSize; i++)
            {
                for (int j = 0; j < tableSize; j++)
                {
                    Button button = new Button();
                    buttons[i, j] = button;
                }
            }

            for (int i = 0; i < tableSize; i++)
            {

                for (int j = 0; j < tableSize; j++)
                {
                    buttons[i, j].Width = 100;
                    buttons[i, j].Height = 100;
                    buttons[i, j].Left = (buttons[i, j].Width + 3) * i + 375;
                    buttons[i, j].Top = (buttons[i, j].Height + 3) * j + 240;
                    buttons[i, j].TabIndex = 10;
                    buttons[i, j].FlatAppearance.BorderSize = 0;
                    buttons[i, j].Cursor = Cursors.Hand;
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].Click += btnClick;


                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void initialPanel()
        {
            // Initial GamePanel bg
            panel.Width = (100 * tableSize) + 50 + 3 * tableSize;
            panel.Height = (100 * tableSize) + 250 + 3 * tableSize;
            panel.Left = 350;
            panel.Top = 100;
            panel.BackColor = Color.FromArgb(43, 0, 64);
            panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 50, 50));

            // Resize Screen Width and Height
            this.Width = 350 + panel.Width + 350;
            this.Height = 100 + panel.Height + 100;
            Controls.Add(panel);

            // initial Move Indicator

            moveIndicator.Width = 100;
            moveIndicator.Height = 5;
            moveIndicator.Left = 25;
            moveIndicator.Top = 15;
            moveIndicator.BackColor = Color.White;
            moveIndicator.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, moveIndicator.Width, moveIndicator.Height, 25, 25));
            panel.Controls.Add(moveIndicator);

            // initial Stats
            initialPlayerXStats(panel);
            initialPlayerOStats(panel);
            initialDrawStats(panel);

            // Initial Reset Game Button

            resetGameBtn.Left = (panel.Width / 2) - 25;
            resetGameBtn.Top = panel.Height - 75;
            resetGameBtn.Click += ResetGameBtn_Click;

            resetGameBtn.BackColor = Color.Transparent;
            resetGameBtn.BackgroundImage = Properties.Resources.icons8_reset_100;
            resetGameBtn.BackgroundImageLayout = ImageLayout.Stretch;
            resetGameBtn.FlatAppearance.BorderSize = 0;
            resetGameBtn.FlatStyle = FlatStyle.Flat;
            resetGameBtn.Height = 50;
            resetGameBtn.Width = 50;
            resetGameBtn.TabIndex = 0;
            resetGameBtn.Cursor = Cursors.Hand;
            resetGameBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, resetGameBtn.Width, resetGameBtn.Height, 25, 25));
            panel.Controls.Add(resetGameBtn);
        }

        private void ResetGameBtn_Click(object sender, EventArgs e)
        {
            ResetGame();
            ResetButtons();
        }
        private void initialBoard()
        {

            // Initial Buttons
            initialButtons();

            // Initial Panel && Stats in Panel
            initialPanel();

            // Initial Logo
            initialLogo();

            // Initial Creator
            initialCreator();

        }
        private void GameScreenClose(object sender, FormClosedEventArgs e)
        {
            //ResetButtons();
            ResetGame();
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        public void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Length != 0)
            {
                return;
            }

            movesCount++;
            btn.Font = new Font("KNIGHT WARRIOR", 71.99999F, FontStyle.Bold, GraphicsUnit.Point, 0);

            if (playerXTurn == true)
            {
                btn.Text = "X";
                moveIndicator.Left = (panel.Width - 100) - 25;
                btn.Enabled = true;
                btn.ForeColor = Color.FromArgb(72, 210, 254);
            }
            else
            {
                btn.Text = "O";
                btn.Enabled = true;
                moveIndicator.Left = 25;
                btn.ForeColor = Color.FromArgb(226, 190, 0);
            }

            if (getWinner())
            {
                if (playerXTurn == true)
                {
                    PlayerXStats.Text = (Int32.Parse(PlayerXStats.Text) + 1).ToString();
                    ResetButtons();
                }
                else
                {
                    PlayerOStats.Text = (Int32.Parse(PlayerOStats.Text) + 1).ToString();
                    ResetButtons();
                }
            }
            else if (movesCount == tableSize * tableSize)
            {
                DrawStats.Text = (Int32.Parse(DrawStats.Text) + 1).ToString();
                ResetButtons();
            }

            playerXTurn = !playerXTurn;
        }



        private bool getWinner()
        {
            for (int i = 0; i < tableSize; i++)
            {
                // Check rows
                if (buttons[i, 0].Text != "" && AllEqual(GetRow(buttons, i)))
                    return true;

                // Check columns
                if (buttons[0, i].Text != "" && AllEqual(GetColumn(buttons, i)))
                    return true;
            }

            // Check diagonals
            if (buttons[0, 0].Text != "" && AllEqual(GetDiagonal(buttons, true)))
                return true;

            if (buttons[0, tableSize - 1].Text != "" && AllEqual(GetDiagonal(buttons, false)))
                return true;

            return false;
        }



        Button[] GetRow(Button[,] array, int row)
        {
            Button[] result = new Button[array.GetLength(1)];
            for (int i = 0; i < array.GetLength(1); i++)
            {
                result[i] = array[row, i];
            }
            return result;
        }

        Button[] GetColumn(Button[,] array, int col)
        {
            Button[] result = new Button[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                result[i] = array[i, col];
            }
            return result;
        }

        Button[] GetDiagonal(Button[,] array, bool fromTopLeft)
        {
            int length = array.GetLength(0);
            Button[] result = new Button[length];
            if (fromTopLeft)
            {
                for (int i = 0; i < length; i++)
                {
                    result[i] = array[i, i];
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    result[i] = array[i, length - i - 1];
                }
            }
            return result;
        }
        bool AllEqual(Button[] buttons)
        {
            string symbol = buttons[0].Text;
            if (symbol == "")
                return false;

            foreach (Button button in buttons)
            {
                if (button.Text != symbol)
                    return false;
            }

            return true;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            initialBoard();
        }
    }
}
