using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HigherLuck
{
    public partial class Form1 : Form
    {
        
        Game game = new Game();

        public Form1()
        {
            InitializeComponent();

            LoadAvatarIcons();
            ResetScreen();
        }

     
        private void LoadAvatarIcons()
        {
            rbAvatar1.Image = Properties.Resources.Icon01;
            rbAvatar2.Image = Properties.Resources.Icon02;
            rbAvatar3.Image = Properties.Resources.Icon03;
            rbAvatar4.Image = Properties.Resources.Icon04;
        }

        
        private void ResetScreen()
        {
            game.Reset();

            nudRounds.Value = 5;
            nudRounds.Enabled = true;

            txtName1.Clear();
            txtName2.Clear();
            txtName1.Enabled = true;
            txtName2.Enabled = true;

            grpAvatars.Enabled = true;
            rbAvatar1.Enabled = true;
            rbAvatar2.Enabled = true;
            rbAvatar3.Enabled = true;
            rbAvatar4.Enabled = true;
            rbAvatar1.Checked = true;

            grpPlayer1.Text = "First Player";
            grpPlayer2.Text = "Second Player";
            pbPlayer1.Image = Properties.Resources.DefaultAvatar;
            pbPlayer2.Image = Properties.Resources.DefaultAvatar;
            lblPoints1.Text = "0";
            lblPoints2.Text = "0";

            UpdateSetupButtons();
            UpdateActionPanel();

            btnStart.Enabled = false;
            btnRoll.Enabled = false;
            pbDice.Image = null;
            lblRollInfo.Text = "";
            lstReport.Items.Clear();
        }

        
        private void UpdateSetupButtons()
        {
            if (txtName1.Text.Trim() != "" && txtName2.Text.Trim() != "")
            {
                btnSetup1.Enabled = !game.first.isSetUp;
                btnSetup2.Enabled = !game.second.isSetUp;
            }
            else
            {
                btnSetup1.Enabled = false;
                btnSetup2.Enabled = false;
            }
        }

        
        private void UpdateActionPanel()
        {
            lblRoundsLeft.Text = game.roundsLeft.ToString();

            if (game.running)
            {
                lblTurn.Text = game.TurnName() + "'s turn";
            }
            else
            {
                lblTurn.Text = "";
            }
        }

        
        private int GetSelectedAvatar()
        {
            if (rbAvatar1.Checked)
            {
                return 1;
            }
            else if (rbAvatar2.Checked)
            {
                return 2;
            }
            else if (rbAvatar3.Checked)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        
        private void TakeSelectedAvatar()
        {
            if (rbAvatar1.Checked)
            {
                rbAvatar1.Enabled = false;
            }
            else if (rbAvatar2.Checked)
            {
                rbAvatar2.Enabled = false;
            }
            else if (rbAvatar3.Checked)
            {
                rbAvatar3.Enabled = false;
            }
            else
            {
                rbAvatar4.Enabled = false;
            }

            if (rbAvatar1.Enabled)
            {
                rbAvatar1.Checked = true;
            }
            else if (rbAvatar2.Enabled)
            {
                rbAvatar2.Checked = true;
            }
            else if (rbAvatar3.Enabled)
            {
                rbAvatar3.Checked = true;
            }
            else
            {
                rbAvatar4.Checked = true;
            }
        }

        
        private void AfterSetUp()
        {
            UpdateSetupButtons();

            if (game.first.isSetUp && game.second.isSetUp)
            {
                grpAvatars.Enabled = false;
                btnStart.Enabled = true;
            }
        }

        
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            UpdateSetupButtons();
        }

        private void btnSetup1_Click(object sender, EventArgs e)
        {
            int avatar = GetSelectedAvatar();

           
            if (avatar == game.second.avatar)
            {
                MessageBox.Show("This avatar is already used by the other player.");
                return;
            }

            game.first.name = txtName1.Text.Trim();
            game.first.avatar = avatar;
            game.first.isSetUp = true;

            txtName1.Enabled = false;
            grpPlayer1.Text = game.first.NameUpper();

            if (avatar == 1)
            {
                pbPlayer1.Image = Properties.Resources.Icon01;
            }
            else if (avatar == 2)
            {
                pbPlayer1.Image = Properties.Resources.Icon02;
            }
            else if (avatar == 3)
            {
                pbPlayer1.Image = Properties.Resources.Icon03;
            }
            else
            {
                pbPlayer1.Image = Properties.Resources.Icon04;
            }

            TakeSelectedAvatar();
            AfterSetUp();
        }

        private void btnSetup2_Click(object sender, EventArgs e)
        {
            int avatar = GetSelectedAvatar();

            
            if (avatar == game.first.avatar)
            {
                MessageBox.Show("This avatar is already used by the other player.");
                return;
            }

            game.second.name = txtName2.Text.Trim();
            game.second.avatar = avatar;
            game.second.isSetUp = true;

            txtName2.Enabled = false;
            grpPlayer2.Text = game.second.NameUpper();

            if (avatar == 1)
            {
                pbPlayer2.Image = Properties.Resources.Icon01;
            }
            else if (avatar == 2)
            {
                pbPlayer2.Image = Properties.Resources.Icon02;
            }
            else if (avatar == 3)
            {
                pbPlayer2.Image = Properties.Resources.Icon03;
            }
            else
            {
                pbPlayer2.Image = Properties.Resources.Icon04;
            }

            TakeSelectedAvatar();
            AfterSetUp();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game.roundsLeft = Convert.ToInt32(nudRounds.Value);
            game.Start();

            nudRounds.Enabled = false;
            btnStart.Enabled = false;
            btnRoll.Enabled = true;
            pbDice.Image = null;
            lblRollInfo.Text = "";

            UpdateActionPanel();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            try
            {
                string rollerName = game.TurnName();   
                int value = game.Roll();               

               
                if (value == 1)
                {
                    pbDice.Image = Properties.Resources.Dice1;
                }
                else if (value == 2)
                {
                    pbDice.Image = Properties.Resources.Dice2;
                }
                else if (value == 3)
                {
                    pbDice.Image = Properties.Resources.Dice3;
                }
                else if (value == 4)
                {
                    pbDice.Image = Properties.Resources.Dice4;
                }
                else if (value == 5)
                {
                    pbDice.Image = Properties.Resources.Dice5;
                }
                else
                {
                    pbDice.Image = Properties.Resources.Dice6;
                }

                lblRollInfo.Text = rollerName + " rolled " + value;

               
                if (game.roundFinished)
                {
                    lblPoints1.Text = game.first.points.ToString();
                    lblPoints2.Text = game.second.points.ToString();
                    lblRollInfo.Text = game.first.name + ": " + game.firstRoll + "   " +
                                       game.second.name + ": " + game.secondRoll;
                }

                UpdateActionPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong with the roll: " + ex.Message);
                return;
            }

            
            if (!game.running)
            {
                FinishGame();
            }
        }

       
        private void SaveResult()
        {
            try
            {
                FileStream fs = new FileStream("GameResults.txt",
                                                FileMode.Append,
                                                FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(game.first.NameUpper() + ";" + game.first.points + ";" +
                             game.second.NameUpper() + ";" + game.second.points + ";" +
                             game.GetResultText());

                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The result could not be saved to the file: " + ex.Message);
            }
        }

        
        private void FinishGame()
        {
            btnRoll.Enabled = false;

            SaveResult();

            MessageBox.Show(game.GetResultText() + "\n\nGAME OVER", "GAME OVER");

            ResetScreen();
        }

        
        private void btnShowResult_Click(object sender, EventArgs e)
        {
            try
            {
                lstReport.Items.Clear();

                FileStream fs = new FileStream("GameResults.txt",
                                                FileMode.OpenOrCreate,
                                                FileAccess.ReadWrite);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    lstReport.Items.Add(sr.ReadLine());
                }

                sr.Close();
                fs.Close();

                if (lstReport.Items.Count == 0)
                {
                    MessageBox.Show("No game has been saved yet.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The results could not be read from the file: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetScreen();
        }
    }
}
