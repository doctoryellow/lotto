using System;
using System.Collections.Generic;
using System.Text;

namespace Lotto.Core
{
    public interface IRandomNumberService
    {
        int GetRandomInteger(int min, int max);
    }
}
