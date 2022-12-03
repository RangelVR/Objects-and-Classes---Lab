using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sentence = Console.ReadLine().Split().ToList();

            Random rnd = new Random();

            for (int i = 0; i < sentence.Count; i++)
            {
                int rndIndex = rnd.Next(0, sentence.Count);
                string exchangeWord = sentence[i];
                sentence[i] = sentence[rndIndex];
                sentence[rndIndex] = exchangeWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, sentence));
        }
    }

}
