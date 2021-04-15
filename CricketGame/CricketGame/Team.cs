using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    class Team
    {

        string _teamName;
        string _wicketkeeper;
        string _captain;
        string _headCoach;
        string _bowlingCoach;

        private Player Team1;
        private Player Team2;

        public Team()
        {}

        public Team(string teamName, string wicketkeeper, string captain, string headCoach, string bowlingCoach, Player team1, Player team2)
        {
            _teamName = teamName;
            _wicketkeeper = wicketkeeper;
            _captain = captain;
            _headCoach = headCoach;
            _bowlingCoach = bowlingCoach;
            Team1 = team1;
            Team2 = team2;
        }

        public string TeamName { get => _teamName; set => _teamName = value; }
        public string Wicketkeeper { get => _wicketkeeper; set => _wicketkeeper = value; }
        public string Captain { get => _captain; set => _captain = value; }
        public string HeadCoach { get => _headCoach; set => _headCoach = value; }
        public string BowlingCoach { get => _bowlingCoach; set => _bowlingCoach = value; }
    }
}
