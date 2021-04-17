using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketGame
{
   

    public partial class CricketGame : Form
    {
        private Ball ball_obj;
        private Over over_obj;
        private Player player_obj;
        private PlayerScore playerScore_obj; 
        private MainClass main;
        private ScoreCard scoreCard_obj;
        int temp, teamCount=1;
        int[] TeamA_Run = { 0, 0, 0, 0, 0};
        int[] TeamA_Balls = { 0, 0, 0, 0, 0};
        int[] TeamB_Run = { 0, 0, 0, 0, 0 };
        int[] TeamB_Balls = { 0, 0, 0, 0, 0 };
        string[] TeamA_Array= {"Farooq","Arslan","Nafees","Fahad","Adnan"};
        string[] TeamB_Array= { "Babar","Fahad","Ahsan","Adeel","Ahmed"};


        public CricketGame()
        {
            InitializeComponent();
            Initilizations_Objects();
        }

        private void CricketGame_Load(object sender, EventArgs e)
        {
            main.AddPlayers();
            foreach(Player P in main.TeamA1)
            {
                
                rtb_team1.Text += "\n";
                rtb_team1.Text += "\n";
                rtb_team1.Text += "\n"; 
                rtb_team1.Text += P.Display();
                  
                
            }
            foreach (Player L in main.TeamB1)
            {
                rtb_team2.Text += "\n";
                rtb_team2.Text += "\n";
                rtb_team2.Text += "\n";
                rtb_team2.Text += L.Display();
               
            }

        }

        private void btn_gScore_Click(object sender, EventArgs e)
        {
            
           
            txt_team.Visible = true;
            Random_Number();
            

            if (txt_rScore1.Text == "7")
            {  Out_Method();  }
            else
            {
                txt_team.Visible = true;
                temp = int.Parse(txt_rScore1.Text);
                scoreCard_obj.Team_Cscore += temp;
                ball_obj.Balls += 1;
                playerScore_obj.PBalls = ball_obj.Balls + over_obj.Overs;
                playerScore_obj.PScore += temp;
                temp = 0;
                txt_cScore.Text = scoreCard_obj.Team_Cscore.ToString() + " / " + scoreCard_obj.Team_Outs;

                TeamA_Names_Score();


                if (ball_obj.Balls >= 1 && ball_obj.Balls < 6 && over_obj.Overs < 3)
                {
                    txt_Over.Text = over_obj.Overs.ToString() + "." + ball_obj.Balls.ToString();
                }

                else if (over_obj.Overs < 3)
                {
                    ball_obj.Balls = 0;
                    over_obj.Overs += 1;
                    txt_Over.Text = over_obj.Overs.ToString() + "." + ball_obj.Balls.ToString();
                }

                else if (over_obj.Overs == 3)
                {
                    txt_target.Text = scoreCard_obj.Team_Cscore.ToString();
                    scoreCard_obj.TeamA_totalScore = scoreCard_obj.Team_Cscore;
                    Target_Message();
                    Empty_Field();
                    teamCount = 2;
                }

                if(teamCount==1)
                {
                    txt_team.Text = "Team A is palying";
                }
                else if(teamCount==2)
                {
                    txt_team.Text = "Team B is palying";
                }

                if (scoreCard_obj.Team_Outs == 5)
                {
                    teamCount = 2;
                    
                }

                else if (teamCount == 2)
                {
                    txt_team.Visible = true;
                    
                    int currentScore = scoreCard_obj.Team_Cscore;
                    int TotalteamA = scoreCard_obj.TeamA_totalScore;
                    scoreCard_obj.RemainingScore = (TotalteamA - currentScore);
                    txt_reScore.Text = scoreCard_obj.RemainingScore.ToString();
                    TeamB_Names_Score();
                    

                    if (scoreCard_obj.Team_Outs == 5 && scoreCard_obj.Team_Cscore < scoreCard_obj.TeamA_totalScore)
                    {
                        VisibleSteam();
                        Hide_button();
                        TeamA_Won_Message();
                        Display();
                    }

                    else if (scoreCard_obj.Team_Cscore == scoreCard_obj.TeamA_totalScore && ball_obj.Balls >= 5)
                    {
                        VisibleSteam();
                        Hide_button();
                        Tie_Message();
                        Display();
                    }

                    else if (scoreCard_obj.Team_Cscore > scoreCard_obj.TeamA_totalScore)
                    {
                        VisibleSteam();
                        txt_reScore.Text = " ";
                        Hide_button();
                        TeamB_Won_Message();
                        Display();
                    }


                    else if (scoreCard_obj.Team_Cscore < scoreCard_obj.TeamA_totalScore && over_obj.Overs == 3)
                    {
                        VisibleSteam();
                        TeamA_Won_Message();
                        Display();
                    }
                }

            }

        }
            void Empty_Field()
            {
                over_obj.Overs = 0;
                txt_Over.Text = "0";
                ball_obj.Balls = 0;
                scoreCard_obj.Team_Cscore = 0;
                txt_cScore.Text = "0";
                playerScore_obj.PScore = 0;
                txt_pScore.Text = "0";
                txt_rScore1.Text = "";
                teamCount = 2;
                scoreCard_obj.Team_Outs = 0;
                
        }

            void Display()
            {
                for (int i = 0; i < 5; i++)
                {
                    txt_SteamA.Text += "\n";
                    txt_SteamA.Text += "\n";
                    txt_SteamA.Text += "  "+TeamA_Array[i] + "    " + TeamA_Run[i] + "        " + TeamA_Balls[i];
                    txt_SteamB.Text += "\n";
                    txt_SteamB.Text += "\n";
                    txt_SteamB.Text += "  "+ TeamB_Array[i] + "    " + TeamB_Run[i] + "        " + TeamB_Balls[i];
                    
            }
            }

        void VisibleSteam()
        {
            txt_SteamA.Visible = true;
            txt_SteamB.Visible = true;
            txtStreamA.Visible = true;
            txtStreamB.Visible = true;
            
        }
            void TeamA_Won_Message()
            {
                
                string message = "Team A has Won by " + scoreCard_obj.RemainingScore + " Runs";
                string title = "Congratulations :)";
                MessageBox.Show(message, title);
            }

            void TeamB_Won_Message()
            {

                 string message = "Team B has Won";
                string title = "Congratulations :)";
                MessageBox.Show(message, title);
            }

            void Tie_Message()
            {
                string message = "Match has Tie";
                string title = "Play Again :)";
                MessageBox.Show(message, title);
            }

            void Hide_button()
            {
                btn_gScore.Visible = false;
            }

            void Target_Message()
            {
                string message = "Team B Requird " + txt_target.Text;
                string title = "Team A Target";
                MessageBox.Show(message, title);
            }

            void Out_Method()
            {
               
                txt_rScore1.Text = "OUT";
                scoreCard_obj.Team_Outs += 1;
                ball_obj.Balls += 1;
                playerScore_obj.PScore = 0;
                txt_pScore.Text = "0";
                playerScore_obj.PBalls = 0;

        }

            void Random_Number()
        {
            Random rendom = new Random();
            int randomnum = rendom.Next(8);
            txt_rScore1.Text = randomnum.ToString();
        }

            void TeamA_Names_Score()
        {
            for (int a = 0; a < 5; a++)
            {
                if (scoreCard_obj.Team_Outs == a && teamCount == 1)
                {
                    txt_pScore.Text = TeamA_Array[a] + "  " + playerScore_obj.PScore.ToString();
                    TeamA_Run[a] = playerScore_obj.PScore;
                    TeamB_Balls[a] = playerScore_obj.PBalls;
                }

            }
        }
          
            void TeamB_Names_Score()
        {
            for (int b = 0; b < 5; b++)
            {
                if (scoreCard_obj.Team_Outs == b && teamCount == 2)
                {
                    txt_pScore.Text = TeamB_Array[b] + "  " + playerScore_obj.PScore.ToString();
                    TeamB_Run[b] = playerScore_obj.PScore;
                    TeamA_Balls[b] = playerScore_obj.PBalls;
                }

            }
        }

       

        void Initilizations_Objects()
        {
            main = new MainClass();
            ball_obj = new Ball();
            over_obj = new Over();
            player_obj = new Player();
            playerScore_obj = new PlayerScore();
            scoreCard_obj = new ScoreCard();
        }
        
    }
}
