using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDartsAgain
{
    public class Game
    { 
        private Player _Player1;
        private Player _Player2;
        private Random _random = new Random();

        public Game(string _Player1Name, string _Player2Name)
        {
            _Player1 = new Player();
            _Player1.Name = _Player1Name;

            _Player2 = new Player();
            _Player2.Name = _Player2Name;

            
            _random = new Random();
        }

        public string Play()
        {
            while(_Player1.Score<300 && _Player2.Score < 300)
            {
                playRound(_Player1);
                playRound(_Player2);
            }
            return displayResults(_Player1,_Player2);
        }

        private string displayResults(Player Player1, Player Player2)
        {
            string result = String.Format("{0}: {1}<br/>{2}: {3}",_Player1.Name,_Player1.Score,_Player2.Name,_Player2.Score);
            return result;
        }

        private void playRound(Player Player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.ScoreDart(Player, dart);
 

            }
        }
    }
}