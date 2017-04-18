using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lotto.Core
{
    public class LuckyNumberService : ILuckyNumberService
    {
        private readonly IRandomNumberService _randomNumberService;

        public LuckyNumberService(IRandomNumberService randomNumberService)
        {
            _randomNumberService = randomNumberService;
        }

        public IEnumerable<int> DrawNumbers()
        {
            var bowl = Enumerable
                .Range(1, 49)
                .ToList();

            while(bowl.Count > 0)
            {
                // take number from a random index, remove it from the bowl and return it to the user
                var randomIndex = _randomNumberService.GetRandomInteger(0, bowl.Count - 1);
                var luckyNumber = bowl[randomIndex];
                bowl.RemoveAt(randomIndex);

                yield return luckyNumber;
            }
        }
    }
}
