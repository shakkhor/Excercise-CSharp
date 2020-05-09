using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercise_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello OOP!");
            RunStopWatch();
            Console.ReadKey();

           
        }

        private static void RunStopWatch()
        {
            var watch = new StopWatch();

            while(true)
            {
                try
                {
                    string key = Console.ReadLine();
                    switch (key)
                    {
                        case "S": Console.WriteLine($"Clock is started at {watch.start()}."); break;
                        case "E": Console.WriteLine($"Clock has run for {watch.stop()} seconds"); break;
                        default: Console.WriteLine("Invalid input. Please Enter S to start and E to stop"); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);    
                }
            }
        }
    }
}
