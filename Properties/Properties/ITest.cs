using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    interface ITest
    {
        int X { get; set; }
        
        int Y { get; set; }

        void Dibujar();
    }

    class Printer2 : ITest
    {
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dibujar()
        {
            throw new NotImplementedException();
        }
    }
}
