using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hondenrace
{
    public partial class form1 : Form
    {

        dog[] dogArray = new dog[5];
        Player[] playerArray = new Player[3];
        Random randomizer = new Random();
        public int StartingPosition = 0;

       

        public form1()
        {
            InitializeComponent();
            MakeDogs();
            makePlayers();
            AddTypesToComboBox(cb_player1);
        }

        public void AddTypesToComboBox(ComboBox box)
        {
            for (int i = 0; i < dogArray.Length; i++)
            {
                box.Items.Add(dogArray[i].Name);
            }
        }
        private void makePlayers()
        {
            playerArray[0] = new Player()
            {
                Name = "Sander",
                playerBalance = 10,
                NuD = NuD_player1,
                mylbl = lbl_player1name,
            };
            playerArray[1] = new Player()
            {
                Name = "Bas",
                playerBalance = 20,
                NuD = NuD_player2,
                mylbl = lbl_player2name,

            };
            playerArray[2] = new Player()
            {
                Name = "Tom",
                playerBalance = 30,
                NuD = NuD_player3,
                mylbl = lbl_player3name,

            };

            //making the labels that display the player value the value of the player from the database
            Player player = new Player();
           int  PlayerCurrency =  player.SetLabels(playerArray[1], playerArray[1].playerBalance);
            playerArray[1].playerBalance = PlayerCurrency;
            lbl_p1balance.Text = playerArray[0].playerBalance.ToString();
            lbl_p2balance.Text = playerArray[1].playerBalance.ToString();
            lbl_p3balance.Text = playerArray[2].playerBalance.ToString();

            NuD_player2.Maximum = PlayerCurrency;
            
            for (int a = 0; a < playerArray.Length; a++)
            {
               // lbl_p1balance.Text = playerArray[a].playerBalance.ToString().Text = playerArray[a].playerBalance.ToString();
            }



        }

        private void MakeDogs()
        {
            dogArray[0] = new dog()
            {
                MyPictureBox = pb_dog1,
                Name = "Mythosis",
                StartingPosition = pb_dog1.Left,
                Randomizer = randomizer,



            };
            dogArray[1] = new dog()
            {
                MyPictureBox = pb_dog2,
                Name = "The Light",
                StartingPosition = pb_dog2.Left,
                Randomizer = randomizer

            };
            dogArray[2] = new dog()
            {
                MyPictureBox = pb_dog3,
                Name = "Bolt",
                StartingPosition = pb_dog3.Left,
                Randomizer = randomizer
            };
            dogArray[3] = new dog()
            {
                MyPictureBox = pb_dog4,
                Name = "Sanic",
                StartingPosition = pb_dog4.Left,
                Randomizer = randomizer
            };
            dogArray[4] = new dog()
            {
                MyPictureBox = pb_dog5,
                Name = "Zeus",
                StartingPosition = pb_dog5.Left,
                Randomizer = randomizer
            };

        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //disable timer and nud
            btn_start.Enabled = false;
            NuD_player2.Enabled = false;
            for (int i = 0; i < dogArray.Length; i++)
            {
                if (dogArray[i].Run() == true)
                {
                    timer1.Stop();
                    //winningcredits
                    int selectedIndex = cb_player1.SelectedIndex;
                    if (selectedIndex == i)
                    {
                        int winnersCredits = Convert.ToInt32(playerArray[1].NuD.Value) * 4;
                        MessageBox.Show(dogArray[i].Name + " has won the race!");

                        //if the player has bet on the winning dog he won x4
                        playerArray[1].playerBalance = playerArray[1].playerBalance + winnersCredits;
                    }
                    else
                    {
                        MessageBox.Show(dogArray[i].Name + " has won the race!");
                        playerArray[1].playerBalance = playerArray[1].playerBalance - Convert.ToInt32(playerArray[1].NuD.Value);
                    }
                    //enable the start button en nud
                    
                    btn_start.Enabled = true;
                    NuD_player2.Enabled = true;
                    NuD_player2.Value = 0;
                    cb_player1.SelectedValue = 0;
                    

                    for (int d = 0; d < dogArray.Length; d++)
                    {
                        dogArray[d].TakeStartingPosition();
                    }
                    for (int a = 0; a < playerArray.Length; a++)
                    {
                        lbl_p1balance.Text = playerArray[a].playerBalance.ToString();
                    }
                    Player player = new Player();
                    player.UpdateLabels(playerArray[1], playerArray[1].playerBalance);

                }

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
