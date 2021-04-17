using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
   public class ScoreCard
    {
       
        int _Team_Cscore;
        int _Team_Outs;
        int _TeamA_totalScore;
        int _TeamB_totalScore;
        int _RemainingScore;

        public ScoreCard()
        {
        }

        public ScoreCard(int team_Cscore, int team_Outs, int teamA_totalScore, int teamB_totalScore, int remainingScore)
        {
            Team_Cscore = team_Cscore;
            Team_Outs = team_Outs;
            TeamA_totalScore = teamA_totalScore;
            TeamB_totalScore = teamB_totalScore;
            RemainingScore = remainingScore;
        }

        public int Team_Cscore { get => _Team_Cscore; set => _Team_Cscore = value; }
        public int Team_Outs { get => _Team_Outs; set => _Team_Outs = value; }
        public int TeamA_totalScore { get => _TeamA_totalScore; set => _TeamA_totalScore = value; }
        public int TeamB_totalScore { get => _TeamB_totalScore; set => _TeamB_totalScore = value; }
        public int RemainingScore { get => _RemainingScore; set => _RemainingScore = value; }
    }
}
