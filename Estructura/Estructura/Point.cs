using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    struct StructPoint
    {
        public int X;
        public int Y;

        public StructPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Calcular()
        {
            return X * Y;
        }
    }

    class ClassPoint
    {
        public int X;
        public int Y;

        public ClassPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Calcular()
        {
            return X * Y;
        }
    }
}
