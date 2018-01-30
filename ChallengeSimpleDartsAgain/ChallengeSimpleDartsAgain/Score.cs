using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDartsAgain
{
    public class Score
    {
        public static void ScoreDart(Player player, Dart dart)
        {
            int score = 0;

            if (dart.innerband) score = dart.Score * 3;
            else if (dart.outterband) score = dart.Score * 2;
            else score = dart.Score;

            if (dart.innerband && dart.Score == 0) score = 50;
            else if (dart.Score == 0) score = 25;

            player.Score += score;
        }
    }
}