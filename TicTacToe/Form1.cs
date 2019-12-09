using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToeForm : Form
    {
        enum Player
        {
            None,
            X,
            O
        }

        Player currentPlayer;        

        #region Button Functions
        private void btn1_Click(object sender, EventArgs e)
        {
            if (currentPlayer == Player.X && btn_1.Text == "")
            {
                btn_1.Text = "X";
                currentPlayer = Player.O;
            }
            else if (currentPlayer == Player.O && btn_1.Text == "")
            {
                btn_1.Text = "O";
                currentPlayer = Player.X;
            }
            CheckWin();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (currentPlayer == Player.X && btn_2.Text == "")
            {
                btn_2.Text = "X";
                currentPlayer = Player.O;
            }
            else if (currentPlayer == Player.O && btn_2.Text == "")
            {
                btn_2.Text = "O";
                currentPlayer = Player.X;
            }
            CheckWin();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (currentPlayer == Player.X && btn_3.Text == "")
            {
                btn_3.Text = "X";
                currentPlayer = Player.O;
            }
            else if (currentPlayer == Player.O && btn_3.Text == "")
            {
                btn_3.Text = "O";
                currentPlayer = Player.X;
            }
            CheckWin();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (currentPlayer == Player.X && btn_4.Text == "")
            {
                btn_4.Text = "X";
                currentPlayer = Player.O;
            }
            else if (currentPlayer == Player.O && btn_4.Text == "")
            {
                btn_4.Text = "O";
                currentPlayer = Player.X;
            }
            CheckWin();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (currentPlayer == Player.X && btn_5.Text == "")
            {
                btn_5.Text = "X";
                currentPlayer = Player.O;
            }
            else if (currentPlayer == Player.O && btn_5.Text == "")
            {
                btn_5.Text = "O";
                currentPlayer = Player.X;
            }
            CheckWin();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (currentPlayer == Player.X && btn_6.Text == "")
            {
                btn_6.Text = "X";
                currentPlayer = Player.O;
            }
            else if (currentPlayer == Player.O && btn_6.Text == "")
            {
                btn_6.Text = "O";
                currentPlayer = Player.X;
            }
            CheckWin();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (currentPlayer == Player.X && btn_7.Text == "")
            {
                btn_7.Text = "X";
                currentPlayer = Player.O;
            }
            else if (currentPlayer == Player.O && btn_7.Text == "")
            {
                btn_7.Text = "O";
                currentPlayer = Player.X;
            }
            CheckWin();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (currentPlayer == Player.X && btn_8.Text == "")
            {
                btn_8.Text = "X";
                currentPlayer = Player.O;
            }
            else if (currentPlayer == Player.O && btn_8.Text == "")
            {
                btn_8.Text = "O";
                currentPlayer = Player.X;
            }
            CheckWin();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (currentPlayer == Player.X && btn_9.Text == "")
            {
                btn_9.Text = "X";
                currentPlayer = Player.O;
            }
            else if (currentPlayer == Player.O && btn_9.Text == "")
            {
                btn_9.Text = "O";
                currentPlayer = Player.X;
            }
            CheckWin();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            btn_1.Text = "";
            btn_2.Text = "";
            btn_3.Text = "";
            btn_4.Text = "";
            btn_5.Text = "";
            btn_6.Text = "";
            btn_7.Text = "";
            btn_8.Text = "";
            btn_9.Text = "";
            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;
            ChkBox_O.Checked = false;
            ChkBox_X.Checked = false;
            currentPlayer = Player.X;
        }
        #endregion

        #region Winning Functions
        private Player CheckWin()
        {
            Player winningPlayer;
            winningPlayer = Player.None;
            if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
            {
                winningPlayer = Player.O;
                ChkBox_O.Checked = true;
                DisableButtons();
            }

            else if (btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
            {
                winningPlayer = Player.X;
                ChkBox_X.Checked = true;
                DisableButtons();
            }

            else if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
            {
                winningPlayer = Player.O;
                ChkBox_O.Checked = true;
                DisableButtons();
            }

            else if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
            {
                winningPlayer = Player.X;
                ChkBox_X.Checked = true;
                DisableButtons();
            }

            else if (btn_1.Text == "O" && btn_4.Text == "O" && btn_7.Text == "O")
            {
                winningPlayer = Player.O;
                ChkBox_O.Checked = true;
                DisableButtons();
            }

            else if (btn_1.Text == "X" && btn_4.Text == "X" && btn_7.Text == "X")
            {
                winningPlayer = Player.X;
                ChkBox_X.Checked = true;
                DisableButtons();
            }

            else if (btn_2.Text == "O" && btn_5.Text == "O" && btn_8.Text == "O")
            {
                winningPlayer = Player.O;
                ChkBox_O.Checked = true;
                DisableButtons();
            }

            else if (btn_2.Text == "X" && btn_5.Text == "X" && btn_8.Text == "X")
            {
                winningPlayer = Player.X;
                ChkBox_X.Checked = true;
                DisableButtons();
            }

            else if (btn_3.Text == "O" && btn_6.Text == "O" && btn_9.Text == "O")
            {
                winningPlayer = Player.O;
                ChkBox_O.Checked = true;
                DisableButtons();
            }

            else if (btn_3.Text == "X" && btn_6.Text == "X" && btn_9.Text == "X")
            {
                winningPlayer = Player.X;
                ChkBox_X.Checked = true;
                DisableButtons();
            }

            else if (btn_3.Text == "O" && btn_5.Text == "O" && btn_7.Text == "O")
            {
                winningPlayer = Player.O;
                ChkBox_O.Checked = true;
                DisableButtons();
            }

            else if (btn_3.Text == "X" && btn_5.Text == "X" && btn_7.Text == "X")
            {
                winningPlayer = Player.X;
                ChkBox_X.Checked = true;
                DisableButtons();
            }

            else if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
            {
                winningPlayer = Player.O;
                ChkBox_O.Checked = true;
                DisableButtons();
            }

            else if (btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
            {
                winningPlayer = Player.X;
                ChkBox_X.Checked = true;
                DisableButtons();
            }

            else if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
            {
                winningPlayer = Player.O;
                ChkBox_O.Checked = true;
                DisableButtons();
            }

            else if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
            {
                winningPlayer = Player.X;
                ChkBox_X.Checked = true;
                DisableButtons();
            }

            return winningPlayer;
        }

        private void DisableButtons()
        {
            btn_1.Enabled = false;
            btn_2.Enabled = false;
            btn_3.Enabled = false;
            btn_4.Enabled = false;
            btn_5.Enabled = false;
            btn_6.Enabled = false;
            btn_7.Enabled = false;
            btn_8.Enabled = false;
            btn_9.Enabled = false;
        }
        #endregion

        #region Utility Functions
        public TicTacToeForm()
        {
            InitializeComponent();

            currentPlayer = Player.X;
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
