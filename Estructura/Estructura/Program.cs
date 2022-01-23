using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StructPoint sp1 = new StructPoint();
            StructPoint sp2 = sp1;

            Console.WriteLine(sp1.X);
            Console.WriteLine(sp2.X);

            sp1.X++;

            Console.WriteLine(sp1.X);
            Console.WriteLine(sp2.X);

            ClassPoint cp1 = new ClassPoint(0,0);
            ClassPoint cp2 = cp1;

            Console.WriteLine(cp1.X);
            Console.WriteLine(cp2.X);

            cp1.X++;

            Console.WriteLine(cp1.X);
            Console.WriteLine(cp2.X);


            Console.ReadLine();
        }

        static void Print(StructPoint? p)
        {
            Console.WriteLine(p.Value.X);
            Console.WriteLine(p.Value.Y);
        }

    }
}
