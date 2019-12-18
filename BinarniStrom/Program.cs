using System;

namespace BinarniStrom
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,int> slovnik = new MyDictionary<int,int>();
            slovnik.Add(2, 2);
            slovnik.Add(1, 1);
            slovnik.Add(3, 3);
            slovnik.Add(9, 9);
            slovnik.Add(5, 5);
            slovnik.Add(8, 8);
            slovnik.Add(6, 6);            
            Console.WriteLine(slovnik);
            Console.WriteLine("Pocet: " + slovnik.Count);
            Console.WriteLine("Max: " + slovnik.Max);
            Console.WriteLine("Min: " + slovnik.Min);
        }
    }
}
