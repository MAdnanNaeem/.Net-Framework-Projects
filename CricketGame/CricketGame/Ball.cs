using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
   public class Ball
    {
        int balls;

        public Ball()
        {
        }

        public Ball(int balls)
        {
            this.balls = balls;
        }

        public int Balls { get => balls; set => balls = value; }
    }
}
