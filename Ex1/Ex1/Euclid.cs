using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Euclid
    {
        Euclid()
        {

        }
        Euclid(int A, int B)
        {
            a = A;
            b = B;
        }

        int calc(int A=0, int B=0)
        {
            if(A==0&&B==0)
            {
                A = a;
                B = b;
            }
            int r = A % B;
            if (r == 0)
                return A;
            else
                calc(B, r);
            return int.MinValue;
        }

        public int a { get; set; }
        public int b { get; set; }
    }
}
