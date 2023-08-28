// This class is the entry point on the application
using SummationTask.Classes;
using SummationTask.Interface;

namespace SummationTask
{
    /// <summary>
    /// The main class for the console application 
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// main mthod triggered when application starts
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number(count) to find the sum of series (from 1 to the number entered)");
            var n = Convert.ToDouble(Console.ReadLine());
            //injecting the dependent class based on SOLID principle and creating facade class for sequence of task and client wont know about the complex of the process
            var summationSeriesFacade = new NaturalSummationFacade(SummationFactory.GetNaturalSeriesSummation());
            // Processing the facade class
            var resultNaturalSummation = summationSeriesFacade.Processs(n);
            //Printing the result
            Console.WriteLine($"The sum of series for the number entered {n} is : " + resultNaturalSummation.SummationResult.ToString());
            //injecting the dependent class and creating facade class for sequence of task and client wont know about the complex of the process
            var summationSquareSeriesFacade = new NaturalSquareSummationFacade(SummationFactory.GetNaturalSeriesSquareSummation());
            // Processing the facade class
            var resultNaturalSquareSummation = summationSquareSeriesFacade.Processs(n);
            //Printing the result
            Console.WriteLine($"The sum of square series for the number entered {n} is : " + resultNaturalSquareSummation.SummationResult.ToString());
            Console.ReadLine();
        }
    }
}
