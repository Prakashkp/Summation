using SummationTask.Classes;
using SummationTask.Interface;

namespace SummationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n to find sum of first n natural numbers");
            var n = Convert.ToDouble(Console.ReadLine());
            ISummation summation = SummationFactory.GetNaturalSeriesSummation();
            var inputSummation = new SummationInput { Data = n };
            var resultNaturalSummation = summation.Calculate(inputSummation);
            Console.WriteLine("∑i^n = 1 + 2 + 3 + ... + n: " + resultNaturalSummation.SummationResult.ToString());
            ISummation summationSquare = SummationFactory.GetNaturalSeriesSquareSummation();
            var resultNaturalSummationSquare = summationSquare.Calculate(inputSummation);
            Console.WriteLine("∑^2 i^2   = 1^2 + 2^2 + 3^2 + ... + n^2 : " + resultNaturalSummationSquare.SummationResult.ToString());
            Console.ReadLine();
        }
    }
}