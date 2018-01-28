using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Cards
    {
        public string Suit { get; set; }
        public string value { get; set; }

        public int CardValue()
        {
            int worth = 0;
            if (this.value == "Jack") worth = 11;
            else if (this.value == "Queen") worth = 12;
            else if (this.value == "King") worth = 13;
            else if (this.value == "Ace") worth = 14;
            else worth = int.Parse(this.value);
            return worth;

        }
    }
}