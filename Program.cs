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
            //injecting the dependent class and creating facade class for sequence of task and client wont know about the complex of the process
            var summationSeriesFacade = new NaturalSummationFacade(SummationFactory.GetNaturalSeriesSummation());
            // Processing the facade class
            var resultNaturalSummation = summationSeriesFacade.Processs(n);
            //Printing the result
            Console.WriteLine("∑i^n = 1 + 2 + 3 + ... + n: " + resultNaturalSummation.SummationResult.ToString());
            //injecting the dependent class and creating facade class for sequence of task and client wont know about the complex of the process
            var summationSquareSeriesFacade = new NaturalSquareSummationFacade(SummationFactory.GetNaturalSeriesSquareSummation());
            // Processing the facade class
            var resultNaturalSquareSummation = summationSquareSeriesFacade.Processs(n);
            //Printing the result
            Console.WriteLine("∑^2 i^2   = 1^2 + 2^2 + 3^2 + ... + n^2 : " + resultNaturalSquareSummation.SummationResult.ToString());
            Console.ReadLine();
        }
    }
}