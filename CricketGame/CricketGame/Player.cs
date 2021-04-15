using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
   public class Player:MainClass
    {

        string _name;
        string _role;
        int _age;
        string _experience;
        string _style;
        int _pRecord;


        public Player()
        {
        }

        public Player(string name, string role, int age, string experience, string style, int pREcord)
        {
            _name = name;
            _role = role;
            _age = age;
            _experience = experience;
            _style = style;
            _pRecord = pREcord;
        }

        public string Name { get => _name; set => _name = value; }
        public string Role { get => _role; set => _role = value; }
        public int Age { get => _age; set => _age = value; }
        public string Experience { get => _experience; set => _experience = value; }
        public string Style { get => _style; set => _style = value; }
        public int PRecord { get => _pRecord; set => _pRecord = value; }

       

        public virtual string Display()
        { 

            return Name + "       " + Age + "       " + Role + "       " + Style + "       " + Experience + "        " + PRecord ;
        }

       

    }
}
