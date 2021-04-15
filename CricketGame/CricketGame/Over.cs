using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
   public class Over 
    {
        double _overs;

        public Over()
        {
        }

        public Over(double overs) 
        {
            this.Overs = overs;
        }

        public double Overs { get => _overs; set => _overs = value; }
    }
}
