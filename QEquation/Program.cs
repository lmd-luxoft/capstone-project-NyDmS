using System;
using System.Threading;
using System.Threading.Tasks;

namespace QEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 2;
            double c = 3;
            double D = b * b - 4 * a * c;

            Task[] tasks = new Task[]
            {
               new TaskFactory().StartNew(()=>
               {
                                          double x1 = -b + Math.Pow(D, 0.5) / (2*a);
                       if (!double.IsInfinity(x1) && double.IsNaN(x1))
                        {
                           System.Console.WriteLine($"Корень x1 = {x1}");
                        }
                       else
                        {
                            System.Console.WriteLine("Нет корня x1");
                        }
               }
               ),
               new TaskFactory().StartNew(() =>
               {
                       double x1 = -b + Math.Pow(D, 0.5) / (2*a);
                       if (!double.IsInfinity(x1) && double.IsNaN(x1))
                        {
                           System.Console.WriteLine($"Корень x1 = {x1}");
                        }
                       else
                        {
                            System.Console.WriteLine("Нет корня x1");
                        }
            })
            };

            Task.WaitAll(tasks);
            System.Console.ReadKey();
        }
    }
}
