using System;

namespace kattis_ADifferentProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                long nr1 = Int64.Parse(split[0]);
                long nr2 = Int64.Parse(split[1]);
                Console.WriteLine(nr1 > nr2 ? (nr1 - nr2) : (nr2 - nr1));
            }
        }
    }
}
