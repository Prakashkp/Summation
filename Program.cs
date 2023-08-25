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
            var summationSeriesFacade = new NaturalSummationFacade(SummationFactory.GetNaturalSeriesSummation());
            var resultNaturalSummation = summationSeriesFacade.Processs(n);
            Console.WriteLine("∑i^n = 1 + 2 + 3 + ... + n: " + resultNaturalSummation.SummationResult.ToString());
            var summationSquareSeriesFacade = new NaturalSquareSummationFacade(SummationFactory.GetNaturalSeriesSquareSummation());
            var resultNaturalSquareSummation = summationSquareSeriesFacade.Processs(n);
            Console.WriteLine("∑^2 i^2   = 1^2 + 2^2 + 3^2 + ... + n^2 : " + resultNaturalSquareSummation.SummationResult.ToString());
            Console.ReadLine();
        }
    }
}