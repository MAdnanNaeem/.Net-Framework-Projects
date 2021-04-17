using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class MainClass
    {
        private List<MainClass> TeamA;
        private List<MainClass> TeamB;
       
       

        public MainClass()
        {

            TeamA = new List<MainClass>();
            TeamB = new List<MainClass>();
           
        }

        public List<MainClass> TeamA1 { get => TeamA; set => TeamA = value; }
        public List<MainClass> TeamB1 { get => TeamB; set => TeamB = value; }
       
        public void AddPlayers()
        {
            Player TeamA_P1 = new Player("Farooq", "Batsman", 24, "  8 years", "Left Handed", 3000);
            Player TeamA_P2 = new Player("Arslan", "Batsman", 22, "  5 years", "Right Handed", 1000);
            Player TeamA_P3 = new Player("Nafees", "Batsman", 18, "  3 years", "Left Handed", 300);
            Player TeamA_P4 = new Player("Noman", " Bowler ",  20, "4 years", "Right ARM Fast", 100);
            Player TeamA_P5 = new Player("Adnan", " Bowler ",  23, " 7 years", "Left ARM Fast", 50);
            
            TeamA.Add(TeamA_P1);
            TeamA.Add(TeamA_P2);
            TeamA.Add(TeamA_P3);
            TeamA.Add(TeamA_P4);
            TeamA.Add(TeamA_P5);

       

            Player TeamB_P1 = new Player("Babar", "Batsman", 26, "5 years", "Right_Handed", 2500);
            Player TeamB_P2 = new Player("Fahad", "Batsman", 24, "2 years", "Right Handed", 1500);
            Player TeamB_P3 = new Player("Ahsan", "Batsman", 25, "8 years", "Left Handed", 300);
            Player TeamB_P4 = new Player("Adeel", "Bowler",  27, "4 years", "Right ARM Fast", 100);
            Player TeamB_P5 = new Player("Ahmed", "Bowler",  28, "7 years", "Left ARM Fast", 50);

            TeamB.Add(TeamB_P1);
            TeamB.Add(TeamB_P2);
            TeamB.Add(TeamB_P3);
            TeamB.Add(TeamB_P4);
            TeamB.Add(TeamB_P5);
        }

       

    }
}
