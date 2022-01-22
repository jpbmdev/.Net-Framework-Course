using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parse
            string numeroEnCadena = "10";
            int valor = int.Parse(numeroEnCadena);

            Console.WriteLine(valor);

            //Try Catch

            try
            {
                int valor2 = 10;
                Console.WriteLine(valor2/0);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {

                /*
                string numeroCad = "asdfadf";
                int valor3 = int.Parse(numeroCad);
                Console.WriteLine(valor3);
                */
                string numeroCad = "9999999999999";
                int valor3 = int.Parse(numeroCad);
                Console.WriteLine(valor3);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            int entero = int.MaxValue;

            try
            {
                checked
                {
                    entero++;
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Ingresa tu mes de nacimiento");
            int mes = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(ObtenerSignoZodiacal(mes));
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("end");
            }
            

            Console.ReadLine();
        }

        static string ObtenerSignoZodiacal(int numeroMes)
        {
            string resultado = string.Empty;
            switch (numeroMes)
            {
                case 1:
                    resultado = "Aries";
                    break;
                case 2:
                    resultado = "Cancer";
                    break;
                case 3:
                    resultado = "Tauro";
                    break;
                case 4:
                    resultado = "Scorpio";
                    break;
                default:
                    throw new InvalidOperationException("El numero debe estar entre 1 y 4");
            }
            return resultado;
        }
    }
}
