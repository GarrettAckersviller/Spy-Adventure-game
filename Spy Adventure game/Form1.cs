using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System;

using System.Media;

namespace Spy_Adventure_game
{
    public partial class SpyGame : Form
    {
        // Track the page I am on
        int page = 1;
        Random randGen = new Random();

        public SpyGame()
        {
            InitializeComponent();
        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                int randValue = randGen.Next(1, 100);//

                if (randValue < 80)
                {
                    page = 4;
                }
                else
                {
                    page = 5;
                }
            }

            else if (page == 5)
            {
                page = 8;

            }

            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 6)
            {
                page = 1;
            }


            else if (page == 7)
            {
                page = 22;
            }
            else if (page == 8)
            {
                page = 9;
            }

            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 10)
            {
                page = 16;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }

            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 19;
            }

            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 1;
            }
            else if (page == 24)
            {
                Thread.Sleep(1000);
                page = 1;
            }

            DisplayPage();

        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        private void optionButton2_Click(object sender, EventArgs e)
        {

            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 24;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 6)
            {
                page = 24;
            }

            else if (page == 7)
            {
                page = 23;
            }
            else if (page == 8)
            {
                page = 10;
            }

            else if (page == 9)
            {
                page = 12;
            }
            else if (page == 10)
            {
                page = 17;
            }
            else if (page == 11)
            {
                page = 15;
            }
            else if (page == 12)
            {
                page = 24;
            }
            else if (page == 13)
            {
                page = 24;
            }
            else if (page == 14)
            {
                page = 24;
            }
            else if (page == 15)
            {
                page = 24;
            }

            else if (page == 16)
            {
                page = 24;
            }
            else if (page == 17)
            {
                page = 18;
            }

            else if (page == 18)
            {
                page = 24;
            }
            else if (page == 19)
            {
                page = 21;
            }
            else if (page == 20)
            {
                page = 24;
            }
            else if (page == 21)
            {
                page = 24;
            }
            else if (page == 22)
            {
                page = 24;
            }
            else if (page == 23)
            {
                page = 24;
            }


            DisplayPage();
        }
        private void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources.Changed_flag;
                    output.Text = "It is the year 1969 you are an American spy in the USSR.  Go to Moscow or St.Petersburg?";
                    optionLabel1.Text = "Moscow";
                    option2Label.Text = "St.Petersburg";
                    break;

                case 2:
                    output.Text ="You get a call back from D.C. you are told your mission is to infultrate KGB head quarters.";
                    pictureBox1.BackgroundImage = Properties.Resources.Emblema_KGB_svg;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "How will you infiltrate the building";
                    optionLabel1.Text = "Front Door";
                    option2Label.Text = "Window";
                    break;

                case 3:
                    output.Text = "You weren't supposed to come here.";
                    pictureBox1.BackgroundImage = Properties.Resources.plain_black_background_02fh7564l8qq4m6d;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    option2Label.Text = "No";
                    break;

                case 4:
                    output.Text = " It is illegal to enter goverment buildings here, you are apprehended.";
                    pictureBox1.BackgroundImage = Properties.Resources.istockphoto_1248589302_612x612;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "How will you escape";
                    optionLabel1.Text = "You chose not to and give up";
                    option2Label.Text = "Attack the guard when he hands you your meal";
                    break;

                case 5:
                    output.Text = " You get into an empty office.";
                    pictureBox1.BackgroundImage = Properties.Resources.Mid_C_Modern_Office_1_620x413;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "What will you do in there";
                    optionLabel1.Text = "Look in file cabinet";
                    option2Label.Text = "Look on desk";
                    break;

                case 6:
                    output.Text = "You spend the rest of your life in a russian prison.";
                    pictureBox1.BackgroundImage = Properties.Resources.plain_black_background_02fh7564l8qq4m6d;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    option2Label.Text = "No";
                    break;

                case 7:
                    output.Text = "You knock him out and grab his gun.";
                   SoundPlayer player = new SoundPlayer(Properties.Resources.Strong_Punch_Mike_Koenig_574430706);
                    player.Play();
                    pictureBox1.BackgroundImage = Properties.Resources.Soviet_Pistols_9;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "Will you sneak out or shoot your way out";
                    optionLabel1.Text = "Sneak";
                    option2Label.Text = "Shoot";
                    break;

                case 8:
                    output.Text = "You find info that there are 1895 KGB agents opperating in the US.";
                    pictureBox1.BackgroundImage = Properties.Resources.Emblema_KGB_svg;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "You report back to D.C.";
                    optionLabel1.Text = "Tell them about the KGB";
                    option2Label.Text = "Tell them that you found nothing";
                    break;

                case 9:
                    output.Text = "The CIA hunts all of them down you return home a hero.";
                    pictureBox1.BackgroundImage = Properties.Resources.plain_black_background_02fh7564l8qq4m6d;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "Will you go home or to the bar";
                    optionLabel1.Text = "Bar";
                    option2Label.Text = "Home";
                    break;

                case 10:
                    output.Text = "The funding for you mission dried up.";
                    pictureBox1.BackgroundImage = Properties.Resources.plain_black_background_02fh7564l8qq4m6d;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "You are fired";
                    optionLabel1.Text = "Go to bar";
                    option2Label.Text = "Go home";
                    break;

                case 11:
                    output.Text = "You get a drink to celebrate a job well done.";
                    pictureBox1.BackgroundImage = Properties.Resources._1200px_Bar_P1030319__1_;
                     player = new SoundPlayer(Properties.Resources.Beer_Bottles_Clank_SoundBible_com_1563311625__1_);
                    player.Play();
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "What will you get to drink";
                    optionLabel1.Text = "Martini";
                    option2Label.Text = "Rum and Coke";
                    option3Lable.Text = "Brandy";

                    break;

                case 12:
                    output.Text = " One of the KGB agents operating in the US was not caught and waited at your house to kill you.";
                    pictureBox1.BackgroundImage = Properties.Resources._103500764_GettyImages_147205632_2;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    option2Label.Text = "No";
                    break;

                case 13:
                    output.Text = "You drink to much and die of alcohol poisining.";
                    pictureBox1.BackgroundImage = Properties.Resources.plain_black_background_02fh7564l8qq4m6d;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    option2Label.Text = "No";
                    break;

                case 14:
                    output.Text = "You drunkenly stuble out to your car and die from drinking and driving.";
                    pictureBox1.BackgroundImage = Properties.Resources.plain_black_background_02fh7564l8qq4m6d;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    option2Label.Text = "No";
                    break;

                case 15:
                    output.Text = "You stumble home and are smothered in your sleep In your drunken slumber by a KGB agent that was not caught.";
                    pictureBox1.BackgroundImage = Properties.Resources.plain_black_background_02fh7564l8qq4m6d;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(5000);
                    output.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    option2Label.Text = "No";
                    break;

                case 16:
                    output.Text = "You try to drink your depreesion away from getting fired you live the rest of your life as an alcoholic. Congrates yo got the good ending.";
                    pictureBox1.BackgroundImage = Properties.Resources._1200px_Bar_P1030319__1_;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(8000);
                    output.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                   
                case 17:
                    output.Text = " You go to the fridge to get some food.";
                    pictureBox1.BackgroundImage = Properties.Resources.DFF180E2SSB_Front_scaled;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "There is only bluebarries and apples";
                    optionLabel1.Text = "Eat the apples";
                    option2Label.Text = "Eat the bluebarries";
                    break;

                case 18:
                    output.Text = "You are allergic and die.";
                    pictureBox1.BackgroundImage = Properties.Resources.plain_black_background_02fh7564l8qq4m6d;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "Play again?";
                    optionLabel1.Text = "Yes";
                    option2Label.Text = "No";
                    break;

                case 19:
                    output.Text = "You ear them on your couch and you get a phone call.";
                    player = new SoundPlayer(Properties.Resources.Telephone);
                    player.Play();
                    pictureBox1.BackgroundImage = Properties.Resources._61YsiuEXBiL__AC_UF894_1000_QL80_;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "You pick it up the KGB wants to recruit you.";
                    optionLabel1.Text = "Join them";
                    option2Label.Text = "Decline";
                    break;

                case 20:
                    output.Text = "You join the KGB and help bring down the US. Worst ending :(.";
                    pictureBox1.BackgroundImage = Properties.Resources.plain_black_background_02fh7564l8qq4m6d;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "Play again";
                    optionLabel1.Text = "Yes";
                    option2Label.Text = "No";
                    break;

                case 21:
                    output.Text = "They hunt you down and kill you.";
                    pictureBox1.BackgroundImage = Properties.Resources.plain_black_background_02fh7564l8qq4m6d;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "Play again";
                    optionLabel1.Text = "Yes";
                    option2Label.Text = "No";
                    break;

                case 22:
                    output.Text = "You get out but have to returne to the US because you identity is compromised,you are a disgrace to your nation.";
                    pictureBox1.BackgroundImage = Properties.Resources.plain_black_background_02fh7564l8qq4m6d;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(5000);
                    output.Text = "Play again";
                    optionLabel1.Text = "Yes";
                    option2Label.Text = "No";
                    break;

                case 23:
                    output.Text = "You run out of bullets and die.";
                    player = new SoundPlayer(Properties.Resources.GUN_FIRE_GoodSoundForYou_820112263);
                    player.Play();
                    pictureBox1.BackgroundImage = Properties.Resources.plain_black_background_02fh7564l8qq4m6d;
                    optionLabel1.Text = "";
                    option2Label.Text = "";
                    Refresh();
                    Thread.Sleep(2000);
                    output.Text = "Play again";
                    optionLabel1.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 24:
                    output.Text = "Thanks for playing.";
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                





            }
        }

        private void optionButton3_Click(object sender, EventArgs e)
        {
           if (page == 11)
            {
                page = 14;
            }
            
            
            
            
           DisplayPage();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

