using System;
using System.Security.Cryptography;
using Generator;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            RandNum numGen = new RandNum();
            Console.WriteLine("Случайное целое число (1-100): " + numGen.GetRandInt(1, 100));
            Console.WriteLine("Случайное дабл число (0-1): " + numGen.GetRandDbl(0, 1));
            RandStr strGen = new RandStr();
            Console.WriteLine("Случайная строка с заданной длиной: " + strGen.GetRandStr(10));
        }
    }
}
