using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
   public class Over 
    {
        int _overs;

        public Over()
        {
        }

        public Over(int overs)
        {
            Overs = overs;
        }

        public int Overs { get => _overs; set => _overs = value; }
    }
}
