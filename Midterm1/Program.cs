using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pyramid> list = new List<Pyramid>()
            {
                new Pyramid(0),
                new Pyramid(1),
                new Pyramid(2),
                new Pyramid(3),
                new Pyramid(4),
                new Pyramid(5)
            };

            foreach(Pyramid pyramid in list)
            {
                Console.WriteLine(pyramid);
                pyramid.Print();
                Console.WriteLine();
            }
        }
    }
}
