using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Player
    {
        public string Name { get; set; }
        public List<Cards> cards { get; set; }

        public Player()
        {
            cards = new List<Cards>();
        }
    }
}