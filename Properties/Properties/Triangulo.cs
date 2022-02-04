using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Triangulo
    {
        int lado1;
        int lado2;      
        int lado3;

        string color;

        public Triangulo()
        {

        }

        public Triangulo(string _color)
        {
            color = _color;
        }

        public int Lado1 { set => lado1 = value; }
        public int Lado2 { set => lado2 = value; }
        public int Lado3 { set => lado3 = value; }

    }
}
