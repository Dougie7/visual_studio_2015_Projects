using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public int Score { get; set; }
        public bool outterband { get; set; }
        public bool innerband { get; set; }

        private Random _random;

        public Dart(Random random)
        {
            _random = random;
        }

        public void Throw()
        {
            Score = _random.Next(0,21);

            int multiplier = _random.Next(0, 101);
            if (multiplier > 95) innerband = true;
            else if (multiplier > 90) outterband = true;
            else
            {
                innerband = false;
                outterband = false;
            }
        }
    }
}
