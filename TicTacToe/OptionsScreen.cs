﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicTacToe
{
    public partial class OptionsScreen : Form
    {
        public OptionsScreen()
        {
            InitializeComponent();
        }

        Form1 form = new Form1();
        GameScreen gameScreen = new GameScreen();
        static private double tableSize;

        private void CloseOptionsScreen(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            form.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SubmitOptions_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || Int32.Parse(textBox1.Text) < 9)
            {
                return;
            }
            gameScreen.setTableSize(tableSize);
            gameScreen.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "") tableSize = Int32.Parse(textBox1.Text);
        }

        private void OptionsScreen_Load(object sender, EventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }
    }
}
