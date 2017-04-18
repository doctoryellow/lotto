using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
    }
}
