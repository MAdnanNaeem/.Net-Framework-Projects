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

        public PlayerScore()
        {
        }

        public PlayerScore(int pScore)
        {
            this.PScore = pScore;
        }

        public int PScore { get => _pScore; set => _pScore = value; }

        
        
    }
}
