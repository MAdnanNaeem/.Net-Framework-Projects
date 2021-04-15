using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    class ScoreCard:MainClass
    {
        int _cScore;

        public ScoreCard(int record, int cScore) : base(record)
        {
            _cScore = cScore;
        }

        public int CScore { get => _cScore; set => _cScore = value; }

       
    }
}
