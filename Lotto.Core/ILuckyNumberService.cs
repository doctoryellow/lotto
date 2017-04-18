using System;
using System.Collections.Generic;

namespace Lotto.Core
{
    public interface ILuckyNumberService
    {
        IEnumerable<int> DrawNumbers();
    }
}
