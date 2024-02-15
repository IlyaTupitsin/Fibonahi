using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фибоначи
{
    class Fibonacci<T>
    {
        public static List<T> GenerateFibonacci(int n)
        {
            List<T> fibonacci = new List<T>();
            dynamic x = 0;
            dynamic y = 1;
            fibonacci.Add((T)x);
            for (int i = 2; i <= n; i++)
            {
                fibonacci.Add((T)y);
                dynamic temp = y;
                y += x;
                x = temp;
            }
            return fibonacci;
        }
    }
}
