using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1
{
    public struct Pyramid
    {
        public int Size { get; private set; }

        public Pyramid(int size) : this()
        {
            Size = size;
        }

        public void Print()
        {
            for (int i = 1; i <= Size; i++)            
            {
                for (int j = i; j <= Size; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write("{0,-1}", " ");
                    Console.ResetColor();
                }
                
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return string.Format("Pyramid of size {0}", Size);
        }
    }
}
