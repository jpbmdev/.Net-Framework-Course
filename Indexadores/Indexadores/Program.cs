using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ascii: a
            //Decimal: 97
            //Binario: 00000000 00000000 00000000 01100001

            int numero = 15;

            //Binarios

            uint bitData = 0b01111;

            uint bitData1 = 0b0_1111_1111;

            Console.WriteLine(bitData);

            Console.WriteLine(bitData1);

            Console.WriteLine(Convert.ToString(bitData1, 2));

            // HEX

            uint bitData2 = 0x0_FF;

            Console.WriteLine(bitData2);

            Console.WriteLine(Convert.ToString(bitData2, 16));

            // Operador Not binario

            uint bitData3 = 0b0_0000_1111;

            uint result = ~bitData3;

            Console.WriteLine(Convert.ToString(result, 2));

            //Desplazar numeros binarios

            Console.WriteLine(Convert.ToString(bitData3, 2));

            result = bitData3 << 2;

            Console.WriteLine(Convert.ToString(result, 2));

            result = bitData3 >> 2;

            Console.WriteLine(Convert.ToString(result, 2));

            //Operaciones boolenas con binarios

            //OR |

            uint bitDataComp1 = 0b0_00000000_00000000_00000000_01000111;
            uint bitDataComp2 = 0b0_00000000_00000000_00000000_00000111;

            result = bitDataComp1 | bitDataComp2;

            Console.WriteLine(Convert.ToString(result, 2));

            //AND &

            result = bitDataComp1 & bitDataComp2;

            Console.WriteLine(Convert.ToString(result, 2));

            //XOR ^

            result = bitDataComp1 ^ bitDataComp2;

            Console.WriteLine(Convert.ToString(result, 2));

            //Comparaciones

            uint bitDatd = 0b0_10000000;
            var resultado = (bitDatd & (1 << 7)) != 0;

            Console.WriteLine(resultado);

            int bitDatd2 = 0b0_10000000;

            Bits bits = new Bits(bitDatd2);
            bool dato = bits[7];
            Console.WriteLine(dato);

            bits[7] = false;

            dato = bits[7];
            Console.WriteLine(dato);

            Console.WriteLine(bits.ToString());

            Console.ReadLine();
        }

        static void HacerAlgo(bool valor)
        {
            Console.WriteLine(valor);
        }
    }
}
