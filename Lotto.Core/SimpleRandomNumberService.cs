using System;
using System.Collections.Generic;
using System.Text;

namespace Lotto.Core
{
    // TODO: If actually drawing for a real lottery create more rigorous implementation using System.Security.Cryptography.RandomNumberGenerator
    public class SimpleRandomNumberService : IRandomNumberService
    {
        private readonly Random _random;

        public SimpleRandomNumberService()
        {
            _random = new Random();
        }

        public int GetRandomInteger(int min, int max) => _random.Next(min, max);
    }
}
