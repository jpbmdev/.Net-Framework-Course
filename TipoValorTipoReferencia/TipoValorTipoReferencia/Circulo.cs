using System;

namespace TipoValorTipoReferencia
{
    class Circulo: IDisposable
    {
        public int radio;

        public Circulo(int radioInicial)
        {
            radio = radioInicial;
        }

        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public void Dispose()
        {
            Console.WriteLine("Estamos en el dispose...");
        }
    }
}
