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
       private PlayerScore playerScore_obj;
        private MainClass main;
        int temp, pscore;
        bool check = true;

        public CricketGame()
        {
            InitializeComponent();
            main = new MainClass();
            ball_obj = new Ball();
            over_obj = new Over();
           playerScore_obj = new PlayerScore();
           
        }

        private void CricketGame_Load(object sender, EventArgs e)
        {
            main.AddPlayers();
            foreach(Player P in main.TeamA1)
            {
                rtb_team1.Text += P.Display();
                rtb_team1.Text += "\n";
                rtb_team2.Text += P.Display();
                rtb_team2.Text += "\n";
                
            }
            
        }

        private void btn_gScore_Click(object sender, EventArgs e)
        {
            if(check)
            {
                Random rendom = new Random();
                int randomnum = rendom.Next(8);
                txt_rScore.Text = randomnum.ToString();
                
                

                if (txt_rScore.Text == "7")
                {
                    txt_rScore.Text = "OUT";
                    ball_obj.Balls += 1;
                    txt_pScore.Text="0";
                    pscore = 0;

                }
                else
                {
                    temp = int.Parse(txt_rScore.Text);
                    main.Record += temp;
                    ball_obj.Balls += 1;
                    pscore = temp;
                    temp = 0;
                    check = false;
                }
                
                
            }

            check = true; 
            txt_cScore.Text = main.Record.ToString();
            txt_pScore.Text = pscore.ToString();

            if (ball_obj.Balls >= 1 && ball_obj.Balls <= 6)
            {
                txt_balls.Text = ball_obj.Balls.ToString();
                txt_Over.Text = over_obj.Overs.ToString();

            }
            else if(over_obj.Overs < 5 )
            {
                ball_obj.Balls = 1;
                txt_balls.Text = "1";
                over_obj.Overs += 1;
                txt_Over.Text = over_obj.Overs.ToString();
            }
            else if(txt_Over.Text == "5")
            {
                txt_target.Text = txt_cScore.Text;
                over_obj.Overs = 0;
                ball_obj.Balls = 0;
                main.Record = 0;
                pscore = 0;
                txt_cScore.Text = "0";
                txt_Over.Text = "0";
                txt_balls.Text = "0";
                txt_pScore.Text = "0";
            }
            
            
            
        }

       
    }
}
