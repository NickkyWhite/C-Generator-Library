using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator;


namespace Generator
{
    public class RandNum
    {
        private Random _random;

        public RandNum()
        {
            _random = new Random();
        }

        public int GetRandInt(int min, int max)
        {
            return _random.Next(min, max);
        }

        public double GetRandDbl(double min, double max)
        {
            return _random.NextDouble() * (max - min) + min;
        }
    }

    public class RandStr
    {
        private Random _random;
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public RandStr()
        {
            _random = new Random();
        }

        public string GetRandStr(int length)
        {
            char[] result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = Chars[_random.Next(Chars.Length)];
            }

            return new string(result);
        }
    }
}
