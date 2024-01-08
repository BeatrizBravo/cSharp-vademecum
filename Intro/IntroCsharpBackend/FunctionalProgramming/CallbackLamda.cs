using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class CallbackLamda
    {
        public void SomeFunctionReturnCallback(Func<int, int, int> fn, int number)
        {
            var result = fn(number, number);

        }
    }
}
