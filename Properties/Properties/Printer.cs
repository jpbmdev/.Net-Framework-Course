using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Printer
    {
        //Campos
        int x;
        int y;

        //Propiedades
        public int X { get => x; set => x = VerificarX(value); }
        public int Y { get => Y; set => y = VerificarY(value); }

        public int propertyTest
        {
            
            get
            {
                int i = 0;
                i++;
                return 20;
            }

            private set
            {
                int temporal = value;
            }
        }

        public void Print()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("X");
        }

        private int VerificarX(int _x)
        {
            if (_x < 0 || _x > 60)
            {
                throw new ArgumentException("Error en X");
            }
            return _x;
        }

        private int VerificarY(int _y)
        {
            if (_y < 0 || _y > 60)
            {
                throw new ArgumentException("Error en Y");
            }
            return _y;
        }
    }
}
