using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kółko_i_krzyżyk
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer currentPlayer;

        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            changeLabel();
        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if(currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                currentPlayer = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "O";
                currentPlayer = CurrentPlayer.Cross;
            }
            if (checkForWinner())
                showWinner();
            changeLabel();
        }
        public void changeLabel()
        {
            if(currentPlayer == CurrentPlayer.Cross)
            {
                currentPlayerLabel.Text = "Krzyżyk";
            }
            else
            {
                currentPlayerLabel.Text = "Kółko";
            }
        }
        public bool checkForWinner()
        {
            if(String.Compare(TL.Text, CL.Text) == 0 && String.Compare(CL.Text, BL.Text) == 0 && String.Compare(CL.Text, "") != 0 )
            {
                return true;
            }
            
            if(String.Compare(TC.Text, CC.Text) == 0 && String.Compare(CC.Text, BC.Text) == 0 && String.Compare(CC.Text, "") != 0 )
            {
                return true;
            }
            
            if(String.Compare(TR.Text, CR.Text) == 0 && String.Compare(CR.Text, BR.Text) == 0 && String.Compare(CR.Text, "") != 0 )
            {
                return true;
            }
            
            if(String.Compare(TL.Text, TC.Text) == 0 && String.Compare(TC.Text, TR.Text) == 0 && String.Compare(TC.Text, "") != 0 )
            {
                return true;
            }
            
            if(String.Compare(CL.Text, CC.Text) == 0 && String.Compare(CC.Text, CR.Text) == 0 && String.Compare(CC.Text, "") != 0 )
            {
                return true;
            }
            if(String.Compare(BL.Text, BC.Text) == 0 && String.Compare(BC.Text, BR.Text) == 0 && String.Compare(BC.Text, "") != 0 )
            {
                return true;
            }
            if(String.Compare(TL.Text, CC.Text) == 0 && String.Compare(CC.Text, BR.Text) == 0 && String.Compare(CC.Text, "") != 0 )
            {
                return true;
            }
            if(String.Compare(TR.Text, CC.Text) == 0 && String.Compare(CC.Text, BL.Text) == 0 && String.Compare(CC.Text, "") != 0 )
            {
                return true;
            }
            return false;

        }
   
        public void showWinner()
        {
            Form2 victoryScreen = new Form2(this);
            victoryScreen.winner = currentPlayerLabel.Text;
            victoryScreen.Show();
        }
        public void clearBoard()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;

            for(int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                    buttons[i].Text = "";
            }

            currentPlayer = CurrentPlayer.Cross;
            currentPlayerLabel.Text = "Krzyżyk";
        }
        
        private void restart_Click(object sender, EventArgs e)
        {
            clearBoard();
            currentPlayer = CurrentPlayer.Cross;
            currentPlayerLabel.Text = "Krzyżyk";
        }

    }
}
