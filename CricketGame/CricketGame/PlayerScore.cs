using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class PlayerScore
    {
        int _pScore;
        int _pBalls;

        public PlayerScore()
        {
        }

        public PlayerScore(int pScore, int pBalls)
        {
            PScore = pScore;
            PBalls = pBalls;
        }

        public int PScore { get => _pScore; set => _pScore = value; }
        public int PBalls { get => _pBalls; set => _pBalls = value; }
    }
}
