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
            Console.WriteLine("Press 1 for Summation Series or Press 2 for Square Series");
            var summationType = Convert.ToInt16(Console.ReadLine());
            //injecting the dependent class based on SOLID principle and creating facade class for sequence of task and client wont know about the complex of the process
            INaturalSummation summationSeriesFacade = new NaturalSummationFacade(SummationFactory.GetNaturalSeriesSummation());
            // Processing the facade class
            var resultNaturalSummation = SummationFacade.ProcessType(summationType, n);
            //Printing the result
            Console.WriteLine($"The sum of series for the number entered {n} is : " + resultNaturalSummation.SummationResult.ToString());
            Console.ReadLine();
        }
    }
}
