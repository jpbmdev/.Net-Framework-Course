using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(5);
            stack.Apilar(1);
            stack.Apilar(2);
            stack.Apilar(3);
            stack.Apilar(4);
            stack.Apilar(5);

            object elemento = stack.Desapliar();
            stack.Print();

            elemento = stack.Desapliar();
            stack.Print();

            ClaseGenerica<int, int> g = new ClaseGenerica<int, int>(5);
            g.HacerAlgo(23);

            ClaseGenerica<string, int> g1 = new ClaseGenerica<string, int>("lol");
            g1.HacerAlgo("hola mundo");


            Console.ReadLine();
        }
    }
}
