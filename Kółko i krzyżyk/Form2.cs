﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kółko_i_krzyżyk
{
    public partial class Form2 : Form
    {
        public string winner;
        private Form1 board;

        public Form2(Form1 b)
        {
            board = b;
            InitializeComponent();
        }

        private void showWinner(object sender, EventArgs e)
        {
            winnerLabel.Text = "Wygrywa: " + winner;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            board.clearBoard();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
