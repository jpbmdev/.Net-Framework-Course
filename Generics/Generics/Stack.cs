using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Stack<T>
    {
        int tamañoDefault = 100;
        T[] arreglo;
        int indiceActual = 0;
        int numElementos = 0;

        public Stack()
        {
            arreglo = new T[tamañoDefault];
        }

        public Stack(int _tamaño)
        {
            if(_tamaño > 0)
            {
                arreglo = new T[_tamaño];
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Apilar(T elemento)
        {
            if(numElementos == arreglo.Length)
            {
                throw new Exception("El arreglo esta a tope");
            }

            arreglo[indiceActual] = elemento;
            indiceActual++;
            numElementos++;
        }

        public object Desapliar()
        {
            if (numElementos == 0)
            {
                throw new Exception("El stack esta vacio");
            }

            indiceActual--;
            T elemento = arreglo[indiceActual];

            arreglo = arreglo.Where((source, index) => index != indiceActual).ToArray();

            numElementos--;
            return elemento;
        }

        public void Print()
        {
            foreach(var item in arreglo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
