using System;
using System.Linq;
using System.Threading.Channels;
using FPConcept;

namespace FPExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FP Concept ");
            DataAccess.NumbersList
                .Select(Opertions.AddOne)
                .Select(Opertions.Square)
                .Where(x=>x <20)
                .Select(Opertions.SubtractTen)
                .ToList()
                .ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
