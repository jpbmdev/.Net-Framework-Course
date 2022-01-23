using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudentPackage
{
    public class Circulo
    {
        private double _radio;

        public Circulo()
        {
            _radio = 0;
        }

        public Circulo(double Radio)
        {
            _radio = Radio;
        }

        public double CalcularArea()
        {
            return Math.PI * (_radio * _radio);

        }


    }
}
