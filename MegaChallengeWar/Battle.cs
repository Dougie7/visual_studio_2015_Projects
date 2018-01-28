using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Battle
    {
        private List<Cards> _treasure;

        public Battle()
        {
            _treasure = new List<Cards>();
        }

        public void performBattle(Player player1, Player player2)
        {
            Cards player1card = getCard(player1);
            Cards player2card = getCard(player2);

            cardEvaluation(player1, player2, player1card, player2card);

        }

        private Cards getCard(Player player)
        {
            Cards card = player.cards.ElementAt(0);
            player.cards.Remove(card);
            _treasure.Add(card);
            return card;
        }

        private void cardEvaluation(Player player1, Player player2, Cards card1, Cards card2)
        {
            if (card1.CardValue() == card2.CardValue()) war(player1,player2);

            if (card1.CardValue() > card2.CardValue())
            {
                if (_treasure.Count == 0) return;
                player1.cards.AddRange(_treasure);
            }
            else { if (_treasure.Count == 0) return;
                player2.cards.AddRange(_treasure); }
            _treasure.Clear();
        }
        private void war(Player player1,Player player2)
        {
            getCard(player1);
            Cards warcard1 = getCard(player1);
            getCard(player1);

            getCard(player2);
            Cards warcard2 = getCard(player2);
            getCard(player2);

            cardEvaluation(player1, player2, warcard1, warcard2);
        } 
    }
}