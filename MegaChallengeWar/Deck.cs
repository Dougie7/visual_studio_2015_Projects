using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MegaChallengeWar
{
    public class Deck
    {
        private List<Cards> _deck;
        private Random _random;
        private StringBuilder _sb;

        public Deck()
        {
            _random = new Random();
            _sb = new StringBuilder();
            _deck = new List<Cards>()
            {
                new Cards {Suit ="Heart", value="2" },
                new Cards {Suit ="Heart", value="3" },
                new Cards {Suit ="Heart", value="4" },
                new Cards {Suit ="Heart", value="5" },
                new Cards {Suit ="Heart", value="6" },
                new Cards {Suit ="Heart", value="7" },
                new Cards {Suit ="Heart", value="8" },
                new Cards {Suit ="Heart", value="9" },
                new Cards {Suit ="Heart", value="10" },
                new Cards {Suit ="Heart", value="Jack" },
                new Cards {Suit ="Heart", value="Queen" },
                new Cards {Suit ="Heart", value="King" },
                new Cards {Suit ="Heart", value="Ace" },

                new Cards {Suit ="Diamond", value="2" },
                new Cards {Suit ="Diamond", value="3" },
                new Cards {Suit ="Diamond", value="4" },
                new Cards {Suit ="Diamond", value="5" },
                new Cards {Suit ="Diamond", value="6" },
                new Cards {Suit ="Diamond", value="7" },
                new Cards {Suit ="Diamond", value="8" },
                new Cards {Suit ="Diamond", value="9" },
                new Cards {Suit ="Diamond", value="10" },
                new Cards {Suit ="Diamond", value="Jack" },
                new Cards {Suit ="Diamond", value="Queen" },
                new Cards {Suit ="Diamond", value="King" },
                new Cards {Suit ="Diamond", value="Ace" },

                new Cards {Suit ="Spade", value="2" },
                new Cards {Suit ="Spade", value="3" },
                new Cards {Suit ="Spade", value="4" },
                new Cards {Suit ="Spade", value="5" },
                new Cards {Suit ="Spade", value="6" },
                new Cards {Suit ="Spade", value="7" },
                new Cards {Suit ="Spade", value="8" },
                new Cards {Suit ="Spade", value="9" },
                new Cards {Suit ="Spade", value="10" },
                new Cards {Suit ="Spade", value="Jack" },
                new Cards {Suit ="Spade", value="Queen" },
                new Cards {Suit ="Spade", value="King" },
                new Cards {Suit ="Spade", value="Ace" },

                new Cards {Suit ="Club", value="2" },
                new Cards {Suit ="Club", value="3" },
                new Cards {Suit ="Club", value="4" },
                new Cards {Suit ="Club", value="5" },
                new Cards {Suit ="Club", value="6" },
                new Cards {Suit ="Club", value="7" },
                new Cards {Suit ="Club", value="8" },
                new Cards {Suit ="Club", value="9" },
                new Cards {Suit ="Club", value="10" },
                new Cards {Suit ="Club", value="Jack" },
                new Cards {Suit ="Club", value="Queen" },
                new Cards {Suit ="Club", value="King" },
                new Cards {Suit ="Club", value="Ace" }
            };


        }


        public string Deal(Player player1, Player player2)
        {

            while (_deck.Count > 0)
            {
                dealCard(player1);
                dealCard(player2);

            }
            return _sb.ToString();
        }
        private void dealCard(Player player)
        {
            Cards card = _deck.ElementAt(_random.Next(_deck.Count));
            player.cards.Add(card);
            _deck.Remove(card);

            _sb.Append("<br/>");
            _sb.Append(player.Name);
            _sb.Append(" was dealt ");
            _sb.Append(card.value);
            _sb.Append(" of ");
            _sb.Append(card.Suit);

        }

        }
    }
