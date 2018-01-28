using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
      

        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player() { Name = player1Name };
            _player2 = new Player() { Name = player2Name };
          
        }

        public string Play()
        {
            Deck deck = new Deck();
            string result= deck.Deal(_player1, _player2);

            int round = 0;
            while (_player1.cards.Count > 0 && _player2.cards.Count > 0)
            {

                Battle battle = new Battle();
                battle.performBattle(_player1, _player2);
                 
                round++;
                if (round > 20) break;
            }
            result += decideWinner();
            return result;
        }


        private string decideWinner()
        {
            string result = "";
            if (_player1.cards.Count > _player2.cards.Count) result= "<br/>Player 1 wins.";
            else result= "<br/>Player 2 wins";
            result += "<br/>" + _player1.Name + " has " + _player1.cards.Count + " and " + _player2.Name + " has " + _player2.cards.Count;
            return result;
        }
    }
        
}