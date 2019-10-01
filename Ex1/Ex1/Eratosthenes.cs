using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Eratosthenes
    {
        List<Tuple<int, bool>> EratField;
        public int maxVal { get; set; }
        Eratosthenes(int MaxVal)
        {
            maxVal = MaxVal;
            for (int i = 2; i < MaxVal; i++)
            {
                EratField.Add(new Tuple<int, bool>(i, true));
            }
        }
        List<int> Calc()
        {
            List<int> Res = new List<int>();

            for (int i = 0; i < maxVal; i++)
            {
                if (EratField[i].Item2)
                {
                    for (int j = i + i; j < maxVal; j += i)
                    {
                        EratField[j] = new Tuple<int, bool>(EratField[j].Item1, false);
                    }
                    Res.Add(EratField[i].Item1);
                }
            }
            return Res;
        }
    }
}
