using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Lambda
    {
        public int SubtractionCompleta(int a, int b)
        {
            int v = a - b;
            return v;
        }


        public Func<int, int, int> subtractionLambda = (a,b) => a - b;

        //con un solo parametro
        public Func<int, int> subtractionOneParameter = a => a * 2;

        public Func<int, int, int> SubtractionConMasLineas = (int a, int b) =>
        {
            int v = a - b;
            return v;
        };

    }
}
