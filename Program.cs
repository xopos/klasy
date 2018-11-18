using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car("Honda", "1999", 2, 120, 5);
            Console.WriteLine(auto.GetCarName());
            auto.AddPassenger();
            auto.IncreaseSpeed(100);
            Console.WriteLine(auto.currentspeed);
            auto.IncreaseSpeed(200);
            Console.WriteLine(auto.currentspeed);
            auto.DecreaseSpeed(300);
            auto.RemovePassenger();
            Console.ReadKey();
        }
    }
}
